using System;

namespace FigureApp.Model
{

    public class Figure
    {
        private readonly Point[] _point;
        private readonly string _type;

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.Y - a.Y), 2) + Math.Pow((b.X - a.X), 2));
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            for (var i = 0; i < _point.Length - 1; i++)
            {
                sum += LengthSide(_point[i], _point[i + 1]);
            }
            sum += LengthSide(_point[_point.Length - 1], _point[0]);
            return Math.Round(sum, 2);
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            _point = new Point[3];
            _point[0] = point1;
            _point[1] = point2;
            _point[2] = point3;
            _type = "triangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _point = new Point[4];
            _point[0] = point1;
            _point[1] = point2;
            _point[2] = point3;
            _point[3] = point4;
            _type = "square";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _point = new Point[5];
            _point[0] = point1;
            _point[1] = point2;
            _point[2] = point3;
            _point[3] = point4;
            _point[4] = point5;
            _type = "pentagon";
        }
        public string Type
        {
            get { return _type; }
        }
    }
}