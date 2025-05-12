using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Rectangle : MultiSidedShape
    {
        // Fields
        private double _length;
        private double _width;

        // Constructors
        public Rectangle(double length, double width, string shapeName, int sides)
            : base(shapeName, sides)
        {
            this._length = length;
            this._width = width;
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
        public override double Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public override double Perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }
        }
        public double Length
        {
            get { return _length; }
        }
        public double Width
        {
            get { return _width; }
        }
        //Methods
        protected override double CalculatePerimeter()
        {
            return Math.Round((this._length * 2) + (this._width * 2), 2);
        }
        protected override double CalculateArea()
        {
            return Math.Round(this._length * this._width, 2);
        }
        protected override List<double> SideLengths
        {
            get { return new List<double> {this._width, this._length}; }
        }
    }
}
