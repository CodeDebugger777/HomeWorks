using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3._3
{
    public class Plane : Vehicle
    {
        public double height { get; set; }
        public int passcount { get; set; }

        public Plane(double x, double y, double price, double speed, int year, double height, int passcount)
           : base(x, y, price, speed, year)
        {
            this.height = height;
            this.passcount = passcount;
        }
        public override void ShowInfo()
        {
            
            Console.WriteLine($"Coordinates: {x}, {y}");
            Console.WriteLine($"Price: {price}, Speed: {speed}, Year: {year}, Height: {height}, Count of passenger: {passcount}" );
        }
    }
}
