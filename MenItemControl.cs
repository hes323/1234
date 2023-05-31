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
    public partial class MenItemControl : UserControl
    {
        public MenItemControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashBoardControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showHome();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.addItemToCard(pictureBox7.BackgroundImage, item6Name.Text, item6Price.Text);
            }
        }
    }
}
