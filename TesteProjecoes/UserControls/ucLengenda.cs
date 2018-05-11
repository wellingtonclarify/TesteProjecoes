using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteProjecoes.UserControls
{
    public partial class ucLengenda : UserControl
    {
        public string Texto
        {
            get { return xLabel1.Text; }
            set { xLabel1.Text = value; }
        }

        public Color Cor
        {
            get { return panel1.BackColor; }
            set { panel1.BackColor = value; }
        }
        
        public ucLengenda()
        {
            InitializeComponent();
        }
    }
}
