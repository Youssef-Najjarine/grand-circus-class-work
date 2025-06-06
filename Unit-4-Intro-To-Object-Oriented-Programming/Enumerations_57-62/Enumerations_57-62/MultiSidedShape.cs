﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal abstract class MultiSidedShape : Shape
    {
        // Constructors
        protected MultiSidedShape(string shapeName, int sides)
        {
            this.ShapeName = shapeName;
            this.SidesCount = sides;
        }
        // Properties
        public string ShapeName { get; set; }
        public int SidesCount { get; set; }
        protected double Radius { get; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        protected abstract List<double> SideLengths { get; }

        // Methods
        public double CalculateArea()
        {
            return Math.Round(Math.PI * (this.Radius * this.Radius), 2);
        }
        public double CalculatePerimeter()
        {
            return Math.Round(Math.PI * (2 * this.Radius), 2);
        }
        public override string ToString()
        {
            string displayString = $"The {this.ShapeName} has side lengths ";
            for (int i = 0; i < SideLengths.Count; i++)
            {
                if ((i < SideLengths.Count - 1) && SideLengths.Count > 2)
                {
                    displayString += $"{SideLengths[i]}, ";
                }
                else if ((i < SideLengths.Count - 1))
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
