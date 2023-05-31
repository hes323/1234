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
    public partial class DashBoardControl : UserControl
    {
        public DashBoardControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void ChangeColor(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showHome();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setName(string firstName, string lastName)
        {
            fullNameLabel.Text = firstName + " " + lastName;
        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.LogoutUser();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showExplore();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showMen();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showLadies();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showKid();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showCart();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
