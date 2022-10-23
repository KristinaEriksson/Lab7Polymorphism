using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    // Child class, derived from Geomtri
    class Rektangel : Geometri
    {
        // Field with properties
        double baseSide { get; set; }
        double heightSide { get; set; }

        // Constructor with default values
        public Rektangel()
        {
            this.baseSide = 12.2;
            this.heightSide = 8.0;
        }
        // Method that override the Area method in Geometri parent class
        // Calculate the area of a rectangle and returns the value
        public override double Area()
        {
            double rektangelArea = heightSide * baseSide;
            return rektangelArea;
        }
    }
    
}
