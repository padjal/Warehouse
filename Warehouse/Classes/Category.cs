using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
	class Category
	{
		private List<Product> _products = new List<Product>();
		private List<Category> _subcategories = new List<Category>();
		public string Name { get; set; }

		public List<Product> Products
		{
			get => _products;
			set => _products = value;
		}
		public List<Category> SubCategories
		{
			get => _subcategories;
			set => _subcategories = value;
		}
		public Category(string name)
		{
			Name = name;
		}

		public BindingSource Bind()
		{

			var bindsrc = new BindingSource();

			foreach (var pr in Products)
			{
				bindsrc.Add(pr);
			}
			if (_subcategories != null) {
				foreach (var subcat in _subcategories) {
					BindSubProducts(bindsrc, subcat);
				}
				
			}
			return bindsrc;
		}

		public void BindSubProducts(BindingSource bs, Category cat) {
			foreach (var pr in cat.Products)
			{
				bs.Add(pr);
			}
			if (cat.SubCategories != null)
			{
				foreach (var subcat in cat.SubCategories)
				{
					BindSubProducts(bs, subcat);
				}

			}
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
