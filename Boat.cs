using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11
{
    class Boat : vehicle
    {
        public string BoatType { get; set; }

        public Boat(string boatType): base ("Boat")
        {
            BoatType = boatType;
        }
        public override string DescribeVehicle()
        {
            string result = " ";
            result += "Boat Model" + BoatType;
            return result;
        }

    }
}
