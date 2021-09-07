using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib2
{
    public abstract class GeometryFigure
    {
        public abstract double GetArea();
        public abstract double GetPerimetro();
        public void PrintFigura()
        {
            Console.WriteLine("Area: {0} Perimetro: {1}", GetArea(), GetPerimetro());
        }
    }
}
