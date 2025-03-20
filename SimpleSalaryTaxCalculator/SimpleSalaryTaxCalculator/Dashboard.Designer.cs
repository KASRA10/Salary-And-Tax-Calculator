namespace SimpleSalaryTaxCalculator
{
	partial class Dashboard_FRM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_FRM));
			this.BackGround_PNL = new System.Windows.Forms.Panel();
			this.NetPay_LBL = new System.Windows.Forms.Label();
			this.NetTitle_LBL = new System.Windows.Forms.Label();
			this.Marital_COMB = new System.Windows.Forms.ComboBox();
			this.Reset_BTN = new System.Windows.Forms.Button();
			this.SalaryCalculation_BTN = new System.Windows.Forms.Button();
			this.NumberOfCHildren_COMB = new System.Windows.Forms.ComboBox();
			this.NumberOfChildren_LBL = new System.Windows.Forms.Label();
			this.MaritalStatus_LBL = new System.Windows.Forms.Label();
			this.HiringDatePicker_DP = new System.Windows.Forms.DateTimePicker();
			this.HiringDate_LBL = new System.Windows.Forms.Label();
			this.NumberOfDays_TB = new System.Windows.Forms.TextBox();
			this.NumberOfDays_LBL = new System.Windows.Forms.Label();
			this.FourThreeYear_RBTN = new System.Windows.Forms.RadioButton();
			this.SelectYear_LBL = new System.Windows.Forms.Label();
			this.Month_COMB = new System.Windows.Forms.ComboBox();
			this.SelectMonth_LBL = new System.Windows.Forms.Label();
			this.MonthlySalary_TB = new System.Windows.Forms.TextBox();
			this.MonthlySalary_LBL = new System.Windows.Forms.Label();
			this.BackGround_PNL.SuspendLayout();
			this.SuspendLayout();
			// 
			// BackGround_PNL
			// 
			this.BackGround_PNL.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.BackGround_PNL.Controls.Add(this.NetPay_LBL);
			this.BackGround_PNL.Controls.Add(this.NetTitle_LBL);
			this.BackGround_PNL.Controls.Add(this.Marital_COMB);
			this.BackGround_PNL.Controls.Add(this.Reset_BTN);
			this.BackGround_PNL.Controls.Add(this.SalaryCalculation_BTN);
			this.BackGround_PNL.Controls.Add(this.NumberOfCHildren_COMB);
			this.BackGround_PNL.Controls.Add(this.NumberOfChildren_LBL);
			this.BackGround_PNL.Controls.Add(this.MaritalStatus_LBL);
			this.BackGround_PNL.Controls.Add(this.HiringDatePicker_DP);
			this.BackGround_PNL.Controls.Add(this.HiringDate_LBL);
			this.BackGround_PNL.Controls.Add(this.NumberOfDays_TB);
			this.BackGround_PNL.Controls.Add(this.NumberOfDays_LBL);
			this.BackGround_PNL.Controls.Add(this.FourThreeYear_RBTN);
			this.BackGround_PNL.Controls.Add(this.SelectYear_LBL);
			this.BackGround_PNL.Controls.Add(this.Month_COMB);
			this.BackGround_PNL.Controls.Add(this.SelectMonth_LBL);
			this.BackGround_PNL.Controls.Add(this.MonthlySalary_TB);
			this.BackGround_PNL.Controls.Add(this.MonthlySalary_LBL);
			this.BackGround_PNL.Location = new System.Drawing.Point(25, 24);
			this.BackGround_PNL.Name = "BackGround_PNL";
			this.BackGround_PNL.Size = new System.Drawing.Size(786, 531);
			this.BackGround_PNL.TabIndex = 0;
			// 
			// NetPay_LBL
			// 
			this.NetPay_LBL.AutoSize = true;
			this.NetPay_LBL.Location = new System.Drawing.Point(348, 394);
			this.NetPay_LBL.Name = "NetPay_LBL";
			this.NetPay_LBL.Size = new System.Drawing.Size(21, 25);
			this.NetPay_LBL.TabIndex = 18;
			this.NetPay_LBL.Text = "0";
			// 
			// NetTitle_LBL
			// 
			this.NetTitle_LBL.AutoSize = true;
			this.NetTitle_LBL.Location = new System.Drawing.Point(182, 394);
			this.NetTitle_LBL.Name = "NetTitle_LBL";
			this.NetTitle_LBL.Size = new System.Drawing.Size(164, 25);
			this.NetTitle_LBL.TabIndex = 17;
			this.NetTitle_LBL.Text = "Net amount payable:";
			// 
			// Marital_COMB
			// 
			this.Marital_COMB.BackColor = System.Drawing.SystemColors.Info;
			this.Marital_COMB.FormattingEnabled = true;
			this.Marital_COMB.Items.AddRange(new object[] {
            "Married",
            "Single"});
			this.Marital_COMB.Location = new System.Drawing.Point(353, 297);
			this.Marital_COMB.Name = "Marital_COMB";
			this.Marital_COMB.Size = new System.Drawing.Size(397, 33);
			this.Marital_COMB.TabIndex = 16;
			// 
			// Reset_BTN
			// 
			this.Reset_BTN.BackColor = System.Drawing.SystemColors.Highlight;
			this.Reset_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Reset_BTN.Location = new System.Drawing.Point(353, 464);
			this.Reset_BTN.Name = "Reset_BTN";
			this.Reset_BTN.Size = new System.Drawing.Size(397, 30);
			this.Reset_BTN.TabIndex = 15;
			this.Reset_BTN.Text = "Reset";
			this.Reset_BTN.UseVisualStyleBackColor = false;
			this.Reset_BTN.Click += new System.EventHandler(this.Reset_BTN_Click);
			// 
			// SalaryCalculation_BTN
			// 
			this.SalaryCalculation_BTN.BackColor = System.Drawing.Color.SeaGreen;
			this.SalaryCalculation_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SalaryCalculation_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.SalaryCalculation_BTN.Location = new System.Drawing.Point(39, 427);
			this.SalaryCalculation_BTN.Name = "SalaryCalculation_BTN";
			this.SalaryCalculation_BTN.Size = new System.Drawing.Size(712, 30);
			this.SalaryCalculation_BTN.TabIndex = 14;
			this.SalaryCalculation_BTN.Text = "Salary calculation";
			this.SalaryCalculation_BTN.UseVisualStyleBackColor = false;
			this.SalaryCalculation_BTN.Click += new System.EventHandler(this.SalaryCalculation_BTN_Click);
			// 
			// NumberOfCHildren_COMB
			// 
			this.NumberOfCHildren_COMB.BackColor = System.Drawing.SystemColors.Info;
			this.NumberOfCHildren_COMB.FormattingEnabled = true;
			this.NumberOfCHildren_COMB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.NumberOfCHildren_COMB.Location = new System.Drawing.Point(353, 345);
			this.NumberOfCHildren_COMB.Name = "NumberOfCHildren_COMB";
			this.NumberOfCHildren_COMB.Size = new System.Drawing.Size(398, 33);
			this.NumberOfCHildren_COMB.TabIndex = 13;
			// 
			// NumberOfChildren_LBL
			// 
			this.NumberOfChildren_LBL.AutoSize = true;
			this.NumberOfChildren_LBL.Location = new System.Drawing.Point(34, 348);
			this.NumberOfChildren_LBL.Name = "NumberOfChildren_LBL";
			this.NumberOfChildren_LBL.Size = new System.Drawing.Size(312, 25);
			this.NumberOfChildren_LBL.TabIndex = 12;
			this.NumberOfChildren_LBL.Text = "Number of children under 18 years old *:";
			// 
			// MaritalStatus_LBL
			// 
			this.MaritalStatus_LBL.AutoSize = true;
			this.MaritalStatus_LBL.Location = new System.Drawing.Point(34, 299);
			this.MaritalStatus_LBL.Name = "MaritalStatus_LBL";
			this.MaritalStatus_LBL.Size = new System.Drawing.Size(134, 25);
			this.MaritalStatus_LBL.TabIndex = 10;
			this.MaritalStatus_LBL.Text = "Marital status  *:";
			// 
			// HiringDatePicker_DP
			// 
			this.HiringDatePicker_DP.CalendarMonthBackground = System.Drawing.SystemColors.Info;
			this.HiringDatePicker_DP.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HiringDatePicker_DP.Location = new System.Drawing.Point(352, 245);
			this.HiringDatePicker_DP.Name = "HiringDatePicker_DP";
			this.HiringDatePicker_DP.Size = new System.Drawing.Size(399, 33);
			this.HiringDatePicker_DP.TabIndex = 9;
			// 
			// HiringDate_LBL
			// 
			this.HiringDate_LBL.AutoSize = true;
			this.HiringDate_LBL.Location = new System.Drawing.Point(34, 250);
			this.HiringDate_LBL.Name = "HiringDate_LBL";
			this.HiringDate_LBL.Size = new System.Drawing.Size(157, 25);
			this.HiringDate_LBL.TabIndex = 8;
			this.HiringDate_LBL.Text = "Select hiring date *:";
			// 
			// NumberOfDays_TB
			// 
			this.NumberOfDays_TB.BackColor = System.Drawing.SystemColors.Info;
			this.NumberOfDays_TB.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfDays_TB.Location = new System.Drawing.Point(352, 195);
			this.NumberOfDays_TB.Name = "NumberOfDays_TB";
			this.NumberOfDays_TB.Size = new System.Drawing.Size(399, 33);
			this.NumberOfDays_TB.TabIndex = 7;
			// 
			// NumberOfDays_LBL
			// 
			this.NumberOfDays_LBL.AutoSize = true;
			this.NumberOfDays_LBL.Location = new System.Drawing.Point(34, 198);
			this.NumberOfDays_LBL.Name = "NumberOfDays_LBL";
			this.NumberOfDays_LBL.Size = new System.Drawing.Size(205, 25);
			this.NumberOfDays_LBL.TabIndex = 6;
			this.NumberOfDays_LBL.Text = "Number of days worked *:";
			// 
			// FourThreeYear_RBTN
			// 
			this.FourThreeYear_RBTN.AutoSize = true;
			this.FourThreeYear_RBTN.Checked = true;
			this.FourThreeYear_RBTN.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FourThreeYear_RBTN.Location = new System.Drawing.Point(352, 154);
			this.FourThreeYear_RBTN.Name = "FourThreeYear_RBTN";
			this.FourThreeYear_RBTN.Size = new System.Drawing.Size(66, 29);
			this.FourThreeYear_RBTN.TabIndex = 5;
			this.FourThreeYear_RBTN.TabStop = true;
			this.FourThreeYear_RBTN.Text = "1404";
			this.FourThreeYear_RBTN.UseVisualStyleBackColor = true;
			// 
			// SelectYear_LBL
			// 
			this.SelectYear_LBL.AutoSize = true;
			this.SelectYear_LBL.Location = new System.Drawing.Point(34, 154);
			this.SelectYear_LBL.Name = "SelectYear_LBL";
			this.SelectYear_LBL.Size = new System.Drawing.Size(111, 25);
			this.SelectYear_LBL.TabIndex = 4;
			this.SelectYear_LBL.Text = "Select year *:";
			// 
			// Month_COMB
			// 
			this.Month_COMB.BackColor = System.Drawing.SystemColors.Info;
			this.Month_COMB.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Month_COMB.FormattingEnabled = true;
			this.Month_COMB.Items.AddRange(new object[] {
            "January (10th–11th - Dey / Bahman)",
            "February (11th–12th - Bahman / Esfand)",
            "March (12th–1st - Esfand / Farvardin)",
            "April (1st–2nd - Farvardin / Ordibehesht)",
            "May (2nd–3rd - Ordibehesht / Khordad)",
            "June (3rd–4th - Khordad / Tir)",
            "July (4th–5th - Tir / Mordad)",
            "August (5th–6th - Mordad / Shahrivar)",
            "September (6th–7th - Shahrivar / Mehr)",
            "October (7th–8th - Mehr / Aban)",
            "November (8th–9th - Aban / Azar)",
            "December (9th–10th - Azar / Dey)"});
			this.Month_COMB.Location = new System.Drawing.Point(352, 105);
			this.Month_COMB.Name = "Month_COMB";
			this.Month_COMB.Size = new System.Drawing.Size(399, 33);
			this.Month_COMB.TabIndex = 3;
			this.Month_COMB.Text = "Select Month";
			// 
			// SelectMonth_LBL
			// 
			this.SelectMonth_LBL.AutoSize = true;
			this.SelectMonth_LBL.Location = new System.Drawing.Point(34, 108);
			this.SelectMonth_LBL.Name = "SelectMonth_LBL";
			this.SelectMonth_LBL.Size = new System.Drawing.Size(153, 25);
			this.SelectMonth_LBL.TabIndex = 2;
			this.SelectMonth_LBL.Text = "Select the month *:";
			// 
			// MonthlySalary_TB
			// 
			this.MonthlySalary_TB.BackColor = System.Drawing.SystemColors.Info;
			this.MonthlySalary_TB.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonthlySalary_TB.Location = new System.Drawing.Point(352, 55);
			this.MonthlySalary_TB.Name = "MonthlySalary_TB";
			this.MonthlySalary_TB.Size = new System.Drawing.Size(399, 33);
			this.MonthlySalary_TB.TabIndex = 1;
			// 
			// MonthlySalary_LBL
			// 
			this.MonthlySalary_LBL.AutoSize = true;
			this.MonthlySalary_LBL.Location = new System.Drawing.Point(34, 58);
			this.MonthlySalary_LBL.Name = "MonthlySalary_LBL";
			this.MonthlySalary_LBL.Size = new System.Drawing.Size(283, 25);
			this.MonthlySalary_LBL.TabIndex = 0;
			this.MonthlySalary_LBL.Text = "Basic monthly gross salary in Rials *:";
			// 
			// Dashboard_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(840, 577);
			this.Controls.Add(this.BackGround_PNL);
			this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.MaximizeBox = false;
			this.Name = "Dashboard_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.BackGround_PNL.ResumeLayout(false);
			this.BackGround_PNL.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BackGround_PNL;
		private System.Windows.Forms.TextBox MonthlySalary_TB;
		private System.Windows.Forms.Label MonthlySalary_LBL;
		private System.Windows.Forms.Label SelectMonth_LBL;
		private System.Windows.Forms.ComboBox Month_COMB;
		private System.Windows.Forms.RadioButton FourThreeYear_RBTN;
		private System.Windows.Forms.Label SelectYear_LBL;
		private System.Windows.Forms.TextBox NumberOfDays_TB;
		private System.Windows.Forms.Label NumberOfDays_LBL;
		private System.Windows.Forms.DateTimePicker HiringDatePicker_DP;
		private System.Windows.Forms.Label HiringDate_LBL;
		private System.Windows.Forms.Label MaritalStatus_LBL;
		private System.Windows.Forms.Button SalaryCalculation_BTN;
		private System.Windows.Forms.ComboBox NumberOfCHildren_COMB;
		private System.Windows.Forms.Label NumberOfChildren_LBL;
		private System.Windows.Forms.Button Reset_BTN;
		private System.Windows.Forms.ComboBox Marital_COMB;
		private System.Windows.Forms.Label NetPay_LBL;
		private System.Windows.Forms.Label NetTitle_LBL;
	}
}