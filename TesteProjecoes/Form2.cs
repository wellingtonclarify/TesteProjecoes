using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TesteProjecoes.Calc;
using TesteProjecoes.Calc.Extensions;
using TesteProjecoes.Model;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes
{
    public partial class Form2 : TesteProjecoes.UserControls.XForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            GeraColunasTimeLine();

            var source = new List<PosicaoTL>();
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
                        p.Marcos = GetMarcos(p);
                    }
                    else
                    {
                        p.Funcionarios = new[] { new FuncionarioTL() { Id = context.Funcionario[i].Id, Nome = context.Funcionario[i].Nome, Nascimento = context.Funcionario[i].Nascimento, Sexo = context.Funcionario[i].Sexo, Salario = context.Funcionario[i].Salario, Admissao = context.Funcionario[i].Admissao, Rescisao = context.Funcionario[i].Rescisao } }.ToList();
                        p.FuncionarioUnico.Marcos = GetMarcos(p);
                    }
                    source.Add(p);
                }
            }
            xDataGridView1.DataSource = source;
        }

        private List<Marco> GetMarcos(PosicaoTL posicao)
        {
            var result = new List<Marco>();
            for (DateTime i = xDateTimePickerMonth1.Value; i <= xDateTimePickerMonth2.Value; i = i.AddMonths(1))
            {
                result.Add(new Marco(i, posicao));
            }
            return result;
        }

        private void GeraColunasTimeLine()
        {
            while (xDataGridView1.Columns.Count > 2)
            {
                xDataGridView1.Columns.RemoveAt(2);
            }
            for (DateTime i = xDateTimePickerMonth1.Value; i <= xDateTimePickerMonth2.Value; i = i.AddMonths(1))
            {
                xDataGridView1.Columns.Add(i.ToString("dd/MM/yyyy"), i.ToString("MM/yyyy"));
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            xDateTimePickerMonth1.MinDate = DateTime.Today.AddMonths(1).AddDays(-(DateTime.Today.Day-1));
            xDateTimePickerMonth2.MinDate = xDateTimePickerMonth1.MinDate;
            xDateTimePickerMonth2.MaxDate = xDateTimePickerMonth1.MinDate.AddYears(2);
            xDateTimePickerMonth2.Value = xDateTimePickerMonth1.MinDate.AddYears(1);
        }

        private void xDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex < 2)
                return;

            var posicao = (PosicaoTL)xDataGridView1.Rows[e.RowIndex].DataBoundItem;
            var referencia = DateTime.Parse(xDataGridView1.Columns[e.ColumnIndex].Name);
            e.Value = Calcular(posicao, referencia);
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
            var marcos = posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos;
            var eventos = marcos.Where(x => x.Referencia == referencia).SelectMany(x => x.Eventos);

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

        private void xDataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex < 2)
                return;

            xDataGridView1.CurrentCell = xDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var posicao = (PosicaoTL)xDataGridView1.Rows[e.RowIndex].DataBoundItem;
            
            e.ContextMenuStrip = posicao.IsPool ? xContextMenuStrip3 : xContextMenuStrip2;
        }

        private Marco GetMarcoFromContextMenuStrip()
        {
            var row = xDataGridView1.CurrentRow;
            var referencia = DateTime.Parse(xDataGridView1.Columns[xDataGridView1.CurrentCell.ColumnIndex].Name);
            var posicao = (PosicaoTL)row.DataBoundItem;
            var marcos = posicao.IsPool ? posicao.Marcos : posicao.FuncionarioUnico.Marcos;
            return marcos.Single(m => m.Referencia == referencia);
        }

        private void AdicionaEvento(Marco marco, enumTipoEvento tipo)
        {
            if (marco.Eventos.Any(x => x.Tipo == tipo))
            {
                MessageBox.Show("Evento já existe.");
                return;
            }

            marco.Eventos.Add(new Evento(tipo));
            xDataGridView1.Refresh();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var marco = GetMarcoFromContextMenuStrip();
            AdicionaEvento(marco, enumTipoEvento.Admissao);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var marco = GetMarcoFromContextMenuStrip();
            AdicionaEvento(marco, enumTipoEvento.Demissao);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            var marco = GetMarcoFromContextMenuStrip();
            AdicionaEvento(marco, enumTipoEvento.AlteraQtdPool);
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
            var marco = GetMarcoFromContextMenuStrip();
            marco.Eventos.Clear();
            xDataGridView1.Refresh();
        }
    }
}
