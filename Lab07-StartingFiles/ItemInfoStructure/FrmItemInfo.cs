using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Devon Sihra
namespace ItemInfoStructure
{
    public partial class FrmItemInfo : Form
    {
        public FrmItemInfo()
        {
            InitializeComponent();
        }

        List<Item> list = new List<Item>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Item it = new Item();

                it.ItemNumber = int.Parse(txtNumber.Text);
                it.ItemPrice = double.Parse(txtPrice.Text);
                it.ItemDescription = txtDescription.Text;
                list.Add(it);


                txtNumber.Focus();
                txtDescription.Clear();
                txtPrice.Clear();
                txtNumber.Clear();
            }
            catch
            {
                MessageBox.Show("Custom Message");
            }
          

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            StringBuilder display = new StringBuilder("Items");

            foreach(Item temp in list)
            {
               
                display.Append("\n\n Items Number: " + temp.ItemNumber +
                               "\n Item Price: " + temp.ItemPrice +
                               "\nItem Decription: " + temp.ItemDescription);
            }
            MessageBox.Show(display.ToString());
        }
    }
}
