using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal class Circle : EllipsesShape
    {
        // Fields
        private double _radius;

        // Constructors
        public Circle(double radius, string shapeName, int sides) : base(shapeName, sides)
        {
            this._radius = radius;
            ShapeName = shapeName;
            SidesCount = sides;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        // Properties
        protected override string ShapeName
        {
            get { return _shapeName; }
            set { _shapeName = value; }
        }
        protected override int SidesCount
        {
            set { _sideCount = value; }
        }
        public override double Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public override double Perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }
        }
        protected override double Radius
        {
            get { return _radius; }
        }
        protected override double CalculateArea()
        {
            return Math.Round(Math.PI * (this._radius * this._radius), 2);
        }
        protected override double CalculatePerimeter()
        {
            return Math.Round(Math.PI * (2 * this._radius), 2);
        }
    }
}
