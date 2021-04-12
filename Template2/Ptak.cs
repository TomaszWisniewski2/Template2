using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Classes
{
    class Ptak : AbstractClass
    {
        public override void Jestem()
        {
            Console.WriteLine("Jestem ptakiem robie: ");
        }

        public override void Głos()
        {
            Console.WriteLine("ćwir.. ćwir..");
        }
    }
}
