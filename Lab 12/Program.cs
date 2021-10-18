using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение R - ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Длина окружности равна {Circle.Lcircle(R):F}");
            Console.WriteLine($"Площадь круга равна {Circle.Sqcircle(R):F}");
            Console.Write("Введите значение X - ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение Y - ");
            int y = Convert.ToInt32(Console.ReadLine());
            double h = Circle.Affiliation(x, y);
            if (h > R)
            {
                Console.WriteLine("Точка не принадлежит кругу");
            }
            else
            {
               Console.WriteLine("Точка принадлежит окружности");
            } 
            Console.ReadKey();
        }
    }
    static class Circle
    {
        public static double Lcircle(int radius)
        {
            return Math.PI * 2 * radius;
        }
        public static double Sqcircle(int radius)
        {
            return Math.PI * radius * radius;
        }
        public static double Affiliation(int X, int Y)
        {
             return Math.Sqrt((X * X) + (Y * Y));
        }
    }
}
