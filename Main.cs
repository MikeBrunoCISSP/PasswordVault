using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace PasswordVault2
{
    public partial class Main : Form
    {
        PasswordVault pd;
        string password;
        private static int passwordLifeInSeconds = 20;

        public Main(PasswordVault mainPD, string pwd)
        {
            InitializeComponent();
            pd = mainPD;
            password = pwd;
            //lstAccounts.DataSource = pd.accountDescriptions;
            lifeBar.Visible = false;
            rePopulateAccountList();
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Entry add = new Add_Entry(pd);
            add.ShowDialog();
            Result r = pd.read(password);
            if (!r.success())
                r.display();
            //lstAccounts.DataSource = pd.accountDescriptions;
            rePopulateAccountList();
        }



        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedIndex != -1)
                //stdlib.grab(pd.getAccountPassword(lstAccounts.Text));
                getPassword(passwordLifeInSeconds);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedIndex == -1)
                return;

            DialogResult result = MessageBox.Show("Are you sure that you want to delete this account from your password vault?", "Password Vault", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            Result r = new Result();
            r = pd.removeEntry(lstAccounts.Text);
            if (!r.success())
            {
                r.display();
                return;
            }

            //lstAccounts.DataSource = pd.accountDescriptions;
            rePopulateAccountList();
            lstAccounts.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedIndex == -1)
                return;

            Account account = pd.get_account(lstAccounts.Text);
            Change_Account change = new Change_Account(pd, account);
            change.ShowDialog();
            Result r = pd.read(password);
            if (!r.success())
                r.display();
            //lstAccounts.DataSource = pd.accountDescriptions;
            rePopulateAccountList();
            lstAccounts.SelectedIndex = -1;
        }

        private void btnCopyURL_Click(object sender, EventArgs e)
        {
            copyAndGotoPage();
        }

        private void lstAccounts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            copyAndGotoPage();
        }

        private void copyAndGotoPage()
        {
            try
            {
                //stdlib.grab(pd.getAccountPassword(lstAccounts.Text));
                getPassword(passwordLifeInSeconds);
                string URL = pd.getURL(lstAccounts.Text);
                if (URL != null)
                    Process.Start(pd.getURL(lstAccounts.Text));
            }
            catch (NullReferenceException) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This operation will export all information about all of your accounts (including passwords) to an unsecured file.  Are you sure that you want to do this?", "Password Vault", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;

            ReEnterPassword rep = new ReEnterPassword(pd.passwordHash);
            rep.ShowDialog();
            if (!rep.success)
                this.Close();
            else
            {
                SaveFileDialog exportFile = new SaveFileDialog();
                exportFile.Filter = "Comma Separated Values|*.csv|Text File|*.txt";
                exportFile.Title = "Specify a file name";
                exportFile.ShowDialog();

                if (exportFile.FileName != "")
                {
                    Result r = pd.export(exportFile.FileName);
                    if (r.success())
                        MessageBox.Show(r.get_message(), "Password Vault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(r.get_message(), "Password Vault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password cp = new Change_Password(pd);
            cp.ShowDialog();
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Comma Separated Values|*.csv";
            ofd.Title = "Select file to import from";
            ofd.ShowDialog();

            if (ofd.FileName == "")
                return;

            if (!File.Exists(ofd.FileName))
            {
                MessageBox.Show("The file was not found: \"" + ofd.FileName + "\"");
                return;
            }

            if (!pd.import(ofd.FileName).success())
                MessageBox.Show("Not all entries were imported successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //lstAccounts.DataSource = pd.accountDescriptions;
            rePopulateAccountList();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedIndex != -1)
                MessageBox.Show(pd.getAccountPassword(lstAccounts.Text), "Password Vault", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rePopulateAccountList()
        {
            List<string> accountsToDisplay;

            if (String.IsNullOrEmpty(txtFilter.Text))
                lstAccounts.DataSource = pd.accountDescriptions;
            else
            {
                accountsToDisplay = new List<string>();
                Regex r = new Regex(txtFilter.Text, RegexOptions.IgnoreCase);
                Match m;

                foreach (string description in pd.accountDescriptions)
                {
                    m = r.Match(description);
                    if (m.Success)
                        accountsToDisplay.Add(description);
                }

                lstAccounts.DataSource = accountsToDisplay;
            }

            lstAccounts.Update();
            lstAccounts.SelectedIndex = -1;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            rePopulateAccountList();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = String.Empty;
            rePopulateAccountList();
        }

        private void getPassword(int lifeInSeconds)
        {
            int maxLifeBarValue = lifeInSeconds * 10;
            if (lstAccounts.SelectedIndex == -1)
                return;

            Thread t = new Thread
            (delegate ()
            {
                Invoke((MethodInvoker)delegate
                {
                    lifeBar.Maximum = maxLifeBarValue;
                    lifeBar.Value = maxLifeBarValue;
                    lifeBar.Visible = true;
                    stdlib.grab(pd.getAccountPassword(lstAccounts.Text));
                });
                //Clipboard.SetText(pd.getAccountPassword(lstAccounts.Text));
                for (int x = maxLifeBarValue; x >= 0; x--)
                {
                    Thread.Sleep(100);
                    Invoke((MethodInvoker)delegate
                    {
                        lifeBar.Value = x;
                    });
                }
                stdlib.clearClipBoard();

                Invoke((MethodInvoker)delegate
                {
                    lifeBar.Visible = false;
                });
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
