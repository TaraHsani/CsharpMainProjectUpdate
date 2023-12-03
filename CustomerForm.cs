using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpProject
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rndNumber = random.Next(minValue: 1, maxValue: 1000);


            Customer customer = new Customer();
           // customer.CreateDate = DateTime.Now;
            customer.FirstName = firstnameLabel.Text;
            customer.LastName = lasatnameTextBox.Text;
            //customer.ID = int.Parse(idLabel.Text);
            customer.Email = emailLabel.Text;


            //var product = new Product
            var customer1 = new Customer()
            {

               // CreateDate = DateTime.Now,
                FirstName = firstnameLabel.Text,
                LastName = lasatnameTextBox.Text,
                //ID = int.Parse(idLabel.Text),
                Email = emailLabel.Text,

            };

        }
    }
}
