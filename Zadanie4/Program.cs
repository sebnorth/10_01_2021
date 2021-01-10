using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj x: ");
            int x = int.Parse(Console.ReadLine());

            int cyfra;
            int iloczyn = 1;

            for (; x > 0 ; )
            {
                cyfra = x % 10;
                iloczyn *= cyfra;
                x /= 10;

            }

            Console.WriteLine("Iloczyn cyfr wynosi: {0}", iloczyn);

            Console.ReadKey();
        }
    }
}
