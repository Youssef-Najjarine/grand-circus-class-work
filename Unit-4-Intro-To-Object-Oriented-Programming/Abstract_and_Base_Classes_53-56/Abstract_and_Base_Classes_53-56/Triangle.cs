using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
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
        protected override string ShapeName
        {
            get { return base._ShapeName; }
            set { _ShapeName = value; }
        }
        protected override int SidesCount
        {
            get { return _SideCount; }
            set { _SideCount = value; }
        }
        public override double Area
        {
            get { return _Area; }
            set { _Area = value; }
        }
        public override double Perimeter
        {
            get { return _Perimeter; }
            set { _Perimeter = value; }
        }

        // Methods
        protected override double CalculatePerimeter()
        {
            return Math.Round(Side1Length + Side2Length + Side3Length, 2);
        }
        protected override double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Round(Math.Sqrt(semiPerimeter * ((semiPerimeter - this._Side1Length) * (semiPerimeter - this._Side2Length) * (semiPerimeter - this._Side3Length))), 2);
        }
    }
}
