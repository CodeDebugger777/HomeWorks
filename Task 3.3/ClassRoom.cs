using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    internal class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4)
            {
                Console.WriteLine("Class must contain 2 to 4 pupils.");
                return;
            }
            this.pupils = pupils;
        }
        public void DisplayPupilsAbility()
        {
            foreach (var pupil in pupils)
            {
                Console.WriteLine("----- " + pupil.GetType().Name + " -----");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}
