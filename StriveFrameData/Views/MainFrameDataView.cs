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
            AddFrameDataControlToTabs();
        }

        #region Private Methods

        /// <summary>
        /// Load main frame data user control into all character tabs
        /// </summary>
        private void AddFrameDataControlToTabs()
        {
            FrameDataControl fdc = new FrameDataControl();
            fdc.MaximumSize = new Size(1302, 703);
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

#endregion
    }
}
