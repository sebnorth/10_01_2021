using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            double wynik = (n + n*n) / 3.0;
            Console.WriteLine(wynik);

            Console.ReadKey();
        }
    }
}
