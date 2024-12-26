namespace Task3._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle _plane = new Plane(45.1, 25.2, 6000000, 400, 1999, 25, 4587);
            Vehicle _sheep = new Ship(77.1, 25.3, 5000000, 650, 2003, 6548, 120);
            Vehicle _car = new Car(74.8, 65.8, 400000, 120, 2015);

            Console.WriteLine($"Plane parameters:");
            _plane.ShowInfo();

            Console.WriteLine($"Sheep parameters:");
            _sheep.ShowInfo();

            Console.WriteLine($"Car parameters:");
            _car.ShowInfo();    

            Console.ReadKey();  

        }
    }
}
