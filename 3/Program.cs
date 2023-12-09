using System;

internal class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Podaj pierwszą liczbę całkowitą: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj drugą liczbę całkowitą: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            // Sprawdzam, czy druga liczba jest równa zero
            if (liczba2 == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez zero!");
            }

            //  Dzielenie i wyświetlenie wyniku
            double wynik = (double)liczba1 / liczba2;
            Console.WriteLine($"Wynik dzielenia: {wynik}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd formatu. Wprowadzono niepoprawne dane.");
        }
        catch (DivideByZeroException a)
        {
            Console.WriteLine($"Błąd dzielenia przez zero: {a.Message}");
        }
        catch (Exception a)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {a.Message}");
        }
    }
}