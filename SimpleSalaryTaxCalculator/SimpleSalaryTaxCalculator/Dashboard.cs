// Ignore Spelling: FRM

using System;
using System.Windows.Forms;

namespace SimpleSalaryTaxCalculator
{
	public partial class Dashboard_FRM : Form
	{
		public Dashboard_FRM()
		{
			InitializeComponent();
		}

		//Reset Button
		private void Reset_BTN_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to clear the data?", "OK", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				MonthlySalary_TB.Clear();
				Month_COMB.SelectedIndex = 0;
				FourThreeYear_RBTN.Checked = true;
				NumberOfDays_TB.Clear();
				HiringDatePicker_DP.Value = DateTime.Now;
				Marital_COMB.SelectedIndex = -1;
				NumberOfCHildren_COMB.SelectedIndex = -1;
				NetPay_LBL.Text = "0";
			}
		}

		// Calculate button
		private void SalaryCalculation_BTN_Click(object sender, EventArgs e)
		{
			try
			{
				// Get inputs
				decimal monthlySalary = decimal.Parse(MonthlySalary_TB.Text);
				int monthIndex = Month_COMB.SelectedIndex + 1;
				DateTime hireDate = HiringDatePicker_DP.Value;
				bool isMarried = Marital_COMB.SelectedIndex == 0; // 0 = single, 1 = married
				int childrenCount = int.Parse(NumberOfCHildren_COMB.SelectedItem.ToString());

				// Number of days in a month
				int daysInMonth = (monthIndex >= 1 && monthIndex <= 6) ? 31 : 30;

				// Fixed values 1404
				decimal minMonthlySalary = 103909680m; // Minimum monthly wage
				decimal housingAllowance = 9000000m; // Housing allowance
				decimal groceryAllowance = 22000000m; // Grocery bin
				decimal marriageAllowance = isMarried ? 5000000m : 0m; // Marriage Allowance
				decimal childAllowanceOne = 10390968m; // Child Allowance for one child
				decimal seniorityBase = (hireDate.Year < 1403) ? 2820000m : 0m; // Seniority Base (at least 1 year of experience)

				// Set base salary to legal minimum if needed
				if (monthlySalary < minMonthlySalary)
				{
					monthlySalary = minMonthlySalary;
					MessageBox.Show("The entered salary is less than the legal minimum. Minimum salary 1404 applied.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

				// Calculate work experience
				DateTime currentDate = new DateTime(1404, monthIndex, 1);
				int yearsOfService = currentDate.Year - hireDate.Year;
				if (currentDate.Month < hireDate.Month ||
				(currentDate.Month == hireDate.Month && currentDate.Day < hireDate.Day))
				{
					yearsOfService--;
				}

				// Calculate child allowance based on number of children
				decimal totalChildAllowance = childrenCount * childAllowanceOne;

				// Calculate total fixed salary
				decimal totalFixedSalary = monthlySalary +
				housingAllowance +
				groceryAllowance +
				marriageAllowance +
				totalChildAllowance +
				seniorityBase;

				// Show result
				NetPay_LBL.Text = $"{totalFixedSalary:N0} Rials";

				// Show details
				string details = $"Base salary: {monthlySalary:N0}\n" +
				$"Housing allowance: {housingAllowance:N0}\n" +
				$"Grocery allowance: {groceryAllowance:N0}\n" +
				$"Marriage allowance: {marriageAllowance:N0}\n" +
				$"Child allowance: {totalChildAllowance:N0}\n" +
				$"Seniority base: {seniorityBase:N0}\n" +
				$"Total sum: {totalFixedSalary:N0}";
				MessageBox.Show(details, "Salary details", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please enter the inputs correctly.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}