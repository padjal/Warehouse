using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
	public partial class AddItem : Form
	{
		internal string Category { get; set; }
		internal Product Product { get; set; }

		public AddItem()
		{
			InitializeComponent();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addProductButton_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				string message = "Please check input fields";
				string caption = "Attention!";
				MessageBox.Show(message, caption, MessageBoxButtons.OK);
				return;
			}
			else
			{
				if (Product != null)
				{
					Product.Name = productName.Text;
					Product.Id = idMaskedText.Text;
					Product.Description = productDescription.Text;
					Product.Price = double.Parse(productPrice.Text);
					Product.Stock = int.Parse(productInStock.Text);
				}
				else
				{
					var product = new Product(
						productName.Text,
						idMaskedText.Text,
						productDescription.Text,
						double.Parse(productPrice.Text),
						int.Parse(productInStock.Text),
						Category);
					Product = product;
				}

				DialogResult = DialogResult.OK;
				Close();

			}
		}

		/// <summary>
		/// All these methods are handlers of the validating control event and
		/// are used to verify user input while entering data for the new product.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		#region Validating user input
		private void idMaskedText_Validating(object sender, CancelEventArgs e)
		{
			if (idMaskedText.Text == string.Empty)
			{
				errorProvider.SetError(idMaskedText, "This field is required.");
				e.Cancel = true;
			}
		}

		private void productName_Validating(object sender, CancelEventArgs e)
		{
			if (productName.Text == string.Empty)
			{
				errorProvider.SetError(productName, "This field is required.");
				e.Cancel = true;
			}
		}

		private void productDescription_Validating(object sender, CancelEventArgs e)
		{
			if (productDescription.Text == string.Empty)
			{
				errorProvider.SetError(productDescription, "This field is required.");
				e.Cancel = true;
			}
		}

		private void productPrice_Validating(object sender, CancelEventArgs e)
		{
			if (productPrice.Text == string.Empty)
			{
				errorProvider.SetError(productPrice, "This field is required.");
				e.Cancel = true;
			}
			if (!double.TryParse(productPrice.Text, out double res))
			{
				errorProvider.SetError(productPrice, "Price should be a number!");
				e.Cancel = true;
			}

		}

		private void productInStock_Validating(object sender, CancelEventArgs e)
		{
			if (productInStock.Text == string.Empty)
			{
				errorProvider.SetError(productInStock, "This field is required.");
			}
			if (!int.TryParse(productInStock.Text, out int res))
			{
				errorProvider.SetError(productInStock, "Availability should be an integer number!");
			}
		}
		#endregion

		private void AddItem_Load(object sender, EventArgs e)
		{
			//Populate data for editing
			if (Product != null)
			{
				productName.Text = Product.Name;
				idMaskedText.Text = Product.Id;
				productDescription.Text = Product.Description;
				productPrice.Text = Product.Price.ToString();
				productInStock.Text = Product.Stock.ToString();
			}
		}
	}
}
