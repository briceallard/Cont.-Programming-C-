using System;
using System.IO;
using System.Windows.Forms;

namespace MdiWorkshop
{
    public partial class NewStore : Form
    {
        private WorkshopForm _workshop;

        public NewStore(WorkshopForm workshop)
        {
            _workshop = workshop;

            InitializeComponent();
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            string storeName = TB_StoreName.Text + Utilities.NEW_FILE_TYPE;
            Directory.CreateDirectory(Utilities.DEFAULT_SAVE_PATH);

            if (storeName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show(Utilities.MSG_INVALID_CHARS,
                    Utilities.ERROR_INVALID_CHARS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (File.Exists(Path.Combine(Utilities.DEFAULT_SAVE_PATH, storeName)))
            {
                MessageBox.Show(Utilities.MSG_FILE_EXISTS,
                    Utilities.ERROR_FILE_EXISTS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string saveFile = Path.Combine(Utilities.DEFAULT_SAVE_PATH, storeName);
                var file = File.Create(saveFile);
                file.Close();

                MessageBox.Show(Utilities.MSG_FILE_CREATED,
                    Utilities.SUCCESS_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                Utilities.STORE_FILE = saveFile;
                Utilities.STORE_NAME = TB_StoreName.Text;

                StoreForm storeForm = new StoreForm
                {
                    MdiParent = _workshop
                };
                storeForm.Show();
            }
        }
    }
}
