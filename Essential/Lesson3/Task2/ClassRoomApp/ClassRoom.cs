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
    }
}