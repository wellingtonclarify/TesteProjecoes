using System;
using System.Collections.Generic;
using System.Linq;
using TesteProjecoes.Calc;
using TesteProjecoes.Model;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes.Extensions
{
    public static class CalcParamsExtensions
    {
        public static Cenario GerarDerivado(this Cenario calcParams, DateTime dataInicial, DateTime dataFinal)
        {
            var posicoes = calcParams.Posicoes.Clone();
            foreach (var posicao in posicoes)
            {
                posicao.Marcos = posicao.Marcos.Where(p => p.Referencia.IsBetween(dataInicial, dataFinal)).ToList();
                posicao.Marcos.AddRange(GetMarcos(calcParams.DataFinal.AddMonths(1), dataFinal));
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
                        p.Marcos = calcParams.GetMarcos();
                    }
                    else
                    {
                        p.Funcionarios = new[] { new FuncionarioTL() { Id = context.Funcionario[i].Id, Nome = context.Funcionario[i].Nome, Nascimento = context.Funcionario[i].Nascimento, Sexo = context.Funcionario[i].Sexo, Salario = context.Funcionario[i].Salario, Cargo = context.Funcionario[i].Cargo, Admissao = context.Funcionario[i].Admissao, Rescisao = context.Funcionario[i].Rescisao } }.ToList();
                        p.FuncionarioUnico.Marcos = calcParams.GetMarcos();
                    }
                    calcParams.Posicoes.Add(p);
                }
            }
        }

        private static List<Marco> GetMarcos(this Cenario calcParams)
        {
            return GetMarcos(calcParams.DataInicial, calcParams.DataFinal);
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
