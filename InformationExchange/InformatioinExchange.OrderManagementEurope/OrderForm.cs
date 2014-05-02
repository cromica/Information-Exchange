using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationExchange.OrderManagementEurope.DataAccess;

namespace InformationExchange.OrderManagementEurope
{
    public partial class OrderForm : Form
    {
        public Order Order { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtItems.Text))
            {
                MessageBox.Show("Items is empty");
                return;
            }
            if (string.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Value is empty");
                return;
            }
            if (cbCountries.SelectedItem == null)
            {
                MessageBox.Show("Country is empty");
                return;
            }

            var order = new Order
                {
                    Name = txtName.Text,
                    Items = Int32.Parse(txtItems.Text),
                    Value = Decimal.Parse(txtValue.Text),
                    Country = cbCountries.SelectedItem.ToString()
                };

            var oc = new OrdersContainer();
            oc.Orders.Add(order);
            oc.SaveChanges();

            Order = order;

            Close();
        }
    }
}
