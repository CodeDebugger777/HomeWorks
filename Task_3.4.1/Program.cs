namespace Task_3._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the document type 'XML' or 'DOC' or 'TXT':");
            string key = Console.ReadLine();



            AbstractHandler abstractHandler;

            if (key == "TXT")
            {
                abstractHandler = new TXTHandler();
            }
            else if (key == "DOC")
            {
                abstractHandler = new DOCHandler();
            }
            else if (key == "XML")
            {
                abstractHandler = new XMLHandler();
            }
            else 
            {
                Console.WriteLine($"Incorrect type of document entered");
                return;
            }
            abstractHandler.Open();
            abstractHandler.Create();
            abstractHandler.Change();
            abstractHandler.Save();

        }

        

    }
}
