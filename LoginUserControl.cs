using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Fragments
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            var parent = this.Parent as Form1;

            if (parent != null)
            {
                parent.LoginUser(email, password);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent = this.Parent as Form1;

            if (parent != null)
            {
                parent.showRegisterForm();
                ClearAllTextBox();
            }
        }

        public void ClearAllTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
