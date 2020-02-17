using System;
using BookApp.Model;

namespace BookApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Title");
            var title = new Title(Console.ReadLine());
            Console.WriteLine("Enter Author");
            var author = new Author(Console.ReadLine());
            Console.WriteLine("Enter Content");
            var content = new Content(Console.ReadLine());
            var book = new Book(title, author, content);
            book.ToString();
            Console.ReadKey();
        }
    }
}