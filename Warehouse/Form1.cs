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
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void newItemButton_Click(object sender, EventArgs e)
		{
			AddItem newItemForm = new AddItem();
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
	}
}
