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
    public partial class ItemDetails : UserControl
    {
        public ItemDetails()
        {
            InitializeComponent();
        }

        private int price = 0;

        public int Price { get { return price; } set {  price = value; } }

        private void ItemDetails_Load(object sender, EventArgs e)
        {

        }

        public void setItemDetails(Image image, string itemName, string itemPrice)
        {

            pictureBox1.BackgroundImage = image;
            itemNameLabel.Text = itemName;
            itemPriceLabel.Text = itemPrice;
            price = Convert.ToInt32(itemPrice);
        }
    }
}
