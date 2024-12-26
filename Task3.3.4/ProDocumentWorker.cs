using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3._4
{
    public class ProDocumentWorker : DocumentWorker
    {
       
        public override void EditDocument()
        {
            Console.WriteLine("The document was edited.");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version.");
        }
    }
}
