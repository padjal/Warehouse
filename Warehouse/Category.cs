﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
	class Category
	{
		private List<Product> _products = new List<Product>();
		private List<Category> _subcategories= new List<Category>();
		public string Name { get; set; }

		public List<Product> Products { 
			get => _products; 
			set => _products = value; 
		}
		public List<Category> SubCategories {
			get => _subcategories;
			set => _subcategories = value;
		}
		public Category(string name) {
			Name = name;
		}
	}
}