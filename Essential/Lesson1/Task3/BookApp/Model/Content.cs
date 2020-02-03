using System;

namespace BookApp.Model
{
    public class Content
    {
        public Content(string value)
        {
            Value = value;
        }
        public string Value { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(Value);
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
