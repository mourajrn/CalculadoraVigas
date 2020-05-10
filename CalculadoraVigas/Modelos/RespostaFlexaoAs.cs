using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVigas.Modelos
{
    public class RespostaFlexaoAs
    {
        public double ArmacaoTracionada { get; private set; }
        public double ArmacaoComprimida { get; private set; }
        public double LinhaNeutra { get; private set; }

        public RespostaFlexaoAs(double armacaoTracionada, double armacaoComprimida, double linhaNeutra)
        {
            ArmacaoTracionada = armacaoTracionada;
            ArmacaoComprimida = armacaoComprimida;
            LinhaNeutra = linhaNeutra;
        }
    }
}
