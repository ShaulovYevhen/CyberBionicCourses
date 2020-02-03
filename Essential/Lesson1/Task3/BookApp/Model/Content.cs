using System;

namespace BookApp.Model
{
    public class Content
    {
        public Content(string value)
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
