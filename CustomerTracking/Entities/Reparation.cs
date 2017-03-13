using CustomerTracking.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.Entities
{
    [Serializable]
    public class Reparation : BaseEntity
    {
        public string Operation { get; set; }
        
        public DateTime DeliverTime { get; set; }

        public DateTime AcceptanceTime { get; set; }

        public string Price { get; set; }

        public Staff Staff { get; set; }

        public override string ToString()
        {
            return Operation;
        }

    }
}
