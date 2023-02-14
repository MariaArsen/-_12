using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_12
{
    static class Circle
    {
        static public double GetLine(double r)
        {
            return 2*Math.PI*r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI*r*r;
        }
        static public string GetKrug (double x, double y,double r)
        {
            if(r== Math.Sqrt(x * x + y * y))
            return "Точка принадлежит кругу";
            else
            return "Точка не принадлежит кругу";

        }
    }
}
