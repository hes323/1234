namespace WinFormsApp2
{
    partial class RegisterControl
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
            label1 = new Label();
            emailBox = new TextBox();
            label2 = new Label();
            passwordBox = new TextBox();
            label3 = new Label();
            confirmPasswordBox = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            firstNameBox = new TextBox();
            label5 = new Label();
            middleNameBox = new TextBox();
            label6 = new Label();
            lastNameBox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 205);
            label1.Name = "label1";
            label1.Size = new Size(83, 13);
            label1.TabIndex = 0;
            label1.Text = "Email Adsdress";
            label1.UseWaitCursor = true;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(70, 222);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(178, 23);
            emailBox.TabIndex = 1;
            emailBox.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 261);
            label2.Name = "label2";
            label2.Size = new Size(56, 13);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.UseWaitCursor = true;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(70, 280);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(178, 23);
            passwordBox.TabIndex = 3;
            passwordBox.UseWaitCursor = true;
            passwordBox.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 324);
            label3.Name = "label3";
            label3.Size = new Size(100, 13);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            label3.UseWaitCursor = true;
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.Location = new Point(70, 343);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.Size = new Size(178, 23);
            confirmPasswordBox.TabIndex = 5;
            confirmPasswordBox.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(57, 387);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(203, 17);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Check the box before you regester";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(102, 417);
            button1.Name = "button1";
            button1.Size = new Size(97, 41);
            button1.TabIndex = 7;
            button1.Text = "REGESTER";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 40);
            label4.Name = "label4";
            label4.Size = new Size(58, 13);
            label4.TabIndex = 8;
            label4.Text = "Full Name";
            label4.UseWaitCursor = true;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(70, 56);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(178, 23);
            firstNameBox.TabIndex = 9;
            firstNameBox.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(70, 93);
            label5.Name = "label5";
            label5.Size = new Size(75, 13);
            label5.TabIndex = 10;
            label5.Text = "Middle Name";
            label5.UseWaitCursor = true;
            // 
            // middleNameBox
            // 
            middleNameBox.Location = new Point(70, 109);
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Size = new Size(178, 23);
            middleNameBox.TabIndex = 11;
            middleNameBox.UseWaitCursor = true;
            middleNameBox.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(72, 145);
            label6.Name = "label6";
            label6.Size = new Size(59, 13);
            label6.TabIndex = 12;
            label6.Text = "Last Name";
            label6.UseWaitCursor = true;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(70, 161);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(178, 23);
            lastNameBox.TabIndex = 13;
            lastNameBox.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            Controls.Add(button2);
            Controls.Add(lastNameBox);
            Controls.Add(label6);
            Controls.Add(middleNameBox);
            Controls.Add(label5);
            Controls.Add(firstNameBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(confirmPasswordBox);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(emailBox);
            Controls.Add(label1);
            Name = "RegisterControl";
            Size = new Size(364, 473);
            UseWaitCursor = true;
            Load += RegisterControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailBox;
        private Label label2;
        private TextBox passwordBox;
        private Label label3;
        private TextBox confirmPasswordBox;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
        private TextBox firstNameBox;
        private Label label5;
        private TextBox middleNameBox;
        private Label label6;
        private TextBox lastNameBox;
        private Button button2;
    }
}
