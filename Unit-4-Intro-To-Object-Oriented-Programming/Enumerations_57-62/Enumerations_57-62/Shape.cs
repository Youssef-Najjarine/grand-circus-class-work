using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal interface Shape
    {
        // Properties
        string ShapeName { get; set; }
        int SidesCount { set; }
        double Area { get; set; }
        double Perimeter { get; set; }

        // Methods
        double CalculateArea();
        double CalculatePerimeter();
    }
}
