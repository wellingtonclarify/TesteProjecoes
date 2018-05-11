using System.Windows.Forms;

namespace TesteProjecoes.UserControls
{
    public class XDateTimePickerMonth : XDateTimePicker
    {
        public XDateTimePickerMonth()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "MM/yyyy";
            ShowUpDown = true;
        }
    }
}
