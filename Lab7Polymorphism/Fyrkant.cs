using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    // Child class, derived from Geometri 
    class Fyrkant : Geometri
    {
        // Field with properties
        double side { get; set; } 

        // Constructor with default values
        public Fyrkant()
        {
            this.side = 8.8;
        }

        // Method override the Area method in Geometri parent class
        // Calculate the area of a square and returns the value
        public override double Area()
        {
            double squareArea = side * side;
            return squareArea;
            
        }
    }
}
