using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal class Triangle : MultiSidedShape
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
            ShapeName = shapeName;
            SidesCount = sides;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
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
        public string ShapeName { get; set; }
        public int SidesCount { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        // Methods
        new double CalculatePerimeter()
        {
            return Math.Round(Side1Length + Side2Length + Side3Length, 2);
        }
        new double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Round(Math.Sqrt(semiPerimeter * ((semiPerimeter - this._Side1Length) * (semiPerimeter - this._Side2Length) * (semiPerimeter - this._Side3Length))), 2);
        }
        protected override List<double> SideLengths
        {
            get
            {
                return new List<double> { this._Side1Length, this._Side2Length, this._Side3Length };
            }
        }
    }
}
