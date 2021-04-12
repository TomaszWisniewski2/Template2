using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Classes
{
    class Pies : AbstractClass
    {
        public override void Jestem()
        {
            Console.WriteLine("Jestem psem robie: ");
        }

        public override void Głos()
        {
            Console.WriteLine("Hau Hau");
        }
    }
}