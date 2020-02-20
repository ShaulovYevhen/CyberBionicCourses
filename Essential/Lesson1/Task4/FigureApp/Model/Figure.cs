using System;

namespace FigureApp.Model
{

    public class Figure
    {
        private readonly Point _point1;
        private readonly Point _point2;
        private readonly Point _point3;
        private readonly Point _point4;
        private readonly Point _point5;
        private readonly string _type;

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.Y - a.Y), 2) + Math.Pow((b.X - a.X), 2));
        }
        public Figure(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _type = "triangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
            _type = "square";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
            _point5 = point5;
            _type = "pentagon";
        }
        public string Type
        {
            get { return _type; }
        }
    }
}