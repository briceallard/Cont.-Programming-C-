using System;
using System.IO;
using System.Windows.Forms;

namespace MdiWorkshop
{
    public partial class WorkshopForm : Form
    {
        public WorkshopForm()
        {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStore newStore = new NewStore(this);
            newStore.ShowDialog();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm vf = new VersionForm();
            vf.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
    }
}
