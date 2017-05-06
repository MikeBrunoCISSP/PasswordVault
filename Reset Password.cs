using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordVault2
{
    public partial class Reset_Password : Form
    {
        PasswordVault pd;
        string oldPassword;
        PasswordQualityChecker pqc;

        public Reset_Password(PasswordVault pd0, string oldpwd, bool allowCancel)
        {
            //DEBUG
            TextWriter outfile = new StreamWriter(@"C:\pv_resetpass.txt");
            outfile.WriteLine(oldpwd);
            outfile.Close();
            //DEBUG

            InitializeComponent();
            AcceptButton = btnOK;
            if (!allowCancel) btnCancel.Enabled = false;
            pd = pd0;
            pqc = new PasswordQualityChecker();
            /*txtOldPassword.Text = oldpwd;
            txtOldPassword.Enabled = false; */
            oldPassword = oldpwd;
            AcceptButton = btnOK;
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        public Reset_Password()
        {
            InitializeComponent();
            AcceptButton = btnOK;
            pd = new PasswordVault();
            pqc = new PasswordQualityChecker();
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkFields())
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }



        private bool checkFields()
        {
            if (txtPassword.Text == "")
            {
                lblUpper.ForeColor = System.Drawing.Color.Red;
                lblLower.ForeColor = System.Drawing.Color.Red;
                lblDigit.ForeColor = System.Drawing.Color.Red;
                lbl8chars.ForeColor = System.Drawing.Color.Red;
                lblPwdMatch.ForeColor = System.Drawing.Color.Red;
                lblSpecial.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            bool passwordsMatch = false;
            pqc.check(txtPassword.Text);

            //Check for Uppercase character
            if (pqc.hasUpper)
                lblUpper.ForeColor = System.Drawing.Color.Green;
            else
                lblUpper.ForeColor = System.Drawing.Color.Red;

            //Check for Lowercase character
            if (pqc.hasLower)
                lblLower.ForeColor = System.Drawing.Color.Green;
            else
                lblLower.ForeColor = System.Drawing.Color.Red;

            //Check for Digit character
            if (pqc.hasDigit)
                lblDigit.ForeColor = System.Drawing.Color.Green;
            else
                lblDigit.ForeColor = System.Drawing.Color.Red;

            //Check for Special character
            if (pqc.hasSpecial)
                lblSpecial.ForeColor = System.Drawing.Color.Green;
            else
                lblSpecial.ForeColor = System.Drawing.Color.Red;

            //Check for at least 8 characters
            if (pqc.hasAtLeast8Chars)
                lbl8chars.ForeColor = System.Drawing.Color.Green;
            else
                lbl8chars.ForeColor = System.Drawing.Color.Red;

            //Check whether the passwords match
            if (txtPassword.Text == "")
            {
                lblPwdMatch.ForeColor = System.Drawing.Color.Red;
                passwordsMatch = false;
            }
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    lblPwdMatch.ForeColor = System.Drawing.Color.Green;
                    passwordsMatch = true;
                }
                else
                {
                    lblPwdMatch.ForeColor = System.Drawing.Color.Red;
                    passwordsMatch = false;
                }
            }

            return (passwordsMatch && pqc.isAcceptable);

            /*if ((txtPassword.Text != "") && (txtPassword.Text == txtConfirmPassword.Text))
            {
                if (txtPassword.Text.Length < 8)
                {
                    btnOK.Enabled = false;
                    lblMustMatch.Text = "Password must be at least 8 characters!";
                    return false;
                }
                else
                {
                    btnOK.Enabled = true;
                    lblMustMatch.Text = "";
                    return true;
                }
            }
            else
            {
                btnOK.Enabled = false;
                lblMustMatch.Text = "Entries must match!";
                return false;
            } */
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkFields())
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result r = pd.resetPassword(oldPassword, txtPassword.Text);
            if (!r.success())
            {
                r.display();
                return;
            }

            MessageBox.Show("Your password has been changed.");
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
