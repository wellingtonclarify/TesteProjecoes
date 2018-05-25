using System.Data;
using System.Linq;
using TesteProjecoes.Model;

namespace TesteProjecoes.Calc
{
    public class Calculator
    {
        public CalculatorParams Parameters { get; private set; }

        public Calculator(CalculatorParams parameters)
        {
            Parameters = parameters;
        }

        public double Calculate()
        {
            ResultDictionary results = null;
            return Calculate(out results);
        }

        public double Calculate(out ResultDictionary results)
        {
            var dataTable = new DataTable();

            foreach (var atributo in Parameters.Atributos)
            {
                string attributeName = GetAttributeName(atributo.AtributoId);
                var type = atributo.Valor?.GetType() ?? typeof(object);
                dataTable.Columns.Add(attributeName, type);
            }

            foreach (var regra in Parameters.Regras)
            {
                dataTable.Columns.Add("Regra_" + regra.Id, typeof(bool), GetCriteriosAsFormula(regra));
                dataTable.Columns.Add("Formula_"+ regra.Id, typeof(double), regra.Formula);
            }

            var dataRow = dataTable.NewRow();
            foreach (var atributo in Parameters.Atributos)
            {
                string attributeName = GetAttributeName(atributo.AtributoId);
                dataRow[attributeName] = atributo.Valor;
            }
            dataTable.Rows.Add(dataRow);

            var partialResults = new ResultDictionary();
            double result = 0;
            foreach (var regra in Parameters.Regras)
            {
                var objResult = dataRow["Formula_" + regra.Id];
                double partialResult = 0;
                double.TryParse(objResult.ToString(), out partialResult);
                if (dataRow["Regra_" + regra.Id].Equals(true))
                {
                    result += partialResult;
                    partialResults.Add(dataTable.Columns["Formula_" + regra.Id].Expression, partialResult);
                }
            }
            results = partialResults;
            return result;
        }

        private string GetCriteriosAsFormula(Regra regra)
        {
            var result = string.Join(" And ", regra.Criterios.Select(c => "("+ c.Formula +")").ToList());
            return result;
        }

        private string GetAttributeName(int id)
        {
            switch (id)
            {
                case 1:
                    return "Id";
                case 2:
                    return "Nome";
                case 3:
                    return "Nascimento";
                case 4:
                    return "Sexo";
                case 5:
                    return "Salario";
                case 6:
                    return "Idade";
                case 7:
                    return "Admissao";
                case 8:
                    return "Rescisao";
                case 9:
                    return "QtdHoras";
                case 10:
                    return "IsPool";
                case 11:
                    return "Ativo";
                default:
                    return "";
            }
        }
    }
}
