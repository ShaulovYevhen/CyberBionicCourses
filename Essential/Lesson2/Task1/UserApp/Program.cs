using System;

namespace UserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("nana", "Annaa", "Ivanova", 20);
            Console.WriteLine(user.ToString());
            Console.WriteLine(user.Date);
            User user2 = new User("naya", "Ann", "Kolesnik", 20);
            Console.WriteLine(user2.ToString());
            Console.WriteLine(user2.Date);
            Console.ReadKey();
        }
    }
}
