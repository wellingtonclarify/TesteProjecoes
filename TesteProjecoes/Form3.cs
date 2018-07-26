using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TesteProjecoes.Calc;
using TesteProjecoes.Calc.Extensions;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes
{
    public partial class Form3 : TesteProjecoes.UserControls.XForm
    {
        Cenario _cenario = new Cenario();
        bool IsCalcStep = false;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Cenario parametros) : this()
        {
            _cenario = parametros;
            IsCalcStep = true;
            xButton1.Visible = false;
            btnCalcular.Visible = false;
            xCheckBox1.Checked = _cenario.AplicarCores;
            xDateTimePickerMonth1.Value = _cenario.DataInicial;
            xDateTimePickerMonth2.Value = _cenario.DataFinal;
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
            _cenario.DataInicial = xDateTimePickerMonth1.Value;
            _cenario.DataFinal = xDateTimePickerMonth2.Value;
            _cenario.AplicarCores = xCheckBox1.Checked;
            GeraColunasTimeLine();

            if (!IsCalcStep)
            {
                _cenario.FillPositions();
            }
            xDataGridView1.DataSource = _cenario.Posicoes;            
        }
        
        private void GeraColunasTimeLine()
        {
            while (xDataGridView1.Columns.Count > 2)
            {
                xDataGridView1.Columns.RemoveAt(2);
            }
            for (DateTime i = _cenario.DataInicial; i <= _cenario.DataFinal; i = i.AddMonths(1))
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
                e.Value = posicao.Calcular(referencia).ToString("N2"); 
            }
            else if(posicao.IsPool)
            {
                e.Value = posicao.QtdHoras;
            }
            SetCellStyle(posicao, referencia, e.CellStyle);
        }

        private void SetCellStyle(PosicaoTL posicao, DateTime referencia, DataGridViewCellStyle cellStyle)
        {
            var marco = posicao.GetMarco(referencia);
            if(_cenario.AplicarCores && marco.Eventos.Any(x => x.Tipo == enumTipoEvento.Admissao))
            {
                cellStyle.BackColor = Color.Green;
            }
            else if(_cenario.AplicarCores && marco.Eventos.Any(x => x.Tipo == enumTipoEvento.Demissao))
            {
                cellStyle.BackColor = Color.Red;
            }
            else if(_cenario.AplicarCores && marco.Eventos.Any(x => x.Tipo == enumTipoEvento.SubirCargo))
            {
                cellStyle.BackColor = Color.Blue;
            }
            else if (_cenario.AplicarCores && marco.Eventos.Any(x => x.Tipo == enumTipoEvento.AlteraQtdPool))
            {
                cellStyle.BackColor = Color.Yellow;
            }
            else
            {
                cellStyle.BackColor = Color.White;
            }
        }

        private double Calcular(out ResultDictionary results)
        {
            var posicao = GetPosicao();
            var referencia = GetReferencia();
            return posicao.Calcular(referencia, out results);
        }
        
        private void xDataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex < 2)
                return;

            xDataGridView1.CurrentCell = xDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var posicao = GetPosicao();
            var marco = GetMarco();

            if(IsCalcStep)
            {
                e.ContextMenuStrip = xContextMenuStrip4;
            }
            else if (posicao.IsPool)
            {
                limparToolStripMenuItem1.Enabled = marco.Eventos.Any();
                e.ContextMenuStrip = xContextMenuStrip3;
            }
            else
            {
                limparToolStripMenuItem.Enabled = marco.Eventos.Any();
                toolStripMenuItem4.Enabled = !posicao.FuncionarioUnico.Admissao.HasValue && !posicao.ExisteEventoNaLinhaTempo(marco.Referencia, enumTipoEvento.Admissao);
                toolStripMenuItem5.Enabled = !posicao.FuncionarioUnico.Rescisao.HasValue && !posicao.ExisteEventoNaLinhaTempo(marco.Referencia, enumTipoEvento.Demissao) && (posicao.FuncionarioUnico.Admissao.HasValue || posicao.ExisteEventoNoPassado(marco.Referencia, enumTipoEvento.Admissao));
                subirDeCargoToolStripMenuItem.Enabled = toolStripMenuItem5.Enabled && posicao.ObtemQtdOcorrenciasEventoNaLinhaTempo(marco.Referencia, enumTipoEvento.SubirCargo) < posicao.FuncionarioUnico.Cargo.ObterQtdPossivelPromocao();
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
            var referencia = GetReferencia();
            return posicao.GetMarco(referencia);
        }

        private DateTime GetReferencia()
        {
            var referencia = DateTime.Parse(xDataGridView1.Columns[xDataGridView1.CurrentCell.ColumnIndex].Name);
            return referencia;
        }

        private void AdicionaEvento(enumTipoEvento tipo)
        {            
            var marco = GetMarco();

            try
            {
                marco.AdicionaEvento(tipo);
                xDataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            //var derivado = _cenario.GerarDerivado(_cenario.DataInicial.AddMonths(3), _cenario.DataFinal.AddMonths(2));

            var frm = new Form3(_cenario);
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
            _cenario.AplicarCores = xCheckBox1.Checked;
            xDataGridView1.Refresh();
        }

        private void verDetalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calcular(out ResultDictionary results);
            var text = string.Join(Environment.NewLine, results.Select(r => string.Format("{0} = {1}", r.Key, r.Value)));
            if (string.IsNullOrEmpty(text))
                text = "Sem resultados";
            MessageBox.Show(text);
        }

        private void subirDeCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionaEvento(enumTipoEvento.SubirCargo);
        }
    }
}
