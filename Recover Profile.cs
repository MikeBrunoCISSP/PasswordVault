using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PasswordVault2
{
    public partial class Recover_Profile : Form
    {
        public Recover_Profile()
        {
            InitializeComponent();

            //Get question numbers
            TextReader tr = new StreamReader(PasswordVault.file);

            //Skip the first 5 lines
            tr.ReadLine(); tr.ReadLine(); tr.ReadLine(); tr.ReadLine(); tr.ReadLine();

            //Get the question numbers and load them into an array of strings
            string[] qNums = tr.ReadLine().Split(',');
            if (qNums.Length != 3)
            {
                MessageBox.Show("Recovery data is corrupt.  Recovery will not be possible");
                return;
            }

            //Get the recovery question text & populate the labels
            RecoveryQuestions rq = new RecoveryQuestions();
            rq.create();
            lblQuestion1.Text = rq.get_text(Convert.ToInt16(qNums[0]));
            lblQuestion2.Text = rq.get_text(Convert.ToInt16(qNums[1]));
            lblQuestion3.Text = rq.get_text(Convert.ToInt16(qNums[2]));

            AcceptButton = btnOK;
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }

        private void checkInput()
        {
            if ((txtAnswer1.Text == "") || (txtAnswer2.Text == "") || (txtAnswer3.Text == ""))
                btnOK.Enabled = false;
            else
                btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PasswordVault pd = new PasswordVault();
            Result r = pd.recoverKey(txtAnswer1.Text, txtAnswer2.Text, txtAnswer3.Text);
            if (!r.success())
            {
                r.display();
                return;
            }
            pd.read(r.get_message());
            this.Hide();
            Reset_Password rp = new Reset_Password(pd, r.get_message(), false);
            rp.ShowDialog();
            this.Close();
        }
    }
}
