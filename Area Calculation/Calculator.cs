using System;
using System.Collections.Generic;


namespace AreaCalculation
{
    public static class Calculator
    {
        public static void Run()
        {
            ShowAreaOfFigure(GetParams());
        }
        public static List<float> GetParams()
        {
            List<float> figureParams = new List<float>();
            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine("Введите длинну элемента вашей фигуры.\n" +
                    "Напомним, что для круга нужно ввести одно значение - радиус, " +
                    "\nдля треугольника три значения - длины сторон.\n");
                Console.Write("Введите число: ");

                try
                {                    
                    float i = Convert.ToSingle(Console.ReadLine());
                    figureParams.Add(i);
                    Console.WriteLine("\n\nПродолжаем вводить данные, или уже приступим к расчёту?" +
                        "\nВведите 'Calc' - что бы начать расчет" +
                        "\nНажмите Enter что бы продолжить вводить данные");

                    if (Console.ReadLine().ToLower() == "calc")
                    {
                        isActive = false;
                    }
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число. Данные не были добавлены.");
                    Console.ReadKey();
                    Console.Clear();

                    continue;
                }


            }
            return figureParams;
        }

        public static void ShowAreaOfFigure(List<float> figureParams)
        {
            switch (figureParams.Count)
            {
                case 1:
                    Circle newCircle = new Circle(figureParams[0]);
                    Console.WriteLine($"Площадь круга - {newCircle.area}");
                    break;
                case 3:
                    Triangle newTriangle = new Triangle(figureParams[0], figureParams[1], figureParams[2]);
                    Console.WriteLine($"Площадь треугольника - {newTriangle.area}");
                    break;
                case 4:
                    Console.WriteLine("Новые фигуры будут добалены в следующем патче");
                    break;
                default:
                    Console.WriteLine("Уточните параметры");
                    break;
            }
        }
    }
}
