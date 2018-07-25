using System.Collections.Generic;
using System.Linq;
using TesteProjecoes.Model;

namespace TesteProjecoes.Calc
{
    public class PosicaoTL : Posicao, IMarcos
    {
        public List<FuncionarioTL> Funcionarios { get; set; }
        public List<Marco> Marcos { get; set; }

        public FuncionarioTL FuncionarioUnico => (Funcionarios != null && Funcionarios.Count == 1 ? Funcionarios.First() : null);

        public PosicaoTL()
        {
            Marcos = new List<Marco>();
            Funcionarios = new List<FuncionarioTL>();
        }
    }
}
