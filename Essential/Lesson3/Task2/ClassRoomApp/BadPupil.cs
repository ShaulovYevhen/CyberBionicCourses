namespace ClassRoomApp
{
    public class BadPupil : Pupil
    {
        public override string Study()
        {
            return "Bad pupil Study";
        }

        public override string Read()
        {
            return "Bad pupil Read";
        }

        public override string Write()
        {
            return "Bad pupil Write";
        }

        public override string Relax()
        {
            return "Bad pupil Relax";
        }
    }
}