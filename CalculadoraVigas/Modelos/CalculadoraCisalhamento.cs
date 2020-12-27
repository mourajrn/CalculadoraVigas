using static CalculadoraVigas.Modelos.Matematica;
using System;

namespace CalculadoraVigas.Modelos
{
    public abstract class CalculadoraCisalhamento
    {
        public abstract RespostaCisalhamento Calcula(Secao secao, double cortante, double fck, double fyk, double inclinacaoBiela, double inclinacaoEstribo);
    }

    public class CalculadoraModeloI : CalculadoraCisalhamento
    {
        public override RespostaCisalhamento Calcula(Secao secao, double cortante, double fck, double fyk, double inclinacaoBiela, double inclinacaoEstribo)
        {
            double fckMPa = fck * 10.0;
            double alfav = (1 - fckMPa / 250);

            double fyd = Math.Min(fyk / 1.15, 50 / 1.15);

            double vc = 0.09 * Math.Pow(fckMPa, 2.0 / 3.0) * secao.Largura * secao.AlturaUtil / 10.0;
            double vrd2 = 0.27 * alfav * (fck / 1.4) * secao.Largura * secao.AlturaUtil;
            double asw =
                (111 * (cortante - vc)) / (secao.AlturaUtil * (Cotan(inclinacaoBiela) + Cotan(inclinacaoEstribo))
                * fyd * Math.Sin(inclinacaoEstribo));

            return new RespostaCisalhamento(asw, vc, vrd2);
        }
    }

    public class CalculadoraModeloII : CalculadoraCisalhamento
    {
        public override RespostaCisalhamento Calcula(Secao secao, double cortante, double fck, double fyk, double inclinacaoBiela, double inclinacaoEstribo)
        {
            double fckMPa = fck * 10.0;
            double alfav = (1 - fckMPa / 250);

            double vrd2 =
                0.54 * alfav * (fck / 1.4) * (Cotan(inclinacaoBiela) + Cotan(inclinacaoEstribo))
                * Math.Pow(Math.Sin(inclinacaoBiela), 2) * secao.Largura * secao.AlturaUtil;

            double vc0 = 0.09 * Math.Pow(fckMPa, 2.0 / 3.0) * secao.Largura * secao.AlturaUtil / 10.0;

            double vc;

            if (cortante <= vc0)
                vc = vc0;
            else if (cortante < vrd2)
                vc = vc0 - ((cortante - vc0) / (vrd2 - vc0)) * vc0;
            else
                vc = 0;

            double asw =
                (111 * (cortante - vc)) / (secao.AlturaUtil * ((1 / Math.Tan(inclinacaoBiela)) + (1 / Math.Tan(inclinacaoEstribo))) * (fyk / 1.15) * Math.Sin(inclinacaoEstribo));

            return new RespostaCisalhamento(asw, vc, vrd2);
        }
    }
}
