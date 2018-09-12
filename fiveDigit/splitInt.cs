/* Brice Allard
 * CMPS 4143: Contemporary Programming Languages
 * September 5th, 2018
 * Dr. Stringfellow
 * Description: Console Application that reads numerical input from
 *  user and displays it back seperated by individual digits. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class SplitInt : Form
    {
        public SplitInt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] numInput = textBox1.Text.ToCharArray();
            int length = numInput.Length;

            if (length > 5)
            {
                MessageBox.Show("Integer too long!\nPlease enter no more than 5 digits ...");
            }
            else if (length >= 1 && length <= 5)
            {
                var outString = string.Join("   ", numInput);
                textBox2.Text = (outString);
            }
            else if (length < 1)
            {
                MessageBox.Show("Enter a valid integer!");
            }
        }
    }
}
