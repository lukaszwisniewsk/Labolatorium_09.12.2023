using System;

internal class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę całkowitą: ");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj drugą liczbę całkowitą: ");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        double wynik = Dzielenie(liczba1, liczba2); // wywołanie metody Dzielenie

        if (double.IsNaN(wynik))
        {
            Console.WriteLine("Błąd dzielenia przez zero.");
        }
        else
        {
            Console.WriteLine($"Wynik dzielenia: {wynik}");
        }
    }

    static double Dzielenie(int dzielna, int dzielnik)  // wejście do metody Dzielenie z obsługą wyjątków
    {
        double wynik = 0;

        try
        {
            if (dzielnik == 0)
            {
                goto BladDzieleniaPrzezZero;
            }

            wynik = (double)dzielna / dzielnik;
            return wynik;

        BladDzieleniaPrzezZero:
            // W przypadku próby dzielenia przez 0 przechodimy do etykiety BladDzieleniaPrzezZero:
            return double.NaN; // NaN oznacza "Not a Number", co można interpretować jako błąd
        }
        catch (Exception a)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {a.Message}");
            return double.NaN;
        }
    }
}