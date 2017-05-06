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
    public partial class ReEnterPassword : Form
    {
        int attempts;
        public bool success;
        HashManager hm;
        string passwordHash;

        public ReEnterPassword(string hash)
        {
            InitializeComponent();
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
            attempts = 0;
            success = false;
            hm = new HashManager("SHA512", PasswordVault.hashIterations);
            passwordHash = hash;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblIncorrect.Text = "";
            if (txtPassword.Text == "")
                btnEnter.Enabled = false;
            else
                btnEnter.Enabled = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (hm.verify(txtPassword.Text, passwordHash))
            {
                success = true;
                this.Close();
            }

            else
            {
                if (++attempts == 3)
                {
                    MessageBox.Show("Too many incorrect passwords entered.  Exiting.", "Password Vault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                    this.Close();
                }

                else
                {
                    lblIncorrect.Text = "Incorrect password.";
                    txtPassword.Text = "";
                }
            }
        }
    }
}
