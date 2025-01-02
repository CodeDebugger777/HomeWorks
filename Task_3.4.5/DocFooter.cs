using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4._5
{
     class DocFooter : AbstractDoc
    {
       
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
