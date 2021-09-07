using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib2
{
    public class Square : GeometryFigure
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
        public override double GetArea()
        {
            return Side * Side; 
        }

        public override double GetPerimetro()
        {
            return Side * 4;
        }
    }
}
