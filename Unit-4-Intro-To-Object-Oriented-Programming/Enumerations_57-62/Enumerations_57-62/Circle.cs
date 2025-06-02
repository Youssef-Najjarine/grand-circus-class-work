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
        new string ShapeName { get; set; }
        public int SidesCount { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        new  double Radius { get { return _radius; } }
        new double CalculateArea()
        {
            return Math.Round(Math.PI * (this._radius * this._radius), 2);
        }
        new double CalculatePerimeter()
        {
            return Math.Round(Math.PI * (2 * this._radius), 2);
        }
    }
}
