using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal class Square : Shape
    {
        //Fields 
        private double _sideLength;
        // Constructors
        public Square(double sideLength, string shapeName, int sides)
        {
            this._sideLength = sideLength;
            ShapeName = shapeName;
            SidesCount = sides;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }
        // Properties
        public string ShapeName { get; set; }
        public int SidesCount { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        //Methods
        public double CalculatePerimeter()
        {
            return Math.Round(this._sideLength * 4, 2);
        }
        public double CalculateArea()
        {
            return Math.Round(_sideLength * _sideLength, 2);
        }
        public override string ToString()
        {
            return $"The {this.ShapeName} has side length of {this._sideLength}. The area is {this.Area} and the its perimeter is {this.Perimeter}.";
        }
    }
}
