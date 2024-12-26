using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3._3
{
    public class Vehicle
    {
        public double x { get; set; }
        public double y { get; set; }

        public double price { get; set; }
        public double speed { get; set; }

        public int year { get; set; }

        public Vehicle(double x, double y, double price, double speed, int year)
        { 
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void ShowInfo()
        {
           
            Console.WriteLine($"Coordinates: {x}, {y}");
            Console.WriteLine($"Price: {price}, Speed: {speed}; Year: {year}");
        }
    
    }
}
