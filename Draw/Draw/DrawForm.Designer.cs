namespace Draw
{
    partial class DrawForm
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
            this.PNL_Draw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PNL_Draw
            // 
            this.PNL_Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Draw.Location = new System.Drawing.Point(0, 0);
            this.PNL_Draw.Name = "PNL_Draw";
            this.PNL_Draw.Size = new System.Drawing.Size(740, 618);
            this.PNL_Draw.TabIndex = 0;
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 618);
            this.Controls.Add(this.PNL_Draw);
            this.MaximumSize = new System.Drawing.Size(756, 657);
            this.Name = "DrawForm";
            this.Text = "Draw and Animate Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Draw;
    }
}

