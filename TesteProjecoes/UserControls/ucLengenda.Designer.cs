namespace TesteProjecoes.UserControls
{
    partial class ucLengenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xLabel1.Location = new System.Drawing.Point(30, 8);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(34, 13);
            this.xLabel1.TabIndex = 0;
            this.xLabel1.Text = "Texto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 18);
            this.panel1.TabIndex = 1;
            // 
            // ucLengenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xLabel1);
            this.Name = "ucLengenda";
            this.Size = new System.Drawing.Size(111, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XLabel xLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}
