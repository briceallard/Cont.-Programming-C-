using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MdiWorkshop
{
    public partial class StoreForm : Form
    {
        public List<Record> list = new List<Record>();
        bool hasChanged = false;

        public StoreForm()
        {
            InitializeComponent();
        }

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

        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            hasChanged = true;

            ItemForm itemForm = new ItemForm();
            itemForm.ShowDialog();

            //list = itemForm._list;
            if(itemForm.record != null)
                AddToListView(itemForm.record);
        }

        private void AddToListView(Record record)
        {
            //Record temp = list.Last();

            ListViewItem lvi = new ListViewItem(record.Sku.ToString());
            lvi.Name = record.Sku.ToString();
            lvi.SubItems.Add(record.Name);
            lvi.SubItems.Add(record.Category);
            lvi.SubItems.Add(record.Quantity.ToString());
            lvi.SubItems.Add(record.Cost.ToString());
            lvi.SubItems.Add(record.Price.ToString());

            if (!listView.Items.ContainsKey(record.Sku.ToString()))
                listView.Items.Add(lvi);
            else
                MessageBox.Show(Utilities.MSG_ENTRY_EXISTS,
                    Utilities.ERROR_ENTRY_EXISTS,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void RefreshListView()
        {
            foreach (Record item in list)
            {
                ListViewItem lvi = new ListViewItem(item.Sku.ToString());
                lvi.Name = item.Sku.ToString();
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Category);
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Cost.ToString());
                lvi.SubItems.Add(item.Price.ToString());

                if (!listView.Items.ContainsKey(item.Sku.ToString()))
                    listView.Items.Add(lvi);
                else
                    MessageBox.Show(Utilities.MSG_ENTRY_EXISTS,
                        Utilities.ERROR_ENTRY_EXISTS,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void Serialize(string file)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(Tag.ToString(),
                FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs, list);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    Utilities.ERROR_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

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
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    Utilities.ERROR_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            Serialize(Tag.ToString());
            Close();
        }

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
    }
}
