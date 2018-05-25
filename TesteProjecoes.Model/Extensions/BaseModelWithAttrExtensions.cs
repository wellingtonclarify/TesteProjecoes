using System.Collections.Generic;
using System.Linq;

namespace TesteProjecoes.Model.Extensions
{
    public static class BaseModelWithAttrExtensions
    {
        /*
        public static IList<TabelaAtributo> GetModelAsAttributes<T>(this T model) where T : BaseModelWithAttr
        {
            var result = new List<TabelaAtributo>();

            var properties = model.GetType().GetProperties();
            foreach (var property in properties)
            {
                var atributo = new TabelaAtributo()
                {
                    RegistroId = model.Id,
                    AtributoId = GetAttributeId(property.Name),
                    Valor = property.GetValue(model)
                };
                if (atributo.AtributoId == 0)
                    continue;
                result.Add(atributo);
            }

            return result;
        }
        */

        public static IList<TabelaAtributo> GetModelAsAttributes(this Posicao model)
        {
            var result = new List<TabelaAtributo>();
            result.Add(new TabelaAtributo(model.Id, 1, model.Id));
            result.Add(new TabelaAtributo(model.Id, 2, model.Nome));
            result.Add(new TabelaAtributo(model.Id, 9, model.QtdHoras));
            result.Add(new TabelaAtributo(model.Id, 10, model.IsPool));
            return result;
        }

        public static IList<TabelaAtributo> GetModelAsAttributes(this Funcionario model)
        {
            var result = new List<TabelaAtributo>();
            result.Add(new TabelaAtributo(model.Id, 1, model.Id));
            result.Add(new TabelaAtributo(model.Id, 2, model.Nome));
            result.Add(new TabelaAtributo(model.Id, 3, model.Nascimento));
            result.Add(new TabelaAtributo(model.Id, 4, model.Sexo));
            result.Add(new TabelaAtributo(model.Id, 5, model.Salario));
            result.Add(new TabelaAtributo(model.Id, 6, model.Idade));
            result.Add(new TabelaAtributo(model.Id, 7, model.Admissao));
            result.Add(new TabelaAtributo(model.Id, 8, model.Rescisao));
            result.Add(new TabelaAtributo(model.Id, 11, model.Ativo));
            result.Add(new TabelaAtributo(model.Id, 12, model.Cargo.SalarioBase));
            return result;
        }

        private static int GetAttributeId(string name)
        {
            switch (name)
            {
                case "Id":
                    return 1;
                case "Nome":
                    return 2;
                case "Nascimento":
                    return 3;
                case "Sexo":
                    return 4;
                case "Salario":
                    return 5;
                case "Idade":
                    return 6;
                case "Admissao":
                    return 7;
                case "Rescisao":
                    return 8;
                case "QtdHoras":
                    return 9;
                case "IsPool":
                    return 10;
                case "Ativo":
                    return 11;
                default:
                    return 0;
            }
        }
    }
}
