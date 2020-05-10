using System;

namespace CalculadoraVigas.Modelos
{
    public class SecaoRetangular : Secao
    {
        public override double Area => Largura * Altura;

        public SecaoRetangular(double largura, double altura, double dLinhaInferior, double dLinhaSuperior)
            : base(largura, altura, dLinhaInferior, dLinhaSuperior)
        {
        }

        public override double LinhaNeutra(double momentoMajorado, double fck) => AlturaComprimidaPor(Largura, momentoMajorado, fck);

        public override RespostaFlexaoAs CalculaAreaAco(double momentoMajorado, double fck, double fyk)
        {
            if (fck <= 0)
                throw new ArgumentException("A resistência característica do concreto deve ser superior a 0 MPa.");

            double linhaNeutra = LinhaNeutra(momentoMajorado, fck);

            double escoamentoCalculo = fyk / 1.15;

            if (linhaNeutra <= 0.45 * AlturaUtil)
                return new RespostaFlexaoAs(momentoMajorado / (BracoAlavanca(AlturaUtil, linhaNeutra) * escoamentoCalculo), 0, linhaNeutra);

            linhaNeutra = 0.45 * AlturaUtil;

            double momentoNervura = MomentoResistente(AlturaUtil, linhaNeutra, fck, Largura);
            double momentoRestante = momentoMajorado - momentoNervura;

            double areaAcoNervura = momentoNervura / (BracoAlavanca(AlturaUtil, linhaNeutra) * escoamentoCalculo);
            double areaAdicionalInferior = momentoRestante / ((AlturaUtil - DLinhaSuperior) * escoamentoCalculo);

            double deformacao = (0.0035 * (linhaNeutra - DLinhaSuperior)) / linhaNeutra;
            double tensao = Math.Min(21000 * deformacao, escoamentoCalculo);
            double areaAcoComprimida = (areaAdicionalInferior * escoamentoCalculo) / tensao;

            return new RespostaFlexaoAs(areaAcoNervura + areaAdicionalInferior, areaAcoComprimida, linhaNeutra);
        }

        public RespostaFlexaoMd MomentoResistente(double areaAco, double fck, double fyk)
        {
            double fyd = (fyk / 1.15);
            double fcd = fck > 0 ? (fck / 1.4) : throw new ArgumentException("A resistência característica do concreto deve ser superior a 0 MPa.");

            double linhaNeutra = (areaAco * fyd) / (0.68 * Largura * fcd);
            if (linhaNeutra <= 0.45 * AlturaUtil)
                return new RespostaFlexaoMd(areaAco * fyd * BracoAlavanca(AlturaUtil, linhaNeutra), 0, linhaNeutra);

            linhaNeutra = 0.45 * AlturaUtil;
            double areaAco1 = 0.306 * Largura * AlturaUtil * fcd / fyd;
            double areaAco2 = areaAco - areaAco1;
            double momento1 = fyd * areaAco1 * (AlturaUtil - 0.4 * linhaNeutra);
            double momento2 = fyd * areaAco2 * (AlturaUtil - DLinhaSuperior);
            double momentoResistente = momento1 + momento2;

            double deformacao = (0.0035 * (linhaNeutra - DLinhaSuperior)) / linhaNeutra;
            double tensao = Math.Min(21000 * deformacao, fyd);
            double areaAcoComprimida = momento2 / ((AlturaUtil - DLinhaSuperior) * tensao);

            return new RespostaFlexaoMd(momentoResistente, areaAcoComprimida, linhaNeutra);
        }
    }
}
