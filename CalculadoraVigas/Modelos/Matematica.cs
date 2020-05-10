using System;

namespace CalculadoraVigas.Modelos
{
    public static class Matematica
    {
        public static double Cotan(double angulo) => (1 / Math.Tan(angulo));

        public static double ConverteRadiano(double anguloGrau) => (anguloGrau * Math.PI) / 180.0;
    }
}
