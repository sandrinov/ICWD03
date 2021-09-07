using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib2
{
    public class Triangle : GeometryFigure
    {
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double L3 { get; set; }

        public Triangle(double l1, double l2, double l3)
        {
            L1 = l1;
            L2 = l2;
            L3 = l3;
        }
        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimetro()
        {
            return L1 + L2 + L3;
        }
    }
}
