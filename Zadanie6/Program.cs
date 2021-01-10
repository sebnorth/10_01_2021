using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in tab)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine();

            int ileUjemnych = 0;

            foreach (int item in tab)
            {
                if (item < 0) ileUjemnych++;
            }

            Console.WriteLine("ilość liczb ujemnych w tablicy: {0}", ileUjemnych);

            Console.ReadKey();
        }
    }
}
