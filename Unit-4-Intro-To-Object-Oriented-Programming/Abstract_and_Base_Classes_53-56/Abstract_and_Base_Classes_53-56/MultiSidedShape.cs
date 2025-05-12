using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal abstract class MultiSidedShape : Shape
    {
        // Constructors
        protected MultiSidedShape(string shapeName, int sides) : base(shapeName, sides)
        {
            this.ShapeName = shapeName;
            this.SidesCount = sides;
        }
        // Properties
        protected abstract List<double> SideLengths { get; }

        // Methods
        public override string ToString()
        {
            string displayString = $"The {this.ShapeName} has side lengths ";
            for (int i = 0; i < SideLengths.Count;i++) {
                if ((i < SideLengths.Count - 1) && SideLengths.Count > 2)
                {
                    displayString += $"{SideLengths[i]}, ";
                } else if ((i < SideLengths.Count - 1))
                {
                    displayString += $"{SideLengths[i]} ";
                }
                else
                {
                    displayString += $"and {SideLengths[i]}. ";
                }
            }
            displayString += $"Its area is {this.Area} and its perimeter is {this.Perimeter}.";
            return displayString;
        }
    }
}
