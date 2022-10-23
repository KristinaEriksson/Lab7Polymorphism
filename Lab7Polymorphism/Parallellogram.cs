using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    // Child class, derived from Geometri
    class Parallellogram : Geometri
    {
        // Field with properties
        double length { get; set; }

        // Constructor with default values
        public Parallellogram()
        {
            this.length = 4.5;
        }

        // Method that override the Area method in Geometri parent class
        // Calculate the area of a parallellogram and returns the value
        public override double Area()
        {
            double parallellogramArea = length * length;
            return parallellogramArea;
        }
    }
}
