using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDZ
{
    class Bicycle : Vehicle
    {
        public double Height { get; set; }
        public Bicycle(int prise, int maxspeed, int date, double height) : base(prise, maxspeed, date)
        {
            this.Height = height;
        }
    }
}
