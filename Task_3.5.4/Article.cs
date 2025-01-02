using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._5._4
{
    internal class Article
    {
        private string product_name;
        private string store_name;
        private double product_value;

        public Article(string productName, string storeName, double price)
        {
            this.product_name = productName;
            this.store_name = storeName;
            this.product_value = price;
        }
        public string ProductName
        {
            get { return product_name; }
        }

        public string StoreName
        {
            get { return store_name; }
        }

        public decimal Price
        {
            get { return product_value; }
        }

        // Метод для виведення інформації про товар
        public void DisplayInfo()
        {
            Console.WriteLine($"Product name: {product_name, store: {store_name}, value: {product_value} грн");
        }

    }
}
