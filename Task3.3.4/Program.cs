using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Task3._3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the access key 'pro' or 'expert':");
            string key = Console.ReadLine();

            DocumentWorker documentWorker;

            
            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "expert")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                
                documentWorker = new DocumentWorker();
            }

            
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
