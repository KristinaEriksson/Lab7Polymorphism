using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    // Child class, derived from Geometri
    class Cirkel : Geometri
    {
        // Field with properties
        double radius { get; set; }
        
       // Constructor with default values
        public Cirkel()
        {
            this.radius = 7.9;
            
        }
        // Method that override the Area method in Geometri parent class
        // Calculate the area of circle and returns the value
        public override double Area()
        {
            double cirkelArea = Math.PI * radius * radius;
            return cirkelArea;
        }
    }
}