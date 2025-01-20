using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault(u => u.UserNumber == txtUserNumber.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                FrmBanks frm = new FrmBanks();
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The User Number or password you entered is incorrect, try again.");
            }
        }
    }
}