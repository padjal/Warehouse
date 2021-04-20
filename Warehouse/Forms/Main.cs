using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse;

namespace Warehouse
{
	public partial class Main : Form
	{
		int _minStock = 10;
		Warehouse CurrentWarehouse { get; set; }
		public int MinStock
		{
			get => _minStock;
			set => _minStock = value;
		}
	

		public Main()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Add a new item to the warehouse. Opens a new window.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void newItemButton_Click(object sender, EventArgs e)
		{
			//Check if a category is selected.
			if (treeView.SelectedNode == null)
			{
				string message = "Please select a category first";
				string caption = "Attention!";
				MessageBox.Show(message, caption, MessageBoxButtons.OK);
				return;
			}

			AddItem newItemForm = new AddItem();
			var category = treeView.SelectedNode.Tag as Category;
			var node = treeView.SelectedNode;
			while (node != null)
			{
				var cat = node.Tag as Category;
				newItemForm.Category = cat.Name + "/" + newItemForm.Category;
				node = node.Parent;
			}
			newItemForm.Category = newItemForm.Category.Substring(0, newItemForm.Category.Length - 1);

			newItemForm.ShowDialog();
			if (newItemForm.DialogResult == DialogResult.OK)
			{
				category.Products.Add(newItemForm.Product);
				dataGridView.DataSource = category.Bind();
				CurrentWarehouse.Products.Add(newItemForm.Product);
			}


		}

		/// <summary>
		/// Save progres. Json serialization is used.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentWarehouse.ExportJson();
			notification.Text = "You have successfuly saved your warehouse. You may exit now.";
			notification.ShowBalloonTip(1000);
		}

		/// <summary>
		/// Exit the app. Save beforehand.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentWarehouse.ExportJson();
			this.Close();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			CurrentWarehouse = new Warehouse();
			if(File.Exists("categories.json")&& File.Exists("products.json")) {
				using (var sw = new StreamReader("categories.json"))
				{
					CurrentWarehouse.Categories = JsonSerializer.Deserialize<List<Category>>(sw.ReadToEnd());
				}
				using (var sw = new StreamReader("products.json"))
				{
					CurrentWarehouse.Products = JsonSerializer.Deserialize<List<Product>>(sw.ReadToEnd());
				}
				if (CurrentWarehouse.Categories != null)
					DrawNodes(CurrentWarehouse.Categories);
			}
			
		}

		#region Manage Categories
		/// <summary>
		/// Adds a new category to the TreeView.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addCategoryButton_Click(object sender, EventArgs e)
		{
			AddCategory newCategory = new AddCategory();
			newCategory.ShowDialog();
			if (newCategory.DialogResult == DialogResult.OK)
			{
				Category cat = new Category(newCategory.Name);
				var newNode = new TreeNode(newCategory.Name);
				newNode.Tag = cat;

				//Check if category exist

				//If this is a top-level category
				if (treeView.SelectedNode == null)
				{
					CurrentWarehouse.Categories.Add(cat);
					treeView.Nodes.Add(newNode);
					return;
				}

				//If this is a child-level category
				Category parentCat = treeView.SelectedNode.Tag as Category;
				parentCat.SubCategories.Add(cat);
				treeView.SelectedNode.Nodes.Add(newNode);
				treeView.SelectedNode.Expand();
				treeView.SelectedNode = null;
			}
		}

		/// <summary>
		/// Edits a category.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editCategoryButton_Click(object sender, EventArgs e)
		{
			if (treeView.SelectedNode != null)
			{
				var cat = treeView.SelectedNode.Tag as Category;
				AddCategory newCategory = new AddCategory();
				newCategory.Name = treeView.SelectedNode.Text;
				newCategory.ShowDialog();
				if (newCategory.DialogResult == DialogResult.OK)
				{
					treeView.SelectedNode.Text = newCategory.Name;
					cat.Name = newCategory.Name;
				}
			}
		}

		/// <summary>
		/// Removes a category.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteCategoryButton_Click(object sender, EventArgs e)
		{
			if (treeView.SelectedNode != null)
			{
				var cat = treeView.SelectedNode.Tag as Category;
				//It is a first-level category
				if (treeView.SelectedNode.Parent == null)
				{
					CurrentWarehouse.Categories.
						Remove(CurrentWarehouse.Categories.
							Find(x => x.Name == treeView.SelectedNode.Text));
					foreach (var pr in cat.Products)
					{
						CurrentWarehouse.Products.Remove(
							CurrentWarehouse.Products.Find(x => x.Name == pr.Name));
					}
				}
				else
				{
					var parentCat = treeView.SelectedNode.Parent.Tag as Category;
					parentCat.SubCategories.
						Remove(CurrentWarehouse.Categories.
							Find(x => x.Name == treeView.SelectedNode.Text));
					foreach (var pr in cat.Products)
					{
						CurrentWarehouse.Products.Remove(
							CurrentWarehouse.Products.Find(x => x.Name == pr.Name));
					}

				}
				dataGridView.Refresh();
				treeView.SelectedNode.Remove();
			}
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (treeView.SelectedNode != null)
			{
				var cat = treeView.SelectedNode.Tag as Category;
				dataGridView.DataSource = cat.Bind();
				dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			}
		}

		private void treeView_Click(object sender, EventArgs e)
		{
		}

		private void treeView_MouseClick(object sender, MouseEventArgs e)
		{
			treeView.SelectedNode = null;
		}
		#endregion

		internal void DrawNodes(List<Category> categories)
		{
			foreach (var cat in categories)
			{
				var tn = new TreeNode(cat.Name);
				tn.Tag = cat;
				if (cat.SubCategories != null)
					AddChildren(cat.SubCategories, tn);

				treeView.Nodes.Add(tn);
			}
		}

		internal void AddChildren(List<Category> categories, TreeNode parent)
		{
			foreach (var cat in categories)
			{
				var tn = new TreeNode(cat.Name);
				tn.Tag = cat;
				if (cat.SubCategories != null)
					AddChildren(cat.SubCategories, tn);

				parent.Nodes.Add(tn);
			}
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			CurrentWarehouse.ExportJson();
		}

		/// <summary>
		/// Edit produst. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void editProductButton_Click(object sender, EventArgs e)
		{

			//Check if a product is selected.
			if (dataGridView.SelectedRows == null)
			{
				string message = "Please select a product first";
				string caption = "Attention!";
				MessageBox.Show(message, caption, MessageBoxButtons.OK);
				return;
			}
			var selectedProduct = dataGridView.SelectedRows[0].DataBoundItem as Product;
			AddItem newItemForm = new AddItem();
			newItemForm.Product = selectedProduct;

			newItemForm.ShowDialog();
			if (newItemForm.DialogResult == DialogResult.OK)
			{
				selectedProduct = newItemForm.Product;
				dataGridView.Refresh();
			}
		}

		/// <summary>
		/// Export to CSV.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentWarehouse.ExportCSVReport(MinStock);
		}

		/// <summary>
		/// Opens up the settings form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var settings = new Settings();
			settings.MinStock = MinStock;
			settings.ShowDialog();
			if (settings.DialogResult == DialogResult.OK)
			{
				MinStock = settings.MinStock;
			}
		}

		//End of class
	}
}