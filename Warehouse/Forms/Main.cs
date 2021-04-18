using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
				MessageBox.Show(message,caption, MessageBoxButtons.OK);
				return;
			}
				AddItem newItemForm = new AddItem();
				newItemForm.Category = (Category)treeView.SelectedNode.Tag;
				newItemForm.Show();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//TODO: Save warehouse
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//TODO: SAVE!
			this.Close();
		}

		private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.Show();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			CurrentWarehouse = new Warehouse();
			//Check for previous save; if not
			//InitializeTreeView();
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
				AddCategory newCategory = new AddCategory();
				newCategory.Name = treeView.SelectedNode.Text;
				newCategory.ShowDialog();
				if (newCategory.DialogResult == DialogResult.OK)
				{
					treeView.SelectedNode.Text = newCategory.Name;
					var cat = treeView.SelectedNode.Tag as Category;
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
			//TODO: Handle products display change.
			if (treeView.SelectedNode != null) {
				var cat = treeView.SelectedNode.Tag as Category;
				dataGridView.DataSource = cat.Bind();
			}
		}
		#endregion

		//End of class
	}
}


