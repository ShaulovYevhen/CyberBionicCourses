using System;

namespace EmploeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var emploee = new Emploee("Ivan", "Petriv")
            {
                Post = "manager",
                Experience = 2
            };
            Console.WriteLine(emploee.ToString());
            Console.ReadKey();
        }
    }
}