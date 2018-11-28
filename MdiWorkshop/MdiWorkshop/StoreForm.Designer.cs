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
            this.listView = new System.Windows.Forms.ListView();
            this.SKU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Edit = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTN_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTN_Insert = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTN_Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CB_Sort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowColumnReorder = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SKU,
            this.Item,
            this.Category,
            this.Quantity,
            this.Cost,
            this.Price});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(12, 72);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(696, 372);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // SKU
            // 
            this.SKU.Text = "SKU";
            this.SKU.Width = 102;
            // 
            // Item
            // 
            this.Item.Text = "Item Name";
            this.Item.Width = 171;
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
            this.Price.Width = 87;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BTN_Edit.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BTN_Edit.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BTN_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.Color.Black;
            this.BTN_Edit.Image = global::MdiWorkshop.Properties.Resources.edit;
            this.BTN_Edit.ImagePosition = 10;
            this.BTN_Edit.ImageZoom = 40;
            this.BTN_Edit.LabelPosition = 20;
            this.BTN_Edit.LabelText = "Edit";
            this.BTN_Edit.Location = new System.Drawing.Point(88, 9);
            this.BTN_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(61, 60);
            this.BTN_Edit.TabIndex = 13;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.BTN_Delete.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.BTN_Delete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete.ForeColor = System.Drawing.Color.Black;
            this.BTN_Delete.Image = global::MdiWorkshop.Properties.Resources.trash;
            this.BTN_Delete.ImagePosition = 10;
            this.BTN_Delete.ImageZoom = 40;
            this.BTN_Delete.LabelPosition = 20;
            this.BTN_Delete.LabelText = "Delete";
            this.BTN_Delete.Location = new System.Drawing.Point(647, 9);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(61, 60);
            this.BTN_Delete.TabIndex = 12;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Insert
            // 
            this.BTN_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Insert.color = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Insert.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BTN_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Insert.ForeColor = System.Drawing.Color.Black;
            this.BTN_Insert.Image = global::MdiWorkshop.Properties.Resources.add_circle;
            this.BTN_Insert.ImagePosition = 10;
            this.BTN_Insert.ImageZoom = 40;
            this.BTN_Insert.LabelPosition = 20;
            this.BTN_Insert.LabelText = "Insert";
            this.BTN_Insert.Location = new System.Drawing.Point(12, 9);
            this.BTN_Insert.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Insert.Name = "BTN_Insert";
            this.BTN_Insert.Size = new System.Drawing.Size(61, 60);
            this.BTN_Insert.TabIndex = 11;
            this.BTN_Insert.Click += new System.EventHandler(this.BTN_Insert_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.ActiveBorderThickness = 1;
            this.BTN_Save.ActiveCornerRadius = 20;
            this.BTN_Save.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.ActiveForecolor = System.Drawing.Color.Black;
            this.BTN_Save.ActiveLineColor = System.Drawing.Color.Black;
            this.BTN_Save.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Save.BackgroundImage")));
            this.BTN_Save.ButtonText = "Save && Exit";
            this.BTN_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.IdleBorderThickness = 1;
            this.BTN_Save.IdleCornerRadius = 20;
            this.BTN_Save.IdleFillColor = System.Drawing.Color.White;
            this.BTN_Save.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.BTN_Save.Location = new System.Drawing.Point(526, 452);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(182, 41);
            this.BTN_Save.TabIndex = 14;
            this.BTN_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // CB_Sort
            // 
            this.CB_Sort.FormattingEnabled = true;
            this.CB_Sort.Items.AddRange(new object[] {
            "SKU",
            "Item Name",
            "Category",
            "Quantity",
            "Cost",
            "Price"});
            this.CB_Sort.Location = new System.Drawing.Point(12, 450);
            this.CB_Sort.Name = "CB_Sort";
            this.CB_Sort.Size = new System.Drawing.Size(121, 24);
            this.CB_Sort.TabIndex = 15;
            this.CB_Sort.Text = "Sort By:";
            this.CB_Sort.SelectedIndexChanged += new System.EventHandler(this.CB_Sort_OnChangeEvent);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 500);
            this.Controls.Add(this.CB_Sort);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Insert);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StoreForm";
            this.Text = "Store Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoreForm_FormClosing);
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader SKU;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.ColumnHeader Price;
        private Bunifu.Framework.UI.BunifuTileButton BTN_Insert;
        private Bunifu.Framework.UI.BunifuTileButton BTN_Delete;
        private Bunifu.Framework.UI.BunifuTileButton BTN_Edit;
        private Bunifu.Framework.UI.BunifuThinButton2 BTN_Save;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox CB_Sort;
    }
}