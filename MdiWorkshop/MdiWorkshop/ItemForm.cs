using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MdiWorkshop
{
    public partial class ItemForm : Form
    {
        public List<Record> _list = new List<Record>();

        public ItemForm(List<Record> list)
        {
            InitializeComponent();

            _list = list;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Record record = new Record
                {
                    Sku = Int32.Parse(TB_Sku.Text),
                    Name = TB_Name.Text,
                    Category = TB_Category.Text,
                    Quantity = Int32.Parse(TB_Quantity.Text),
                    Cost = Double.Parse(TB_Cost.Text),
                    Price = Double.Parse(TB_Price.Text),
                    storeName = Utilities.STORE_NAME
                };
                
                _list.Add(record);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                    Utilities.ERROR_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
