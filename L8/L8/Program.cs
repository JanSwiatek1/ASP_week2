using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace L8
{
    internal class Program
    {

        public void zad1()
        {
            Console.WriteLine("zad1");
            /*
             *1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100. 
             */
            int count = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }

            Console.WriteLine($"Liczba liczb pierwszych w zakresie od 0 do 100 wynosi: {count}");


            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0) return false;
                }

                return true;
            }
        }

        public void zad2()
        {
            //Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            int i = 0;
            do
            {
                i++;
                if (i % 2 == 0) Console.WriteLine($"{i}");

            } while (i <= 1000);
        }

        public void zad3()
        {
            // Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            Console.Write("Podaj liczbę elementów ciągu Fibonacciego do wyświetlenia: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public void zad4()
        {
            // Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej: 
            //    1 
            //    2 3 
            //    4 5 6 
            //    7 8 9 10
            Console.Write("Podaj liczbę: ");
            int.TryParse(Console.ReadLine(), out int n);
            int c = 1;
            for (int i = 1; c <= n; i++)
            {
                for (int j = 1; j <= i && c <= n; j++)
                {
                    Console.Write(c + " ");
                    c++;
                }
                Console.WriteLine();
            }
        }

        public void zad5()
        {
            //5. Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            for(int i = 1;i < 20; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Liczba: {i}, Trzecia potęga: {cube}");

            }
        }

        public void zad6()
        {
            //6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:  1 + ½ +1 / 3 + ¼ itd.
            int w = 0;
            for ( int i = 1; i < 20; i++)
            {
                w += 1 / i;
            }
            Console.WriteLine(w);
        }

        public void zad7()
        {
            //7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            //   przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:

            Console.WriteLine("Podaj długość krótszej przekątnej diamentu: ");
            Int32.TryParse(Console.ReadLine(), out int d);
            for (int i = 1; i <= d; i++)
            {
                for (int j = d - i; j > 0; j--)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= d; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");

                }
                for (int j = d - i; j > 0; j--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public void zad8()
        {
            // Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np. 
            // Testowe dane: 
            // Abcdefg
            // Rezultat
            // Gfedcba

            Console.WriteLine("Podaj slowo: ");
            string word = Console.ReadLine();
            StringBuilder word2 = new StringBuilder();

            for (int i = word.Length - 1; i > 0; i--)
            {
                word2.Append(word[i]);
            }
            Console.WriteLine(word2.ToString());
        }

        public void zad9()
        {
            // Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            Console.WriteLine("Podaj liczbę dziesiętną: ");
            int d = int.Parse(Console.ReadLine());
            List<int> binNum = new List<int>();

            if (d == 0)
            {
                Console.WriteLine("0");
                return;
            }

            while (d > 0)
            {
                int r = d % 2;
                d = d / 2;
                binNum.Add(r);
            }


            binNum.Reverse();


            Console.Write("Liczba binarna: ");
            foreach (int bit in binNum)
            {
                Console.Write(bit);
            }
        }
        public static void zad10() 
        {
            // Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            Console.WriteLine("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            int g = Calculate(a, b);
            int l = (a * b) / g;
            Console.WriteLine($"Najmniejsza wspólną wielokrotność obu liczb wynosi: {l}");
        }
        static int Calculate(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
