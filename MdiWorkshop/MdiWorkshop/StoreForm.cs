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
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MdiWorkshop
{
    /// <summary>
    /// All items saved in stores inventory are displayed on this form
    /// </summary>
    public partial class StoreForm : Form, ICommon
    {
        public List<Record> list = new List<Record>();
        bool hasChanged = false; //Track if needs to be saved

        public StoreForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Deserialize the file and display it in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreForm_Load(object sender, EventArgs e)
        {
            Text = Utilities.STORE_NAME;
            Tag = Utilities.STORE_FILE;

            // Has items to de-serialize
            if (new FileInfo(Tag.ToString()).Length > 0)
            {
                Deserialize(Tag.ToString());

                RefreshListView();
            }
        }

        /// <summary>
        /// Sort items in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Sort_OnChangeEvent(object sender, EventArgs e)
        {
            switch (CB_Sort.SelectedIndex)
            {
                case 0: // Sort by SKU
                    list.Sort((a, b) => a.Sku.CompareTo(b.Sku));
                    RefreshListView();
                    break;
                case 1: // Sort by Name
                    list.Sort((a, b) => a.Name.CompareTo(b.Name));
                    RefreshListView();
                    break;
                case 2: // Sort by Category
                    list.Sort((a, b) => a.Category.CompareTo(b.Category));
                    RefreshListView();
                    break;
                case 3: // Sort by Quantity
                    list.Sort((a, b) => a.Quantity.CompareTo(b.Quantity));
                    RefreshListView();
                    break;
                case 4: // Sort by Cost
                    list.Sort((a, b) => a.Cost.CompareTo(b.Cost));
                    RefreshListView();
                    break;
                case 5: // Sort by Price
                    list.Sort((a, b) => a.Price.CompareTo(b.Price));
                    RefreshListView();
                    break;
                default: // Don't sort
                    break;
            }
        }

        /// <summary>
        /// Add item to storage file and display on list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BTN_Insert_Click(object sender, EventArgs e)
        {
            hasChanged = true;

            ItemForm itemForm = new ItemForm();
            itemForm.ShowDialog();

            if (itemForm.record != null)
            {
                list.Add(itemForm.record);
                AddToListView(itemForm.record);
            }
        }

        /// <summary>
        /// Adds new item to list box
        /// </summary>
        /// <param name="record"></param>
        private void AddToListView(Record record)
        {
            ListViewItem lvi = GenerateLVI(record);

            if (!listView.Items.ContainsKey(record.Sku.ToString()))
                listView.Items.Add(lvi);
            else
                MessageBox.Show(Utilities.MSG_ENTRY_EXISTS,
                    Utilities.ERROR_ENTRY_EXISTS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        /// <summary>
        /// Adds edited item to list box
        /// </summary>
        /// <param name="record"></param>
        private void EditToListView(Record record)
        {
            ListViewItem lvi = GenerateLVI(record);

            listView.Items.Add(lvi);
        }

        /// <summary>
        /// Refreshed list box after load and sorts
        /// </summary>
        private void RefreshListView()
        {
            listView.Items.Clear(); // Clear list box

            foreach (Record item in list)
            {
                ListViewItem lvi = GenerateLVI(item);

                listView.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Helper function to generate and return ListViewItems
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        private ListViewItem GenerateLVI(Record record)
        {
            ListViewItem lvi = new ListViewItem(record.Sku.ToString());
            lvi.Name = record.Sku.ToString();
            lvi.SubItems.Add(record.Name);
            lvi.SubItems.Add(record.Category);
            lvi.SubItems.Add(record.Quantity.ToString());
            lvi.SubItems.Add(record.Cost.ToString());
            lvi.SubItems.Add(record.Price.ToString());

            return lvi;
        }

        /// <summary>
        /// Keep data serialized on saves and creation
        /// </summary>
        /// <param name="file"></param>
        private void Serialize(string file)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(Tag.ToString(),
                FileMode.Open, FileAccess.Write, FileShare.None);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs, list);
                }
            }
            catch (Exception error) // Uh oh!
            {
                MessageBox.Show(error.Message,
                    Utilities.ERROR_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deserialize data for view on file load
        /// </summary>
        /// <param name="file"></param>
        private void Deserialize(string file)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(Tag.ToString(),
                FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    list = (List<Record>)bf.Deserialize(fs);
                }
            }
            catch (Exception error) // Uh oh!
            {
                MessageBox.Show(error.Message,
                    Utilities.ERROR_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save file by ensuring serialization and reset changed bool
        /// </summary>
        public void Save()
        {
            Serialize(Tag.ToString());
            hasChanged = false;
        }

        /// <summary>
        /// Saves and Closes, Thats it ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        /// <summary>
        /// If file hasn't been saved on close, ask user to save.
        /// Don't lose that data!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanged)
            {
                if (MessageBox.Show("Would you like to save?", "Save File",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    BTN_Save_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// Loads edititemform and allows changes to LVI then 
        /// refreshes the list box with updated data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BTN_Edit_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                if (lvi.Selected)
                {
                    Int32.TryParse(lvi.Name, out int sku);
                    Record toEdit = list.Find(item => item.Sku == sku);

                    EditItemForm editForm = new EditItemForm(toEdit);
                    editForm.ShowDialog();

                    list.Remove(toEdit);
                    lvi.Remove();

                    list.Add(editForm._sendRecord);
                    EditToListView(editForm._sendRecord);
                }
            }
        }

        /// <summary>
        /// Removes selected item from the store/data/LVI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BTN_Delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView.Items)
            {
                if (lvi.Selected)
                {
                    Int32.TryParse(lvi.Name, out int sku);
                    Record toRemove = list.Find(item => item.Sku == sku);

                    list.Remove(toRemove);
                    lvi.Remove();

                    return;
                }
            }
            MessageBox.Show("Choose and item to delete");
        }
    }
}
