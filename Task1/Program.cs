using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Х координату точки");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y координату точки");
            double y = Convert.ToDouble(Console.ReadLine());
            double square = Rectangle.GetSquare(r);
            double perimeter = Rectangle.GetPerimeter(r);
            double point = Rectangle.GetPoint(r, x, y);
            Console.WriteLine($"Площадь круга = {square} \nПериметр круга = {perimeter} \nРасстояние от точки до центра окружности = {point}");
            if (point > r)
            {
                Console.WriteLine("Точка не лежит в окружности");
            }
            else
            {
                Console.WriteLine("Точка лежит в окружности");
            }
            Console.ReadLine();
        }
    }
}
