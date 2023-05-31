namespace WinFormsApp2.Fragments
{
    partial class CartControl
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
            panel1 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            totalAmountLabel = new Label();
            priceLabel = new Label();
            button2 = new Button();
            label1 = new Label();
            totalItemLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 36);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(841, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.CLOTHING_SHOP;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 38);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(175, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(582, 445);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new Point(772, 399);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(83, 15);
            totalAmountLabel.TabIndex = 5;
            totalAmountLabel.Text = "Total amount: ";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(861, 399);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(38, 15);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(802, 424);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Check out";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(772, 375);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 8;
            label1.Text = "Total items:";
            label1.Click += label1_Click;
            // 
            // totalItemLabel
            // 
            totalItemLabel.AutoSize = true;
            totalItemLabel.Location = new Point(861, 375);
            totalItemLabel.Name = "totalItemLabel";
            totalItemLabel.Size = new Size(38, 15);
            totalItemLabel.TabIndex = 9;
            totalItemLabel.Text = "label1";
            // 
            // CartControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalItemLabel);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(priceLabel);
            Controls.Add(totalAmountLabel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "CartControl";
            Size = new Size(931, 479);
            Load += Cart_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label totalAmountLabel;
        private Label priceLabel;
        private Button button2;
        private Label label1;
        private Label totalItemLabel;
    }
}
