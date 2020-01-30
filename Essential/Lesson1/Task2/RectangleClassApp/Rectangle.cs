using System;

namespace RectangleClassApp
{
    public class Rectangle
    {
        readonly double _side1;
        readonly double _side2;

        public Rectangle(double side1, double side2) 
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        public double AreaCalculator()
        {
            return _side1*_side2;
        }

        public double Area
        {
            get { return this.AreaCalculator(); }
        }

        double PerimeterCalculator() 
        {
            return (_side1 + _side2) * 2;
        }

        public double Perimeter
        {
            get{ return this.PerimeterCalculator(); }
        }
    }
}
