using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pageTwoSixtySix
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();

            JewelTheif jewelTheif = new JewelTheif();
            jewelTheif.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
