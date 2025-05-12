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
        protected string _shapeName;
        protected int _sideCount;
        protected double _area;
        protected double _perimeter;

        // Constructors
        protected Shape(string shapeName, int sides)
        {
            this._shapeName = shapeName;
            this._sideCount = sides;
        }

        // Properties
        protected abstract string ShapeName { get;  set; }
        protected abstract int SidesCount { set; }
        public abstract double Area { get; set; }
        public abstract double Perimeter { get; set; }

        // Methods
        protected abstract double CalculateArea();
        protected abstract double CalculatePerimeter();
    }
}
