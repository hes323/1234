namespace WinFormsApp2.Fragments
{
    partial class ItemDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            itemNameLabel = new Label();
            itemPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(27, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 117);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(198, 25);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(102, 15);
            itemNameLabel.TabIndex = 1;
            itemNameLabel.Text = "qweqeqweqweqw";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Location = new Point(198, 106);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(32, 15);
            itemPriceLabel.TabIndex = 2;
            itemPriceLabel.Text = "P100";
            // 
            // ItemDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(itemPriceLabel);
            Controls.Add(itemNameLabel);
            Controls.Add(pictureBox1);
            Name = "ItemDetails";
            Size = new Size(582, 150);
            Load += ItemDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label itemNameLabel;
        private Label itemPriceLabel;
    }
}
