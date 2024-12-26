using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3._4
{
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("The document is opened.");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing a document in the Pro version.");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document in the Pro version.");
        }

    }
}
