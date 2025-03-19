// Ignore Spelling: FRM

using System;
using System.Windows.Forms;

namespace SimpleSalaryTaxCalculator
{
	public partial class LoginForm_FRM : Form
	{
		public LoginForm_FRM()
		{
			InitializeComponent();
		}

		// Link Image
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			// URL to open 
			string url = "https://github.com/KASRA10";
			try
			{
				// Use Process.Start to open the URL in the default browser 
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true // Ensures it uses the default browser 
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable 
				MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		// Show UserNAme And PassWord
		private void ShowKeys_BTN_Click(object sender, EventArgs e)
		{
			if (UserNameStar_LBL.Visible == true && PassWOrdStar_LBL.Visible == true)
			{
				UserNameStar_LBL.Visible = false;
				PassWOrdStar_LBL.Visible = false;
			}
			else
			{
				UserNameStar_LBL.Visible = true;
				PassWOrdStar_LBL.Visible = true;
			}
		}
	}
}
