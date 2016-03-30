using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11
{
    public class car : vehicle
    {
        public bool EngineIsRunning { get; set; }
        public string CarModel { get; set; }
        public int DoorsQty { get; set; }
        public string EngineModel { get; set; }
        public car(string carModel, int doorsQty, string engineModel ) : base ("Car")
        {
            CarModel = carModel;
            DoorsQty = doorsQty;
            EngineModel = engineModel;
            EngineIsRunning = false;
                
        }
      
       

        public void StartEngine()
        {
            EngineIsRunning = true;
        }

        public void StopEngine()
        {
            EngineIsRunning = false;
        }
        public override string DescribeVehicle()
        {
            string result = "";

            result += "CarModel = " + this.CarModel;
            result += "Doors = " + DoorsQty + " ";
            result += "Engine model = " + EngineModel;

            return result;
        }
    }
}
