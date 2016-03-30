using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData MyVehicleData = new VehicleData();
            car MyCar = new car("Volvo " , 4 ," 2,3 Turbo");
            car MyCar2 = new car("SAAB", 4, "2,0 Turbo");
            Boat MyBoat = new Boat("HallbergRassy");

            MyVehicleData.PrintVehicle(MyCar);
        }
    }
}
