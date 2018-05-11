namespace TesteProjecoes
{
    partial class Form1
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
            this.ucBloco1 = new TesteProjecoes.UserControls.ucBloco();
            this.SuspendLayout();
            // 
            // ucBloco1
            // 
            this.ucBloco1.Location = new System.Drawing.Point(0, 0);
            this.ucBloco1.Name = "ucBloco1";
            this.ucBloco1.OnAddBloco = null;
            this.ucBloco1.SimulacaoAutomatica = true;
            this.ucBloco1.Size = new System.Drawing.Size(529, 352);
            this.ucBloco1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 354);
            this.Controls.Add(this.ucBloco1);
            this.Name = "Form1";
            this.Text = "Simulações";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucBloco ucBloco1;
    }
}

