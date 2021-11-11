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
            Console.WriteLine();
            Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n. ");
            Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. ");
            Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).");
            Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
            Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");
            Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. ");
            Console.WriteLine("13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive. Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
            Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. ");

            Console.Write("ALEGETI PROBLEMA NUMARUL: ");
            int problema = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            if (problema == 1)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
                Console.WriteLine(); 
                p1();
            }
            if (problema == 2)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
                Console.WriteLine();
                p2();
            }
            if (problema == 3)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n. ");
                Console.WriteLine();
                p3();
            }
            if (problema == 4)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. ");
                Console.WriteLine();
                p4();
            }
            if (problema == 5)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. ");
                Console.WriteLine();
                p5();
            }
            if (problema == 6)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
                Console.WriteLine();
                p6();
            }
            if (problema == 7)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
                Console.WriteLine();
                p7();
            }
            if (problema == 8)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).");
                Console.WriteLine();
                p8();
            }
            if (problema == 9)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
                Console.WriteLine();
                p9();
            }
            if (problema == 10)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
                Console.WriteLine();
                p10();
            }
            if (problema == 11)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");
                Console.WriteLine();
                p11();
            }
            if (problema == 12)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. ");
                Console.WriteLine();
                p12();
            }
            if (problema == 13)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive. Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
                Console.WriteLine();
                p13();
            }
            if (problema == 14)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
                Console.WriteLine();
                p14();
            }
            if (problema == 15)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
                Console.WriteLine();
                p15();
            }
            if (problema == 16)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
                Console.WriteLine();
                //p16();
            }
            if (problema == 17)
            {
                Console.WriteLine($"Ati ales problema numarul {problema}: ");
                Console.WriteLine();
                Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. ");
                Console.WriteLine();
                //p17();
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine();

        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. 
        /// Se da o secventa de n numere. Sa se determine daca este bitonica.
        /// </summary>
        private static void p15()
        {
            int n, crescator = 0, descrescator = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("numar= ");
            int numar1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("numar= ");
                int numar2 = int.Parse(Console.ReadLine());
                if(numar2 >= numar1)
                {
                    crescator++;
                }
                if(numar2 < numar1)
                {
                    descrescator++;
                }
                if(descrescator != 0)
                {
                    crescator = -1;

                }

            }
        }

        /// <summary>
        /// O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. 
        /// Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        private static void p14()
        {
            
        }

        /// <summary>
        /// O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        private static void p13()
        {
            
        }

        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        private static void p12()
        {
            int n, grup = 0, cuvant = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("numar = ");
                int numar = int.Parse(Console.ReadLine());
                if (numar == 0)
                {
                    if(cuvant != 0)
                    {
                        grup++;
                    }
                    else
                    {
                        cuvant = 0;
                    }
                }
                if(numar != 0)
                {
                    cuvant++;
                }
            }
            if(cuvant != 0)
            {
                grup++;
            }
            Console.WriteLine($"in secventa exista {grup} grupuri de numere delimitate de 0");
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
