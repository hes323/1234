using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void getInformationRegister()
        {


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string firstName = firstNameBox.Text;
            string middleName = middleNameBox.Text;
            string lastName = lastNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;

            var parent = this.Parent as Form1;
            if (parent != null)
            {
                parent.RegisterUser(firstName, middleName, lastName, email, password, confirmPassword);
                ClearAllTextBox();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form1;

            if (parent != null)
            {
                parent.showLoginForm();
                
            }
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {

        }

        public void ClearAllTextBox()
        {
            firstNameBox.Text = "";
            middleNameBox.Text = "";
            lastNameBox.Text = "";
            emailBox.Text = "";
            passwordBox.Text = "";
            confirmPasswordBox.Text = "";
        }
    }
}
