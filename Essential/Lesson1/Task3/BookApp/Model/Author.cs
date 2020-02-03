using System;

namespace BookApp.Model
{
    public class Author
    {
        public Author(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public void Show()
        {
            Console.WriteLine(Value);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
