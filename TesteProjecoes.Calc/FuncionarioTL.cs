using System.Collections.Generic;
using TesteProjecoes.Model;

namespace TesteProjecoes.Calc
{
    public class FuncionarioTL : Funcionario, IMarcos
    {
        public List<Marco> Marcos { get; set; }

        public FuncionarioTL()
        {
            Marcos = new List<Marco>();
        }
    }
}
