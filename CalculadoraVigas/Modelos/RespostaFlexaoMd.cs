namespace CalculadoraVigas.Modelos
{
    public class RespostaFlexaoMd
    {
        public double MomentoSolicitante { get; private set; }
        public double AreaComprimida { get; private set; }
        public double LinhaNeutra { get; private set; }

        public RespostaFlexaoMd(double momentoSolicitante, double areaComprimida, double linhaNeutra)
        {
            MomentoSolicitante = momentoSolicitante;
            AreaComprimida = areaComprimida;
            LinhaNeutra = linhaNeutra;
        }
    }
}
