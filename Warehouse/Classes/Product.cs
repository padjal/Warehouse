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
		public string Id { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int Stock { get; set; }

		public Category Category { get; set; }

		public Product(string name, string id, string description, double price, int stock, Category category) {
			Name = name;
			Id = id;
			Description = description;
			Price = price;
			Stock = stock;
			Category = category;
		}
	}
}
