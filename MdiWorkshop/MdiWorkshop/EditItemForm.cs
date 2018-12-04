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
using System.Windows.Forms;

namespace MdiWorkshop
{
    /// <summary>
    /// Automatically receive data and allow change
    /// </summary>
    public partial class EditItemForm : Form, ICommon
    {
        public Record _record;
        public Record _sendRecord;

        public EditItemForm(Record record)
        {
            _record = record;
            InitializeComponent();
        }

        /// <summary>
        /// Automatically load data into form for visual representation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditItemForm_Load(object sender, EventArgs e)
        {
            TB_Sku.Text = _record.Sku.ToString();
            TB_Name.Text = _record.Name;
            TB_Category.Text = _record.Category;
            TB_Quantity.Text = _record.Quantity.ToString();
            TB_Cost.Text = _record.Cost.ToString();
            TB_Price.Text = _record.Price.ToString();
        }

        /// <summary>
        /// ICommon functions
        /// </summary>
        public void Save() { }
        public void BTN_Insert_Click(object sender, EventArgs e) { }
        public void BTN_Delete_Click(object sender, EventArgs e) { }
        public void BTN_Edit_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Verify data, save data in global variable for storage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BTN_Edit_ClickEvent(object sender, EventArgs e)
        {
            // Can't be empty!
            if (verifyNoEmptyFields())
            {
                try
                {
                    _sendRecord = new Record
                    {
                        Sku = Int32.Parse(TB_Sku.Text),
                        Name = TB_Name.Text,
                        Category = TB_Category.Text,
                        Quantity = Int32.Parse(TB_Quantity.Text),
                        Cost = Double.Parse(TB_Cost.Text),
                        Price = Double.Parse(TB_Price.Text),
                        storeName = Utilities.STORE_NAME
                    };
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        Utilities.ERROR_TITLE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else // Was empty!
            {
                MessageBox.Show(Utilities.MSG_EMPTY_FIELDS,
                        Utilities.ERROR_EMPTY_FIELDS,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

            // All done!
            Close();
        }

        /// <summary>
        /// Boolean checker for form validation
        /// </summary>
        /// <returns></returns>
        private bool verifyNoEmptyFields()
        {
            return (TB_Sku.Text != "" &&
                TB_Name.Text != "" &&
                TB_Category.Text != "" &&
                TB_Quantity.Text != "" &&
                TB_Cost.Text != "" &&
                TB_Price.Text != "") ? true : false;
        }
    }
}
