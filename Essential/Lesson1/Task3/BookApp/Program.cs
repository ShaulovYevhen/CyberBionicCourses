using System;
using BookApp.Model;

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = new Title("adasdas");
            var author = new Author("Petrow");
            var content = new Content("text");
            var book = new Book(title, author, content);
            title.Show();
            author.Show();
            content.Show();
            Console.WriteLine(book.ToString());
            Console.ReadKey();
        }
    }
}