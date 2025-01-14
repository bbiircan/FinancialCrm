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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLastReceivedRemittanceAmount = new System.Windows.Forms.Label();
            this.lblAkbank = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel5.Size = new System.Drawing.Size(224, 100);
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
            this.lblTotalBalance.Size = new System.Drawing.Size(103, 41);
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
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(19, 367);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(186, 44);
            this.button8.TabIndex = 7;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(19, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "Settings";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(19, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(19, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Account Activities";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(19, 167);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(186, 44);
            this.btnBillForm.TabIndex = 3;
            this.btnBillForm.Text = "Expenses";
            this.btnBillForm.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(19, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Bills";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(19, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Banks";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Categories";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel2.Size = new System.Drawing.Size(920, 41);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(54)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(228, 231);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(329, 246);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(226, 168);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 57);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(580, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 57);
            this.panel7.TabIndex = 17;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(580, 231);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Invoices";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(329, 246);
            this.chart2.TabIndex = 16;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "You can find the amounts of money in banks\r\nand bank accounts in the chart below." +
    "\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "You can find the amounts of the paid and\r\noutstanding invoices in the graph below" +
    ".";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 489);
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}

