using System;

namespace GeometricShapesWithInterfaces
{
    public class Program
    {
        static void Main(string[] args) 
        {
            var shapes = new IShape[]
            {
                new Quadrilateral {},
            new Rectangle { },
            new Square { },
            };

            foreach(var shape in shapes)
            {
                if(shape == null)
                {

                }
            }

        }
    }
}
