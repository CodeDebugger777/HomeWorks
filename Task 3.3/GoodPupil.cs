using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil is studying well.");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil reads at a good pace.");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil writes correctly.");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil relaxes when needed.");
        }
    }
}
