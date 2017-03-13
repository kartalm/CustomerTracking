using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.NonRelationalEntities
{
    public class ServiceResponse
    {
        public AppException AppException { get; set; }

        public bool IsSucceed
        {
            get { return AppException == null; }
        }

    }

    public class ServiceResponse<T> : ServiceResponse
    {
        public T Data { get; set; }

    }

}
