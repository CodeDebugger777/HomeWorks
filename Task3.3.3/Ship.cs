using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3._3
{
    public class Ship : Vehicle
    {
        public int port { get; set; }
        public int passcount { get; set; }

        public Ship(double x, double y, double price, double speed, int year, int port, int passcount)
           : base(x, y, price, speed, year)
        {
            this.port = port;
            this.passcount = passcount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

    }
}
