using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Square : Shape
    {
        // Fields

        private double _SideLength;
        // Constructors

        public Square(double sideLength, string shapeName, int sides) : base(shapeName, sides)
        {
            this._SideLength = sideLength;
            ShapeName = shapeName;
            SidesCount = sides;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }
        // Properties
        public double SideLength
        {
            get { return this._SideLength; }
        }
        protected override string ShapeName
        {
            get { return base._ShapeName; }
            set { _ShapeName = value; }
        }
        protected override int SidesCount
        {
            get { return _SideCount; }
            set { _SideCount = value; }
        }
        public override double Area {
            get { return _Area; }
            set { _Area = value;  }
        }
        public override double Perimeter {
            get { return _Perimeter; }
            set { _Perimeter = value; }
        }
        //Methods
        protected override double CalculatePerimeter()
        {
            return Math.Round(this._SideLength * 4, 2);
        }
         protected override double CalculateArea()
        {
            return Math.Round(_SideLength * _SideLength, 2);
        }
    }
}
