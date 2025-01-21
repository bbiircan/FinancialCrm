using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmAccountActivities : Form
    {
        public FrmAccountActivities()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmAccountActivities_Load(object sender, EventArgs e)
        {
            var spendings = db.Spendings
                .Join(db.Categories,
                      s => s.CategoryId, 
                      c => c.CategoryId, 
                      (s, c) => new
                      {
                          Date = s.SpendingDate,
                          Title = s.SpendingTitle,
                          Amount = s.SpendingAmount,
                          Type = c.CategoryName, 
                      })
                .AsEnumerable();  

            var bankProcesses = db.BankProcesses
                .Select(b => new
                {
                    Date = b.ProcessDate,
                    Title = b.Description,
                    Amount = b.Amount,
                    Type = b.ProcessType,
                })
                .AsEnumerable();  

            var values = spendings.Concat(bankProcesses)
                                        .OrderBy(x => x.Date)
                                        .ToList();

            dataGridView1.DataSource = values;
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnInvoicesForm_Click(object sender, EventArgs e)
        {
            FrmPayments frm = new FrmPayments();
            frm.Show();
            this.Hide();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}