using System;

namespace Lab7Polymorphism
{
    class Program
    {
        // Kristina Eriksson .NET 22
        static void Main(string[] args)
        {
            // Objects, output a value from Area method from every derived class
            Rektangel rektangel = new Rektangel();
            Console.WriteLine("Area Rektangel: " + rektangel.Area());

            Fyrkant fyrkant = new Fyrkant();
            Console.WriteLine("Area Fyrkant: " + fyrkant.Area());

            Cirkel cirkel = new Cirkel();
            Console.WriteLine("Area Cirkel: " + cirkel.Area());

            Parallellogram parallellogram = new Parallellogram();
            Console.WriteLine("Area Prallellogram: " + parallellogram.Area());

            Ellips ellips = new Ellips();
            Console.WriteLine("Area Ellips: " + ellips.Area());
        }
    }
}
