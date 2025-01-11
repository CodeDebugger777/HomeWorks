using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_3._5._4
{
    public class Store
    {
        private Article[] articles;

        
        public Store(int numberOfArticles)
        {
            articles = new Article[numberOfArticles];
        }

        
        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                {
                    return articles[index];
                }
                else
                {
                    Console.WriteLine("Товар з таким індексом не знайдено.");
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < articles.Length)
                {
                    articles[index] = value;
                }
                else
                {
                    Console.WriteLine("Невірний індекс для додавання товару.");
                }
            }
        }

        
        public void DisplayArticleByName(string name)
        {
            bool found = false;
            foreach (var article in articles)
            {
                if (article != null && article.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    article.DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Товар з такою назвою не знайдено.");
            }
        }
    }
}
