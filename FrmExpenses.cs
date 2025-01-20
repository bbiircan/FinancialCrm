using FinancialCrm.Models;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmExpenses_Load(object sender, System.EventArgs e)
        {
            var expenses = db.Spendings.Select(x => new
            {
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.Categories.CategoryName,
            }).ToList();

            dataGridView1.DataSource = expenses;
        }

        private void btnCategoriesForm_Click(object sender, System.EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, System.EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, System.EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnInvoicesForm_Click(object sender, System.EventArgs e)
        {
            FrmPayments frm = new FrmPayments();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, System.EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }
    }
}


