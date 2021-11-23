using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сравнение площадей треугольников
            Console.WriteLine("Введите длину сторон первого треугольника");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double s1 = TriangleS(x, y, z);

            Console.WriteLine("Введите длину сторон второго треугольника");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            double s2 = TriangleS(x, y, z);

            if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника");
            }
            else
            {
                if (s1 < s2)
                {
                    Console.WriteLine("Площадь второго треугольника больше площади первого треугольника");
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны");
                }
            }
            Console.ReadKey();
        }

        static double TriangleS(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }



    }
}
