using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MdiWorkshop
{
    public partial class ItemForm : Form
    {
        //public List<Record> _list = new List<Record>();
        public Record record;

        public ItemForm()
        {
            InitializeComponent();
            
            //_list = list;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (verifyNoEmptyFields())
            {
                try
                {
                    record = new Record
                    {
                        Sku = Int32.Parse(TB_Sku.Text),
                        Name = TB_Name.Text,
                        Category = TB_Category.Text,
                        Quantity = Int32.Parse(TB_Quantity.Text),
                        Cost = Double.Parse(TB_Cost.Text),
                        Price = Double.Parse(TB_Price.Text),
                        storeName = Utilities.STORE_NAME
                    };
                    
                    //_list.Add(record);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        Utilities.ERROR_TITLE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Utilities.MSG_EMPTY_FIELDS,
                        Utilities.ERROR_EMPTY_FIELDS,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

            Close();
        }

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
