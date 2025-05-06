using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_42_46
{
    internal class Shape
    {
        // Fields
        private string _ShapeName;
        private int _SideCount;
        private double _Area;
        private double _Perimeter;

        // Constructors
        public Shape(string shapeName, int sides) { 
            this._ShapeName = shapeName;
            this._SideCount = sides;
        }

        // Properties
        protected string ShapeName
        {
            get { return this._ShapeName; }
            set { this._ShapeName = value; }
        }
        protected int SidesCount
        {
            get { return this._SideCount; }
            set { this._SideCount = value; }
        }
        public double Area
        {
            get { return this._Area; }
            set { this._Area= value; }
        }
        public double Perimeter
        {
            get { return this._Perimeter; }
            set { this._Perimeter = value; }
        }
    }
}
