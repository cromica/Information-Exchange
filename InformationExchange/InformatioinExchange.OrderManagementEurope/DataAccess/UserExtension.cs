using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.OrderManagementEurope.DataAccess
{
	public partial class User
	{
		public override string ToString()
		{
			return this.UserName;
		}
	}
}
