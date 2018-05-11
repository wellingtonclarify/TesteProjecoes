using System.Windows.Forms;

namespace TesteProjecoes.UserControls
{
    public class XDataGridView : DataGridView
    {
        public XDataGridView()
        {
            RowHeadersVisible = false;
            AutoGenerateColumns = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }
    }
}
