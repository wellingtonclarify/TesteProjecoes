using System;
using System.Collections.Generic;
using TesteProjecoes.Calc;

namespace TesteProjecoes
{
    public class CalcParams
    {
        public List<PosicaoTL> Posicoes { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public bool AplicarCores { get; internal set; }

        public CalcParams Origem { get; set; }
    }
}