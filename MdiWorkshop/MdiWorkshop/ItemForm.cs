﻿/**
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
    /// Form to create new item and add it to the list (database perse)
    /// </summary>
    public partial class ItemForm : Form
    {
        public Record record;

        public ItemForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Stores data after form validation checks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                }
                catch (Exception error) // Uh oh!
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

        // Close form
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
