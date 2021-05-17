using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Classes
{
	[Flags]
	enum Status
	{
		Processed,
		Paid,
		Shipped,
		Completed,
	}

	class Order
	{
		public List<Product> Cart { get; set; }
		public int Qty => Cart.Count;

		public double Price { get; set; }

		public int Number { get; set; }

		public DateTime Date { get; set; }
		public Status Status { get; set; }
		public Client Client { get; set; }

	}
}
