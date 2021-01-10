using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość zmiennej ile: ");
            uint ile = uint.Parse(Console.ReadLine());

            // int licznik = 0;
            // int liczba = 0; // liczba przechowuje kolejne wielokrotności 13

            //while (licznik < ile)
            //{
            //    if (liczba % 13 == 0 && liczba % 2 == 1) {

            //        licznik++;
            //        Console.Write("{0} ", liczba);
            //    }

            //    liczba += 13;
            //}

            int liczba = 13; 

            while (ile-- > 0)
            {
                
                   
               Console.Write("{0} ", liczba);
                
               liczba += 26;
            }

            Console.ReadKey();
        }
    }
}
