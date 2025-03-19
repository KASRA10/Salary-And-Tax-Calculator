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
			this.Month_COMB = new System.Windows.Forms.ComboBox();
			this.SelectMonth_LBL = new System.Windows.Forms.Label();
			this.MonthlySalary_TB = new System.Windows.Forms.TextBox();
			this.MonthlySalary_LBL = new System.Windows.Forms.Label();
			this.SelectYear_LBL = new System.Windows.Forms.Label();
			this.FourThreeYear_RBTN = new System.Windows.Forms.RadioButton();
			this.NumberOfDays_LBL = new System.Windows.Forms.Label();
			this.NumberOfDays_TB = new System.Windows.Forms.TextBox();
			this.BackGround_PNL.SuspendLayout();
			this.SuspendLayout();
			// 
			// BackGround_PNL
			// 
			this.BackGround_PNL.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.BackGround_PNL.Controls.Add(this.NumberOfDays_TB);
			this.BackGround_PNL.Controls.Add(this.NumberOfDays_LBL);
			this.BackGround_PNL.Controls.Add(this.FourThreeYear_RBTN);
			this.BackGround_PNL.Controls.Add(this.SelectYear_LBL);
			this.BackGround_PNL.Controls.Add(this.Month_COMB);
			this.BackGround_PNL.Controls.Add(this.SelectMonth_LBL);
			this.BackGround_PNL.Controls.Add(this.MonthlySalary_TB);
			this.BackGround_PNL.Controls.Add(this.MonthlySalary_LBL);
			this.BackGround_PNL.Location = new System.Drawing.Point(28, 25);
			this.BackGround_PNL.Name = "BackGround_PNL";
			this.BackGround_PNL.Size = new System.Drawing.Size(786, 531);
			this.BackGround_PNL.TabIndex = 0;
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
			this.Month_COMB.Location = new System.Drawing.Point(342, 70);
			this.Month_COMB.Name = "Month_COMB";
			this.Month_COMB.Size = new System.Drawing.Size(399, 33);
			this.Month_COMB.TabIndex = 3;
			this.Month_COMB.Text = "Select Month";
			// 
			// SelectMonth_LBL
			// 
			this.SelectMonth_LBL.AutoSize = true;
			this.SelectMonth_LBL.Location = new System.Drawing.Point(24, 73);
			this.SelectMonth_LBL.Name = "SelectMonth_LBL";
			this.SelectMonth_LBL.Size = new System.Drawing.Size(153, 25);
			this.SelectMonth_LBL.TabIndex = 2;
			this.SelectMonth_LBL.Text = "Select the month *:";
			// 
			// MonthlySalary_TB
			// 
			this.MonthlySalary_TB.BackColor = System.Drawing.SystemColors.Info;
			this.MonthlySalary_TB.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonthlySalary_TB.Location = new System.Drawing.Point(342, 28);
			this.MonthlySalary_TB.Name = "MonthlySalary_TB";
			this.MonthlySalary_TB.Size = new System.Drawing.Size(399, 33);
			this.MonthlySalary_TB.TabIndex = 1;
			// 
			// MonthlySalary_LBL
			// 
			this.MonthlySalary_LBL.AutoSize = true;
			this.MonthlySalary_LBL.Location = new System.Drawing.Point(24, 31);
			this.MonthlySalary_LBL.Name = "MonthlySalary_LBL";
			this.MonthlySalary_LBL.Size = new System.Drawing.Size(319, 25);
			this.MonthlySalary_LBL.TabIndex = 0;
			this.MonthlySalary_LBL.Text = "Enter your monthly gross salary in Rials *:";
			// 
			// SelectYear_LBL
			// 
			this.SelectYear_LBL.AutoSize = true;
			this.SelectYear_LBL.Location = new System.Drawing.Point(26, 124);
			this.SelectYear_LBL.Name = "SelectYear_LBL";
			this.SelectYear_LBL.Size = new System.Drawing.Size(111, 25);
			this.SelectYear_LBL.TabIndex = 4;
			this.SelectYear_LBL.Text = "Select year *:";
			// 
			// FourThreeYear_RBTN
			// 
			this.FourThreeYear_RBTN.AutoSize = true;
			this.FourThreeYear_RBTN.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FourThreeYear_RBTN.Location = new System.Drawing.Point(342, 124);
			this.FourThreeYear_RBTN.Name = "FourThreeYear_RBTN";
			this.FourThreeYear_RBTN.Size = new System.Drawing.Size(66, 29);
			this.FourThreeYear_RBTN.TabIndex = 5;
			this.FourThreeYear_RBTN.TabStop = true;
			this.FourThreeYear_RBTN.Text = "1404";
			this.FourThreeYear_RBTN.UseVisualStyleBackColor = true;
			// 
			// NumberOfDays_LBL
			// 
			this.NumberOfDays_LBL.AutoSize = true;
			this.NumberOfDays_LBL.Location = new System.Drawing.Point(24, 164);
			this.NumberOfDays_LBL.Name = "NumberOfDays_LBL";
			this.NumberOfDays_LBL.Size = new System.Drawing.Size(205, 25);
			this.NumberOfDays_LBL.TabIndex = 6;
			this.NumberOfDays_LBL.Text = "Number of days worked *:";
			// 
			// NumberOfDays_TB
			// 
			this.NumberOfDays_TB.BackColor = System.Drawing.SystemColors.Info;
			this.NumberOfDays_TB.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfDays_TB.Location = new System.Drawing.Point(342, 163);
			this.NumberOfDays_TB.Name = "NumberOfDays_TB";
			this.NumberOfDays_TB.Size = new System.Drawing.Size(399, 33);
			this.NumberOfDays_TB.TabIndex = 7;
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
	}
}