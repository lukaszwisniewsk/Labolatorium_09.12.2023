using System;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // Wywołaj funkcję z wiekiem wprowadzonym przez użytkownika
            Console.Write("Podaj wiek: ");
            int age = Convert.ToInt32(Console.ReadLine());
            CheckAge(age);
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd formatu. Wprowadź poprawną liczbę.");
        }
        catch (InvalidAgeException a)
        {
            Console.WriteLine($"Błąd wieku: {a.Message}");
        }
    }

    public static void CheckAge(int age)
    {
        if (age < 0 || age > 130)
        {
            // Rzuć własny wyjątek InvalidAgeException
            throw new InvalidAgeException("Wiek musi być między 0 a 120.");
        }

        // Logika dla poprawnego wieku
        Console.WriteLine($"Wiek osoby: {age}");
    }
}