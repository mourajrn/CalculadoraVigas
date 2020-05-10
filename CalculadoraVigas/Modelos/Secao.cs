using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraVigas.Modelos
{
    public abstract class Secao
    {
        public double Largura { get; private set; }
        public double Altura { get; private set; }
        public double DLinhaInferior { get; private set; }
        public double DLinhaSuperior { get; private set; }

        public double AlturaUtil => Altura - DLinhaInferior;
        public abstract double Area { get; }

        /// <summary>
        /// Instancia uma seção
        /// </summary>
        /// <param name="largura">Largura da nervura em cm.</param>
        /// <param name="altura">Altura da viga em cm.</param>
        /// <param name="dLinhaInferior">Distância da armadura tracionada para borda tracionada.</param>
        /// <param name="dLinhaSuperior">Distância da armadura comprimida para borda comprimida.</param>
        protected Secao(double largura, double altura, double dLinhaInferior, double dLinhaSuperior)
        {
            Largura = largura > 0 ? largura : throw new ArgumentException("A largura da viga deve ser um número superior a zero.");
            Altura = altura > 0 ? altura : throw new ArgumentException("A altura da viga deve ser um número superior a zero.");
            DLinhaInferior = dLinhaInferior;
            DLinhaSuperior = dLinhaSuperior;
        }

        /// <summary>
        /// Retorna a posição da linha neutra de uma região retangular em cm dada largura, momento solicitante e resistência característica do concreto.
        /// </summary>
        /// <param name="largura">Largura da seção em cm.</param>
        /// <param name="momentoMajorado">O momento majorado em kN.cm.</param>
        /// <param name="fck">Resistência característica em kN/cm².</param>
        /// <returns></returns>
        protected double AlturaComprimidaPor(double largura, double momentoMajorado, double fck)
        {
            var raizes = new List<double>
            {
                (0.68 * AlturaUtil +
                Math.Sqrt(Math.Pow(0.68 * AlturaUtil, 2) - 4 * 0.272 * ((momentoMajorado) / (largura * (fck) / (1.4))))) / (0.544),
                (0.68 * AlturaUtil -
                Math.Sqrt(Math.Pow(0.68 * AlturaUtil, 2) - 4 * 0.272 * ((momentoMajorado) / (largura * (fck) / (1.4))))) / (0.544)
            };

            var solucoes = (from raiz in raizes
                            where raiz >= 0 && raiz <= Altura
                            select raiz).ToList();

            if (solucoes.Count.Equals(0))
                return Altura;

            return solucoes.First();
        }

        public abstract double LinhaNeutra(double momentoMajorado, double fck);

        /// <summary>
        /// Retorna a força de compressão no concreto em kN dada a resistência característica, largura comprimida e altura comprimida.
        /// </summary>
        /// <param name="fck">Resistência característica em kN/cm².</param>
        /// <param name="larguraComprimida">Largura comprimida em cm.</param>
        /// <param name="alturaComprimida">Altura comprimida em cm.</param>
        /// <returns></returns>
        public double ForcaConcreto(double fck, double larguraComprimida, double alturaComprimida) =>
            0.85 * (fck / 1.4) * larguraComprimida * alturaComprimida;

        /// <summary>
        /// Retorna o momento resistente em kN.cm de dada a altura útil, a altura da linha neutra, a resistência característica e a largura da seção.
        /// </summary>
        /// <param name="alturaUtil">Altura útil em cm.</param>
        /// <param name="linhaNeutra">Profundidade da linha neutra em cm.</param>
        /// <param name="fck">Resistência característica do concreto em kN/cm².</param>
        /// <param name="largura">Largura da seção em cm.</param>
        /// <returns></returns>
        public double MomentoResistente(double alturaUtil, double linhaNeutra, double fck, double largura) =>
            BracoAlavanca(alturaUtil, linhaNeutra) * ForcaConcreto(fck, largura, 0.8 * linhaNeutra);

        /// <summary>
        /// Retorna o braço de alavanca da seção em cm dada a altura útil e a linha neutra.
        /// </summary>
        /// <param name="alturaUtil">Altura útil em cm.</param>
        /// <param name="linhaNeutra">Profundidade da linha neutra em cm.</param>
        /// <returns></returns>
        protected double BracoAlavanca(double alturaUtil, double linhaNeutra) =>
            alturaUtil - 0.4 * linhaNeutra;

        /// <summary>
        /// Calcula a área de aço.
        /// </summary>
        /// <param name="momentoMajorado">Momento majorado em kN.cm.</param>
        /// <param name="fck">Resistência característica do concreto em kN/cm².</param>
        /// <param name="fyk">Tensão de escoamento característica do aço em kN/cm².</param>
        /// <returns></returns>
        public abstract RespostaFlexaoAs CalculaAreaAco(double momentoMajorado, double fck, double fyk);
    }
}
