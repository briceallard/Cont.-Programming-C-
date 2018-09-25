namespace FindSampleGame
{
    partial class GridSizeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonClr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Grid Size:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(99, 10);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(30, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(153, 10);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(30, 20);
            this.textBoxY.TabIndex = 4;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(16, 36);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(113, 23);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Must not exceed 10 X 10";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonClr
            // 
            this.ButtonClr.Location = new System.Drawing.Point(138, 35);
            this.ButtonClr.Name = "ButtonClr";
            this.ButtonClr.Size = new System.Drawing.Size(45, 24);
            this.ButtonClr.TabIndex = 7;
            this.ButtonClr.Text = "CLR";
            this.ButtonClr.UseVisualStyleBackColor = true;
            this.ButtonClr.Click += new System.EventHandler(this.ButtonClr_Click);
            // 
            // GridSizeForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 91);
            this.Controls.Add(this.ButtonClr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Name = "GridSizeForm";
            this.Text = "The Game of Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonClr;
    }
}

