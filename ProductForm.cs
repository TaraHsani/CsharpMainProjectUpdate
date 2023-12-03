using CsharpProject.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace CsharpProject
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(countLextBox.Text) || string.IsNullOrEmpty(priceTextBox.Text))
            {

                MessageBox.Show("Pleace inter a valid number");
                return;
            
            
            }



            Product product = new Product(Name: nameTextBox.Text, Price: decimal.Parse(priceTextBox.Text, Count: int.Parse(countLextBox.Text));
            product.Name = nameTextBox.Text;
            product.Price = decimal.Parse(priceTextBox.Text);
            product.Count = int.Parse(countLextBox.Text);
            product.BrandName = brandTextBox.Text;
            product.CreationDate = DateTime.Now;


            var product2 = new Product()

            {


                Name = nameTextBox.Text,
                Price = decimal.Parse(priceTextBox.Text),
                Count = int.Parse(countLextBox.Text),
                BrandName = brandTextBox.Text,
                //CreationDate = DateTime.Now,


            };

        }
    }
}