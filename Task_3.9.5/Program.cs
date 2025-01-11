using System.Data;

namespace Task_3._9._5
{
    public delegate void MyDelegate(ref int a, ref int b,ref int c, out double z );
    internal class Program
    {
        static void Main()
        {
            int a = 5, b = 6, c = 10;
            double z;
            MyDelegate avarage = static delegate (ref int a, ref int b, ref int c, out double z)
            {
                z = (a + b + c) / 3.0; 
            };
            avarage(ref a, ref b, ref c, out z);
            Console.WriteLine($"Average is: {z}");
        }
    }
}
