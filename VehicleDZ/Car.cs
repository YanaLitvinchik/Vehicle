using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDZ
{
    class Car : Vehicle
    {
        public int Passengers { get; set; }
        public Car(int prise, int maxspeed, int date, int passengers) : base(prise, maxspeed, date)
        {
            this.Passengers = passengers;
        }
    }
}
