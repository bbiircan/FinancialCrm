using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x=>x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastReceivedRemittance = db.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastReceivedRemittanceAmount.Text = lastReceivedRemittance.ToString() + " ₺";

            // chart 1 codes
            var bankData = db.Banks.Select(x=> new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData) 
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            // chart 2 codes
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Invoices");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var electricBill = db.Bills.Where(x=>x.BillTitle == "Electric Bill").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Electric Bill";
                lblBillAmount.Text = electricBill.ToString() + " ₺";

            }

            if (count % 4 == 2)
            {
                var phoneBill = db.Bills.Where(x=>x.BillTitle == "Phone Bill").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Phone Bill";
                lblBillAmount.Text= phoneBill.ToString() + " ₺";
            }

            if (count % 4 == 3) 
            {
                var waterBill = db.Bills.Where(x=>x.BillTitle == "Water Bill").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Water Bill";
                lblBillAmount.Text = waterBill.ToString() + " ₺";
            }

            if (count % 4 == 0)
            {
                var internetBill = db.Bills.Where(x => x.BillTitle == "Internet Bill").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Internet Bill";
                lblBillAmount.Text = internetBill.ToString() + " ₺";
            }

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }
    }
}
