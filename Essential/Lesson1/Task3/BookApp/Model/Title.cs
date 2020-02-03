using System;

namespace BookApp.Model
{
    public class Title
    {
        public Title(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Title: " + Value);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}