
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
			this.components = new System.ComponentModel.Container();
			this.addProductButton = new System.Windows.Forms.Button();
			this.productName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.productDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addItemImage = new System.Windows.Forms.Button();
			this.productInStock = new System.Windows.Forms.NumericUpDown();
			this.showDollarSign = new System.Windows.Forms.Label();
			this.productImage = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.productPrice = new System.Windows.Forms.TextBox();
			this.idMaskedText = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.productInStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// addProductButton
			// 
			this.addProductButton.Location = new System.Drawing.Point(145, 238);
			this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
			this.addProductButton.Name = "addProductButton";
			this.addProductButton.Size = new System.Drawing.Size(191, 52);
			this.addProductButton.TabIndex = 0;
			this.addProductButton.Text = "Add";
			this.addProductButton.UseVisualStyleBackColor = true;
			this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
			// 
			// productName
			// 
			this.productName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.productName.Location = new System.Drawing.Point(145, 44);
			this.productName.Margin = new System.Windows.Forms.Padding(4);
			this.productName.Name = "productName";
			this.productName.Size = new System.Drawing.Size(368, 27);
			this.productName.TabIndex = 1;
			this.productName.Validating += new System.ComponentModel.CancelEventHandler(this.productName_Validating);
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
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(299, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "In stock:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(82, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price:";
			// 
			// productDescription
			// 
			this.productDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.productDescription.Location = new System.Drawing.Point(145, 82);
			this.productDescription.Multiline = true;
			this.productDescription.Name = "productDescription";
			this.productDescription.Size = new System.Drawing.Size(296, 88);
			this.productDescription.TabIndex = 5;
			this.productDescription.Validating += new System.ComponentModel.CancelEventHandler(this.productDescription_Validating);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 82);
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
			// productInStock
			// 
			this.productInStock.Location = new System.Drawing.Point(377, 183);
			this.productInStock.Name = "productInStock";
			this.productInStock.Size = new System.Drawing.Size(64, 27);
			this.productInStock.TabIndex = 14;
			this.productInStock.Validating += new System.ComponentModel.CancelEventHandler(this.productInStock_Validating);
			// 
			// showDollarSign
			// 
			this.showDollarSign.AutoSize = true;
			this.showDollarSign.Location = new System.Drawing.Point(234, 183);
			this.showDollarSign.Name = "showDollarSign";
			this.showDollarSign.Size = new System.Drawing.Size(18, 20);
			this.showDollarSign.TabIndex = 15;
			this.showDollarSign.Text = "$";
			this.showDollarSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// productImage
			// 
			this.productImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.productImage.Location = new System.Drawing.Point(459, 82);
			this.productImage.Name = "productImage";
			this.productImage.Size = new System.Drawing.Size(211, 159);
			this.productImage.TabIndex = 12;
			this.productImage.TabStop = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(592, 47);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Id:";
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			// 
			// productPrice
			// 
			this.productPrice.Location = new System.Drawing.Point(145, 182);
			this.productPrice.Name = "productPrice";
			this.productPrice.Size = new System.Drawing.Size(72, 27);
			this.productPrice.TabIndex = 19;
			this.productPrice.Validating += new System.ComponentModel.CancelEventHandler(this.productPrice_Validating);
			// 
			// idMaskedText
			// 
			this.idMaskedText.Location = new System.Drawing.Point(626, 41);
			this.idMaskedText.Mask = "0000";
			this.idMaskedText.Name = "idMaskedText";
			this.idMaskedText.Size = new System.Drawing.Size(44, 27);
			this.idMaskedText.TabIndex = 20;
			this.idMaskedText.ValidatingType = typeof(int);
			this.idMaskedText.Validating += new System.ComponentModel.CancelEventHandler(this.idMaskedText_Validating);
			// 
			// AddItem
			// 
			this.AcceptButton = this.addProductButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(782, 403);
			this.Controls.Add(this.idMaskedText);
			this.Controls.Add(this.productPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.showDollarSign);
			this.Controls.Add(this.productInStock);
			this.Controls.Add(this.productImage);
			this.Controls.Add(this.addItemImage);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.productDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.productName);
			this.Controls.Add(this.addProductButton);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(800, 450);
			this.Name = "AddItem";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New item";
			((System.ComponentModel.ISupportInitialize)(this.productInStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addProductButton;
		private System.Windows.Forms.TextBox productName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox productDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button addItemImage;
		private System.Windows.Forms.PictureBox productImage;
		private System.Windows.Forms.NumericUpDown productInStock;
		private System.Windows.Forms.Label showDollarSign;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.TextBox productPrice;
		private System.Windows.Forms.MaskedTextBox idMaskedText;
	}
}