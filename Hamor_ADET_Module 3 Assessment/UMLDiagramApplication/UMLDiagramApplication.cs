using System;

/** Application of the UML 
Class Diagram Representation!
This program represents the given
UML class diagram in the problem.

@author: Mary Grizelle Hamor
@section: BSCS 3-1N
@date: January 11, 2023
*/

namespace Hamor_ADET_Module_3_Assessment.UMLDiagramApplication
{

    public class Shape
    {
        protected Location c;

        public Shape(Location c)
        {
            this.c = c;
        }

        public string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.00;
        }

        public double Perimeter()
        {
            return 0.00;
        }
    }

    public class Location
    {
        private double x, y;

        public void setX(double x)
        {
            this.x = x;
        }
        public double getX()
        { 
            return this.x; 
        }
        
        public void setY(double y)
        {
            this.y = y;
        }
        public double getY()
        {
            return this.y;
        }

        public Location(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

    }

    public class Rectangle : Shape
    {
        protected double side1, side2;

        public Rectangle(double side1, double side2, Location c) : base(c)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.c = c;
        }

        public new string ToString()
        {
            return "Rectangle:\nside1: " + side1 
                + "\nside2: " + side2 
                + "\nlocation: (" + c.getX() 
                + "," + c.getY() + ")";
        }

        public new double Area()
        {
            return side1 * side2;
        }

        public new double Perimeter()
        {
            return (side1 * 2) + (side2 * 2);
        }
    }

    public class Circle : Shape
    {
        protected double radius;

        public Circle(double radius, Location c) : base(c)
        {
            this.radius = radius;
            this.c = c;
        }

        public new string ToString()
        {
            return "Circle:\nradius: " + radius
                + "\nlocation: (" + c.getX()
                + "," + c.getY() + ")";
        }

        public new double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public new double Perimeter()
        {
            return Math.PI * radius * 2;
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            double x, y, side1, side2, radius;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\t\tModule 3\n\tProblem: Apply UML Diagram \n\tRepresentation in a C# Program");
            Console.WriteLine("------------------------------------------");

            // INPUT
            // Coordinates
            Console.Write("\nEnter value of x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter value of y: ");
            y = int.Parse(Console.ReadLine());

            Location c = new Location(x, y);

            // Rectangle
            Console.Write("\nEnter value of side1: ");
            side1 = int.Parse(Console.ReadLine());
            Console.Write("Enter value of side2: ");
            side2 = int.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2, c);

            // Coordinates
            Console.Write("\nEnter value of radius: ");
            radius = int.Parse(Console.ReadLine());

            Circle circle = new Circle(radius, c);

            // OUTPUT
            Console.WriteLine("------------------------------------------");
          
            Console.WriteLine("\n" + rectangle.ToString());
            Console.WriteLine("area: " + rectangle.Area());
            Console.WriteLine("perimeter: " + rectangle.Perimeter());

            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("\n" + circle.ToString());
            Console.WriteLine("area: " + circle.Area());
            Console.WriteLine("perimeter: " + circle.Perimeter());

            Console.WriteLine("\n---------- Calculation Finished ----------");
        }
    }

}
