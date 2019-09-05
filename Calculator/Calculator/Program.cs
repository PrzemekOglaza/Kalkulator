using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   //Zadeklaruj zmienne, a następnie zainicjuj do zera.
            int num1 = 0;
            int num2 = 0;

            //Wyświetl tytuł jako aplikację kalkulatora konsoli C #.

            Console.WriteLine("Aplikacja kalkulatora dla C#\r");
            Console.WriteLine("----------------------------\n");

            //Poproś użytkownika o wpisanie liczb.

            Console.WriteLine("Wprowadz pierwszą liczbę i naciśnij ENTER");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wprowadz drugą liczbę i naciśnij ENTER");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Wybierz opcje z listy

            Console.WriteLine("Wybierz z listy i zatwierdz ENTER: ");
            Console.WriteLine("a - Add (DODAJ)");
            Console.WriteLine("s - Subtract (ODEJMIJ)");
            Console.WriteLine("m - Multiply (POMNÓŻ)");
            Console.WriteLine("d- Divide (PODZIEL)");
            Console.Write("Twój wybór?  ");

            //Instrukcja SWITCH do obliczeń matematycznych

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Twoje równanie: {num1} + {num2} = "+(num1+num2));
                    break;
                case "s":
                    Console.WriteLine($"Twoje równanie: {num1} - {num2} = "+( num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Twoje równanie: {num1} * {num2} = "+(num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Twoje równanie: {num1} / {num2} = "+(num1/num2));
                    break;
            }
            //Zamknięcie Kalkulatora
            Console.WriteLine("Wciśnij dowolny klawisz żeby zakończyć pracę kalkulatora");
            Console.ReadKey();
        }
    }
}
