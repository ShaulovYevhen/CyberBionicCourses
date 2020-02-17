namespace FigureApp.Model
{
    public class Point
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _name;
        
        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }
        public int X
        {
            get { return _x; }
        }
        public int Y
        {
            get { return _y; }
        }
        public string Name
        {
            get { return _name; }
        }
    }
}