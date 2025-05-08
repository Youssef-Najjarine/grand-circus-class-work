using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Pentagon : Shape
    {
        // Fields
        private double _Side1;
        private double _Side2;
        private double _Side3;
        private double _Side4;
        private double _Side5;
        private double _Area;
        private double _Perimeter;

        // Constructors
        public Pentagon(double side1, double side2, double side3, double side4, double side5, string shapeName, int sideCount) : base(shapeName, sideCount)
        {
            this._Side1 = side1;
            this._Side2 = side2;
            this._Side3 = side3;
            this._Side4 = side4;
            this._Side5 = side5; 
            ShapeName = shapeName;
            SidesCount = sideCount;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        // Properties
        protected override string ShapeName
        {
            set { base._ShapeName = value; } 
        }
        protected override int SidesCount
        {
            set { base._SideCount = value; }
        }
        public override double Area
        {
            get { return this._Area; }
            set { this._Area = value; }
        }
        public overide double Perimeter
        {
            get { return this._Perimeter; }
            set { this._Perimeter = value; }
        }
        {

        }
    }
}
