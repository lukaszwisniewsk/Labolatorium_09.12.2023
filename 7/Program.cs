using System;


internal class Program
{
    static void Main()
    {
        
        // Ścieżka do pliku
        string filePath = "sciezka/do/twojego/pliku.txt"; ;

        try
        {
            // Otwórz plik do odczytu
            string fileContent = ReadFileContent(filePath);
            Console.WriteLine("Zawartość pliku: " + fileContent);
        }
        catch (FileNotFoundException a)
        {
            Console.WriteLine($"Błąd: Nie znaleziono pliku - {a.Message}");
        }
        catch (IOException a)
        {
            Console.WriteLine($"Błąd wejścia/wyjścia: {a.Message}");
        }
        catch (Exception a)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {a.Message}");
        }
        finally
        {
            // Zawsze zamykaj plik w bloku finally
            Console.WriteLine("Zamykanie pliku...");
        }
    }

    static string ReadFileContent(string filePath)
    {
        // Sprawdź, czy plik istnieje
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Nie znaleziono pliku.", filePath);
        }

        // Odczytaj zawartość pliku
        return File.ReadAllText(filePath);
    }
}