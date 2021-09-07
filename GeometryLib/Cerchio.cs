using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Cerchio : IFiguraGeometrica
    {
        public double Raggio { get; set; }

        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }
        public double GetArea()
        {
            return (Raggio * Raggio * Math.PI);
        }
        public double GetPerimetro()
        {
            return (2 * Raggio * Math.PI);
        }
    }
}
