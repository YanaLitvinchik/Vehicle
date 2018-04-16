using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDZ
{
    class Lorry : Vehicle
    {
        public double Weight { get; set; }
        public Lorry(int prise, int maxspeed, int date, double weight) : base(prise, maxspeed, date)
        {
            this.Weight = weight;
        }
    }
}
