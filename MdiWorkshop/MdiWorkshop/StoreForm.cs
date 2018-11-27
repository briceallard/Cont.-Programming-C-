using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace MdiWorkshop
{
    public partial class StoreForm : Form
    {
        public List<Record> list = new List<Record>();

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
            ItemForm itemForm = new ItemForm(list);
            itemForm.ShowDialog();
            list = itemForm._list;
            
            AddToListView();
        }

        private void AddToListView()
        {
            Record temp = list[list.Count - 1];

            ListViewItem lvi = new ListViewItem(temp.Sku.ToString());
            lvi.SubItems.Add(temp.Name);
            lvi.SubItems.Add(temp.Category);
            lvi.SubItems.Add(temp.Quantity.ToString());
            lvi.SubItems.Add(temp.Cost.ToString());
            lvi.SubItems.Add(temp.Price.ToString());

            listView.Items.Add(lvi);
        }

        private void RefreshListView()
        {
            foreach (Record item in list)
            {
                ListViewItem lvi = new ListViewItem(item.Sku.ToString());
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Category);
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Cost.ToString());
                lvi.SubItems.Add(item.Price.ToString());

                listView.Items.Add(lvi);
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
    }
}
