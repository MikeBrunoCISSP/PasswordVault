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
    public partial class Change_Account : Form
    {
        Account account;
        string old_desc;
        PasswordVault pd;

        public Change_Account(PasswordVault mainPD, Account a)
        {
            InitializeComponent();
            txtAccount.Text = a.get_name();
            txtUsername.Text = a.get_username();
            txtPassword.Text = a.get_password();
            txtConfirmPassword.Text = a.get_password();
            txtURL.Text = a.get_url();

            account = a;
            pd = mainPD;
            old_desc = a.description;
            AcceptButton = btnOK;
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void checkInput()
        {
            if ((txtAccount.Text == "") ||
                (txtUsername.Text == "") ||
                (txtPassword.Text == "") ||
                (txtConfirmPassword.Text == "") ||
                (txtURL.Text == "")
                )
            {

                btnOK.Enabled = false;
                lblCheckInput.Text = "All fields must be completed.";
                return;
            }

            if (!(String.Equals(txtPassword.Text, txtConfirmPassword.Text)))
            {
                btnOK.Enabled = false;
                lblCheckInput.Text = "Passwords must match.";
                return;
            }

            lblCheckInput.Text = "";
            btnOK.Enabled = true;
        } */

        private void checkInput()
        {
            if ((txtAccount.Text == "") || (txtUsername.Text == "") || (txtPassword.Text == "") || (txtConfirmPassword.Text == "") || (txtURL.Text == ""))
                btnOK.Enabled = false;
            else
                btnOK.Enabled = checkPasswords();
        }

        private bool checkPasswords()
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
                return false;

            return true;
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!checkPasswords())
                lblMustMatch.Text = "Password Entries must match!";
            else
                lblMustMatch.Text = "";

            checkInput();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!checkPasswords())
                lblMustMatch.Text = "Password Entries must match!";
            else
                lblMustMatch.Text = "";

            checkInput();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r = pd.editEntry(old_desc, txtAccount.Text, txtUsername.Text, txtPassword.Text, txtURL.Text);
            if (!r.success())
            {
                r.display();
                return;
            }

            this.Close();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to replace the current password on this account with a random password?  The old password will not be recoverable.", "Password Vault - Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (var form = new Generate_Random_Password())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string rndPassword = form.password;
                        this.txtPassword.Text = rndPassword;
                        this.txtConfirmPassword.Text = rndPassword;
                    }
                }
            }
        }
    }
}
