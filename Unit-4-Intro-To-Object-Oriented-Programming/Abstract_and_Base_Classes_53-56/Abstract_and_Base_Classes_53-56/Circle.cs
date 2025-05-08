using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Circle : Shape
    {
        // Fields
        private double _Radius;

        // Constructors
        public Circle(double radius, string shapeName, int sides) : base(shapeName, sides)
        {
            this._Radius = radius;
            ShapeName = shapeName;
            SidesCount = sides;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        // Properties
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
        public double Radius {
            get { return _Radius; }
        }
        protected override double CalculateArea()
        {
            return Math.Round(Math.PI * (this._Radius * this._Radius), 2);
        }
        protected override double CalculatePerimeter()
        {
            return Math.Round(Math.PI * (2 * this._Radius), 2);
        }
    }
}
