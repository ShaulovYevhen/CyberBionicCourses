﻿namespace RectangleClassApp
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        public double AreaCalculator()
        {
            return _side1 * _side2;
        }

        public double Area
        {
            get { return this.AreaCalculator(); }
        }

        public double PerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }

        public double Perimeter
        {
            get { return this.PerimeterCalculator(); }
        }
    }
}