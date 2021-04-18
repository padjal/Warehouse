using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
	public partial class AddCategory : Form
	{
		public string Name { get; set; }
		public AddCategory()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Receives user input data for new category name.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addCategoryButton_Click(object sender, EventArgs e)
		{
			if (newCategoryName.Text == String.Empty) {
				warningMessage.Visible = true;
				return;
			}	
			Name = newCategoryName.Text;
			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
