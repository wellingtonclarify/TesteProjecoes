using System.Collections.Generic;
using System.Linq;

namespace TesteProjecoes.Model.Extensions
{
    public static class BaseModelWithAttrExtensions
    {
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
