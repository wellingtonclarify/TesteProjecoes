using System.Collections.Generic;
using TesteProjecoes.Model;

namespace TesteProjecoes.Calc
{
    public class CalculatorParams
    {
        public IList<TabelaAtributo> Atributos { get; private set; }
        public IList<Regra> Regras { get; private set; }

        public CalculatorParams(IList<TabelaAtributo> atributos, IList<Regra> regras)
        {
            Atributos = atributos;
            Regras = regras;
        }
    }
}
