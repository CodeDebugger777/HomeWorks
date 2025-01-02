using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4._1
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine($"Document with a type XML is opened");
        }

        public override void Change()
        {
            Console.WriteLine($"Document with a type XML is changed");
        }

        public override void Create()
        {
            Console.WriteLine($"Document with a type XML is Created");
        }

        public override void Save()
        {
            Console.WriteLine($"Document with a type XML is Saved");
        }
    }
}
