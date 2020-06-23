using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesWithInterfaces
{
    public class Quadrilateral : IShape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }
        //public int Perimeter { get; set; }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter is {Side1+Side2+Side3}");
        }






    }
}
