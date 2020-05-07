using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StriveFrameData.Presenters;
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
            if (sender != null)
            {
                MainFrameDataPresenter p = new MainFrameDataPresenter();
                p.Initialize();
                LoadUserControlsIntoTabs();
                LoadFrameDataIntoAllComboBoxes();
            }
        }
        
        #region Private Methods
        private void LoadUserControlsIntoTabs()
        {
            MainFrameDataPresenter p = new MainFrameDataPresenter();
            List<TabPage> tabPages = new List<TabPage>
            {
                this.tabMayPage,
                this.tabSolPage,
                this.tabKyPage,
                this.tabAxlPage,
                this.tabChippPage,
                this.tabFaustPage,
                this.tabPotemkinPage
            };

            // Add user controls to tab pages
            for (int i = 0; i < MainFrameDataPresenter.FrameDataUserControls.Count; i++)
            {
                tabPages[i].Controls.Add(MainFrameDataPresenter.FrameDataUserControls[i]);
            }
            
            this.Dock = DockStyle.Fill;
        }

        private void LoadFrameDataIntoAllComboBoxes()
        {
            
        }

        #endregion

    }
}
