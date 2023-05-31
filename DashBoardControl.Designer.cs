namespace WinFormsApp2
{
    partial class DashBoardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardControl));
            panel1 = new Panel();
            button11 = new Button();
            fullNameLabel = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button10 = new Button();
            button5 = new Button();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(fullNameLabel);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 47);
            panel1.TabIndex = 0;
            // 
            // button11
            // 
            button11.Location = new Point(569, 12);
            button11.Name = "button11";
            button11.Size = new Size(86, 27);
            button11.TabIndex = 4;
            button11.Text = "Cart";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameLabel.Location = new Point(236, 14);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(113, 21);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Hesper Dumali";
            fullNameLabel.Click += fullNameLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(719, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = " search";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(214, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 444);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 255);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 499);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(60, 447);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 12;
            button10.Text = "Logout";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(48, 139);
            button5.Name = "button5";
            button5.Size = new Size(104, 23);
            button5.TabIndex = 11;
            button5.Text = "New member";
            button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(19, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 115);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(60, 391);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Messages";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(60, 331);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Product";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(60, 269);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(60, 204);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseHover += ChangeColor;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources._1;
            pictureBox4.Location = new Point(437, 130);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 275);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources._2;
            pictureBox5.Location = new Point(597, 130);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(154, 275);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources._3;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(757, 130);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(154, 275);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(443, 73);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 11;
            button6.Text = "Explore";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(580, 73);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 12;
            button7.Text = "Men";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(712, 73);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 13;
            button8.Text = "Ladies";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(832, 73);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 14;
            button9.Text = "Kids";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // DashBoardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashBoardControl";
            Size = new Size(954, 499);
            Load += DashBoardControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label fullNameLabel;
        private Button button10;
        private Button button11;
    }
}
