namespace Task_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new ExcelentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            Pupil pupil4 = new ExcelentPupil();

            
            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

            
            classRoom.DisplayPupilsAbility();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}