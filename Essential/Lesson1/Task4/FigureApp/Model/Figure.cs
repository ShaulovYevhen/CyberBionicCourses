namespace FigureApp.Model
{

    public class Figure
    {
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly Point _point3;
        private readonly Point _point4;
        private readonly Point _point5;
        public string Type { get; }

        public Figure(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
            _point5 = point5;
        }
    }
}