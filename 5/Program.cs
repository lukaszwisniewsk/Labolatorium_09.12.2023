using System;

internal class Program
{
    static void Main()
    {
        Random random = new Random();

        // Pętla do generowania liczb losowych
        while (true)
        {
            int randomNumber = random.Next(1, 51); // Generuj liczby od 1 do 50

            // Sprawdzamy warunki
            if (randomNumber > 40)
            {
                Console.WriteLine($"Wygenerowano liczbę większą niż 40: {randomNumber}");
                break; // Przerwij pętlę
            }
            else if (randomNumber < 10)
            {
                Console.WriteLine($"Wygenerowano liczbę mniejszą niż 10: {randomNumber}");
                goto WygenerujPonownie; // Użycie instrukcji goto do wykonujący skok do etykiety WygenerujPonownie
            }
            else
            {
                Console.WriteLine($"Wygenerowano liczba: {randomNumber}");
            }
        }

    WygenerujPonownie:
        Console.WriteLine("Generowanie liczby ponownie...");
    }
}