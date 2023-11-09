using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T8_5
{
    internal class Program
    {
        public static double Length(double x, double y)
        {
            return Math.Pow(x - y, 2);
        }

        public static void P(double length_1, double length_2, double length_3)
        {
            if (length_1 < length_2 + length_3 && length_2 < length_1 + length_3 && length_3 < length_1 + length_2)
            {
                double Per = length_1 + length_2 + length_3;
                WriteLine($"\nПериметр треугольника ABC: {Per:f2}");
            }
            else { WriteLine("\nТреугольник не существует"); };
        }

        public static void S(double length_1, double length_2, double length_3)
        {
            double p = (length_1 + length_2 + length_3) / 2;
            double S = Math.Sqrt(p * (p - length_1) * (p - length_2) * (p - length_3));
            WriteLine($"\nПлощадь треугольника ABC: {S:f2}");
        }
        
        static void Main(string[] args)
        {
            try
            {
                Write("Введите координаты вершины A: \nx = ");
                double x1 = Convert.ToDouble(ReadLine());
                Write("y = ");
                double y1 = Convert.ToDouble(ReadLine());
                Write("\nВведите координаты вершины B: \nx = ");
                double x2 = Convert.ToDouble(ReadLine());
                Write("y = ");
                double y2 = Convert.ToDouble(ReadLine());
                Write("\nВведите координаты вершины C: \nx = ");
                double x3 = Convert.ToDouble(ReadLine());
                Write("y = ");
                double y3 = Convert.ToDouble(ReadLine());

                double length_1 = Math.Sqrt(Length(x2, x1) + Length(y2, y1));
                double length_2 = Math.Sqrt(Length(x3, x2) + Length(y3, y2));
                double length_3 = Math.Sqrt(Length(x3, x1) + Length(y3, y1));

                WriteLine($"\nСторона AB: {length_1:f2}\nСторона BC: {length_2:f2}\nСторона AC: {length_3:f2}");

                P(length_1, length_2, length_3);

                S(length_1, length_2, length_3);

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
