using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Dallas
{
    //makes and object sedan with the interface IAutimobile with and calls apound the vaules of the interface.
    internal class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            speed = speed;
            LicensePlate = "GCTC-06";
        }

        //wrights out the following phrase while calling apon the vaules.
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a license Plate # of {LicensePlate}.");
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
