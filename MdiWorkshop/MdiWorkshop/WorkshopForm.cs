/**
 * Brice Allard
 * Contemporary Programming - C#
 * Dr. Stringfellow
 * 11-27-2018
 * 
 * Inventory Solution Software designed with MDI in mind. One parent form
 * and multiple child forms to maintain the inventory of several locations
 * at once. Menu items are demonstrated as well as sort and serialization
 * for easy data management and file storage.
 **/

using System;
using System.IO;
using System.Windows.Forms;

namespace MdiWorkshop
{
    /// <summary>
    /// Mostly handles Child forms
    /// </summary>
    public partial class WorkshopForm : Form
    {
        public WorkshopForm()
        {
            InitializeComponent();
        }

        // Lets make a new store
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStore newStore = new NewStore(this);
            newStore.ShowDialog();
        }

        // Display software version
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm vf = new VersionForm();
            vf.Show();
        }

        // Display about author -- Check it out, he's awesome
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        // Close the entire application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Opens a previously generated store
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Browse Store Files",
                DefaultExt = Utilities.NEW_FILE_TYPE,
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = Utilities.DEFAULT_SAVE_PATH,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Utilities.STORE_NAME = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                Utilities.STORE_FILE = openFileDialog.FileName;

                StoreForm storeForm = new StoreForm();
                storeForm.MdiParent = this;
                storeForm.Show();
            }
        }

        /// <summary>
        /// ICommon menu controls below -
        /// 
        /// Allows for method s haring between child and parent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ICommon)this.ActiveMdiChild).BTN_Insert_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ICommon)this.ActiveMdiChild).BTN_Delete_Click(sender, e);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((ICommon)this.ActiveMdiChild).BTN_Edit_Click(sender, e);
        }

        /// <summary>
        /// Data validation disabling/enabling certain menu items when needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                TSM_Delete.Enabled = true;
                TSM_Edit.Enabled = true;
                TSM_Insert.Enabled = true;
                TSM_Save.Enabled = true;
            }
            else
            {
                TSM_Delete.Enabled = false;
                TSM_Edit.Enabled = false;
                TSM_Insert.Enabled = false;
                TSM_Save.Enabled = false;
            }
        }
    }
}
