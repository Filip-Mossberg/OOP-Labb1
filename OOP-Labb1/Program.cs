using System;

namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"The Circle Area For {circle.Radie} Is {circle.getArea()}\n");

            Circle circle2 = new Circle(6);
            Console.WriteLine($"The Circle Area For {circle2.Radie} Is {circle2.getArea()}");

            Console.ReadKey();
        }
    }

    internal class Circle
    {
        public float Pi = 3.141f;
        public double Radie;

        public Circle(double radie)
        {
            this.Radie = radie;
        }

        public double getArea()
        {
            return (Radie * Radie * Pi);
        }
    }
}
