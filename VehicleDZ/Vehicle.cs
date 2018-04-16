using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDZ
{
    abstract class Vehicle
    {
        public int Price { get; set; }
        public int MaxSpeed { get; set; }
        public int Date { get; set; }
        public Vehicle(int price, int maxspeed, int date)
        {
            this.Price = price;
            this.MaxSpeed = maxspeed;
            this.Date = date;
        }
        public override string ToString()
        {
            return $"Price: {Price}\n" +
                   $"Max Speed: {MaxSpeed}\n" +
                   $"Date:{Date} ";
        }
    }
    
    
    
}
