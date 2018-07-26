using System;
using System.Collections.Generic;
using System.Linq;
using TesteProjecoes.Model;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes.Calc.Extensions
{
    public static class CenarioExtensions
    {
        public static Cenario GerarDerivado(this Cenario calcParams, DateTime dataInicial, DateTime dataFinal)
        {
            var posicoes = calcParams.Posicoes.Clone();
            foreach (var posicao in posicoes)
            {
                posicao.Marcos = posicao.Marcos.Where(p => p.Referencia.IsBetween(dataInicial, dataFinal)).ToList();
                posicao.Marcos.AddRange(GetMarcos(calcParams.DataFinal.AddMonths(1), dataFinal, posicao));
            }

            return new Cenario()
            {
                DataInicial = dataInicial,
                DataFinal = dataFinal,
                AplicarCores = calcParams.AplicarCores,
                Posicoes = posicoes,
                Origem = calcParams,
            };
        }

        public static void FillPositions(this Cenario calcParams)
        {
            calcParams.Posicoes = new List<PosicaoTL>();
            using (var context = new Context())
            {
                for (int i = 0; i < context.Posicao.Count; i++)
                {
                    var posicao = context.Posicao[i];
                    /*
                    var modelAsAttributes = posicao.GetModelAsAttributes();
                    var parameters = new CalculatorParams(modelAsAttributes, context.Regra);
                    var result = new Calculator(parameters).Calculate();
                    */
                    var p = new PosicaoTL()
                    {
                        Id = posicao.Id,
                        Nome = posicao.Nome,
                    };
                    if (posicao.IsPool)
                    {
                        p.QtdHoras = posicao.QtdHoras;
                        p.Marcos = calcParams.GetMarcos(p);
                    }
                    else
                    {
                        p.Funcionarios = new[] { new FuncionarioTL() { Id = context.Funcionario[i].Id, Nome = context.Funcionario[i].Nome, Nascimento = context.Funcionario[i].Nascimento, Sexo = context.Funcionario[i].Sexo, Salario = context.Funcionario[i].Salario, Cargo = context.Funcionario[i].Cargo, Admissao = context.Funcionario[i].Admissao, Rescisao = context.Funcionario[i].Rescisao } }.ToList();
                        p.FuncionarioUnico.Marcos = calcParams.GetMarcos(p);
                    }
                    calcParams.Posicoes.Add(p);
                }
            }
        }

        private static List<Marco> GetMarcos(this Cenario calcParams, PosicaoTL posicao)
        {
            return GetMarcos(calcParams.DataInicial, calcParams.DataFinal, posicao);
        }

        private static List<Marco> GetMarcos(DateTime dataInicial, DateTime dataFinal, PosicaoTL posicao)
        {
            var result = new List<Marco>();
            for (DateTime i = dataInicial; i <= dataFinal; i = i.AddMonths(1))
            {
                result.Add(new Marco(i, posicao));
            }
            return result;
        }
    }
}
