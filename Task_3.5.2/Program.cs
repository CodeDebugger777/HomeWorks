namespace Task_3._5._2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the size of the array from1 to 10:");
            int N = int.Parse(Console.ReadLine());


            int[] array = new int[N];
            Random rand = new Random();

            Console.WriteLine("Array:");

            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();


            int max = array[0];
            int min = array[0];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
                sum += array[i];
            }


            double average = (double)sum / N;


            Console.WriteLine($"Max value is: {max}");
            Console.WriteLine($"Min value is: {min}");
            Console.WriteLine($"Summ is: {sum}");
            Console.WriteLine($"Average is: {average}");

            // Виведення непарних чисел
            Console.WriteLine("Unpaired elements of the array:");
            foreach (var num in array)
            {
                if (num % 2 != 0)
                    Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}