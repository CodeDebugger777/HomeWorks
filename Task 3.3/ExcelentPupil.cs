using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil is studying very hard!");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil is reading quickly and efficiently.");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil writes neatly and correctly.");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil relaxes efficiently, taking short breaks.");
        }
    }
}
