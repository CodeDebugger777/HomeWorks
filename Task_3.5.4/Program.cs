namespace Task_3._5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Store store = new Store(3);

            
            store[0] = new Article("Телефон", "Магазин1", 5000);
            store[1] = new Article("Ноутбук", "Магазин2", 12000);
            store[2] = new Article("Планшет", "Магазин3", 7000);

            
            Console.WriteLine("Введіть індекс товару (0-2): ");
            int index = int.Parse(Console.ReadLine());
            var article = store[index];
            if (article != null)
            {
                article.DisplayInfo();
            }

           
            Console.WriteLine("Введіть назву товару: ");
            string name = Console.ReadLine();
            store.DisplayArticleByName(name);
        }
    }
}
