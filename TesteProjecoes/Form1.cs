using System.Drawing;
using TesteProjecoes.UserControls;

namespace TesteProjecoes
{
    public partial class Form1 : XForm
    {
        public Form1()
        {
            InitializeComponent();
            ucBloco1.OnAddBloco = OnAddBloco;
        }

        private void OnAddBloco(object sender, System.EventArgs e)
        {
            var bloco = new ucBloco();
            bloco.Location = new Point(this.Controls.Count * 529, 0);
            bloco.OnAddBloco = OnAddBloco;
            this.Controls.Add(bloco);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
