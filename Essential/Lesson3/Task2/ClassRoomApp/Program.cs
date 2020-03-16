using System;

namespace ClassRoomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new BadPupil();
            var p2 = new ExcellentPupil();
            var firstClass = new ClassRoom(p1, p2);
            Console.WriteLine(firstClass.ClassRoomStudy());
            Console.WriteLine(firstClass.ClassRoomRead());
            Console.WriteLine(firstClass.ClassRoomWrite());
            Console.WriteLine(firstClass.ClassRoomRelax());
            Console.ReadKey();
        }
    }
}
