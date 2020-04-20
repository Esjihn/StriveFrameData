using System.Drawing;
using System.Windows.Forms;
using StriveFrameData.UserControls;

namespace StriveFrameData.Views
{
    public partial class MainFrameDataView : Form
    {
        public MainFrameDataView()
        {
            InitializeComponent();
        }

        private void tabSolPage_Click(object sender, System.EventArgs e)
        {
            FrameDataControl fdc = new FrameDataControl();
            this.tabSolPage.Controls.Add(fdc);
        }
    }
}
