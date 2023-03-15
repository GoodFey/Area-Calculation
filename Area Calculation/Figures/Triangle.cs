using System;
using System.Collections.Generic;
using System.Linq;


namespace AreaCalculation
{    
    public class Triangle
    {
        public List<float> sides = new List<float>();
        public float area;

        public Triangle(float a, float b, float c)
        {
            sides.Add(a);
            sides.Add(b);
            sides.Add(c);
            if (CheckExistTriangle(a, b, c))
                area = CalcArea();
            else
                Console.WriteLine("Треугольник с такими сторонами не может существовать.");
        }

        public float CalcArea()
        {
            var halfPerimeter = (sides[0] + sides[1] + sides[2]) / 2;
            var result = Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) *
                (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));

            return Convert.ToInt32(result);

        }
        public bool CheckExistTriangle(float a, float b, float c)
        {
            if (a + b >= c)
                if (a + c >= b)
                    if (b + c >= a)
                        return true;
                    else
                        return false;
                else
                    return false;
            else
                return false;
        }
        public void CheckRectangular(List<float> sides)
        {
            var maxSide = sides.Max();
            sides.Remove(maxSide);
            var otherSide = sides[0];
            var otherSide2 = sides[1];

            var sumPowOtherSides = Math.Pow(otherSide, 2) + Math.Pow(otherSide2, 2);

            if (Math.Pow(maxSide, 2) == sumPowOtherSides)
                Console.WriteLine("Поздравляю, ваш треугольник - прямоугольный!");

        }
    }


}
