using System;
using System.Collections.Generic;
using System.Linq;


namespace AreaCalculation
{
    public class Circle
    {
        public double radius;
        private float _piNumber = 3.14f;
        public float area;

        public Circle(double radius)
        {
            this.radius = radius;
            area = CalcArea();
        }
        public float CalcArea()
        {
            var result = Math.Pow(radius, 2) * _piNumber;
            return Convert.ToInt32(result);
        }
    }
}
