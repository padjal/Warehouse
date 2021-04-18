
namespace Warehouse
{
	partial class AddItem
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addItemImage = new System.Windows.Forms.Button();
			this.itemPriceUpDown = new System.Windows.Forms.NumericUpDown();
			this.itemInStockUpDown = new System.Windows.Forms.NumericUpDown();
			this.showDollarSign = new System.Windows.Forms.Label();
			this.itemImage = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.itemPriceUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInStockUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(145, 269);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(191, 52);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(145, 44);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(525, 27);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 48);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(274, 214);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "In stock:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(82, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price:";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(145, 113);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(296, 88);
			this.textBox2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 113);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Description:";
			// 
			// addItemImage
			// 
			this.addItemImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addItemImage.Location = new System.Drawing.Point(525, 247);
			this.addItemImage.Name = "addItemImage";
			this.addItemImage.Size = new System.Drawing.Size(145, 33);
			this.addItemImage.TabIndex = 11;
			this.addItemImage.Text = "Browse image";
			this.addItemImage.UseVisualStyleBackColor = true;
			// 
			// itemPriceUpDown
			// 
			this.itemPriceUpDown.Location = new System.Drawing.Point(145, 212);
			this.itemPriceUpDown.Name = "itemPriceUpDown";
			this.itemPriceUpDown.Size = new System.Drawing.Size(83, 27);
			this.itemPriceUpDown.TabIndex = 13;
			// 
			// itemInStockUpDown
			// 
			this.itemInStockUpDown.Location = new System.Drawing.Point(352, 214);
			this.itemInStockUpDown.Name = "itemInStockUpDown";
			this.itemInStockUpDown.Size = new System.Drawing.Size(89, 27);
			this.itemInStockUpDown.TabIndex = 14;
			// 
			// showDollarSign
			// 
			this.showDollarSign.AutoSize = true;
			this.showDollarSign.Location = new System.Drawing.Point(234, 214);
			this.showDollarSign.Name = "showDollarSign";
			this.showDollarSign.Size = new System.Drawing.Size(18, 20);
			this.showDollarSign.TabIndex = 15;
			this.showDollarSign.Text = "$";
			this.showDollarSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// itemImage
			// 
			this.itemImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemImage.Location = new System.Drawing.Point(459, 82);
			this.itemImage.Name = "itemImage";
			this.itemImage.Size = new System.Drawing.Size(211, 159);
			this.itemImage.TabIndex = 12;
			this.itemImage.TabStop = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(108, 82);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Id:";
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(145, 79);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(296, 27);
			this.textBox3.TabIndex = 16;
			// 
			// AddItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(782, 403);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.showDollarSign);
			this.Controls.Add(this.itemInStockUpDown);
			this.Controls.Add(this.itemPriceUpDown);
			this.Controls.Add(this.itemImage);
			this.Controls.Add(this.addItemImage);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(800, 450);
			this.Name = "AddItem";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New item";
			this.Load += new System.EventHandler(this.AddItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.itemPriceUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInStockUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button addItemImage;
		private System.Windows.Forms.PictureBox itemImage;
		private System.Windows.Forms.NumericUpDown itemPriceUpDown;
		private System.Windows.Forms.NumericUpDown itemInStockUpDown;
		private System.Windows.Forms.Label showDollarSign;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
	}
}