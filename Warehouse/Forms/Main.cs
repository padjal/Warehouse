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

		Warehouse CurrentWarehouse { get; set; }

		public Main()
		{
			InitializeComponent();
		}

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

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentWarehouse.ExportJson();
			notification.Text = "You have successfuly saved your warehouse. You may exit now.";
			notification.ShowBalloonTip(1000);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentWarehouse.ExportJson();
			this.Close();
		}

		private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//TODO: Check if file exist!
			CurrentWarehouse = new Warehouse();
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
			//TODO: Edit all products.
		}

		/// <summary>
		/// Removes a category.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteCategoryButton_Click(object sender, EventArgs e)
		{
			//TODO: Check if empty
			if (treeView.SelectedNode != null)
			{
				var cat = treeView.SelectedNode.Tag as Category;
				//It is a first-level category
				if (treeView.Parent == null)
				{
					CurrentWarehouse.Categories.
						Remove(CurrentWarehouse.Categories.
							Find(x => x.Name == treeView.SelectedNode.Text));
				}
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
			//TODO: Figure out how to deselect a node!
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

		private void editProductButton_Click(object sender, EventArgs e)
		{
			//Check if a category is selected.
			/*if (dataGridView.SelectedRows[0]. == null)
			{
				string message = "Please select a category first";
				string caption = "Attention!";
				MessageBox.Show(message, caption, MessageBoxButtons.OK);
				return;
			}*/

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

		//End of class
	}
}