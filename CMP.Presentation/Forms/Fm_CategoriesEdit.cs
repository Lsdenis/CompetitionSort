using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CMP.BusinessLogin.DataModel;

namespace CMP.Presentation.Forms
{
	public partial class Fm_CategoriesEdit : Form
	{
		private CMPEntities _context;

		public Fm_CategoriesEdit()
		{
			StartPosition = FormStartPosition.CenterParent;
			_context = new CMPEntities();
			InitializeComponent();
		}

		private void Fm_CategoriesEdit_Load(object sender, System.EventArgs e)
		{
			_context.Categories.Load();
			categoryBindingSource.DataSource = _context.Categories.Local.ToBindingList();
		}

		private void Fm_CategoriesEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveChanges();
			_context.Dispose();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void categoryBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
		{
			SaveChanges();
		}

		private void SaveChanges()
		{
			foreach (var product in _context.Categories.Local.ToList())
			{
				if (string.IsNullOrWhiteSpace(product.Name))
				{
					_context.Categories.Remove(product);
				}
			}

			_context.SaveChanges();
		}
	}
}
