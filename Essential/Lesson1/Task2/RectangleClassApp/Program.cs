using System;
using static System.Console;
namespace RectangleClassApp
{
    public class Program
    {
        public static double Input()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error!Enter number");
            }
            return number;
        }
        public static void Main(string[] args)
        {
            WriteLine("Введите превую сторону прямоугольника");
            var side1 = Input();
            WriteLine("Введите вторую сторону прямоугольника");
            var side2 = Input();
            Rectangle rectangle = new Rectangle(side1, side2);
            WriteLine("Perimeter = {0}, Area= {1}", rectangle.Perimeter, rectangle.Area);
            ReadKey(); 
        }
    }
}