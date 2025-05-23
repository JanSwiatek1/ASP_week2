﻿using System;
using System.Diagnostics;
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

        static void zad4()
        {
            /*
           4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok 
            jest rokiem przestępnym. 
            Dane testowe : 2016 
            Rezultat w terminalu : 
            2016 jest rokiem przestępnym
            */

            Console.WriteLine("podaj rok: ");
            Int32.TryParse(Console.ReadLine(), out int year);
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} to rok przestępny.");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }
        }
        static void zad5()
        {
            /*
            5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek 
            uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, 
            prezydenta. 
            Dane testowe : 21 
            Rezultat w terminalu : 
            Możesz zostać posłem 
             */
            // poseł - 21
            // premier - 21
            // senator - 30
            // prezydent - 35

            Console.WriteLine("Podaj wiek: ");
            Int32.TryParse(Console.ReadLine(), out int age);

            if (age >= 21)
            {
                Console.WriteLine("Twój wiek uprawnia cię do ubiegania się o stanowisko \r\n posła i premiera");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Twój wiek uprawnia cię do ubiegania się o stanowisko \r\n posła, premiera i sentarora");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Twój wiek uprawnia cię do ubiegania się o stanowisko \r\n posła, premiera, sentarora i prezydenta");
            }
            else 
            {
                Console.WriteLine("Twój wiek nie uprawnia cię do ubiegania się o stanowisko posła, premiera, sentarora,prezydenta");
            }

        }
        static void zad6()
        {
            /*
             6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu 
                wymyśloną kategorię wzrostu. 
                Dane testowe : 140 
                Rezultat w terminalu : 
                Jesteś krasnoludem
             */
            Console.WriteLine("Podaj wzrost: ");
            Int32.TryParse(Console.ReadLine(), out int height);
            if (height >= 160)
            {
                Console.WriteLine("Jesteś człowiekiem");
            }
            else if (height >= 180)
            {
                Console.WriteLine("Jesteś elfem");
            }
            else if (height >= 200)
            {
                Console.WriteLine("Jesteś gigantem");
            }
            else
            {
                Console.WriteLine("Jesteś krasnoludem");
            }

        }
        static void zad7()
        {
            /*
             7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, 
                która jest największa 
                Dane testowe: 
                25 
                63 
                79 
                Rezultat w terminalu : 
                79 jest największa z podanych
             */
            Console.WriteLine("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int L1);

            Console.WriteLine("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int L2);

            Console.WriteLine("Podaj trzecią liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int L3);

            if (L3 > L2)
            {
                if (L2 > L1) Console.WriteLine($"Największa jest liczba {L3}, następna jest {L2} a najmniejsza jest {L1}");
                else if ((L2 < L1) && (L3 > L1)) Console.WriteLine($"Największa jest liczba {L3}, następna jest {L1} a najmniejsza jest {L2}");
                else Console.WriteLine($"Największa jest liczba {L1}, następna jest {L3} a najmniejsza jest {L2}");
            }
            else
            {
                if (L3 > L1) Console.WriteLine($"Największa jest liczba {L2}, następna jest {L3} a najmniejsza jest {L1}");
                else if ((L3 < L1) && (L2 > L1)) Console.WriteLine($"Największa jest liczba {L2}, następna jest {L1} a najmniejsza jest {L3}");
                else Console.WriteLine($"Największa jest liczba {L1}, następna jest {L2} a najmniejsza jest {L3}");
            }
        }
        static void zad8()
        {
            /*
             8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce 
                na studiach wg. Następujących kryteriów: 

                Wynik z Matury z matematyki powyżej 70 
                Wynik z fizyki powyżej 55 
                Wynik z chemii powyżej 45 
                Łączny wynik z 3 przedmiotów powyżej 180 

                Albo 

                Wynik z matematyki i jednego przedmiotu powyżej 150 
                Dane testowe: 
                Matematyka 80 
                Fizyka 71 
                Chemia 0 
                Rezultat w terminalu : 
                Kandydat dopuszczony do rekrutacji
             */
            Console.WriteLine("Podaj wynik z matury dla matematyki: ");
            Int32.TryParse(Console.ReadLine(), out int mat);

            Console.WriteLine("Podaj wynik z matury dla fizyki: ");
            Int32.TryParse(Console.ReadLine(), out int fiz);

            Console.WriteLine("Podaj wynik z matury dla cemii: ");
            Int32.TryParse(Console.ReadLine(), out int chem);

            int sum = mat + fiz + chem;
            Console.WriteLine($"Twój wynik to {sum}");

            if ((mat > 70) && (sum > 180) && ((fiz>55) || (chem>45)) && ((mat+fiz>150) || (mat+chem>150)) )   Console.WriteLine("Zostałeś dopuszczony do rekrutacji.");
            else Console.WriteLine("Nie zostałeś dopuszczony do rekrutacji.");
        }
        static void zda9()
        {
            /*
             9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w 
                poniższych kryteriach 
                Temp < 0 – cholernie piździ 
                Temp 0 – 10 – zimno 
                Temp 10 – 20 – chłodno 
                Temp 20 – 30 – w sam raz 
                Temp 30 – 40 – zaczyna być słabo, bo gorąco 
                Temp >= 40 – a weź wyprowadzam się na Alaskę. 
 
                Dane testowe : 41 
                Rezultat w terminalu : 
                a weź wyprowadzam się na Alaskę.  
             */
            Console.WriteLine("Podaj temperaturę: ");
            Int32.TryParse(Console.ReadLine(), out int temp);

            if (temp < 0) Console.WriteLine("cholernie piździ");
            else if (temp < 10) Console.WriteLine("zimno");
            else if (temp < 20) Console.WriteLine("chłodno");
            else if (temp < 30) Console.WriteLine("w sam raz");
            else if (temp < 40) Console.WriteLine("zaczyna być słabo, bo gorąco");
            else Console.WriteLine("a weź wyprowadzam się na Alaskę");

        }
        static void zda10()
        {
            /*
             10. Napisz program, który sprawdzi, czy z 3 podanych długości można 
                stworzyć trójkąt 
                Dane testowe : 40 55 65 
                Rezultat w terminalu : 
                Można zbudować trójkąt
             */

            Console.WriteLine("Podaj pierwszy bok: ");
            Int32.TryParse(Console.ReadLine(), out int B1);

            Console.WriteLine("Podaj drugi bok: ");
            Int32.TryParse(Console.ReadLine(), out int B2);

            Console.WriteLine("Podaj trzeci bok: ");
            Int32.TryParse(Console.ReadLine(), out int B3);

            if (B1<B2+B3 || B2<B1+B3 || B3<B1+B2) {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else Console.WriteLine("Nie można zbudować trójkąta");
        }
        static void zda11()
        {
            /*
             Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli: 
            6 Celujący 
            5 Bardzo dobry 
            4 Dobry 
            3 Dostateczny 
            2 Dopuszczający 
            1 Niedostateczny 

            Dane testowe : 3 
            Rezultat w terminalu : 
            Dostateczny 
             */
            Console.WriteLine("Podaj swoją ocenę: ");
            Int32.TryParse(Console.ReadLine(), out int grade);

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej oceny!");
                    break;
            }
        }
        static void zad12()
        {
            /*
             12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego 
                nazwę 
                Dane testowe : 4 
                Rezultat w terminalu : 
                Czwartek
             */
            Console.WriteLine("Podaj numer dnia tygodnia: ");
            Int32.TryParse(Console.ReadLine(), out int day);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Tydzień ma 7 dni!");
                    break;
            }
        }
        static void zad13() 
        {
            /*
             13. Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I 
                    będzie prostym kalkulatorem 
                    Podaj pierwszą liczbę:  
                    … 
                    Podaj drugą liczbę: 
                    … 
                    Podaj numer operacji do wykonania: 
                    1. Dodawanie 
                    2. Odejmowanie 
                    3. Mnożenie 
                    4. Dzielenie 
    … 
                    Twój wynik to:
             */

            Console.WriteLine("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            operation:
            Console.WriteLine("Podaj numer operacji do wykonania:\r\n 1. Dodawanie \r\n2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");
            Int32.TryParse(Console.ReadLine(), out int op);

            switch (op)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to: {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to: {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Twój wynik to: {a * b}");
                    break;
                case 4:
                    Console.WriteLine($"Twój wynik to: {a / b}");
                    break;
                default :
                    Console.WriteLine("Wybierz od 1 do 4");
                    goto operation;

            }
        }
    }
}
