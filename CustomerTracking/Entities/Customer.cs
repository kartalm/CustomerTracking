using CustomerTracking.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.Entities
{
    [Serializable]
    public class Customer : BaseEntity
    {
        public string NameSurname { get; set; }
         
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return NameSurname;
        }

        public int? VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

    }
}
