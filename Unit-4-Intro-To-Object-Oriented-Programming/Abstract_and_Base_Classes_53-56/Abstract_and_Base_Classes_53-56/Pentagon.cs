using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Pentagon : MultiSidedShape
    {
        // Fields
        private double _side1;
        private double _side2;
        private double _side3;
        private double _side4;
        private double _side5;

        // Constructors
        public Pentagon(double side1, double side2, double side3, double side4, double side5, string shapeName, int sideCount) : base(shapeName, sideCount)
        {
            this._side1 = side1;
            this._side2 = side2;
            this._side3 = side3;
            this._side4 = side4;
            this._side5 = side5; 
            ShapeName = shapeName;
            SidesCount = sideCount;
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        // Properties
        protected override string ShapeName
        {
            get { return base._shapeName; }
            set { base._shapeName = value; } 
        }
        protected override int SidesCount
        {
            set { base._sideCount = value; }
        }
        public override double Area
        {
            get { return this._area; }
            set { this._area = value; }
        }
        public override double Perimeter
        {
            get { return this._perimeter; }
            set { this._perimeter = value; }
        }
        protected override List<double> SideLengths
        {
            get
            {
                return new List<double> { this._side1, this._side2, this._side3, this._side4, this._side5 };
            }
        }
        // Methods
        protected override double CalculateArea()
        {
            double s_avg = (this._side1 + this._side2 + this._side3 + this._side4 + this._side5) / 5.0;
            double area = Math.Round(0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * s_avg * s_avg,2);
            return area;
        }
        protected override double CalculatePerimeter()
        {
            return Math.Round(this._side1 + this._side2 + this._side3 + this._side4 + this._side5,2);
        }
    }
}
