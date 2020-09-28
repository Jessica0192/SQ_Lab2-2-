using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Triangle
    {
        public double CalculateHypotenuse(double A, double B)
        {
            double hypo = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

            return hypo;
        }

        public double CalculateArea(double A, double B)
        {
            double area = 0.5 * A * B;
            return area;
        }

        public double CalculateMissingAngle(double firstAng, double secondAng)
        {
            int total = 180;
            double angle = total - firstAng - secondAng;

            return angle;
        }
    }
}
