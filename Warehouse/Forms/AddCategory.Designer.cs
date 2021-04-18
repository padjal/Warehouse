
namespace Warehouse
{
	partial class AddCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
			this.newCategoryNameLabel = new System.Windows.Forms.Label();
			this.newCategoryName = new System.Windows.Forms.TextBox();
			this.addCategoryButton = new System.Windows.Forms.Button();
			this.warningMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newCategoryNameLabel
			// 
			this.newCategoryNameLabel.AutoSize = true;
			this.newCategoryNameLabel.Location = new System.Drawing.Point(108, 59);
			this.newCategoryNameLabel.Name = "newCategoryNameLabel";
			this.newCategoryNameLabel.Size = new System.Drawing.Size(45, 17);
			this.newCategoryNameLabel.TabIndex = 0;
			this.newCategoryNameLabel.Text = "Name";
			// 
			// newCategoryName
			// 
			this.newCategoryName.Location = new System.Drawing.Point(160, 56);
			this.newCategoryName.Name = "newCategoryName";
			this.newCategoryName.Size = new System.Drawing.Size(100, 22);
			this.newCategoryName.TabIndex = 1;
			// 
			// addCategoryButton
			// 
			this.addCategoryButton.Location = new System.Drawing.Point(185, 109);
			this.addCategoryButton.Name = "addCategoryButton";
			this.addCategoryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.addCategoryButton.Size = new System.Drawing.Size(75, 23);
			this.addCategoryButton.TabIndex = 2;
			this.addCategoryButton.Text = "Add";
			this.addCategoryButton.UseVisualStyleBackColor = true;
			this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
			// 
			// warningMessage
			// 
			this.warningMessage.AutoSize = true;
			this.warningMessage.ForeColor = System.Drawing.Color.Red;
			this.warningMessage.Location = new System.Drawing.Point(103, 81);
			this.warningMessage.Name = "warningMessage";
			this.warningMessage.Size = new System.Drawing.Size(157, 17);
			this.warningMessage.TabIndex = 3;
			this.warningMessage.Text = "Name cannot be empty!";
			this.warningMessage.Visible = false;
			// 
			// AddCategory
			// 
			this.AcceptButton = this.addCategoryButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 167);
			this.Controls.Add(this.warningMessage);
			this.Controls.Add(this.addCategoryButton);
			this.Controls.Add(this.newCategoryName);
			this.Controls.Add(this.newCategoryNameLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "AddCategory";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddCategory";
			this.Load += new System.EventHandler(this.AddCategory_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label newCategoryNameLabel;
		private System.Windows.Forms.TextBox newCategoryName;
		private System.Windows.Forms.Button addCategoryButton;
		private System.Windows.Forms.Label warningMessage;
	}
}