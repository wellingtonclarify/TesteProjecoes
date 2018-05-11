namespace TesteProjecoes.UserControls
{
    partial class ucBloco
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xSplitContainer1 = new TesteProjecoes.UserControls.XSplitContainer();
            this.ucSubstituicao1 = new TesteProjecoes.UserControls.ucSubstituicao();
            this.btnNovo = new TesteProjecoes.UserControls.XButton();
            this.xDataGridView1 = new TesteProjecoes.UserControls.XDataGridView();
            this.btnSimular = new TesteProjecoes.UserControls.XButton();
            this.dgcFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xSplitContainer1)).BeginInit();
            this.xSplitContainer1.Panel1.SuspendLayout();
            this.xSplitContainer1.Panel2.SuspendLayout();
            this.xSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xSplitContainer1
            // 
            this.xSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.xSplitContainer1.Name = "xSplitContainer1";
            this.xSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // xSplitContainer1.Panel1
            // 
            this.xSplitContainer1.Panel1.Controls.Add(this.ucSubstituicao1);
            // 
            // xSplitContainer1.Panel2
            // 
            this.xSplitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.xSplitContainer1.Panel2.Controls.Add(this.xDataGridView1);
            this.xSplitContainer1.Panel2.Controls.Add(this.btnSimular);
            this.xSplitContainer1.Size = new System.Drawing.Size(554, 352);
            this.xSplitContainer1.SplitterDistance = 176;
            this.xSplitContainer1.TabIndex = 0;
            // 
            // ucSubstituicao1
            // 
            this.ucSubstituicao1.Location = new System.Drawing.Point(3, 3);
            this.ucSubstituicao1.Name = "ucSubstituicao1";
            this.ucSubstituicao1.OnAddSubstituicao = null;
            this.ucSubstituicao1.Size = new System.Drawing.Size(545, 29);
            this.ucSubstituicao1.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Location = new System.Drawing.Point(514, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(34, 130);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "N\r\nO\r\nV\r\nO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            this.dgcFuncionario,
            this.dgcIdade,
            this.dgcSalario,
            this.dgcValor});
            this.xDataGridView1.Location = new System.Drawing.Point(110, 32);
            this.xDataGridView1.Name = "xDataGridView1";
            this.xDataGridView1.RowHeadersVisible = false;
            this.xDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xDataGridView1.Size = new System.Drawing.Size(329, 130);
            this.xDataGridView1.TabIndex = 1;
            // 
            // btnSimular
            // 
            this.btnSimular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSimular.Location = new System.Drawing.Point(239, 3);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dgcFuncionario
            // 
            this.dgcFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcFuncionario.DataPropertyName = "Nome";
            this.dgcFuncionario.HeaderText = "Funcionário";
            this.dgcFuncionario.Name = "dgcFuncionario";
            this.dgcFuncionario.ReadOnly = true;
            // 
            // dgcIdade
            // 
            this.dgcIdade.DataPropertyName = "Idade";
            this.dgcIdade.FillWeight = 50F;
            this.dgcIdade.HeaderText = "Idade";
            this.dgcIdade.Name = "dgcIdade";
            this.dgcIdade.ReadOnly = true;
            this.dgcIdade.Width = 50;
            // 
            // dgcSalario
            // 
            this.dgcSalario.DataPropertyName = "Salario";
            this.dgcSalario.FillWeight = 50F;
            this.dgcSalario.HeaderText = "Salário";
            this.dgcSalario.Name = "dgcSalario";
            this.dgcSalario.ReadOnly = true;
            this.dgcSalario.Width = 50;
            // 
            // dgcValor
            // 
            this.dgcValor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dgcValor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcValor.FillWeight = 50F;
            this.dgcValor.HeaderText = "Valor";
            this.dgcValor.Name = "dgcValor";
            this.dgcValor.ReadOnly = true;
            this.dgcValor.Width = 50;
            // 
            // ucBloco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xSplitContainer1);
            this.Name = "ucBloco";
            this.Size = new System.Drawing.Size(554, 352);
            this.Load += new System.EventHandler(this.ucBloco_Load);
            this.xSplitContainer1.Panel1.ResumeLayout(false);
            this.xSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xSplitContainer1)).EndInit();
            this.xSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XSplitContainer xSplitContainer1;
        private XButton btnSimular;
        private XDataGridView xDataGridView1;
        private ucSubstituicao ucSubstituicao1;
        private XButton btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValor;
    }
}
