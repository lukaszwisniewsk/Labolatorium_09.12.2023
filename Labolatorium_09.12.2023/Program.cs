using System;

internal class Program
{
    static void Main()
    {
        int[] liczby = { 1, 2, 3, 4, 5 };
        double srednia = ObliczSrednia(liczby);
        Console.WriteLine($"Średnia arytmetyczna: {srednia}");
    }

    static double ObliczSrednia(int[] tablica)
    {
        if (tablica == null || tablica.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta");
        }

        int sum = 0;

        //  pętla foreach do sumowania elementów tablicy
        foreach (int number in tablica)
        {
            sum += number;
        }

        // Obliczam średnią arytmetyczną
        double srednia = (double)sum / tablica.Length;

        return srednia;
    }
}