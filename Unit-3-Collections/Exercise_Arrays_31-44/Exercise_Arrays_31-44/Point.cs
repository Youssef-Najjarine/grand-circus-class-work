using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Arrays_31_44
{
    public class Point
    {
        private int xCordinate;
        private int yCordinate;
        private int[] xCordinates;
        private int[] yCordinates;
        public Point(int x, int y)
        {
            xCordinate = x;
            yCordinate = y;
        }
        public Point(int[] x, int[] y)
        {
            xCordinates = x;
            yCordinates = y;
        }
        public string DisplayCordinates()
        {
            return $"{xCordinate}, {yCordinate}";
        }
        public string DisplayGroupedXCordinates()
        {
            return $"{xCordinates[0]}, {xCordinates[1]}";
        }
        public string DisplayGroupedYCordinates()
        {
            return $"{yCordinates[0]}, {yCordinates[1]}";
        }
        public double CalculateDistance()
        {
            return Math.Round(Math.Sqrt(((double)xCordinate * xCordinate) + ((double)yCordinate * yCordinate)),2,MidpointRounding.AwayFromZero);
        }
        public string CalculateMidpoint()
        {
            double midX = Math.Round(((double)xCordinates[0] + yCordinates[0]) / 2,2,MidpointRounding.AwayFromZero);
            double midY = Math.Round(((double)xCordinates[1] + yCordinates[1]) / 2,2,MidpointRounding.AwayFromZero);
            return $"{midX},{midY}";
        }
    }
}
