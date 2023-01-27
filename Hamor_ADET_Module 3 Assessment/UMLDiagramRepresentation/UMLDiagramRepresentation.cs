using System;

/** UML Class Diagram Representation!
This program represents the given
UML class diagram in the problem.

@author: Mary Grizelle Hamor
@section: BSCS 3-1N
@date: January 11, 2023
*/

namespace Hamor_ADET_Module_3_Assessment.UMLDiagramRepresentation
{
    public class Shape
    {
        protected Location c;

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
    }

    public class Rectangle : Shape
    {
        protected double side1, side2;
    }

    public class Circle : Shape
    {
        protected double radius;
    }

}