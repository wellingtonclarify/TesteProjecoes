namespace TesteProjecoes
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xLabel1 = new TesteProjecoes.UserControls.XLabel();
            this.xDateTimePickerMonth1 = new TesteProjecoes.UserControls.XDateTimePickerMonth();
            this.xDateTimePickerMonth2 = new TesteProjecoes.UserControls.XDateTimePickerMonth();
            this.xButton1 = new TesteProjecoes.UserControls.XButton();
            this.xDataGridView1 = new TesteProjecoes.UserControls.XDataGridView();
            this.dgcPosicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xContextMenuStrip2 = new TesteProjecoes.UserControls.XContextMenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.subirDeCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xContextMenuStrip3 = new TesteProjecoes.UserControls.XContextMenuStrip();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.limparToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalcular = new TesteProjecoes.UserControls.XButton();
            this.ucLengenda1 = new TesteProjecoes.UserControls.ucLengenda();
            this.ucLengenda2 = new TesteProjecoes.UserControls.ucLengenda();
            this.ucLengenda3 = new TesteProjecoes.UserControls.ucLengenda();
            this.xCheckBox1 = new TesteProjecoes.UserControls.XCheckBox();
            this.xContextMenuStrip4 = new TesteProjecoes.UserControls.XContextMenuStrip();
            this.verDetalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucLengenda4 = new TesteProjecoes.UserControls.ucLengenda();
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).BeginInit();
            this.xContextMenuStrip2.SuspendLayout();
            this.xContextMenuStrip3.SuspendLayout();
            this.xContextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xLabel1.Location = new System.Drawing.Point(13, 18);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(48, 13);
            this.xLabel1.TabIndex = 0;
            this.xLabel1.Text = "Período:";
            // 
            // xDateTimePickerMonth1
            // 
            this.xDateTimePickerMonth1.CustomFormat = "MM/yyyy";
            this.xDateTimePickerMonth1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.xDateTimePickerMonth1.Location = new System.Drawing.Point(67, 12);
            this.xDateTimePickerMonth1.Name = "xDateTimePickerMonth1";
            this.xDateTimePickerMonth1.ShowUpDown = true;
            this.xDateTimePickerMonth1.Size = new System.Drawing.Size(77, 20);
            this.xDateTimePickerMonth1.TabIndex = 1;
            // 
            // xDateTimePickerMonth2
            // 
            this.xDateTimePickerMonth2.CustomFormat = "MM/yyyy";
            this.xDateTimePickerMonth2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.xDateTimePickerMonth2.Location = new System.Drawing.Point(150, 12);
            this.xDateTimePickerMonth2.Name = "xDateTimePickerMonth2";
            this.xDateTimePickerMonth2.ShowUpDown = true;
            this.xDateTimePickerMonth2.Size = new System.Drawing.Size(77, 20);
            this.xDateTimePickerMonth2.TabIndex = 2;
            // 
            // xButton1
            // 
            this.xButton1.Location = new System.Drawing.Point(233, 9);
            this.xButton1.Name = "xButton1";
            this.xButton1.Size = new System.Drawing.Size(75, 23);
            this.xButton1.TabIndex = 3;
            this.xButton1.Text = "Gerar";
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // xDataGridView1
            // 
            this.xDataGridView1.AllowUserToAddRows = false;
            this.xDataGridView1.AllowUserToDeleteRows = false;
            this.xDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcPosicao,
            this.dgcFuncionario});
            this.xDataGridView1.Location = new System.Drawing.Point(17, 38);
            this.xDataGridView1.Name = "xDataGridView1";
            this.xDataGridView1.RowHeadersVisible = false;
            this.xDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xDataGridView1.Size = new System.Drawing.Size(878, 256);
            this.xDataGridView1.TabIndex = 4;
            this.xDataGridView1.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.xDataGridView1_CellContextMenuStripNeeded);
            this.xDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.xDataGridView1_CellFormatting);
            // 
            // dgcPosicao
            // 
            this.dgcPosicao.DataPropertyName = "Nome";
            this.dgcPosicao.HeaderText = "Posição";
            this.dgcPosicao.Name = "dgcPosicao";
            this.dgcPosicao.ReadOnly = true;
            // 
            // dgcFuncionario
            // 
            this.dgcFuncionario.HeaderText = "Funcionário";
            this.dgcFuncionario.Name = "dgcFuncionario";
            this.dgcFuncionario.ReadOnly = true;
            // 
            // xContextMenuStrip2
            // 
            this.xContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.subirDeCargoToolStripMenuItem,
            this.toolStripSeparator1,
            this.limparToolStripMenuItem});
            this.xContextMenuStrip2.Name = "xContextMenuStrip1";
            this.xContextMenuStrip2.Size = new System.Drawing.Size(130, 98);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem4.Text = "Admissão";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItem5.Text = "Demissão";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // subirDeCargoToolStripMenuItem
            // 
            this.subirDeCargoToolStripMenuItem.Name = "subirDeCargoToolStripMenuItem";
            this.subirDeCargoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.subirDeCargoToolStripMenuItem.Text = "Promoção";
            this.subirDeCargoToolStripMenuItem.Click += new System.EventHandler(this.subirDeCargoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // xContextMenuStrip3
            // 
            this.xContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripSeparator2,
            this.limparToolStripMenuItem1});
            this.xContextMenuStrip3.Name = "xContextMenuStrip1";
            this.xContextMenuStrip3.Size = new System.Drawing.Size(167, 54);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem9.Text = "Alterar Qtd Horas";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // limparToolStripMenuItem1
            // 
            this.limparToolStripMenuItem1.Name = "limparToolStripMenuItem1";
            this.limparToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.limparToolStripMenuItem1.Text = "Limpar";
            this.limparToolStripMenuItem1.Click += new System.EventHandler(this.limparToolStripMenuItem1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(314, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ucLengenda1
            // 
            this.ucLengenda1.Cor = System.Drawing.Color.Green;
            this.ucLengenda1.Location = new System.Drawing.Point(496, 7);
            this.ucLengenda1.Name = "ucLengenda1";
            this.ucLengenda1.Size = new System.Drawing.Size(86, 25);
            this.ucLengenda1.TabIndex = 7;
            this.ucLengenda1.Texto = "Admissão";
            // 
            // ucLengenda2
            // 
            this.ucLengenda2.Cor = System.Drawing.Color.Red;
            this.ucLengenda2.Location = new System.Drawing.Point(588, 7);
            this.ucLengenda2.Name = "ucLengenda2";
            this.ucLengenda2.Size = new System.Drawing.Size(87, 25);
            this.ucLengenda2.TabIndex = 8;
            this.ucLengenda2.Texto = "Demissão";
            // 
            // ucLengenda3
            // 
            this.ucLengenda3.Cor = System.Drawing.Color.Yellow;
            this.ucLengenda3.Location = new System.Drawing.Point(681, 7);
            this.ucLengenda3.Name = "ucLengenda3";
            this.ucLengenda3.Size = new System.Drawing.Size(124, 25);
            this.ucLengenda3.TabIndex = 9;
            this.ucLengenda3.Texto = "Alterar Qtd Horas";
            // 
            // xCheckBox1
            // 
            this.xCheckBox1.AutoSize = true;
            this.xCheckBox1.Checked = true;
            this.xCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xCheckBox1.Location = new System.Drawing.Point(404, 12);
            this.xCheckBox1.Name = "xCheckBox1";
            this.xCheckBox1.Size = new System.Drawing.Size(87, 17);
            this.xCheckBox1.TabIndex = 10;
            this.xCheckBox1.Text = "Aplicar cores";
            this.xCheckBox1.UseVisualStyleBackColor = true;
            this.xCheckBox1.CheckedChanged += new System.EventHandler(this.xCheckBox1_CheckedChanged);
            // 
            // xContextMenuStrip4
            // 
            this.xContextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetalhesToolStripMenuItem});
            this.xContextMenuStrip4.Name = "xContextMenuStrip4";
            this.xContextMenuStrip4.Size = new System.Drawing.Size(139, 26);
            // 
            // verDetalhesToolStripMenuItem
            // 
            this.verDetalhesToolStripMenuItem.Name = "verDetalhesToolStripMenuItem";
            this.verDetalhesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.verDetalhesToolStripMenuItem.Text = "Ver Detalhes";
            this.verDetalhesToolStripMenuItem.Click += new System.EventHandler(this.verDetalhesToolStripMenuItem_Click);
            // 
            // ucLengenda4
            // 
            this.ucLengenda4.Cor = System.Drawing.Color.Blue;
            this.ucLengenda4.Location = new System.Drawing.Point(811, 6);
            this.ucLengenda4.Name = "ucLengenda4";
            this.ucLengenda4.Size = new System.Drawing.Size(124, 25);
            this.ucLengenda4.TabIndex = 11;
            this.ucLengenda4.Texto = "Promoção";
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(907, 306);
            this.Controls.Add(this.ucLengenda4);
            this.Controls.Add(this.xCheckBox1);
            this.Controls.Add(this.ucLengenda3);
            this.Controls.Add(this.ucLengenda2);
            this.Controls.Add(this.ucLengenda1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.xDataGridView1);
            this.Controls.Add(this.xButton1);
            this.Controls.Add(this.xDateTimePickerMonth2);
            this.Controls.Add(this.xDateTimePickerMonth1);
            this.Controls.Add(this.xLabel1);
            this.Name = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).EndInit();
            this.xContextMenuStrip2.ResumeLayout(false);
            this.xContextMenuStrip3.ResumeLayout(false);
            this.xContextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.XLabel xLabel1;
        private UserControls.XDateTimePickerMonth xDateTimePickerMonth1;
        private UserControls.XDateTimePickerMonth xDateTimePickerMonth2;
        private UserControls.XButton xButton1;
        private UserControls.XDataGridView xDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPosicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFuncionario;
        private UserControls.XContextMenuStrip xContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private UserControls.XContextMenuStrip xContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem1;
        private UserControls.XButton btnCalcular;
        private UserControls.ucLengenda ucLengenda1;
        private UserControls.ucLengenda ucLengenda2;
        private UserControls.ucLengenda ucLengenda3;
        private UserControls.XCheckBox xCheckBox1;
        private UserControls.XContextMenuStrip xContextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem verDetalhesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirDeCargoToolStripMenuItem;
        private UserControls.ucLengenda ucLengenda4;
    }
}
