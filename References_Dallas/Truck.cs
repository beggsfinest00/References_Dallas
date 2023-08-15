using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Dallas
{
    //makes and object truck with the interface IAutimobile with and calls apound the vaules of the interface.
    internal class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }

        //adds a statemnet caulculating weight to find how mant wheels it will have.
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;

            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        //wrights out the following phrase while calling apon the vaules.
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!"); 
        }

        // make vaule of increasing speed and decreasing speed.
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
