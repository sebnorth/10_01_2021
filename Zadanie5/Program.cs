using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine()); // ilość kolumn

            Console.WriteLine("Podaj b: "); // ilość wierszy
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                if (i == 0 || i == b - 1)
                {

                    for (int j = 0; j < a; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();

                }

                else {

                    // 1 gwiazdkę
                    Console.Write("*");
                    // a-2 spacje
                    for (int j = 0; j < a-2; j++)
                    {
                        Console.Write(" ");
                    }
                    // 1 gwiazdkę
                    Console.Write("*");
                    // nowa linia
                    Console.WriteLine();

                }
            }

            Console.ReadKey();
        }
    }
}
