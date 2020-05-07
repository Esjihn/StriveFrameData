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

        /// <summary>
        /// Main Frame data view load event.
        /// Loads user controls into form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrameDataView_Load(object sender, System.EventArgs e)
        {
            FrameDataControl fdc = new FrameDataControl();
            FrameDataControl fdc2 = new FrameDataControl();
            FrameDataControl fdc3 = new FrameDataControl();
            FrameDataControl fdc4 = new FrameDataControl();
            FrameDataControl fdc5 = new FrameDataControl();
            FrameDataControl fdc6 = new FrameDataControl();
            FrameDataControl fdc7 = new FrameDataControl();

            this.tabMayPage.Controls.Add(fdc);
            this.tabSolPage.Controls.Add(fdc2);
            this.tabKyPage.Controls.Add(fdc3);
            this.tabAxlPage.Controls.Add(fdc4);
            this.tabChippPage.Controls.Add(fdc5);
            this.tabFaustPage.Controls.Add(fdc6);
            this.tabPotemkinPage.Controls.Add(fdc7);
            this.Dock = DockStyle.Fill;
        }
    }
}
