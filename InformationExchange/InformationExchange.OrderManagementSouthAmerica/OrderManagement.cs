using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationExchange.OrderManagementSouthAmerica.DataAccess;

namespace InformationExchange.OrderManagementSouthAmerica
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var oc = new OrdersContainer();
            orderBindingSource.DataSource = oc.Orders.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var orderForm = new OrderForm())
            {
                orderForm.ShowDialog();

                if (orderForm.Order != null)
                {
                    orderBindingSource.Add(orderForm.Order);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var order = orderBindingSource.Current as Order;
            if (order == null) return;
            var oc = new OrdersContainer();
            var existingOrder = oc.Orders.Find(order.Id);
            if (existingOrder != null)
            {
                oc.Orders.Remove(existingOrder);
                oc.SaveChanges();
                orderBindingSource.Remove(order);
            }
        }
    }
}
