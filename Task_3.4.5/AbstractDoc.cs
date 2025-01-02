using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4._5
{
    abstract class AbstractDoc
    {
        string content;

        public abstract string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Нижній колонтитул відсутній.";
            }
            set
            {
                content = value;
            }
        }
          
            public abstract void Show();
        }
}
