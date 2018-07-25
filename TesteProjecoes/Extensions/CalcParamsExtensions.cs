using System;
using System.Collections.Generic;
using System.Linq;
using TesteProjecoes.Calc;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes.Extensions
{
    public static class CalcParamsExtensions
    {
        public static CalcParams GerarDerivado(this CalcParams calcParams, DateTime dataInicial, DateTime dataFinal)
        {
            var posicoes = calcParams.Posicoes.Clone();
            foreach (var posicao in posicoes)
            {
                posicao.Marcos = posicao.Marcos.Where(p => p.Referencia.IsBetween(dataInicial, dataFinal)).ToList();
                posicao.Marcos.AddRange(GetMarcos(calcParams.DataFinal.AddMonths(1), dataFinal));
            }

            return new CalcParams()
            {
                DataInicial = dataInicial,
                DataFinal = dataFinal,
                AplicarCores = calcParams.AplicarCores,
                Posicoes = posicoes,
                Origem = calcParams,
            };
        }
        
        private static List<Marco> GetMarcos(DateTime dataInicial, DateTime dataFinal)
        {
            var result = new List<Marco>();
            for (DateTime i = dataInicial; i <= dataFinal; i = i.AddMonths(1))
            {
                result.Add(new Marco(i));
            }
            return result;
        }
    }
}
