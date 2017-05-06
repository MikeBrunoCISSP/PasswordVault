using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordVault2
{
    public partial class Change_Password : Form
    {
        PasswordVault pv;
        PasswordQualityChecker pqc;
        HashManager hm;
        int attempts;

        public Change_Password(PasswordVault pd)
        {
            InitializeComponent();
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
            pv = pd;
            pqc = new PasswordQualityChecker();
            attempts = 0;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkFields() && (txtOldPassword.Text != ""))
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private bool checkFields()
        {
            if (txtNewPassword.Text == "")
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
            pqc.check(txtNewPassword.Text);

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
            if (txtNewPassword.Text == "")
            {
                lblPwdMatch.ForeColor = System.Drawing.Color.Red;
                passwordsMatch = false;
            }
            else
            {
                if (txtNewPassword.Text == txtConfirmNewPassword.Text)
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
        }

        private void txtConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkFields() && (txtOldPassword.Text != ""))
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            hm = new HashManager("SHA512", PasswordVault.hashIterations);

            if (hm.verify(txtOldPassword.Text, pv.passwordHash))
            {
                Result r = pv.resetPassword(txtNewPassword.Text);
                if (!r.success())
                {
                    r.display();
                    return;
                }

                MessageBox.Show("Your password has been changed.");
                this.Hide();
                Main app = new Main(pv, txtNewPassword.Text);
                app.ShowDialog();
                this.Close();
            }

            else
            {
                if (++attempts == 3)
                {
                    MessageBox.Show("Too many incorrect passwords entered.  Exiting.", "Password Vault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The current password you entered is incorrect.", "Password Vault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmNewPassword.Text = "";
                    btnOK.Enabled = false;
                }
            }
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (checkFields() && (txtOldPassword.Text != ""))
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }
    }
}
