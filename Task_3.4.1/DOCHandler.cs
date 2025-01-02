using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4._1
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine($"Document with a type DOC is opened");
        }

        public override void Change()
        {
            Console.WriteLine($"Document with a type DOC is changed");
        }

        public override void Create()
        {
            Console.WriteLine($"Document with a type DOC is created");
        }

        public override void Save()
        {
            Console.WriteLine($"Document with a type DOC is saved");
        }


    }
}
