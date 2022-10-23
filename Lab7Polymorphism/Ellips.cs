using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    // Child class, derived from Geometri
    class Ellips : Geometri
    {
        // Field with properties
        double radius_a { get; set; }
        double radius_b { get; set; }

        // Constructor with default values
        public Ellips()
        {
            this.radius_a = 5.6;
            this.radius_b = 6.4;
        }
        // Method that override the Area method in Geometri parent class
        // Calculate the area of a ellipse and returns the value
        public override double Area()
        {
            double EllipsArea = radius_a * radius_b * Math.PI;
            return EllipsArea;
        }
    }
}
