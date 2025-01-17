using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmPayments : Form
    {
        public FrmPayments()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmPayments_Load(object sender, EventArgs e)
        {
            var values = db.Invoices.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Invoices.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Invoices invoices = new Invoices();
            invoices.BillTitle = title;
            invoices.BillAmount = amount;
            invoices.BillPeriod = period;
            db.Invoices.Add(invoices);
            db.SaveChanges();
            MessageBox.Show("New payment has been added to the system.", "Payment & Invoices", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Invoices.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Invoices.Find(id);
            db.Invoices.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Payment has been removed from the system.", "Payment & Invoices", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Invoices.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            int id = int.Parse(txtBillId.Text);

            var values = db.Invoices.Find(id);

            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("The payment update process has been successfully completed.", "Payment & Invoices", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Invoices.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }
    }
}
