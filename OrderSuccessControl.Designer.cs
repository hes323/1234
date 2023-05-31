namespace WinFormsApp2
{
    partial class OrderSuccessControl
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
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.CLOTHING_SHOP;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.CLOTHING_SHOP;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 41);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(215, 7);
            button1.Name = "button1";
            button1.Size = new Size(153, 20);
            button1.TabIndex = 6;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(122, 72);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 7;
            label1.Text = "Order Success !!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.check;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(112, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 119);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(127, 309);
            button3.Name = "button3";
            button3.Size = new Size(110, 29);
            button3.TabIndex = 10;
            button3.Text = "BACK TO HOME";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(149, 362);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 13);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "view reciept";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 248);
            label2.Name = "label2";
            label2.Size = new Size(0, 13);
            label2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 257);
            label3.Name = "label3";
            label3.Size = new Size(191, 26);
            label3.TabIndex = 13;
            label3.Text = "Your shipping info: (+63)94******21.\r\n Basak pardo Cebu CityPhilippines\r\n";
            // 
            // OrderSuccessControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "OrderSuccessControl";
            Size = new Size(377, 415);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
    }
}
