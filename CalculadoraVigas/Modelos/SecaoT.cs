using System;

namespace CalculadoraVigas.Modelos
{
    public class SecaoT : Secao
    {
        public double LarguraColaborante { get; private set; }
        public double EspessuraMesa { get; private set; }

        public override double Area => LarguraColaborante * EspessuraMesa + Largura * (Altura - EspessuraMesa);

        public SecaoT(
            double largura, double altura, double dLinha, double dLinhaSuperior,
            double larguraColaborante, double espessuraMesa)
            : base(largura, altura, dLinha, dLinhaSuperior)
        {
            LarguraColaborante = larguraColaborante >= Largura ? larguraColaborante :
                throw new ArgumentException("A largura colaborante deve ser maior que a largura da nervura.");

            EspessuraMesa = espessuraMesa <= Altura ? espessuraMesa :
                throw new ArgumentException("A espessura da mesa deve ser superior a altura da seção.");
        }

        public override double LinhaNeutra(double momentoMajorado, double fck)
        {
            double hipoteseInicial = AlturaComprimidaPor(LarguraColaborante, momentoMajorado, fck);
            if (0.8 * hipoteseInicial <= EspessuraMesa)
                return hipoteseInicial;

            double momentoAbas = 0.85 * (fck) / (1.4) * EspessuraMesa * (LarguraColaborante - Largura) * (AlturaUtil - (EspessuraMesa * 0.5));
            double momentoNervura = momentoMajorado - momentoAbas;

            return AlturaComprimidaPor(Largura, momentoNervura, fck);
        }

        public override RespostaFlexaoAs CalculaAreaAco(double momentoMajorado, double fck, double fyk)
        {
            if (fck <= 0)
                throw new ArgumentException("A resistência característica do concreto deve ser superior a 0 MPa.");

            double linhaNeutra = LinhaNeutra(momentoMajorado, fck);

            double momentoAbas = 0.85 * (fck) / (1.4) * EspessuraMesa * (LarguraColaborante - Largura) * (AlturaUtil - (EspessuraMesa * 0.5));
            double momentoRestante = momentoMajorado - momentoAbas;
            double escoamentoCalculo = (fyk / 1.15);
            double areaAcoAbas = 0;
            double areaAcoRestante = 0;

            if (linhaNeutra <= 0.45 * AlturaUtil)
            {
                if (linhaNeutra <= EspessuraMesa)
                {
                    return new RespostaFlexaoAs(momentoMajorado / (BracoAlavanca(AlturaUtil, linhaNeutra) * escoamentoCalculo), 0, linhaNeutra);
                }
                else
                {
                    areaAcoAbas = momentoAbas / ((AlturaUtil - (EspessuraMesa / 2)) * escoamentoCalculo);
                    areaAcoRestante = momentoRestante / (BracoAlavanca(AlturaUtil, linhaNeutra) * escoamentoCalculo);

                    return new RespostaFlexaoAs(areaAcoAbas + areaAcoRestante, 0, linhaNeutra);
                }
            }

            linhaNeutra = 0.45 * AlturaUtil;

            double momentoNervura = MomentoResistente(AlturaUtil, linhaNeutra, fck, Largura);
            momentoRestante = momentoMajorado - momentoAbas - momentoNervura;

            areaAcoAbas = momentoAbas / ((AlturaUtil - (EspessuraMesa / 2)) * escoamentoCalculo);
            double areaAcoNervura = momentoNervura / (BracoAlavanca(AlturaUtil, linhaNeutra) * escoamentoCalculo);

            double areaAdicionalInferior = momentoRestante / ((AlturaUtil - DLinhaSuperior) * escoamentoCalculo);

            double deformacao = (0.0035 * (linhaNeutra - DLinhaSuperior)) / linhaNeutra;
            double tensao = Math.Min(21000 * deformacao, escoamentoCalculo);
            double areaAcoComprimida = (areaAdicionalInferior * escoamentoCalculo) / tensao;

            return new RespostaFlexaoAs(areaAcoAbas + areaAcoNervura + areaAdicionalInferior, areaAcoComprimida, linhaNeutra);
        }
    }
}

