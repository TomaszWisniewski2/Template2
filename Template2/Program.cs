using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Classes;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass Pies = new Pies();
            Pies.Przedstaw();

            AbstractClass Kot = new Kot();
            Kot.Przedstaw();

            AbstractClass Krowa = new Krowa();
            Krowa.Przedstaw();

            AbstractClass Ptak = new Ptak();
            Ptak.Przedstaw();




            // Wait for user
            Console.ReadKey();
        }
    }
}