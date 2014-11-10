using System;
using System.Windows.Forms;

namespace CMP.Presentation.Controls
{
	public partial class TextBoxWithPlaceholder : UserControl
	{
		private Action _buttonPressed;

		public Action OnEnterPressed
		{
			get { return _buttonPressed; }
			set { _buttonPressed = value; }
		}

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

		private void lblPlaceholder_Click(object sender, System.EventArgs e)
		{
			txtInputText.Focus();
		}

		private void txtInputText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != (char)Keys.Return)
			{
				return;
			}

			var handler = _buttonPressed;
			if (handler != null)
			{
				handler();
			}
		}
	}
}
