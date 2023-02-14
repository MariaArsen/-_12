using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты х и у");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double square = Circle.GetSquare(r);
            double line = Circle.GetLine(r);
            string krug = Circle.GetKrug(x, y, r);
            Console.WriteLine($"Длина окружности -{line:F2} \nПлощадь круга -{square:F2} \n{krug}");
            Console.ReadKey();
        }
    }
}
