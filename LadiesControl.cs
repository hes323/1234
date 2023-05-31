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
    public partial class LadiesControl : UserControl
    {
        public LadiesControl()
        {
            InitializeComponent();
        }

        private void LadiesControl_Load(object sender, EventArgs e)
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.addItemToCard(pictureBox9.BackgroundImage, item8Name.Text, item8Price.Text);
            }
        }
    }
}
