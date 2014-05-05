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
	public partial class OrderForm : Form
	{
		public Order Order { get; set; }

		public OrderForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			var oc = new OrdersContainer();
			countryBindingSource.DataSource = oc.Countries.ToList();
			userBindingSource.DataSource = oc.Users.ToList();
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
			if (cbUser.SelectedItem == null)
			{
				MessageBox.Show("User is empty");
				return;
			}

			var oc = new OrdersContainer();
			var country = cbCountries.SelectedItem as Country;
			if (country != null)
			{
				var existingCountry = oc.Countries.Find(country.Code);

				var order = new Order
					{
						Name = txtName.Text,
						Items = Int32.Parse(txtItems.Text),
						Value = Decimal.Parse(txtValue.Text),
						Country = existingCountry,
						UserId = ((User)cbUser.SelectedItem).Id
					};




				oc.Orders.Add(order);
				oc.SaveChanges();

				Order = order;
			}

			Close();
		}
	}
}

