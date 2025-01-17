using FinancialCrm.Models;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmExpenses : Form
    {
        private const int PageSize = 8;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;
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
    }
}


