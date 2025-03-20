using static System.Runtime.InteropServices.JavaScript.JSType;

namespace L7
{
    internal class Program
    {
        static void zad1()
        {
            //  1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie. Dane testowe: 
            //  a: 5
            //  b: 5
            //  Rezultat w terminalu: 5 i 5 są równe
            int a = 5;
            int b = 5;
            if (a == b) Console.WriteLine("true");
            else Console.WriteLine("false");

        }
        static void zad2()
        { 
//            2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
           // jest parzysta czy nieparzysta.
          //  Dane testowe : 15
         //   Rezultat w terminalu:
//            15 jest liczbą nieparzystą

            Console.WriteLine("Podaj liczbę");
            Int32.TryParse(Console.ReadLine(), out int c);

            Console.WriteLine("Podaj drugą liczbę");
            if (c%2 == 0)
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine("false");
            }

        }
        static void zad3()
        {
            /*
              3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna. 
                Dane testowe : 14 
                Rezultat w terminalu : 
                14 jest liczbą dodatnią 
             */
            Console.WriteLine("Podaj liczbę");
            Int32.TryParse(Console.ReadLine(), out int d);
            if (d > 0)
            {
                Console.WriteLine("nieujemna");
            }
            else if (d == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("niedodatnia");
            }
        }
    }
}
