using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Warehouse
{
	class Warehouse
	{
		List<Category> _categories = new List<Category>();
		List<Product> _products = new List<Product>();
		public List<Category> Categories
		{
			get => _categories;
			set => _categories = value;
		}
		public List<Product> Products
		{
			get => _products;
			set => _products = value;
		}

		public void ExportJson()
		{
			using (var sw = new StreamWriter("categories.json"))
			{
				sw.Write(JsonSerializer.Serialize(_categories));
			}

			using (var sw = new StreamWriter("products.json"))
			{
				sw.Write(JsonSerializer.Serialize(Products));
			}
		}

		public void ExportCSVReport(int minInStock) {
			var sb = new StringBuilder();
			sb.AppendLine("Name, Id, Description, Price, Stock, Category");
			foreach (var pr in _products) { 
				if(pr.Stock<=minInStock)
					sb.AppendLine(pr.ToString());
			}

			using (var sr = new StreamWriter(File.Create("report.csv"))) {
				sr.Write(sb);
			}
				
		}

	}
}
