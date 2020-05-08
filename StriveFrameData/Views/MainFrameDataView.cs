using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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



                CreateTabPagesList();
                LoadUserControlsIntoTabs();
                LoadFrameDataIntoAllComboBoxes();
            }
        }

        #region Private Properties

        /// <summary>
        /// Property with current list of TabPages
        /// </summary>
        private static List<TabPage> TabPages { get; set; }

        #endregion

        #region Private Methods
        /// <summary>
        /// Loads user controls into All Tab Pages during form load event.
        /// </summary>
        private void LoadUserControlsIntoTabs()
        {
            MainFrameDataPresenter p = new MainFrameDataPresenter();

            if (TabPages != null)
            {
                // Add user controls to tab pages
                for (int i = 0; i < MainFrameDataPresenter.FrameDataUserControls.Count; i++)
                {
                    TabPages[i].Controls.Add(MainFrameDataPresenter.FrameDataUserControls[i]);
                }
            }

            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Loads Frame Data data into all combo boxes during form load event.
        /// </summary>
        private void LoadFrameDataIntoAllComboBoxes()
        {
            MainFrameDataPresenter p = new MainFrameDataPresenter();
            p.FrameDataList();

            // Tab pages
            for(int i = 0; i < TabPages.Count; i++)
            {
                // User controls
                for (int j = 0; i < TabPages[i].Controls.Count; i++)
                {
                    // User control controlCollection
                    for (int k = 0; k < TabPages[i].Controls[j].Controls.Count; k++)
                    {
                        if (TabPages[i].Controls[j].Controls[k] is ComboBox)
                        {
                            ComboBox comboBoxControl = TabPages[i].Controls[j] as ComboBox;
                            if (comboBoxControl != null)
                            {
                                BindingSource bs = new BindingSource();
                                bs.DataSource = p.FrameDataList();
                                comboBoxControl.DataSource = bs.DataSource;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Creates list of all UI tab pages
        /// </summary>
        /// <returns></returns>
        private void CreateTabPagesList()
        {
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
            TabPages = tabPages;
        }

        #endregion
    }
}
