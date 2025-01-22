namespace FinancialCrm
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLastReceivedRemittanceAmount = new System.Windows.Forms.Label();
            this.lblAkbank = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnAccountActivitiesForm = new System.Windows.Forms.Button();
            this.btnExpensesForm = new System.Windows.Forms.Button();
            this.btnInvoicesForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoriesForm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastReceivedRemittanceAmount
            // 
            this.lblLastReceivedRemittanceAmount.AutoSize = true;
            this.lblLastReceivedRemittanceAmount.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastReceivedRemittanceAmount.ForeColor = System.Drawing.Color.White;
            this.lblLastReceivedRemittanceAmount.Location = new System.Drawing.Point(47, 42);
            this.lblLastReceivedRemittanceAmount.Name = "lblLastReceivedRemittanceAmount";
            this.lblLastReceivedRemittanceAmount.Size = new System.Drawing.Size(101, 40);
            this.lblLastReceivedRemittanceAmount.TabIndex = 4;
            this.lblLastReceivedRemittanceAmount.Text = "0.00 ₺";
            // 
            // lblAkbank
            // 
            this.lblAkbank.AutoSize = true;
            this.lblAkbank.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAkbank.ForeColor = System.Drawing.Color.White;
            this.lblAkbank.Location = new System.Drawing.Point(3, 10);
            this.lblAkbank.Name = "lblAkbank";
            this.lblAkbank.Size = new System.Drawing.Size(221, 24);
            this.lblAkbank.TabIndex = 3;
            this.lblAkbank.Text = "Last Received Remittance";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.YellowGreen;
            this.panel5.Controls.Add(this.lblLastReceivedRemittanceAmount);
            this.panel5.Controls.Add(this.lblAkbank);
            this.panel5.Location = new System.Drawing.Point(687, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 100);
            this.panel5.TabIndex = 12;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.White;
            this.lblBillAmount.Location = new System.Drawing.Point(32, 43);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(101, 40);
            this.lblBillAmount.TabIndex = 4;
            this.lblBillAmount.Text = "0.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Balance";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.Color.White;
            this.lblBillTitle.Location = new System.Drawing.Point(3, 10);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(78, 24);
            this.lblBillTitle.TabIndex = 3;
            this.lblBillTitle.Text = "Bill Title";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalance.Location = new System.Drawing.Point(3, 42);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(101, 40);
            this.lblTotalBalance.TabIndex = 4;
            this.lblTotalBalance.Text = "0.00 ₺";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(227, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 100);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard / Overview Form";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(19, 378);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 44);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnSettingsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Location = new System.Drawing.Point(19, 328);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(186, 44);
            this.btnSettingsForm.TabIndex = 6;
            this.btnSettingsForm.Text = "Settings";
            this.btnSettingsForm.UseVisualStyleBackColor = false;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnDashboardForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Location = new System.Drawing.Point(19, 278);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(186, 44);
            this.btnDashboardForm.TabIndex = 5;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            // 
            // btnAccountActivitiesForm
            // 
            this.btnAccountActivitiesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnAccountActivitiesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountActivitiesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccountActivitiesForm.ForeColor = System.Drawing.Color.White;
            this.btnAccountActivitiesForm.Location = new System.Drawing.Point(19, 228);
            this.btnAccountActivitiesForm.Name = "btnAccountActivitiesForm";
            this.btnAccountActivitiesForm.Size = new System.Drawing.Size(186, 44);
            this.btnAccountActivitiesForm.TabIndex = 4;
            this.btnAccountActivitiesForm.Text = "Account Activities";
            this.btnAccountActivitiesForm.UseVisualStyleBackColor = false;
            this.btnAccountActivitiesForm.Click += new System.EventHandler(this.btnAccountActivitiesForm_Click);
            // 
            // btnExpensesForm
            // 
            this.btnExpensesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnExpensesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpensesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesForm.ForeColor = System.Drawing.Color.White;
            this.btnExpensesForm.Location = new System.Drawing.Point(19, 178);
            this.btnExpensesForm.Name = "btnExpensesForm";
            this.btnExpensesForm.Size = new System.Drawing.Size(186, 44);
            this.btnExpensesForm.TabIndex = 3;
            this.btnExpensesForm.Text = "Expenses";
            this.btnExpensesForm.UseVisualStyleBackColor = false;
            this.btnExpensesForm.Click += new System.EventHandler(this.btnExpensesForm_Click);
            // 
            // btnInvoicesForm
            // 
            this.btnInvoicesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnInvoicesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoicesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInvoicesForm.ForeColor = System.Drawing.Color.White;
            this.btnInvoicesForm.Location = new System.Drawing.Point(19, 128);
            this.btnInvoicesForm.Name = "btnInvoicesForm";
            this.btnInvoicesForm.Size = new System.Drawing.Size(186, 44);
            this.btnInvoicesForm.TabIndex = 2;
            this.btnInvoicesForm.Text = "Invoices";
            this.btnInvoicesForm.UseVisualStyleBackColor = false;
            this.btnInvoicesForm.Click += new System.EventHandler(this.btnInvoicesForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnBanksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(19, 78);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(186, 44);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Banks";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoriesForm
            // 
            this.btnCategoriesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnCategoriesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoriesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoriesForm.Location = new System.Drawing.Point(19, 28);
            this.btnCategoriesForm.Name = "btnCategoriesForm";
            this.btnCategoriesForm.Size = new System.Drawing.Size(186, 44);
            this.btnCategoriesForm.TabIndex = 0;
            this.btnCategoriesForm.Text = "Categories";
            this.btnCategoriesForm.UseVisualStyleBackColor = false;
            this.btnCategoriesForm.Click += new System.EventHandler(this.btnCategoriesForm_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OliveDrab;
            this.panel4.Controls.Add(this.lblBillAmount);
            this.panel4.Controls.Add(this.lblBillTitle);
            this.panel4.Location = new System.Drawing.Point(457, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 100);
            this.panel4.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(106)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 41);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSettingsForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnAccountActivitiesForm);
            this.panel1.Controls.Add(this.btnExpensesForm);
            this.panel1.Controls.Add(this.btnInvoicesForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoriesForm);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 452);
            this.panel1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(228, 231);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(362, 246);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(226, 168);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 57);
            this.panel6.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "You can find the amounts of money in banks\r\nand bank accounts in the chart below." +
    "\r\n";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(599, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(336, 57);
            this.panel7.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "You can find the amounts of the paid and\r\noutstanding invoices in the graph below" +
    ".";
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(599, 231);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Invoices";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(336, 246);
            this.chart2.TabIndex = 16;
            this.chart2.Text = "chart2";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 489);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard Form";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLastReceivedRemittanceAmount;
        private System.Windows.Forms.Label lblAkbank;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnAccountActivitiesForm;
        private System.Windows.Forms.Button btnExpensesForm;
        private System.Windows.Forms.Button btnInvoicesForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoriesForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
    }
}

