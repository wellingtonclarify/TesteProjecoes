using System;
using System.Windows.Forms;
using TesteProjecoes.Model;

namespace TesteProjecoes.UserControls
{
    public partial class ucSubstituicao : UserControl
    {
        #region Events
        public EventHandler OnAddSubstituicao { get; set; }
        #endregion
        
        public ucSubstituicao()
        {
            InitializeComponent();
        }

        public int GetIdAtributo()
        {
            switch (cmbAtributo.SelectedItem.ToString())
            {
                case "Sexo":
                    return 4;
                case "Idade":
                    return 6;
                case "Salario":
                    return 5;
                default:
                    return 0;
            }
        }

        public TabelaAtributo GetNovoAtributo(TabelaAtributo antigoAtributo)
        {
            var atributo = new TabelaAtributo();
            atributo.TabelaId = antigoAtributo.TabelaId;
            atributo.RegistroId = antigoAtributo.RegistroId;
            atributo.AtributoId = GetIdAtributo();
            switch (cmbAtributo.SelectedItem.ToString())
            {
                case "Sexo":
                    if (cmbAcao.SelectedItem.ToString() != "Substituir")
                        throw new Exception("Ação inválida.");
                    atributo.Valor = txtValor.Text;
                    return atributo;
                case "Idade":
                case "Salario":
                    atributo.Valor = GetNovoValor(antigoAtributo);
                    return atributo;
                default:
                    return null;
            }
        }

        private double GetNovoValor(TabelaAtributo antigoAtributo)
        {
            var antigoValor = double.Parse(antigoAtributo.Valor.ToString());
            var novoValor = double.Parse(txtValor.Text);
            switch (cmbAcao.SelectedItem.ToString())
            {
                case "Substituir":
                    return novoValor;
                case "+":
                    return antigoValor += novoValor;
                case "-":
                    return antigoValor -= novoValor;
                case "*":
                    return antigoValor *= novoValor;
                case "/":
                    return antigoValor /= novoValor;
                default:
                    throw new Exception("Ação inválida");
            }
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            if (OnAddSubstituicao != null)
            {
                OnAddSubstituicao.Invoke(sender, e);
                xButton1.Enabled = false;
            }
        }
    }
}
