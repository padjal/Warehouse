using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
	class Product
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int Stock { get; set; }

		public Product(string name, string description, double price, int stock) { 
		}
	}
}
