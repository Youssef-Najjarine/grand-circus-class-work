using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal class EllipsesShape : Shape
    {
        // constructors
        protected EllipsesShape(string shapeName, int sides)
        {
            this.ShapeName = shapeName;
            this.SidesCount = sides;
        }
        // Properties
        public string ShapeName { get; set; }
        public int SidesCount { get; set; }
        double Radius { get; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        internal double CalculateArea()
        {
            return Math.Round(Math.PI * (this.Radius * this.Radius), 2);
        }
        internal double CalculatePerimeter()
        {
            return Math.Round(Math.PI * (2 * this.Radius), 2);
        }
        // Methods
        public override string ToString()
        {
            return $"The {ShapeName} has a radius of {Radius}. The area is {Area} and the perimeter is {Perimeter}.";

        }

        double Shape.CalculateArea()
        {
            return CalculateArea();
        }

        double Shape.CalculatePerimeter()
        {
            return CalculatePerimeter();
        }
    }
}
