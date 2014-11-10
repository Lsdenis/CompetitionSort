using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CMP.BusinessLogin.DataModel;
using CMP.BusinessLogin.Services;
using CMP.Presentation.Extenstions;

namespace CMP.Presentation.Forms
{
	public partial class Fm_EditSportsmen : Form
	{
		public Fm_EditSportsmen()
		{
			StartPosition = FormStartPosition.CenterParent;
			InitializeComponent();
			txtSearch.OnEnterPressed = () =>
			{
				var sportsmen = SportsmenService.LoadAllSportsmen().Where(sp => sp.LastName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase));
				LoadSportsmenToDataGridView(sportsmen);
			};
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var form = new Fm_Sportsman(null);
			form.ShowDialog(this);
		}

		private void Fm_EditSportsmen_Load(object sender, EventArgs e)
		{
			LoadSportsmen();
		}

		private void LoadSportsmen()
		{
			var sportsmen = SportsmenService.LoadAllSportsmen();

			LoadSportsmenToDataGridView(sportsmen);
		}

		private void LoadSportsmenToDataGridView(IEnumerable<Sportsmen> sportsmen)
		{
			dgvSportsmen.Rows.Clear();

			foreach (var sportsman in sportsmen)
			{
				dgvSportsmen.Rows.Add(new object[] { sportsman, sportsman.Age, sportsman.Club });
			}
		}

		private void dgvSportsmen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}

			var sportsman = (Sportsmen)dgvSportsmen[0, e.RowIndex].Value;

			var form = new Fm_Sportsman(sportsman);
			form.ShowDialog(this);
			LoadSportsmen();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
