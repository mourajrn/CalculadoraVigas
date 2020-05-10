using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVigas.Modelos
{
    public class RespostaCisalhamento
    {
        public double AreaTransversal { get; private set; }
        public double Vc { get; private set; }
        public double VRd2 { get; private set; }

        public RespostaCisalhamento(double areaTransversal, double vc, double vRd2)
        {
            AreaTransversal = areaTransversal;
            Vc = vc;
            VRd2 = vRd2;
        }
    }
}
