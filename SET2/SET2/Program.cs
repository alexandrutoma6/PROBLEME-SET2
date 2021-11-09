using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET2
{
    class Program
    {
        static void Main(string[] args)
        {
            //p1();
            p2();
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
        /// </summary>
        private static void p2()
        {
            int n, numar;
            int pozitiv = 0, negativ = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("numar= ");
                numar = int.Parse(Console.ReadLine());

                if (numar > 0)
                {
                    pozitiv++;
                }
                if (numar < 0)
                {
                    negativ++;
                }
            }
            Console.WriteLine($"din {n} numere, {pozitiv} au fost pozitive, {negativ} au fost negative si {n-(pozitiv + negativ)} au fost = cu 0");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        private static void p1()
        {
            int n, numar, count = 0 ;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("numar= ");
                numar = int.Parse(Console.ReadLine());
                if (numar % 2 == 0)
                {
                    count++;
                }
                
            }
            Console.WriteLine($"s-au introdus {count} numere pare");
        }
    }
}
