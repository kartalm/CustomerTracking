using CustomerTracking.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.Entities
{
    [Serializable]
    public class Vehicle : BaseEntity
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string NumberPlate { get; set; }

        public override string ToString()
        {
            return Brand + " - " + Model;
        }

        public int? StaffId { get; set; }

        public Staff Staff { get; set; }

        public Customer Customer { get; set; }

    }
}
