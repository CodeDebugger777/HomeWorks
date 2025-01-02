using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_3._5._4
{
    class Store
    {
        private Article[] articles;

        // Конструктор для ініціалізації масиву товарів
        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        // Метод для виведення інформації про товар за номером
        public void DisplayArticleByIndex(int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index].DisplayInfo();
            }
            else
            {
                Console.WriteLine("Товар з таким індексом не знайдений.");
            }
        }
        public void DisplayArticleByName(string product_name)
        {
            bool found = false;
            foreach (var article in articles)
            {
                if (article.ProductName.Equals(product_name, StringComparison.OrdinalIgnoreCase))
                {
                    article.DisplayInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Товар з такою назвою не знайдений.");
            }
        }
        
    }
}
