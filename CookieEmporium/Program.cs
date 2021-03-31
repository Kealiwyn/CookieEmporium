using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieEmporium
{
    class Program
    {
        static void Main(string[] args)
        {
            CookieOrder n = new CookieOrder(01, "Patrick", "Chocolate Chip", 2);
            Console.WriteLine(n.ToString());

            SpecialCookieOrder s = new SpecialCookieOrder(01, "Patrick", "Chocolate Chip", 2, "gluten-free");
            Console.WriteLine(s.ToString());

            Console.ReadKey();
        }
    }
}
