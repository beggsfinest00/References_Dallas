using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Dallas
{
    //creating vaules of speed and Wheels and licenseplate to be called on later by another class.
    internal interface IAutomobile
    {
        public double Speed { get; }
        public int Wheels { get; }

        public string LicensePlate { get; }

            public void Stringify();
    }
}
