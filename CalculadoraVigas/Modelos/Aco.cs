namespace CalculadoraVigas.Modelos
{
    public class Aco
    {
        public double ResistenciaCaracteristica { get; private set; }

        /// <summary>
        /// Cria uma instância do material do aço
        /// </summary>
        /// <param name="resistenciaCaracteristica">Resistência característica do aço em kN/cm².</param>
        public Aco(double resistenciaCaracteristica)
        {
            ResistenciaCaracteristica = resistenciaCaracteristica;
        }

        public override string ToString()
        {
            return $"CA{ResistenciaCaracteristica}";
        }
    }
}
