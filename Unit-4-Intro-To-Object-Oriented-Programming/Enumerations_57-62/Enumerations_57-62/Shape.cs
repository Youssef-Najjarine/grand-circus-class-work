using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal interface Shape
    {
        // Fields
        //protected string _shapeName;
        //protected int _sideCount;
        //protected double _area;
        //protected double _perimeter;

        //// Constructors
        //protected Shape(string shapeName, int sides)
        //{
        //    this._shapeName = shapeName;
        //    this._sideCount = sides;
        //}

        // Properties
        protected string ShapeName { get; set; }
        protected int SidesCount { set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        // Methods
        protected double CalculateArea();
        protected double CalculatePerimeter();
    }
}
