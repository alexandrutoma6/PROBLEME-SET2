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
            //p2();
            //p3();
            //p4();
            //p5();
            //p6();
            //p7();
            //p8();
            //p9();
            //p10();
            //p11();
        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
        /// </summary>

        static int invers(int numar2)
        {
            int reverse = 0;
            while (numar2 != 0)
            {
                reverse = reverse * 10 + numar2 % 10;
                numar2 /= 10;
            }
            return reverse;
        }
        private static void p11()
        {
            int n, numar, suma = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("numar= ");
                numar = int.Parse(Console.ReadLine());
                suma += invers(numar);
            }
            Console.WriteLine($"suma inverselor numerelor din sir este {suma}");
            
        }

        /// <summary>
        ///Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        private static void p10()
        {
            int n, consecutiv = 0, numar1, numar2, count = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("numar = ");
            numar1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("numar = ");
                numar2 = int.Parse(Console.ReadLine());
                if (numar1 != numar2)
                {
                    count = 0;
                }
                if (numar1 == numar2)
                {
                    count++;
                }
                
                if (count >= consecutiv)
                {
                    consecutiv = count;
                }
                
                numar1 = numar2;
            }
            if(consecutiv != 0)
            {
                Console.WriteLine($"in sir, se gasesc {consecutiv + 1} numere egale consecutive ");
            }
            else
            {
                Console.WriteLine($"in sir, nu se gasesc numere egale consecutive ");
            }
        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        private static void p9()
        {
            int n, numar1, numar2, monotonie = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("numar = ");
            numar1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("numar = ");
                numar2 = int.Parse(Console.ReadLine());
                if (numar1 <= numar2)
                {
                    monotonie++;
                }
                else
                {
                    monotonie--;
                }
                if(monotonie == 0)
                {
                    break;
                }
                numar1 = numar2;
            }
            if(monotonie > 0)
            {
                Console.WriteLine($"sirul de {n} numere este crescator");
            }
            if(monotonie < 0)
            {
                Console.WriteLine($"sirul de {n} numere este descrescator");
            }
            if(monotonie == 0)
            {
                Console.WriteLine($"sirul de {n} numere nu este monoton");
            }
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
        /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        private static void p8()
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int numar1, numar2, numar3=0;
            numar1 = 0;
            numar2 = 1;
            for (int i = 2; i <= n; i++)
            {
                numar3 = numar1 + numar2;
                numar1 = numar2;
                numar2 = numar3;
            }
            Console.WriteLine($"al {n} numar din sirul lui Fibbonaci este {numar1}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>
        private static void p7()
        {
            int n, minim, maxim, numar;
            minim = int.MaxValue;
            maxim = int.MinValue;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("numar = ");
                numar = int.Parse(Console.ReadLine());
                if (numar >= maxim)
                {
                    maxim = numar;
                }
                if (numar <= minim)
                {
                    minim = numar;
                }
            }
            Console.WriteLine($"cel mai mare numar din secventa este {maxim}");
            Console.WriteLine($"cel mai mic numar din secventa este {minim}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        private static void p6()
        {
            int n, numar1, numar2, obs = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("numar = ");
            numar1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n && obs == 0; i++)
            {
                Console.Write("numar = ");
                numar2 = int.Parse(Console.ReadLine());
                if (numar1 > numar2)
                {
                    obs = 1;
                }
                numar1 = numar2;
            }
            if (obs == 1)
            {
                Console.WriteLine("numerele nu sunt in ordine crescatoare");
            }
            else
            {
                Console.WriteLine("numerele sunt in ordine crescatoare");
            }

        }

        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        /// Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
        private static void p5()
        {
            int n, count_pozitie = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("numarul = ");
                int numar = int.Parse(Console.ReadLine());
                if (numar == i)
                {
                    count_pozitie++;
                }
            }
            Console.WriteLine($" {count_pozitie} numere sunt egale cu pozitia pe care apar");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        private static void p4()
        {
            int n, numar, pozitie = -1;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("sa se caute nr = ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"numarul introdus pe pozitia {i}= ");
                numar = int.Parse(Console.ReadLine());
                if (numar == a)
                {
                    pozitie = i;
                }
            }
            Console.WriteLine($"numarul {a} s-a gasit pe pozitia {pozitie}");

        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n. 
        /// </summary>
        private static void p3()
        {
            int suma = 0, produs = 1;
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                suma += i;
                produs = produs * i;
            }
            Console.WriteLine($"suma numerelor de la 1 la {n} este = {suma}");
            Console.WriteLine($"produsul numerelor de la 1 la {n} este = {produs}");
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
