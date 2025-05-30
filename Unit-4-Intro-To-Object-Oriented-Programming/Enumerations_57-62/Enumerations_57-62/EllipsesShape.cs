using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal abstract class EllipsesShape : Shape
    {
        // constructors
        protected EllipsesShape(string shapeName, int sides) : base(shapeName, sides)
        {
            this.ShapeName = shapeName;
            this.SidesCount = sides;
        }
        // Properties
        protected abstract double Radius { get; }


        // Methods
        public override string ToString()
        {
            return $"The {ShapeName} has a radius of {Radius}. The area is {Area} and the perimeter is {Perimeter}.";

        }
    }
}
