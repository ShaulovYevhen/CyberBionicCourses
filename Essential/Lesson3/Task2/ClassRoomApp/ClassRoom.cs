using System;

namespace ClassRoomApp
{
    public class ClassRoom
    {
        private readonly Pupil[] _pupils = new Pupil[4];
        public ClassRoom()
        {
            _pupils[0] = RandomPupil();
            _pupils[1] = RandomPupil();
            _pupils[2] = RandomPupil();
            _pupils[3] = RandomPupil();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            _pupils[0] = pupil1;
            _pupils[1] = pupil2;
            _pupils[2] = pupil3;
            _pupils[3] = pupil4;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            _pupils[0] = pupil1;
            _pupils[1] = pupil2;
            _pupils[2] = RandomPupil();
            _pupils[3] = RandomPupil();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            _pupils[0] = pupil1;
            _pupils[1] = pupil2;
            _pupils[2] = pupil3;
            _pupils[3] = RandomPupil();
        }

        private Pupil RandomPupil()
        {
            var rand = new Random();
            var pupilRandomNumber = rand.Next(1, 3);
            switch (pupilRandomNumber)
            {
                case 1:
                    return new BadPupil();
                case 2:
                    return new GoodPupil();
                default:
                    return new ExcellentPupil();
            }
        }

        public string ClassRoomStudy()
        {
            var result = "";
            foreach (var p in _pupils)
            {
                result += "Study = " + p.Study() + "\n";
            }
            return result;
        }

        public string ClassRoomRead()
        {
            var result = "";
            foreach (var p in _pupils)
            {
                result += "Read = " + p.Read() + "\n";
            }
            return result;
        }

        public string ClassRoomWrite()
        {
            var result = "";
            foreach (var p in _pupils)
            {
                result += "Write = " + p.Write() + "\n";
            }
            return result;
        }

        public string ClassRoomRelax()
        {
            var result = "";
            foreach (var p in _pupils)
            {
                result += "Relax = " + p.Relax() + "\n";
            }
            return result;
        }
    }
}