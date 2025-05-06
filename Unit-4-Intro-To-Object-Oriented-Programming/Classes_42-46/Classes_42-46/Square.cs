using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_42_46
{
    internal class Square : Shape
    {
        // Fields

        private double _SideLength;
        // Constructors

        public Square(double sideLength, string shapeName, int sides) :base (shapeName,sides)
        {
            this._SideLength = sideLength;
            base.ShapeName = shapeName;
            base.SidesCount = sides;
            base.Area = CalculateArea();
            base.Perimeter = CalculatePerimeter();
        }
        // Properties
        public double SideLength {
            get { return this._SideLength; }
        }
        //Methods
        private double CalculatePerimeter()
        {
            return Math.Round(this._SideLength * 4,2);
        }
        private double CalculateArea()
        {
            return Math.Round(_SideLength * _SideLength, 2);
        }
    }
}
