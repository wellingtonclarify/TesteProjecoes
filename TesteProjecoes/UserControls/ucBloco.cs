using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteProjecoes.Model;
using TesteProjecoes.Calc;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes.UserControls
{
    public partial class ucBloco : UserControl
    {
        #region Events
        public EventHandler OnAddBloco { get; set; }
        public bool SimulacaoAutomatica { get; set; }
        #endregion

        public ucBloco()
        {
            InitializeComponent();
            ucSubstituicao1.OnAddSubstituicao = OnAddSubstituicao;
        }

        private void OnAddSubstituicao(object sender, EventArgs e)
        {
            var substituicao = new ucSubstituicao();
            substituicao.Location = new Point(3, this.xSplitContainer1.Panel1.Controls.Count * 30);
            substituicao.OnAddSubstituicao = OnAddSubstituicao;
            this.xSplitContainer1.Panel1.Controls.Add(substituicao);
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Simular();
        }

        private void Simular()
        {
            var dictionary = new List<SimulationResult>();
            using (var context = new Context())
            {
                foreach (var funcionario in context.Funcionario)
                {
                    var modelAsAttributes = funcionario.GetModelAsAttributes();
                    var finalModel = TrataSubstituicoes(modelAsAttributes);
                    var parameters = new CalculatorParams(finalModel, context.Regra.Where(r => r.Id < 3).ToList());
                    var result = new Calculator(parameters).Calculate();
                    var simulationResult = new SimulationResult(result)
                    {
                        Nome = finalModel.Single(m => m.AtributoId == 2).Valor.ToString(),
                        Idade = int.Parse(finalModel.Single(m => m.AtributoId == 6).Valor.ToString()),
                        Salario = decimal.Parse(finalModel.Single(m => m.AtributoId == 5).Valor.ToString())
                    };
                    dictionary.Add(simulationResult);
                }
            }
            xDataGridView1.DataSource = dictionary;
        }

        private IList<TabelaAtributo> TrataSubstituicoes(IList<TabelaAtributo> modelAsAttributes)
        {
            var result = new List<TabelaAtributo>();
            foreach (ucSubstituicao item in xSplitContainer1.Panel1.Controls)
            {
                try
                {
                    var atributoId = item.GetIdAtributo();
                    var antigoAtributo = modelAsAttributes.FirstOrDefault(a => a.AtributoId == atributoId);
                    if (antigoAtributo == null)
                    {
                        continue;
                    }
                    else
                    {
                        var novoAtributo = item.GetNovoAtributo(antigoAtributo);
                        result.Add(novoAtributo);
                    }
                }
                catch { }
            }
            var y = modelAsAttributes.Where(a => !result.Select(x => x.AtributoId).Contains(a.AtributoId)).ToList();
            result.AddRange(y);
            return result;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (OnAddBloco != null)
            {
                OnAddBloco.Invoke(sender, e);
                btnNovo.Enabled = false;
            }
        }

        private void ucBloco_Load(object sender, EventArgs e)
        {
            if(SimulacaoAutomatica)
            {
                btnSimular.Enabled = false;
                Simular();
            }
        }
    }
}
