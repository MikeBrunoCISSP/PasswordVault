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
    public partial class Add_Entry : Form
    {
        PasswordVault pd;

        public Add_Entry(PasswordVault mainPD)
        {
            InitializeComponent();
            pd = mainPD;

            AcceptButton = btnOK;
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r = pd.createEntry(txtAccount.Text, txtUsername.Text, txtPassword.Text, txtURL.Text);
            if (!r.success())
            {
                r.display();
                return;
            }

            this.Close();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
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
