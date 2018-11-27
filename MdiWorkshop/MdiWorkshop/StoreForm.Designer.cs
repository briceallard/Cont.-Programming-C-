namespace MdiWorkshop
{
    partial class StoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.LBL_StoreName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listView = new System.Windows.Forms.ListView();
            this.SKU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LBL_TotalItems = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LBL_TotalCost = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LBL_TotalPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BTN_Edit = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTN_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTN_Insert = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTN_Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // LBL_StoreName
            // 
            this.LBL_StoreName.Location = new System.Drawing.Point(133, 27);
            this.LBL_StoreName.Name = "LBL_StoreName";
            this.LBL_StoreName.Size = new System.Drawing.Size(197, 16);
            this.LBL_StoreName.TabIndex = 2;
            this.LBL_StoreName.Text = "No Store Selected";
            this.LBL_StoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SKU,
            this.Item,
            this.Category,
            this.Quantity,
            this.Cost,
            this.Price});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(12, 134);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(763, 372);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // SKU
            // 
            this.SKU.Text = "SKU";
            this.SKU.Width = 131;
            // 
            // Item
            // 
            this.Item.Text = "Item Name";
            this.Item.Width = 200;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 173;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 77;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 81;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 95;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(367, 27);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(118, 16);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Total Items:";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 27);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 16);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Store Name:";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(365, 57);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(118, 16);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Total Cost:";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(365, 87);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(118, 16);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Total Price:";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_TotalItems
            // 
            this.LBL_TotalItems.Location = new System.Drawing.Point(491, 27);
            this.LBL_TotalItems.Name = "LBL_TotalItems";
            this.LBL_TotalItems.Size = new System.Drawing.Size(197, 16);
            this.LBL_TotalItems.TabIndex = 8;
            this.LBL_TotalItems.Text = "0";
            this.LBL_TotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_TotalCost
            // 
            this.LBL_TotalCost.Location = new System.Drawing.Point(489, 57);
            this.LBL_TotalCost.Name = "LBL_TotalCost";
            this.LBL_TotalCost.Size = new System.Drawing.Size(197, 16);
            this.LBL_TotalCost.TabIndex = 9;
            this.LBL_TotalCost.Text = "$0";
            this.LBL_TotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_TotalPrice
            // 
            this.LBL_TotalPrice.Location = new System.Drawing.Point(489, 87);
            this.LBL_TotalPrice.Name = "LBL_TotalPrice";
            this.LBL_TotalPrice.Size = new System.Drawing.Size(197, 16);
            this.LBL_TotalPrice.TabIndex = 10;
            this.LBL_TotalPrice.Text = "$0";
            this.LBL_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BTN_Edit.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BTN_Edit.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BTN_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.Color.Black;
            this.BTN_Edit.Image = global::MdiWorkshop.Properties.Resources.edit;
            this.BTN_Edit.ImagePosition = 10;
            this.BTN_Edit.ImageZoom = 40;
            this.BTN_Edit.LabelPosition = 20;
            this.BTN_Edit.LabelText = "Edit";
            this.BTN_Edit.Location = new System.Drawing.Point(83, 71);
            this.BTN_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(60, 60);
            this.BTN_Edit.TabIndex = 13;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.BTN_Delete.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.BTN_Delete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.Black;
            this.BTN_Delete.Image = global::MdiWorkshop.Properties.Resources.trash;
            this.BTN_Delete.ImagePosition = 10;
            this.BTN_Delete.ImageZoom = 40;
            this.BTN_Delete.LabelPosition = 20;
            this.BTN_Delete.LabelText = "Delete";
            this.BTN_Delete.Location = new System.Drawing.Point(154, 71);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(60, 60);
            this.BTN_Delete.TabIndex = 12;
            // 
            // BTN_Insert
            // 
            this.BTN_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Insert.color = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Insert.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BTN_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Insert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Insert.ForeColor = System.Drawing.Color.Black;
            this.BTN_Insert.Image = global::MdiWorkshop.Properties.Resources.add_circle;
            this.BTN_Insert.ImagePosition = 10;
            this.BTN_Insert.ImageZoom = 40;
            this.BTN_Insert.LabelPosition = 20;
            this.BTN_Insert.LabelText = "Insert";
            this.BTN_Insert.Location = new System.Drawing.Point(12, 71);
            this.BTN_Insert.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Insert.Name = "BTN_Insert";
            this.BTN_Insert.Size = new System.Drawing.Size(60, 60);
            this.BTN_Insert.TabIndex = 11;
            this.BTN_Insert.Click += new System.EventHandler(this.BTN_Insert_Click);
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
            this.BTN_Save.ButtonText = "Save && Exit";
            this.BTN_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.IdleBorderThickness = 1;
            this.BTN_Save.IdleCornerRadius = 20;
            this.BTN_Save.IdleFillColor = System.Drawing.Color.White;
            this.BTN_Save.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.Location = new System.Drawing.Point(592, 507);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(181, 41);
            this.BTN_Save.TabIndex = 14;
            this.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 557);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Insert);
            this.Controls.Add(this.LBL_TotalPrice);
            this.Controls.Add(this.LBL_TotalCost);
            this.Controls.Add(this.LBL_TotalItems);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.LBL_StoreName);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StoreForm";
            this.Text = "Store Form";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel LBL_StoreName;
        private System.Windows.Forms.ColumnHeader SKU;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.ColumnHeader Price;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel LBL_TotalItems;
        private Bunifu.Framework.UI.BunifuCustomLabel LBL_TotalCost;
        private Bunifu.Framework.UI.BunifuCustomLabel LBL_TotalPrice;
        private Bunifu.Framework.UI.BunifuTileButton BTN_Insert;
        private Bunifu.Framework.UI.BunifuTileButton BTN_Delete;
        private Bunifu.Framework.UI.BunifuTileButton BTN_Edit;
        private Bunifu.Framework.UI.BunifuThinButton2 BTN_Save;
        public System.Windows.Forms.ListView listView;
    }
}