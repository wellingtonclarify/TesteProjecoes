using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteProjecoes.Model;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes.Calc.Extensions
{
    public static class PosicaoTLExtensions
    {
        public static int ObtemQtdOcorrenciasEventoNaLinhaTempo(this PosicaoTL posicao, DateTime referencia, enumTipoEvento tipo)
        {
            return (posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos)
                //.Where(m => m.Referencia != referencia)
                .SelectMany(m => m.Eventos)
                .Count(x => x.Tipo == tipo);
        }

        public static bool ExisteEventoNaLinhaTempo(this PosicaoTL posicao, DateTime referencia, enumTipoEvento tipo)
        {
            return (posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos)
                //.Where(m => m.Referencia != referencia)
                .SelectMany(m => m.Eventos)
                .Any(x => x.Tipo == tipo);
        }

        public static bool ExisteEventoNoPassado(this PosicaoTL posicao, DateTime referencia, enumTipoEvento tipo)
        {
            return (posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos)
                .Where(m => m.Referencia < referencia)
                .SelectMany(m => m.Eventos)
                .Any(x => x.Tipo == tipo);
        }

        public static int ObtemQtdOcorrenciasEventoNoPassado(this PosicaoTL posicao, DateTime referencia, enumTipoEvento tipo)
        {
            return (posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos)
                .Where(m => m.Referencia < referencia)
                .SelectMany(m => m.Eventos)
                .Count(x => x.Tipo == tipo);
        }
        
        public static Marco GetMarco(this PosicaoTL posicao, DateTime referencia)
        {
            var marcos = posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos;
            return marcos.Single(m => m.Referencia == referencia);
        }

        public static IList<TabelaAtributo> TrataSubstituicoes(this PosicaoTL posicao, DateTime referencia, object baseObject, IList<TabelaAtributo> modelAsAttributes)
        {
            var eventos = posicao.GetMarco(referencia).Eventos.Clone();

            //Trata eventos permanentes
            if (posicao.ExisteEventoNoPassado(referencia, enumTipoEvento.Admissao))
                eventos.Add(enumTipoEvento.Admissao);
            if (posicao.ExisteEventoNoPassado(referencia, enumTipoEvento.Demissao))
                eventos.Add(enumTipoEvento.Demissao);

            var qtd = posicao.ObtemQtdOcorrenciasEventoNoPassado(referencia, enumTipoEvento.SubirCargo);
            for (int i = 1; i <= qtd; i++)
                eventos.Add(enumTipoEvento.SubirCargo);
            //

            if (eventos == null || eventos.Count() == 0)
                return modelAsAttributes;

            object localBaseObject = baseObject;
            foreach (var evento in eventos)
            {
                switch (evento.Tipo)
                {
                    case enumTipoEvento.Admissao:
                        modelAsAttributes.Single(a => a.AtributoId == 7).Valor = referencia;
                        break;
                    case enumTipoEvento.Demissao:
                        modelAsAttributes.Single(a => a.AtributoId == 8).Valor = referencia;
                        break;
                    case enumTipoEvento.SubirCargo:
                        var func = (Funcionario)localBaseObject;
                        func = func.Clone();
                        func.Cargo = func.Cargo.ObterCargoSuperior();
                        localBaseObject = func;
                        modelAsAttributes.Single(a => a.AtributoId == 12).Valor = func.Cargo.SalarioBase;
                        break;
                    case enumTipoEvento.AlteraQtdPool:
                        modelAsAttributes.Single(a => a.AtributoId == 9).Valor = 320;
                        break;
                    default:
                        break;
                }
            }

            return modelAsAttributes;
        }

        public static double Calcular(this PosicaoTL posicao, DateTime referencia)
        {
            return posicao.Calcular(referencia, out ResultDictionary results);
        }

        public static double Calcular(this PosicaoTL posicao, DateTime referencia, out ResultDictionary results)
        {
            IList<TabelaAtributo> modelAsAttributes = null;
            IList<Regra> regras = null;
            object baseObject = null;
            using (var context = new Context())
            {
                if (posicao.IsPool)
                {
                    modelAsAttributes = posicao.GetModelAsAttributes();
                    baseObject = posicao;
                    regras = context.Regra.Where(r => r.Id == 5).ToList();
                }
                else
                {
                    modelAsAttributes = posicao.FuncionarioUnico.GetModelAsAttributes();
                    baseObject = posicao.FuncionarioUnico;
                    regras = context.Regra.Where(r => r.Id < 5).ToList();
                }
            }

            var finalModel = posicao.TrataSubstituicoes(referencia, baseObject, modelAsAttributes);
            var parameters = new CalculatorParams(finalModel, regras);
            var result = new Calculator(parameters).Calculate(out results);
            return result;
        }

    }
}
