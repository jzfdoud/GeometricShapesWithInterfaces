using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesWithInterfaces
{
    public class Rectangle : IShape
    {
        public int Side1 {get; set;}
        public int Side2 {get; set;}

        //public int Perimeter { get; set; }

        //public void Area()
        //{
        //}
        public void Perimeter()
        {
            Console.WriteLine($"Perimeter is {Side1+Side2+Side1+Side2}");
        }


        public Rectangle() { }
    }
}
