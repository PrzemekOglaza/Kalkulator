using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //KalkulatorNiezabezpieczonyPrzedWpisaniemLitery();
            bool endApp = false;
            Console.WriteLine(" Kalkulator dla C#\r ");
            Console.WriteLine("_________________\n");

            while (!endApp)
            {   // Deklaracja zmiennych
                string numInput1 = " ";
                string numInput2 = " ";
                double result = 0;

                // Wpisanie pierwszej liczby
                Console.Write("Podaj pierwszą liczbę i potwierdz ENTER\n");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("To nie jest poprawna liczba. Wprowadz ponownie\n");
                    numInput1 = Console.ReadLine();
                }

                // Wpisanie drugiej liczby
                Console.Write("Podaj drugą liczbę i potwierdz ENTER\n");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("To nie jest poprawna liczba. Wprowadz ponownie\n");
                    numInput2 = Console.ReadLine();
                }

                // Wybierz rodzaj operacji
                Console.WriteLine("Wybierz rodzaj operacji:  ");
                Console.WriteLine(" \ta  - dodawanie");
                Console.WriteLine(" \ts  - odejmowanie");
                Console.WriteLine(" \tm  - mnożenie");
                Console.WriteLine(" \td  - dzielenie");
                Console.Write("Twój wybór to:  ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.Operacje(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Ta operacja spowoduje błąd");
                    }
                    else
                    {
                        Console.WriteLine("Twój wynik: {0:0.##}", result );
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Wystąpił wyjątek, szczegóły : " + e.Message );
                }
                Console.WriteLine("_________________");

                Console.WriteLine("Nacijśnij n i ENTER aby zakończyć, lub inny klawisz żeby kontynuować: ");
                if (Console.ReadLine() == "n") 
                {
                    endApp = true;
                }
                Console.WriteLine("\n");
            }
            return;
        }

        private static void KalkulatorNiezabezpieczonyPrzedWpisaniemLitery()
        {
            //Zadeklaruj zmienne, a następnie zainicjuj do zera.
            double num1 = 0;
            double num2 = 0;

            //Wyświetl tytuł jako aplikację kalkulatora konsoli C #.

            Console.WriteLine("Aplikacja kalkulatora dla C#\r");
            Console.WriteLine("----------------------------\n");

            //Poproś użytkownika o wpisanie liczb.

            Console.WriteLine("Wprowadz pierwszą liczbę i naciśnij ENTER");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadz drugą liczbę i naciśnij ENTER");
            num2 = Convert.ToDouble(Console.ReadLine());

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
                    Console.WriteLine($"Twoje równanie: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Twoje równanie: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Twoje równanie: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Wprowadz drógą liczbę inną niż 0
                    while (num2 == 0)
                    {
                        Console.WriteLine("Liczba nie może być 0, wpisz inną liczbę:  ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Twoje równanie: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            //Zamknięcie Kalkulatora
            Console.WriteLine("Wciśnij dowolny klawisz żeby zakończyć pracę kalkulatora");
            Console.ReadKey();
        }
    }
}
