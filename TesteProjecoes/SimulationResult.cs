using TesteProjecoes.Model;

namespace TesteProjecoes
{
    public class SimulationResult
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Salario { get; set; }
        public double Valor { get; set; }

        public SimulationResult(double valor)
        {
            Valor = valor;
        }
    }
}
