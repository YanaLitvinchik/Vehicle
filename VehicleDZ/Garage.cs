using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDZ
{
    class Garage
    {
        public List<Lorry> lorries = new List<Lorry>();
        public List<Car> cars = new List<Car>();
        public List<Bicycle> bicycles = new List<Bicycle>();
        public void AddLorry()
        {
            int prise = 0, maxspeed = 0, date = 0, Weight = 0;
            Console.WriteLine("Input a price: ");
            prise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input max speed: ");
            maxspeed = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Input date: ");
            date = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Input weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());
            lorries.Add(new Lorry(prise, maxspeed, date, Weight));            
        }
        public void AddBicycle()
        {
            int prise = 0, maxspeed = 0, date = 0, Height = 0;
            Console.WriteLine("Input a price: ");
            prise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input max speed: ");
            maxspeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input date: ");
            date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input weight: ");
            Height = Convert.ToInt32(Console.ReadLine());
            bicycles.Add(new Bicycle(prise, maxspeed, date, Height));
        }
        public void AddCar()
        {
            int prise = 0, maxspeed = 0, date = 0, Passengers = 0;
            Console.WriteLine("Input a price: ");
            prise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input max speed: ");
            maxspeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input date: ");
            date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input weight: ");
            Passengers = Convert.ToInt32(Console.ReadLine());
            cars.Add(new Car(prise, maxspeed, date, Passengers));
        }
        public void GetAllLorry()
        {
            foreach (Lorry lorry in lorries)
            {
                Console.WriteLine($"----Lorry----\nPrice:{lorry.Price}\nMax Speed:{lorry.MaxSpeed}\nDate:{lorry.Date}\nWeight:{lorry.Weight}\n");

            }
        }

        public void GetAllCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"----Car----\nPrice:{car.Price}\nMax Speed:{car.MaxSpeed}\nDate:{car.Date}\nPassengers:{car.Passengers}\n");

            }
        }

        public void GetAllBicycle()
        {
            foreach (Bicycle bicycle in bicycles)
            {
                Console.WriteLine($"----Bicycle----\nPrice:{bicycle.Price}\nMax Speed:{bicycle.MaxSpeed}\nDate:{bicycle.Date}\nWeight:{bicycle.Height}\n");

            }
        }
    }
}
