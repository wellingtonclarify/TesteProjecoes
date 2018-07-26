using System;
using System.Collections.Generic;
using TesteProjecoes.Calc;

namespace TesteProjecoes
{
    public class Cenario
    {
        public List<PosicaoTL> Posicoes { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public bool AplicarCores { get; set; }
        public enumTipoCenario? Tipo { get; set; }

        public Cenario Origem { get; set; }
    }

    public enum enumTipoCenario
    {
        Pessimista = 1,
        Realista = 2,
        Otimista = 3
    }
}