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
	public partial class Settings : Form
	{
		public int MinStock { get; set; }
		public Settings()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Changes the value of MinStock to the selected in the numeric TopDown.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void changeButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			MinStock = (int)numericUpDown.Value;
			Close();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			numericUpDown.Value = MinStock;
		}
	}
}
