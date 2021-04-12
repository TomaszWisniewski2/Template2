using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Classes
{
    abstract class AbstractClass
    {
        public abstract void Jestem();
        public abstract void Głos();

        // The "Template method"
        public void Przedstaw()
        {
            Jestem();
            Głos();
            Console.WriteLine();
        }
    }
}