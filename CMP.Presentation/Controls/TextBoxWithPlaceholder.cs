using System.Windows.Forms;

namespace CMP.Presentation.Controls
{
	public partial class TextBoxWithPlaceholder : UserControl
	{
		public override string Text
		{
			get { return txtInputText.Text; }
			set { txtInputText.Text = value; }
		}

		public string Placeholder
		{

			get { return lblPlaceholder.Text; }
			set { lblPlaceholder.Text = value; }
		}

		public TextBoxWithPlaceholder()
		{
			InitializeComponent();
		}

		private void txtInputText_TextChanged(object sender, System.EventArgs e)
		{
		}

		private void TextBoxWithPlaceholder_Enter(object sender, System.EventArgs e)
		{
			lblPlaceholder.Visible = false;
			txtInputText.Focus();
		}

		private void TextBoxWithPlaceholder_Leave(object sender, System.EventArgs e)
		{
			lblPlaceholder.Visible = txtInputText.Text.Length <= 0;
		}
	}
}
