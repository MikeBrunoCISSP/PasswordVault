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
    public partial class Login : Form
    {
        PasswordVault pd;

        public Login()
        {
            InitializeComponent();
            AcceptButton = btnLogIn;
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
                btnLogIn.Enabled = true;
            else
                btnLogIn.Enabled = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            pd = new PasswordVault();
            r = pd.read(txtPassword.Text);
            if (!r.success())
            {
                r.display();
                txtPassword.Text = "";
                return;
            }

            this.Hide();
            Main app = new Main(pd, txtPassword.Text);
            app.ShowDialog();
            this.Close();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recover_Profile rp = new Recover_Profile();
            rp.ShowDialog();
            this.Close();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password rp = new Change_Password();
            rp.ShowDialog();
            this.Close();
        } */
    }
}
