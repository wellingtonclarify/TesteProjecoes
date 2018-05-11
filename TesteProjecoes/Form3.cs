using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TesteProjecoes.Calc;
using TesteProjecoes.Model;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes
{
    public partial class Form3 : TesteProjecoes.UserControls.XForm
    {
        CalcParams _parametros = new CalcParams();
        bool IsCalcStep = false;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(CalcParams parametros) : this()
        {
            _parametros = parametros;
            IsCalcStep = true;
            xButton1.Visible = false;
            btnCalcular.Visible = false;
            xCheckBox1.Checked = _parametros.AplicarCores;
            xDateTimePickerMonth1.Value = _parametros.DataInicial;
            xDateTimePickerMonth2.Value = _parametros.DataFinal;
            xDateTimePickerMonth1.Enabled = false;
            xDateTimePickerMonth2.Enabled = false;
            Gerar();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            Gerar();
            btnCalcular.Enabled = true;
        }

        private void Gerar()
        {
            _parametros.DataInicial = xDateTimePickerMonth1.Value;
            _parametros.DataFinal = xDateTimePickerMonth2.Value;
            _parametros.AplicarCores = xCheckBox1.Checked;
            GeraColunasTimeLine();

            if (!IsCalcStep)
            { 
                _parametros.Source = new List<PosicaoTL>();
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
                            p.Marcos = GetMarcos();
                        }
                        else
                        {
                            p.Funcionarios = new[] { new FuncionarioTL() { Id = context.Funcionario[i].Id, Nome = context.Funcionario[i].Nome, Nascimento = context.Funcionario[i].Nascimento, Sexo = context.Funcionario[i].Sexo, Salario = context.Funcionario[i].Salario, Cargo = context.Funcionario[i].Cargo, Admissao = context.Funcionario[i].Admissao, Rescisao = context.Funcionario[i].Rescisao } }.ToList();
                            p.FuncionarioUnico.Marcos = GetMarcos();
                        }
                        _parametros.Source.Add(p);
                    }
                } 
            }
            xDataGridView1.DataSource = _parametros.Source;            
        }

        private IList<Marco> GetMarcos()
        {
            var result = new List<Marco>();
            for (DateTime i = xDateTimePickerMonth1.Value; i <= xDateTimePickerMonth2.Value; i = i.AddMonths(1))
            {
                result.Add(new Marco(i));
            }
            return result;
        }

        private void GeraColunasTimeLine()
        {
            while (xDataGridView1.Columns.Count > 2)
            {
                xDataGridView1.Columns.RemoveAt(2);
            }
            for (DateTime i = _parametros.DataInicial; i <= _parametros.DataFinal; i = i.AddMonths(1))
            {
                var col = new DataGridViewTextBoxColumn();
                col.Name = i.ToString("dd/MM/yyyy");
                col.HeaderText = i.ToString("MM/yyyy");
                col.ReadOnly = true;
                col.MinimumWidth = 60;
                col.Width = 60;
                xDataGridView1.Columns.Add(col);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            xDateTimePickerMonth1.MinDate = DateTime.Today.AddMonths(1).AddDays(-(DateTime.Today.Day-1));
            xDateTimePickerMonth2.MinDate = xDateTimePickerMonth1.MinDate;
            xDateTimePickerMonth2.MaxDate = xDateTimePickerMonth1.MinDate.AddYears(2);
            xDateTimePickerMonth2.Value = xDateTimePickerMonth1.MinDate.AddMonths(11);
        }

        private void xDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex < 2)
                return;

            var posicao = (PosicaoTL)xDataGridView1.Rows[e.RowIndex].DataBoundItem;
            var referencia = DateTime.Parse(xDataGridView1.Columns[e.ColumnIndex].Name);
            if (IsCalcStep)
            {
                e.Value = Calcular(posicao, referencia); 
            }
            else if(posicao.IsPool)
            {
                e.Value = posicao.QtdHoras;
            }
            SetCellStyle(posicao, referencia, e.CellStyle);
        }

        private void SetCellStyle(PosicaoTL posicao, DateTime referencia, DataGridViewCellStyle cellStyle)
        {
            var marco = GetMarco(posicao, referencia);
            if(_parametros.AplicarCores && marco.Eventos.Any(x => x.Tipo == enumTipoEvento.Admissao))
            {
                cellStyle.BackColor = Color.Green;
            }
            else if(_parametros.AplicarCores && marco.Eventos.Any(x => x.Tipo == enumTipoEvento.Demissao))
            {
                cellStyle.BackColor = Color.Red;
            }
            else if(_parametros.AplicarCores && marco.Eventos.Any(x => x.Tipo == enumTipoEvento.AlteraQtdPool))
            {
                cellStyle.BackColor = Color.Yellow;
            }
            else
            {
                cellStyle.BackColor = Color.White;
            }
        }

        private double Calcular(PosicaoTL posicao, DateTime referencia)
        {
            IList<TabelaAtributo> modelAsAttributes = null;
            IList<Regra> regras = null;
            using (var context = new Context())
            {
                if (posicao.IsPool)
                {
                    modelAsAttributes = posicao.GetModelAsAttributes();
                    regras = context.Regra.Where(r => r.Id == 3).ToList();
                }
                else
                {
                    modelAsAttributes = posicao.FuncionarioUnico.GetModelAsAttributes();
                    regras = context.Regra.Where(r => r.Id < 3).ToList();
                } 
            }

            var finalModel = TrataSubstituicoes(posicao, referencia, modelAsAttributes);
            var parameters = new CalculatorParams(finalModel, regras);
            var result = new Calculator(parameters).Calculate();
            return result;
        }

        private IList<TabelaAtributo> TrataSubstituicoes(PosicaoTL posicao, DateTime referencia, IList<TabelaAtributo> modelAsAttributes)
        {
            var eventos = GetMarco(posicao, referencia).Eventos.Clone();

            //Trata eventos permanentes e únicos
            if (ExisteEventoNoPassado(posicao, referencia, enumTipoEvento.Admissao))
                eventos.Add(new Evento(enumTipoEvento.Admissao));
            if (ExisteEventoNoPassado(posicao, referencia, enumTipoEvento.Demissao))
                eventos.Add(new Evento(enumTipoEvento.Demissao));
            //

            if (eventos == null || eventos.Count() == 0)
                return modelAsAttributes;

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
                    case enumTipoEvento.AlteraQtdPool:
                        modelAsAttributes.Single(a => a.AtributoId == 9).Valor = 320;
                        break;
                    default:
                        break;
                }
            }

            return modelAsAttributes;
        }

        private bool ExisteEventoNaLinhaTempo(PosicaoTL posicao, DateTime referencia, enumTipoEvento tipo)
        {
            return (posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos)
                //.Where(m => m.Referencia != referencia)
                .SelectMany(m => m.Eventos)
                .Any(x => x.Tipo == tipo);
        }

        private bool ExisteEventoNoPassado(PosicaoTL posicao, DateTime referencia, enumTipoEvento tipo)
        {
            return (posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos)
                .Where(m => m.Referencia < referencia)
                .SelectMany(m => m.Eventos)
                .Any(x => x.Tipo == tipo);
        }

        private bool ExisteEventoNoFuturo(PosicaoTL posicao, DateTime referencia, enumTipoEvento tipo)
        {
            return (posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos)
                .Where(m => m.Referencia > referencia)
                .SelectMany(m => m.Eventos)
                .Any(x => x.Tipo == tipo);
        }

        private void xDataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex < 2 || IsCalcStep)
                return;

            xDataGridView1.CurrentCell = xDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var posicao = GetPosicao();
            var marco = GetMarco();

            if (posicao.IsPool)
            {
                limparToolStripMenuItem1.Enabled = marco.Eventos.Any();
                e.ContextMenuStrip = xContextMenuStrip3;
            }
            else
            {
                limparToolStripMenuItem.Enabled = marco.Eventos.Any();
                toolStripMenuItem4.Enabled = !posicao.FuncionarioUnico.Admissao.HasValue && !ExisteEventoNaLinhaTempo(posicao, marco.Referencia, enumTipoEvento.Admissao);
                toolStripMenuItem5.Enabled = !posicao.FuncionarioUnico.Rescisao.HasValue && !ExisteEventoNaLinhaTempo(posicao, marco.Referencia, enumTipoEvento.Demissao) && (posicao.FuncionarioUnico.Admissao.HasValue || ExisteEventoNoPassado(posicao, marco.Referencia, enumTipoEvento.Admissao));
                e.ContextMenuStrip = xContextMenuStrip2;
            }
        }
        
        private PosicaoTL GetPosicao()
        {
            var row = xDataGridView1.CurrentRow;
            var posicao = (PosicaoTL)row.DataBoundItem;
            return posicao;
        }

        private Marco GetMarco()
        {
            var posicao = GetPosicao();
            var referencia = DateTime.Parse(xDataGridView1.Columns[xDataGridView1.CurrentCell.ColumnIndex].Name);
            return GetMarco(posicao, referencia);
        }

        private Marco GetMarco(PosicaoTL posicao, DateTime referencia)
        {
            var marcos = posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos;
            return marcos.Single(m => m.Referencia == referencia);
        }

        private void AdicionaEvento(enumTipoEvento tipo)
        {            
            var marco = GetMarco();

            if ((tipo == enumTipoEvento.Admissao || tipo == enumTipoEvento.Demissao) && ExisteEventoNaLinhaTempo(GetPosicao(), marco.Referencia, tipo))
            {
                MessageBox.Show("Evento já existente na linha do tempo.");
                return;
            }

            AdicionaEvento(marco, tipo);
            xDataGridView1.Refresh();
        }

        private void AdicionaEvento(Marco marco, enumTipoEvento tipo)
        {
            if(marco.Eventos.Any(x => x.Tipo == tipo))
            {
                MessageBox.Show("Evento já existente neste marco.");
                return;
            }

            marco.Eventos.Add(new Evento(tipo));
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AdicionaEvento(enumTipoEvento.Admissao);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AdicionaEvento(enumTipoEvento.Demissao);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            AdicionaEvento(enumTipoEvento.AlteraQtdPool);
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparMarcos();
        }

        private void limparToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LimparMarcos();
        }

        private void LimparMarcos()
        {
            var marco = GetMarco();
            marco.Eventos.Clear();
            xDataGridView1.Refresh();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var frm = new Form3(_parametros);
            frm.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!IsCalcStep)
            {
                if(MessageBox.Show("Deseja realmente fechar a simulação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void xCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _parametros.AplicarCores = xCheckBox1.Checked;
            xDataGridView1.Refresh();
        }
    }
}
