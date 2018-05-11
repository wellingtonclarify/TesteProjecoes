namespace TesteProjecoes.UserControls
{
    partial class ucSubstituicao
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
            this.xLabel1 = new TesteProjecoes.UserControls.XLabel();
            this.cmbAtributo = new TesteProjecoes.UserControls.XComboBox();
            this.cmbAcao = new TesteProjecoes.UserControls.XComboBox();
            this.xLabel2 = new TesteProjecoes.UserControls.XLabel();
            this.txtValor = new TesteProjecoes.UserControls.XTextBox();
            this.xLabel3 = new TesteProjecoes.UserControls.XLabel();
            this.xButton1 = new TesteProjecoes.UserControls.XButton();
            this.SuspendLayout();
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xLabel1.Location = new System.Drawing.Point(4, 7);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(46, 13);
            this.xLabel1.TabIndex = 0;
            this.xLabel1.Text = "Atributo:";
            // 
            // cmbAtributo
            // 
            this.cmbAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtributo.FormattingEnabled = true;
            this.cmbAtributo.Items.AddRange(new object[] {
            "Sexo",
            "Idade",
            "Salario"});
            this.cmbAtributo.Location = new System.Drawing.Point(54, 4);
            this.cmbAtributo.Name = "cmbAtributo";
            this.cmbAtributo.Size = new System.Drawing.Size(121, 21);
            this.cmbAtributo.TabIndex = 1;
            // 
            // cmbAcao
            // 
            this.cmbAcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "Substituir"});
            this.cmbAcao.Location = new System.Drawing.Point(222, 3);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(121, 21);
            this.cmbAcao.TabIndex = 3;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xLabel2.Location = new System.Drawing.Point(181, 7);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(35, 13);
            this.xLabel2.TabIndex = 2;
            this.xLabel2.Text = "Ação:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(389, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xLabel3.Location = new System.Drawing.Point(349, 7);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(34, 13);
            this.xLabel3.TabIndex = 5;
            this.xLabel3.Text = "Valor:";
            // 
            // xButton1
            // 
            this.xButton1.Location = new System.Drawing.Point(495, 4);
            this.xButton1.Name = "xButton1";
            this.xButton1.Size = new System.Drawing.Size(27, 23);
            this.xButton1.TabIndex = 6;
            this.xButton1.Text = "+";
            this.xButton1.UseVisualStyleBackColor = true;
            this.xButton1.Click += new System.EventHandler(this.xButton1_Click);
            // 
            // ucSubstituicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xButton1);
            this.Controls.Add(this.xLabel3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cmbAcao);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.cmbAtributo);
            this.Controls.Add(this.xLabel1);
            this.Name = "ucSubstituicao";
            this.Size = new System.Drawing.Size(528, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XLabel xLabel1;
        private XComboBox cmbAtributo;
        private XComboBox cmbAcao;
        private XLabel xLabel2;
        private XTextBox txtValor;
        private XLabel xLabel3;
        private XButton xButton1;
    }
}
