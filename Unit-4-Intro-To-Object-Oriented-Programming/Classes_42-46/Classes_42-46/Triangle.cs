using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Classes_42_46
{
    internal class Triangle : Shape
    {
        // Fields
        private double _Side1Length;
        private double _Side2Length;
        private double _Side3Length;

        //Constructors
        public Triangle(double side1Length, double side2Length, double side3Length, string shapeName, int sides) 
            : base(shapeName, sides)
        {
            this._Side1Length = side1Length;
            this._Side2Length = side2Length;
            this._Side3Length = side3Length;
            base.ShapeName = shapeName;
            base.SidesCount = sides;
            base.Area = CalculateArea();
            base.Perimeter = CalculatePerimeter();
        }

        // Properties
        public double Side1Length
        {
            get { return this._Side1Length; }
        }
        public double Side2Length
        {
            get { return this._Side2Length; }
        }
        public double Side3Length
        {
            get { return this._Side3Length; }
        }

        // Methods
        private double CalculatePerimeter()
        {
            return Math.Round(Side1Length + Side2Length + Side3Length,2);
        }
        private double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Round(Math.Sqrt(semiPerimeter * ((semiPerimeter - this._Side1Length) * (semiPerimeter - this._Side2Length) * (semiPerimeter - this._Side3Length))),2);
        }
    }
}
