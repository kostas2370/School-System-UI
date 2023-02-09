using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class InitialStyle
    {

        public static void setStyle(Form x)
        {
            x.StartPosition = FormStartPosition.Manual;
            x.Location = new Point(100, 100);
            x.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;



        }

    }
}
