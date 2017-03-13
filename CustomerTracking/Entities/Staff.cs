using CustomerTracking.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.Entities
{
    [Serializable]
    public class Staff : BaseEntity
    {
        public string NameSurname { get; set; }
         
        public string Speciality { get; set; }
         
        public int? ReparationId { get; set; }

        public Reparation Reparation { get; set; }

        public Vehicle Vehicle { get; set; }

        public override string ToString()
        {
            return NameSurname;
        }

    }
}
