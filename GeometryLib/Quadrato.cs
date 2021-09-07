using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Quadrato : IFiguraGeometrica
    {
        public double Lato { get; set; }
        public Quadrato(double lato)
        {
            Lato = lato;
        }

        public double GetArea()
        {
            return Lato * Lato;
        }
        public double GetPerimetro()
        {
            return Lato * 4;
        }
    }
}
