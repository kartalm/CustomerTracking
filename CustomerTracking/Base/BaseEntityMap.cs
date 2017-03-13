using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.Base
{
    public class BaseEntityMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityMap()
        {
            Map(x => x.Requires("IsDeleted").HasValue(false)).Ignore(x => x.IsDeleted);
        }

    }
}
