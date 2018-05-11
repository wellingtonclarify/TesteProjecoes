namespace TesteProjecoes
{
    partial class Form2
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
            this.btnGerar = new TesteProjecoes.UserControls.XButton();
            this.xDataGridView1 = new TesteProjecoes.UserControls.XDataGridView();
            this.dgcPosicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xContextMenuStrip1 = new TesteProjecoes.UserControls.XContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xContextMenuStrip2 = new TesteProjecoes.UserControls.XContextMenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xContextMenuStrip3 = new TesteProjecoes.UserControls.XContextMenuStrip();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.limparToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).BeginInit();
            this.xContextMenuStrip1.SuspendLayout();
            this.xContextMenuStrip2.SuspendLayout();
            this.xContextMenuStrip3.SuspendLayout();
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
            this.xDateTimePickerMonth1.Size = new System.Drawing.Size(96, 20);
            this.xDateTimePickerMonth1.TabIndex = 1;
            // 
            // xDateTimePickerMonth2
            // 
            this.xDateTimePickerMonth2.CustomFormat = "MM/yyyy";
            this.xDateTimePickerMonth2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.xDateTimePickerMonth2.Location = new System.Drawing.Point(169, 12);
            this.xDateTimePickerMonth2.Name = "xDateTimePickerMonth2";
            this.xDateTimePickerMonth2.ShowUpDown = true;
            this.xDateTimePickerMonth2.Size = new System.Drawing.Size(96, 20);
            this.xDateTimePickerMonth2.TabIndex = 2;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(271, 9);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.xButton1_Click);
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
            this.xDataGridView1.Size = new System.Drawing.Size(788, 256);
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
            // xContextMenuStrip1
            // 
            this.xContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.xContextMenuStrip1.Name = "xContextMenuStrip1";
            this.xContextMenuStrip1.Size = new System.Drawing.Size(167, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem1.Text = "Admissão";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem2.Text = "Demissão";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem3.Text = "Alterar Qtd Horas";
            // 
            // xContextMenuStrip2
            // 
            this.xContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.limparToolStripMenuItem});
            this.xContextMenuStrip2.Name = "xContextMenuStrip1";
            this.xContextMenuStrip2.Size = new System.Drawing.Size(127, 76);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem4.Text = "Admissão";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem5.Text = "Demissão";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(817, 306);
            this.Controls.Add(this.xDataGridView1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.xDateTimePickerMonth2);
            this.Controls.Add(this.xDateTimePickerMonth1);
            this.Controls.Add(this.xLabel1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).EndInit();
            this.xContextMenuStrip1.ResumeLayout(false);
            this.xContextMenuStrip2.ResumeLayout(false);
            this.xContextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.XLabel xLabel1;
        private UserControls.XDateTimePickerMonth xDateTimePickerMonth1;
        private UserControls.XDateTimePickerMonth xDateTimePickerMonth2;
        private UserControls.XButton btnGerar;
        private UserControls.XDataGridView xDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPosicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFuncionario;
        private UserControls.XContextMenuStrip xContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private UserControls.XContextMenuStrip xContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private UserControls.XContextMenuStrip xContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem1;
    }
}
