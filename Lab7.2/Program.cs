using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, v, p;
            x = Convert.ToDouble(Console.ReadLine());
            if (x >= 0)
            {
                Cube(x, out v, out p);
                Console.WriteLine("Площади поверхности куба - {0}, Объем куба - {1}", p, v);
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }
            Console.ReadKey();

        }
        //Метод расчет параметров куба
        static void Cube(double x, out double v, out double p)
        {
            p = x * x * 6;
            v = x * x * x;
        }
    }
}
