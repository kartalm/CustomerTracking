using CustomerTracking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.ViewModels
{
    public class CustomerViewModel
    { 
        public string CustomerNameSurname { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public string VehicleBrand { get; set; }

        public string VehicleNumberPlate { get; set; }

        public string StaffNameSurname { get; set; }

        public string ReparationOperation { get; set; }

        public int Id { get; set; }

    }
}
