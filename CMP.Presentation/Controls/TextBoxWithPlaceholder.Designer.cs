namespace CMP.Presentation.Controls
{
	partial class TextBoxWithPlaceholder
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtInputText = new System.Windows.Forms.TextBox();
			this.lblPlaceholder = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtInputText
			// 
			this.txtInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInputText.ForeColor = System.Drawing.Color.Black;
			this.txtInputText.Location = new System.Drawing.Point(0, 0);
			this.txtInputText.Name = "txtInputText";
			this.txtInputText.Size = new System.Drawing.Size(206, 20);
			this.txtInputText.TabIndex = 0;
			this.txtInputText.TextChanged += new System.EventHandler(this.txtInputText_TextChanged);
			this.txtInputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputText_KeyPress);
			// 
			// lblPlaceholder
			// 
			this.lblPlaceholder.AutoSize = true;
			this.lblPlaceholder.BackColor = System.Drawing.Color.White;
			this.lblPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lblPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPlaceholder.ForeColor = System.Drawing.Color.Silver;
			this.lblPlaceholder.Location = new System.Drawing.Point(3, 3);
			this.lblPlaceholder.Name = "lblPlaceholder";
			this.lblPlaceholder.Size = new System.Drawing.Size(0, 13);
			this.lblPlaceholder.TabIndex = 1;
			this.lblPlaceholder.Click += new System.EventHandler(this.lblPlaceholder_Click);
			// 
			// TextBoxWithPlaceholder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblPlaceholder);
			this.Controls.Add(this.txtInputText);
			this.Name = "TextBoxWithPlaceholder";
			this.Size = new System.Drawing.Size(206, 20);
			this.Enter += new System.EventHandler(this.TextBoxWithPlaceholder_Enter);
			this.Leave += new System.EventHandler(this.TextBoxWithPlaceholder_Leave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtInputText;
		private System.Windows.Forms.Label lblPlaceholder;
	}
}
