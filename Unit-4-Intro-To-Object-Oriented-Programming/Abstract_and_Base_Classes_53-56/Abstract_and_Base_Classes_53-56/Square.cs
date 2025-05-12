using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Square : Shape
    {
        //Fields 
        private double _sideLength;
        // Constructors
        public Square(double sideLength, string shapeName, int sides) : base(shapeName, sides)
        {
            this._sideLength = sideLength;
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
        public override double Area {
            get { return _area; }
            set { _area = value;  }
        }
        public override double Perimeter {
            get { return _perimeter; }
            set { _perimeter = value; }
        }
        //Methods
        protected override double CalculatePerimeter()
        {
            return Math.Round(this._sideLength * 4, 2);
        }
         protected override double CalculateArea()
        {
            return Math.Round(_sideLength * _sideLength, 2);
        }
        public override string ToString()
        {
            return $"The {this.ShapeName} has side length of {this._sideLength}. The area is {this.Area} and the its perimeter is {this.Perimeter}.";
        }
    }
}
