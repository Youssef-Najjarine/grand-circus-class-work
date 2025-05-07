using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Rectangle : Shape
    {
        // Fields
        private double _Length;
        private double _Width;

        // Constructors
        public Rectangle(double length, double width, string shapeName, int sides)
            : base(shapeName, sides)
        {
            this._Length = length;
            this._Width = width;
            ShapeName = shapeName;
            SidesCount = sides;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }
        // Properties
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
        public override double Area
        {
            get { return _Area; }
            set { _Area = value; }
        }
        public override double Perimeter
        {
            get { return _Perimeter; }
            set { _Perimeter = value; }
        }
        public double Length
        {
            get { return _Length; }
        }
        public double Width
        {
            get { return _Width; }
        }
        //Methods
        protected override double CalculatePerimeter()
        {
            return Math.Round((this._Length * 2) + (this._Width * 2), 2);
        }
        protected override double CalculateArea()
        {
            return Math.Round(this._Length * this._Width, 2);
        }
    }
}
