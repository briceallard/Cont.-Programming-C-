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
    /// Form for creating a new store location
    /// </summary>
    public partial class NewStore : Form
    {
        private WorkshopForm _workshop;

        /// <summary>
        /// Constructor passing in parent form to set child too
        /// </summary>
        /// <param name="workshop"></param>
        public NewStore(WorkshopForm workshop)
        {
            _workshop = workshop;

            InitializeComponent();
        }

        /// <summary>
        /// Form Validation then create the store
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Create_Click(object sender, EventArgs e)
        {
            string storeName = TB_StoreName.Text + Utilities.NEW_FILE_TYPE;
            Directory.CreateDirectory(Utilities.DEFAULT_SAVE_PATH);

            // If store name is invalid
            if (storeName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show(Utilities.MSG_INVALID_CHARS,
                    Utilities.ERROR_INVALID_CHARS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // else if file already exists
            else if (File.Exists(Path.Combine(Utilities.DEFAULT_SAVE_PATH, storeName)))
            {
                MessageBox.Show(Utilities.MSG_FILE_EXISTS,
                    Utilities.ERROR_FILE_EXISTS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // All good!
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

                // Set parent form
                StoreForm storeForm = new StoreForm
                {
                    MdiParent = _workshop
                };
                storeForm.Show();
            }
        }
    }
}
