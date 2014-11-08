using System;
using System.Windows.Forms;
using CMP.BusinessLogin.DataModel;
using CMP.BusinessLogin.Services;

namespace CMP.Presentation.Forms
{
	public partial class Fm_Sportsman : Form
	{
		private Sportsmen _sportsmen;

		public Fm_Sportsman(Sportsmen sportsmen)
		{
			StartPosition = FormStartPosition.CenterParent;
			_sportsmen = sportsmen;
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Fm_AddSportsman_Load(object sender, EventArgs e)
		{
			if (_sportsmen == null)
			{
				_sportsmen = new Sportsmen();
			}
			else
			{
				SetSportsmanValues();
			}
		}

		private void SetSportsmanValues()
		{
			txtClub.Text = _sportsmen.Club;
			txtLastName.Text = _sportsmen.LastName;
			txtName.Text = _sportsmen.Name;
			udAge.Value = _sportsmen.Age;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!IsSportsmanValid())
			{
				return;
			}

			GetCurrentValues();
			SportsmenService.SaveOrUpdateSportsman(_sportsmen);
			Close();
		}

		private bool IsSportsmanValid()
		{
			if (string.IsNullOrWhiteSpace(txtName.Text))
			{
				MessageBox.Show("Должно быть заполнено имя!", "Внимание!", MessageBoxButtons.OK);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtLastName.Text))
			{
				MessageBox.Show("Должна быть заполнена фамилия!", "Внимание!", MessageBoxButtons.OK);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtClub.Text))
			{
				MessageBox.Show("Должен быть заполнен клуб!", "Внимание!", MessageBoxButtons.OK);
				return false;
			}

			return true;
		}

		private void GetCurrentValues()
		{
			_sportsmen.Age = (int)udAge.Value;
			_sportsmen.Club = txtClub.Text;
			_sportsmen.LastName = txtLastName.Text;
			_sportsmen.Name = txtName.Text;
		}
	}
}
