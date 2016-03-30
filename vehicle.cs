using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11
{
    public abstract class vehicle
    {

        public string VehicleType { get; set; }
        public vehicle (string vehicleType)
        {
            VehicleType = vehicleType;
        }

        public virtual string DescribeVehicle()
        {
            return ("This vehicle is a " + VehicleType);
        }
      
    }
}
