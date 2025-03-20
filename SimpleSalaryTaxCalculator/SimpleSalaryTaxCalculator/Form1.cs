// Ignore Spelling: FRM

using SimpleSalaryTaxCalculator.Windows;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleSalaryTaxCalculator
{
	public partial class LoginForm_FRM : Form
	{
		#region PublicVariablse
		string UserNamePass = "admin";
		public int counter = 0;
		#endregion
		public LoginForm_FRM()
		{
			InitializeComponent();
			ShowKeys_BTN.Visible = false;
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

		// Show Password
		private void ShowHide_BTN_Click(object sender, EventArgs e)
		{
			if (PassWord_TB.PasswordChar == '*') // If currently showing asterisks
			{
				PassWord_TB.PasswordChar = '\0'; // Show plain text
				ShowHide_BTN.Size = new Size(40, 40);
				ShowHide_BTN.Image = Properties.Resources.EyeClose;
			}
			else // If currently showing plain text
			{
				PassWord_TB.PasswordChar = '*'; // Show asterisks
				ShowHide_BTN.Size = new Size(40, 40);
				ShowHide_BTN.Image = Properties.Resources.ShowEye;
			}
		}

		// Login Button
		private void Login_BTN_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(UserName_TB.Text))
			{
				DialogResult result = MessageBox.Show("UserName Is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (string.IsNullOrWhiteSpace(PassWord_TB.Text))
			{
				DialogResult result = MessageBox.Show("PassWord Is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				if (UserName_TB.Text == UserNamePass && PassWord_TB.Text == UserNamePass)
				{
					DialogResult result = MessageBox.Show($"Login Was Successful \"{UserNamePass}\"", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Dashboard_FRM form = new Dashboard_FRM();
					this.Hide();
					form.Show();
				}
				else
				{
					DialogResult result = MessageBox.Show("UserName Or PassWord is Wrong, If It Is Visible!!!, Please Check Info Button In The Bottom-Left Panel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					counter++;
					if (counter == 3)
					{
						this.Enabled = false;

						using (WaitingForm waitingForm = new WaitingForm())
						{
							waitingForm.ShowDialog(this); // Show the waiting form and let it handle its own closing
						}

						this.Enabled = true;
						ShowKeys_BTN.Visible = true;
						counter = 0; // Reset counter after lockout
					}
				}
			}
		}
	}
}
