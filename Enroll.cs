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
    public partial class Enroll : Form
    {
        RecoveryQuestions rq;
        PasswordVault pd;
        PasswordQualityChecker pqc;
        bool acceptablePassword;

        public Enroll()
        {
            InitializeComponent();
            pqc = new PasswordQualityChecker();
            acceptablePassword = false;
            rq = new RecoveryQuestions();
            rq.create();
            cbxQuestion1.DataSource = rq.get_allQuestions();
            AcceptButton = btnSubmit;
            System.Drawing.Icon ico = PasswordVault2.Properties.Resources.vault;
            this.Icon = ico;
        }

        private void validate()
        {
            if ((txtPassword.Text.Length >= 8) &&
                (validateGroup(txtPassword.Text, txtConfirmPassword.Text)) &&
                (validateGroup(txtAnswer1.Text, txtAnswer1Confirm.Text)) &&
                (validateGroup(txtAnswer2.Text, txtAnswer2Confirm.Text)) &&
                (validateGroup(txtAnswer3.Text, txtAnswer3Confirm.Text))
                )

                btnSubmit.Enabled = true;
        }

        private static bool validateGroup(string item1, string item2)
        {
            if ((item1 != "") && (item1 == item2))
                return true;

            return false;
        }

        private void txtAnswer1Confirm_TextChanged(object sender, EventArgs e)
        {
            if ((txtAnswer1Confirm.Text != "") && (txtAnswer1.Text == txtAnswer1Confirm.Text))
            {
                cbxQuestion2.DataSource = rq.get_subset(cbxQuestion1.Text);
                cbxQuestion2.Enabled = true;
                lblQ1Match.Text = "";
            }
            else
                lblQ1Match.Text = "Answers must match!";

            checkInput();
        }

        private void txtAnswer2Confirm_TextChanged(object sender, EventArgs e)
        {
            if ((txtAnswer2Confirm.Text != "") && (txtAnswer2.Text == txtAnswer2Confirm.Text))
            {
                cbxQuestion3.DataSource = rq.get_subset(cbxQuestion1.Text, cbxQuestion2.Text);
                cbxQuestion3.Enabled = true;
                lblQ2Match.Text = "";
            }
            else
                lblQ2Match.Text = "Answers must match!";

            checkInput();
        }

        private void txtAnswer3Confirm_TextChanged(object sender, EventArgs e)
        {
            if ((txtAnswer3Confirm.Text != "") && (txtAnswer3.Text == txtAnswer3Confirm.Text))
                lblQ3Match.Text = "";
            else
                lblQ3Match.Text = "Answers must match!";

            checkInput();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            acceptablePassword = checkPasswords();
            checkInput();
        }

        private void cbxQuestion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnswer1.Enabled = true;
            txtAnswer1Confirm.Enabled = true;
            txtAnswer1.Focus();
        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            if ((txtAnswer1.Text != "") && (txtAnswer1.Text == txtAnswer1Confirm.Text))
            {
                cbxQuestion2.DataSource = rq.get_subset(cbxQuestion1.Text);
                cbxQuestion2.Enabled = true;
                lblQ1Match.Text = "";
            }
            else
                lblQ1Match.Text = "Answers must match!";
            checkInput();
        }

        private void cbxQuestion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnswer2.Enabled = true;
            txtAnswer2Confirm.Enabled = true;
            txtAnswer2.Focus();
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            if ((txtAnswer2.Text != "") && (txtAnswer2.Text == txtAnswer2Confirm.Text))
            {
                cbxQuestion3.DataSource = rq.get_subset(cbxQuestion1.Text, cbxQuestion2.Text);
                cbxQuestion3.Enabled = true;
                lblQ2Match.Text = "";
            }
            else
                lblQ2Match.Text = "Answers must match!";

            checkInput();
        }

        private void cbxQuestion3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnswer3.Enabled = true;
            txtAnswer3Confirm.Enabled = true;
            txtAnswer3.Focus();
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            if ((txtAnswer3.Text != "") && (txtAnswer3.Text == txtAnswer3Confirm.Text))
                lblQ3Match.Text = "";
            else
                lblQ3Match.Text = "Answers must match!";

            checkInput();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            acceptablePassword = checkPasswords();
            checkInput();
        }

        private bool checkPasswords()
        {
            bool passwordsMatch = false;
            /*if ((txtPassword.Text != txtConfirmPassword.Text) || (txtPassword.Text == ""))
            {
                lblPwdMatch.ForeColor = System.Drawing.Color.Red;
                lblUpper.ForeColor = System.Drawing.Color.Red;
                lblLower.ForeColor = System.Drawing.Color.Red;
                lblDigit.ForeColor = System.Drawing.Color.Red;
                lblSpecial.ForeColor = System.Drawing.Color.Red;
                lbl8chars.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            lblPwdMatch.ForeColor = System.Drawing.Color.Green; */
            pqc.check(txtPassword.Text);

            //Must have at least 1 upper case letter
            if (pqc.hasUpper)
                lblUpper.ForeColor = System.Drawing.Color.Green;
            else
                lblUpper.ForeColor = System.Drawing.Color.Red;

            //Must have at least 1 lower case letter
            if (pqc.hasLower)
                lblLower.ForeColor = System.Drawing.Color.Green;
            else
                lblLower.ForeColor = System.Drawing.Color.Red;

            //Must have at least 1 digit
            if (pqc.hasDigit)
                lblDigit.ForeColor = System.Drawing.Color.Green;
            else
                lblDigit.ForeColor = System.Drawing.Color.Red;

            //Must have at least 1 special character
            if (pqc.hasSpecial)
                lblSpecial.ForeColor = System.Drawing.Color.Green;
            else
                lblSpecial.ForeColor = System.Drawing.Color.Red;

            //Must be at least 8 characters
            if (pqc.hasAtLeast8Chars)
                lbl8chars.ForeColor = System.Drawing.Color.Green;
            else
                lbl8chars.ForeColor = System.Drawing.Color.Red;

            //Passwords must match
            if (txtPassword.Text == "")
            {
                passwordsMatch = false;
                lblPwdMatch.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    passwordsMatch = true;
                    lblPwdMatch.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    passwordsMatch = false;
                    lblPwdMatch.ForeColor = System.Drawing.Color.Red;
                }
            }

            return (pqc.isAcceptable && passwordsMatch);
        }

        private void checkInput()
        {
            if ((txtAnswer1.Text == "") || (txtAnswer2.Text == "") || (txtAnswer3.Text == "") || (txtPassword.Text == ""))
            {
                btnSubmit.Enabled = false;
                return;
            }

            if ((acceptablePassword) &&
                (txtAnswer1.Text == txtAnswer1Confirm.Text) &&
                (txtAnswer2.Text == txtAnswer2Confirm.Text) &&
                (txtAnswer3.Text == txtAnswer3Confirm.Text))
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Result r = initialize(txtPassword.Text, 
                                  cbxQuestion1.Text, 
                                  cbxQuestion2.Text, 
                                  cbxQuestion3.Text, 
                                  txtAnswer1.Text, 
                                  txtAnswer2.Text, 
                                  txtAnswer3.Text);

            if (!r.success())
            {
                r.display();
                Application.Exit();
            }

            else
            {
                this.Hide();
                Main app = new Main(pd, txtPassword.Text);
                app.ShowDialog();
                this.Close();
            }
        }

        private Result initialize(string password, string question1, string question2, string question3, string answer1, string answer2, string answer3)
        {
            Result r = new Result();

            try
            {
                string concatenatedAnswers = (answer1 + answer2 + answer3).ToUpper();
                pd = new PasswordVault();
                return pd.createDB(password, concatenatedAnswers, question1, question2, question3);
            }

            catch (Exception e)
            {
                r.failure("An error occurred when initializing the PasswordVaut database", e);
            }

            return r;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

    }
}
