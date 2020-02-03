using System;

namespace BookApp.Model
{
    public class Author
    {
        public Author(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Author: " + Value);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}