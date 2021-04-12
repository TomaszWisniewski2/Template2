using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Classes
{
    class Kot : AbstractClass
    {
        public override void Jestem()
        {
            Console.WriteLine("Jestem kotem robie: ");
        }

        public override void Głos()
        {
            Console.WriteLine("Miałłłł");
        }
    }
}
