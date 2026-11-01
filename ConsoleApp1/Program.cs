using System;
using System.IO;
using System.Text.Json;

namespace Program;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        string fileName = "hm.json";
        string jsonString = File.ReadAllText(fileName);

        List<Book>? books = JsonSerializer.Deserialize<List<Book>>(jsonString);

        if (books != null)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Книга: {book.Title}");
                Console.WriteLine($"ID видавництва: {book.PublishingHouseId}");
                Console.WriteLine($"Видавництво: {book.PublishingHouse?.Name} ({book.PublishingHouse?.Adress})");
            }
        }
    }

}
