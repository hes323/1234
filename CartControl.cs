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
    public partial class CartControl : UserControl
    {
        public CartControl()
        {
            InitializeComponent();
        }

        int totalAmount = 0;
        int totalItem = 0;

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        public void addItemCart(Image image, string itemName, string itemPrice)
        {
            ItemDetails newItemDetails = new ItemDetails();

            newItemDetails.setItemDetails(image, itemName, itemPrice);
            
            flowLayoutPanel1.Controls.Add(newItemDetails);

            foreach(ItemDetails it  in flowLayoutPanel1.Controls) { 
                totalAmount+= it.Price;
                totalItem++;
            }
            
            priceLabel.Text = Convert.ToString(totalAmount);
            totalItemLabel.Text = Convert.ToString(totalItem);
            totalAmount = 0;
            totalItem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form2;

            if (parent != null)
            {
                parent.showHome();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
