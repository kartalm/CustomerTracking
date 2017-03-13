using CustomerTracking.Base;
using CustomerTracking.Entities;
using CustomerTracking.NonRelationalEntities;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace CustomerTracking.DAL
{
    public class CutomerTrackingContext : System.Data.Entity.DbContext, IDbContext
    {
        private readonly Logger _logger; 

        static CutomerTrackingContext()
        {
            //
        }

        public CutomerTrackingContext()
            : base(ConnectionString.ToString())
        {
            _logger = LogManager.GetCurrentClassLogger();
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CutomerTrackingContext, Configuration>());

            #region Mapping Shortcut

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(BaseEntityMap<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);

                modelBuilder.Configurations.Add(configurationInstance);
            }

            #endregion

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            #region One to One Relationship

            modelBuilder.Entity<Customer>()
                .HasOptional(x => x.Vehicle)
                .WithOptionalDependent(s => s.Customer);

            modelBuilder.Entity<Vehicle>()
                .HasOptional(x => x.Staff)
                .WithOptionalDependent(s => s.Vehicle);

            modelBuilder.Entity<Staff>()
                .HasOptional(x => x.Reparation)
                .WithOptionalDependent(s => s.Staff);

            #endregion

            Configuration.LazyLoadingEnabled = false;

            base.OnModelCreating(modelBuilder);

        }

        public new IDbSet<T> Set<T>() where T : BaseEntity
        {
            return base.Set<T>();
        }

        public int SaveChanges(bool dispose = false)
        {
            try
            {
                ChangeTracker.DetectChanges();

                var affectedEntries = ChangeTracker.Entries().ToList();

                if (dispose)
                    base.Dispose();

                var affectedEntityCount = affectedEntries.Count;

                if (affectedEntityCount > 0)
                {
                    var affectedEntityNames = new List<string>();
                    var affectedDeletedEntityNames = new List<string>();

                    for (var i = 0; i < affectedEntries.Count; i++)
                    {
                        var ee = affectedEntries[i];
                        var entity = ((BaseEntity)ee.Entity);
                        var entityName =
                            System.Data.Entity.Core.Objects.ObjectContext.GetObjectType(entity.GetType()).Name;

                        affectedEntityNames.Add(entityName);

                        switch (ee.State)
                        {
                            case EntityState.Unchanged:
                                break;
                            case EntityState.Deleted:

                                if (affectedDeletedEntityNames.All(x => x != entityName))
                                {
                                    affectedDeletedEntityNames.Add(entityName);
                                }

                                entity.UpdatedDate = DateTime.Now;
                                var sql = string.Format("UPDATE {0} SET IsDeleted = 1, UpdatedDate = @date WHERE Id = @id", entityName);
                                affectedEntityCount += Database.ExecuteSqlCommand(sql, new SqlParameter("@id", entity.Id), new SqlParameter("@date", entity.UpdatedDate));
                                ee.State = EntityState.Detached;
                                break;
                            case EntityState.Added:
                                entity.CreatedDate = DateTime.Now;
                                entity.UpdatedDate = DateTime.Now;
                                break;
                            case EntityState.Modified:
                                entity.UpdatedDate = DateTime.Now;
                                break;
                        }

                    }

                    affectedEntityCount += base.SaveChanges();

                    if (affectedEntityCount > 0 || affectedDeletedEntityNames.Count > 0)
                    {
                        var affectedCacheKeys = affectedEntityNames.Distinct().ToList();

                        foreach (var aden in affectedDeletedEntityNames)
                        {
                            if (affectedCacheKeys.All(x => x != aden))
                            {
                                affectedCacheKeys.Add(aden);
                            }

                        }

                        foreach (var affectedCacheKey in affectedCacheKeys)
                        {
                            Console.WriteLine("---------> " + affectedCacheKey);
                        }

                    }

                    return affectedEntityCount;

                }

                return 0;

            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        msg += string.Format("Property: {0} Error: {1}", validationError.PropertyName,
                                          validationError.ErrorMessage) + Environment.NewLine;

                Console.WriteLine(msg);
                Console.WriteLine(dbEx.Message);

                var fail = new Exception(msg, dbEx);
                _logger.Error(fail);

                throw fail;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw ex;
            }

        }

        public new DbEntityEntry Entry<T>(T t) where T : BaseEntity
        {
            return base.Entry(t);
        }

    }

    public class Configuration : DbMigrationsConfiguration<CutomerTrackingContext>
    {
        public Configuration()
        {
            //CommandTimeout = 500;//this code should be executed if database has no index and ef commands take too much time for migration (cb: mkartal)

            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CutomerTrackingContext context)
        {
            base.Seed(context);
        }

    }

    public interface IDbContext : IDisposable
    {
        DbEntityEntry Entry<T>(T t) where T : BaseEntity;

        IDbSet<T> Set<T>() where T : BaseEntity;

        int SaveChanges(bool dispose = false);

    }

}
