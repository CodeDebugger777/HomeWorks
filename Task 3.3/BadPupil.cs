using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil studies only when forced.");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil reads slowly and not very well.");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil writes untidily and often makes mistakes.");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil spends too much time relaxing.");
        }
    }
}

