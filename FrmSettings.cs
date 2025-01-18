using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrentPass.Text;
            string newPass = txtNewPass.Text;
            string confirmNewPass = txtConfirmNewPass.Text;

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmNewPass))
            {
                MessageBox.Show("Fill in the field for the new password and to confirm the password.");
                return;
            }

            if (newPass != confirmNewPass)
            {
                MessageBox.Show("The passwords do not match.");
                return;
            }

            var user = db.Users.FirstOrDefault(u => u.Password == currentPass);

            if (user == null)
            {
                MessageBox.Show("The current password is incorrect.");
                return;
            }

            user.Password = newPass;
            db.SaveChanges();
            MessageBox.Show("The password has been successfully updated.");

        }
    }
}



