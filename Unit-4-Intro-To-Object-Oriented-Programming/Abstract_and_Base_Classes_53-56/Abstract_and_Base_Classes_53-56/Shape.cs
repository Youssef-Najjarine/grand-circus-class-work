using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
     internal abstract class Shape
    {
        // Fields
        protected string _ShapeName;
        protected int _SideCount;
        protected double _Area;
        protected double _Perimeter;

        // Constructors
        protected Shape(string shapeName, int sides)
        {
            this._ShapeName = shapeName;
            this._SideCount = sides;
        }

        // Properties
        protected abstract string ShapeName { get; set; }
        protected abstract int SidesCount { get; set; }
        public abstract double Area { get; set; }
        public abstract double Perimeter { get; set; }

        protected abstract double CalculateArea();
        protected abstract double CalculatePerimeter();
    }
}
