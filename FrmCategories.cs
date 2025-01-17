using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var categories = db.Categories.Take(6).ToList();

            Label[] labels = new Label[]
            {
                lblCategory1,
                lblCategory2,
                lblCategory3,
                lblCategory4,
                lblCategory5,
                lblCategory6
            };

            for (int i = 0; i < categories.Count && i < labels.Length; i++)
            {
                labels[i].Text = categories[i].CategoryName;
            }

                var values = db.Spendings.Join(db.Categories,
                                spending => spending.CategoryId,
                                category => category.CategoryId,
                                (spending, category) => new
                                {
                                    CategoryId = category.CategoryId,
                                    CategoryName = category.CategoryName,
                                })
                                .GroupBy(x => x.CategoryName)
                                .Select(group => new
                                {
                                    CategoryName = group.Key,
                                    Count = group.Count()
                                })
                                .OrderByDescending(x => x.Count).Take(6).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Most Popular Categories");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            foreach (var item in values)
            {
                series.Points.AddXY(item.CategoryName, item.Count);
            }
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

        private void btnInvoicesForm_Click(object sender, EventArgs e)
        {
            FrmPayments frm = new FrmPayments();
            frm.Show();
            this.Close();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses();
            frm.Show();
            this.Close();
        }
    }
}

