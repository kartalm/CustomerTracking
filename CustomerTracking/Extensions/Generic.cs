using CustomerTracking.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.Extensions
{
    public static class Generic
    {
        public static bool IsNull(this object value)
        {
            return value == null;
        }

        public static bool IsNotNull(this object value)
        {
            return value != null;
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        
        public static bool ContainsOrNull(this string value, string searchKey)
        {
            return value.IsNullOrEmpty() || value.IndexOf(searchKey, StringComparison.Ordinal) >= 0;
        }
        
        public static IQueryable<T> IncludeRelations<T>(this IQueryable<T> source, params Expression<Func<T, object>>[] includes) where T : BaseEntity
        {
            if (includes != null)
            {
                foreach (var inc in includes)
                {
                    source = source.Include(inc);
                }
            }

            return source;

        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];

            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }

            return table;

        }

        public static List<T> ToList<T>(this DataTable dt)
        {
            List<T> data = new List<T>();

            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }

            return data;

        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);

            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }

            return obj;

        }

    }
}
