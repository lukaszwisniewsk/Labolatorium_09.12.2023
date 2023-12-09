using System;

internal class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 }; // definicja tablicy

        try
        {
            int indexToRetrieve = 5;
            int result = GetElementAtIndex(numbers, indexToRetrieve);

            Console.WriteLine($"Element o indeksie {indexToRetrieve}: {result}");
            
        }
        catch (IndexOutOfRangeException)  // obsługa wyjątku indeks jest poza zakresem tablicy
        {
            Console.WriteLine("Błąd: Podany indeks jest poza zakresem tablicy.");
        }
        catch (ArgumentNullException) // obsługa wyjątku tablica jest null
        {
            Console.WriteLine("Błąd: Tablica jest null.");
        }
        catch (Exception a)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {a.Message}");
        }
    }

    static int GetElementAtIndex(int[] array, int index) //funkcja sprawdza czy tablica array != null oraz czy indeks
      //  nie jest poza zakresem tablicy, następnie wykonuje odpowiednią obsługę wyjątków lub zwraca element o podanym indeksie  
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Tablica nie może być null.");
        }

        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Podany indeks jest poza zakresem tablicy.");
        }

        return array[index];
    }
}