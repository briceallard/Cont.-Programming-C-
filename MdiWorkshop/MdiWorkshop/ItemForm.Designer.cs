namespace MdiWorkshop
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_Sku = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TB_Name = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TB_Cost = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TB_Price = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TB_Category = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.BTN_Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TB_Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(75, 27);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "SKU:";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Quantity);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.TB_Category);
            this.groupBox1.Controls.Add(this.TB_Price);
            this.groupBox1.Controls.Add(this.TB_Cost);
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.TB_Sku);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Item";
            // 
            // TB_Sku
            // 
            this.TB_Sku.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_Sku.Location = new System.Drawing.Point(87, 32);
            this.TB_Sku.Name = "TB_Sku";
            this.TB_Sku.Size = new System.Drawing.Size(154, 27);
            this.TB_Sku.TabIndex = 1;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(6, 207);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(75, 27);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Price:";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(6, 172);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(75, 27);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "Cost:";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 102);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(75, 27);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Category:";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 67);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(75, 27);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Name:";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TB_Name
            // 
            this.TB_Name.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_Name.Location = new System.Drawing.Point(87, 67);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(154, 27);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_Cost
            // 
            this.TB_Cost.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_Cost.Location = new System.Drawing.Point(87, 172);
            this.TB_Cost.Name = "TB_Cost";
            this.TB_Cost.Size = new System.Drawing.Size(154, 27);
            this.TB_Cost.TabIndex = 5;
            // 
            // TB_Price
            // 
            this.TB_Price.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_Price.Location = new System.Drawing.Point(87, 207);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(154, 27);
            this.TB_Price.TabIndex = 6;
            // 
            // TB_Category
            // 
            this.TB_Category.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_Category.Location = new System.Drawing.Point(87, 102);
            this.TB_Category.Name = "TB_Category";
            this.TB_Category.Size = new System.Drawing.Size(154, 27);
            this.TB_Category.TabIndex = 3;
            // 
            // BTN_Save
            // 
            this.BTN_Save.ActiveBorderThickness = 1;
            this.BTN_Save.ActiveCornerRadius = 20;
            this.BTN_Save.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_Save.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Save.BackgroundImage")));
            this.BTN_Save.ButtonText = "Create Item";
            this.BTN_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.BTN_Save.IdleBorderThickness = 1;
            this.BTN_Save.IdleCornerRadius = 20;
            this.BTN_Save.IdleFillColor = System.Drawing.Color.White;
            this.BTN_Save.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.Location = new System.Drawing.Point(100, 264);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(178, 41);
            this.BTN_Save.TabIndex = 7;
            this.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(6, 137);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(75, 27);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Quantity:";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TB_Quantity
            // 
            this.TB_Quantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.TB_Quantity.Location = new System.Drawing.Point(87, 137);
            this.TB_Quantity.Name = "TB_Quantity";
            this.TB_Quantity.Size = new System.Drawing.Size(154, 27);
            this.TB_Quantity.TabIndex = 4;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 309);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TB_Sku;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TB_Category;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TB_Price;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TB_Cost;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TB_Name;
        private Bunifu.Framework.UI.BunifuThinButton2 BTN_Save;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TB_Quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}