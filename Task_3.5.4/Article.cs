using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._5._4
{
    public class Article
    {
        
        private string name;
        private string storeName;
        private decimal price;

        public string Name
        {
            get { return name; }
        }

        public string StoreName
        {
            get { return storeName; }
        }

        public decimal Price
        {
            get { return price; }
        }



        public Article(string name, string storeName, decimal price)
        {
            this.name = name;
            this.storeName = storeName;
            this.price = price;
        }

        
        
        // Метод для виведення інформації про товар
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва товару: {name}");
            Console.WriteLine($"Назва магазину: {storeName}");
            Console.WriteLine($"Вартість товару: {price} грн");
        }
    }
}