namespace PasswordVault2
{
    partial class Enroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQ1Match = new System.Windows.Forms.Label();
            this.txtAnswer1Confirm = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxQuestion1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblQ2Match = new System.Windows.Forms.Label();
            this.txtAnswer2Confirm = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxQuestion2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblQ3Match = new System.Windows.Forms.Label();
            this.txtAnswer3Confirm = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxQuestion3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblDigit = new System.Windows.Forms.Label();
            this.lbl8chars = new System.Windows.Forms.Label();
            this.lblPwdMatch = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSpecial);
            this.groupBox1.Controls.Add(this.lblPwdMatch);
            this.groupBox1.Controls.Add(this.lbl8chars);
            this.groupBox1.Controls.Add(this.lblDigit);
            this.groupBox1.Controls.Add(this.lblLower);
            this.groupBox1.Controls.Add(this.lblUpper);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(100, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '∙';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(100, 228);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '∙';
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 21);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirm Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQ1Match);
            this.groupBox2.Controls.Add(this.txtAnswer1Confirm);
            this.groupBox2.Controls.Add(this.txtAnswer1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxQuestion1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(245, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recovery Question #1";
            // 
            // lblQ1Match
            // 
            this.lblQ1Match.AutoSize = true;
            this.lblQ1Match.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1Match.ForeColor = System.Drawing.Color.Red;
            this.lblQ1Match.Location = new System.Drawing.Point(20, 96);
            this.lblQ1Match.Name = "lblQ1Match";
            this.lblQ1Match.Size = new System.Drawing.Size(0, 11);
            this.lblQ1Match.TabIndex = 25;
            // 
            // txtAnswer1Confirm
            // 
            this.txtAnswer1Confirm.Enabled = false;
            this.txtAnswer1Confirm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1Confirm.Location = new System.Drawing.Point(107, 78);
            this.txtAnswer1Confirm.Name = "txtAnswer1Confirm";
            this.txtAnswer1Confirm.PasswordChar = '∙';
            this.txtAnswer1Confirm.Size = new System.Drawing.Size(255, 21);
            this.txtAnswer1Confirm.TabIndex = 4;
            this.txtAnswer1Confirm.TextChanged += new System.EventHandler(this.txtAnswer1Confirm_TextChanged);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Enabled = false;
            this.txtAnswer1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(107, 52);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.PasswordChar = '∙';
            this.txtAnswer1.Size = new System.Drawing.Size(255, 21);
            this.txtAnswer1.TabIndex = 3;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Answer:";
            // 
            // cbxQuestion1
            // 
            this.cbxQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuestion1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuestion1.FormattingEnabled = true;
            this.cbxQuestion1.Location = new System.Drawing.Point(107, 26);
            this.cbxQuestion1.Name = "cbxQuestion1";
            this.cbxQuestion1.Size = new System.Drawing.Size(255, 21);
            this.cbxQuestion1.TabIndex = 10;
            this.cbxQuestion1.TabStop = false;
            this.cbxQuestion1.SelectedIndexChanged += new System.EventHandler(this.cbxQuestion1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Question:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblQ2Match);
            this.groupBox3.Controls.Add(this.txtAnswer2Confirm);
            this.groupBox3.Controls.Add(this.txtAnswer2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxQuestion2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(245, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 113);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recovery Question #2";
            // 
            // lblQ2Match
            // 
            this.lblQ2Match.AutoSize = true;
            this.lblQ2Match.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2Match.ForeColor = System.Drawing.Color.Red;
            this.lblQ2Match.Location = new System.Drawing.Point(20, 96);
            this.lblQ2Match.Name = "lblQ2Match";
            this.lblQ2Match.Size = new System.Drawing.Size(0, 11);
            this.lblQ2Match.TabIndex = 26;
            // 
            // txtAnswer2Confirm
            // 
            this.txtAnswer2Confirm.Enabled = false;
            this.txtAnswer2Confirm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2Confirm.Location = new System.Drawing.Point(107, 78);
            this.txtAnswer2Confirm.Name = "txtAnswer2Confirm";
            this.txtAnswer2Confirm.PasswordChar = '∙';
            this.txtAnswer2Confirm.Size = new System.Drawing.Size(255, 21);
            this.txtAnswer2Confirm.TabIndex = 6;
            this.txtAnswer2Confirm.TextChanged += new System.EventHandler(this.txtAnswer2Confirm_TextChanged);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Enabled = false;
            this.txtAnswer2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(107, 52);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.PasswordChar = '∙';
            this.txtAnswer2.Size = new System.Drawing.Size(255, 21);
            this.txtAnswer2.TabIndex = 5;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirm Answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Answer:";
            // 
            // cbxQuestion2
            // 
            this.cbxQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuestion2.Enabled = false;
            this.cbxQuestion2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuestion2.FormattingEnabled = true;
            this.cbxQuestion2.Location = new System.Drawing.Point(107, 26);
            this.cbxQuestion2.Name = "cbxQuestion2";
            this.cbxQuestion2.Size = new System.Drawing.Size(255, 21);
            this.cbxQuestion2.TabIndex = 11;
            this.cbxQuestion2.TabStop = false;
            this.cbxQuestion2.SelectedIndexChanged += new System.EventHandler(this.cbxQuestion2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Select Question:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblQ3Match);
            this.groupBox4.Controls.Add(this.txtAnswer3Confirm);
            this.groupBox4.Controls.Add(this.txtAnswer3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbxQuestion3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(245, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 113);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recovery Question #3";
            // 
            // lblQ3Match
            // 
            this.lblQ3Match.AutoSize = true;
            this.lblQ3Match.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ3Match.ForeColor = System.Drawing.Color.Red;
            this.lblQ3Match.Location = new System.Drawing.Point(20, 95);
            this.lblQ3Match.Name = "lblQ3Match";
            this.lblQ3Match.Size = new System.Drawing.Size(0, 11);
            this.lblQ3Match.TabIndex = 27;
            // 
            // txtAnswer3Confirm
            // 
            this.txtAnswer3Confirm.Enabled = false;
            this.txtAnswer3Confirm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3Confirm.Location = new System.Drawing.Point(107, 78);
            this.txtAnswer3Confirm.Name = "txtAnswer3Confirm";
            this.txtAnswer3Confirm.PasswordChar = '∙';
            this.txtAnswer3Confirm.Size = new System.Drawing.Size(255, 21);
            this.txtAnswer3Confirm.TabIndex = 8;
            this.txtAnswer3Confirm.TextChanged += new System.EventHandler(this.txtAnswer3Confirm_TextChanged);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Enabled = false;
            this.txtAnswer3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.Location = new System.Drawing.Point(107, 52);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.PasswordChar = '∙';
            this.txtAnswer3.Size = new System.Drawing.Size(255, 21);
            this.txtAnswer3.TabIndex = 7;
            this.txtAnswer3.TextChanged += new System.EventHandler(this.txtAnswer3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Confirm Answer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Answer:";
            // 
            // cbxQuestion3
            // 
            this.cbxQuestion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuestion3.Enabled = false;
            this.cbxQuestion3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuestion3.FormattingEnabled = true;
            this.cbxQuestion3.Location = new System.Drawing.Point(107, 26);
            this.cbxQuestion3.Name = "cbxQuestion3";
            this.cbxQuestion3.Size = new System.Drawing.Size(255, 21);
            this.cbxQuestion3.TabIndex = 12;
            this.cbxQuestion3.TabStop = false;
            this.cbxQuestion3.SelectedIndexChanged += new System.EventHandler(this.cbxQuestion3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Select Question:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(13, 277);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(226, 81);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Get Started!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Complexity Requirements:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.ForeColor = System.Drawing.Color.Red;
            this.lblUpper.Location = new System.Drawing.Point(11, 47);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(138, 13);
            this.lblUpper.TabIndex = 26;
            this.lblUpper.Text = "At least 1 upper case letter";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.ForeColor = System.Drawing.Color.Red;
            this.lblLower.Location = new System.Drawing.Point(11, 70);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(136, 13);
            this.lblLower.TabIndex = 27;
            this.lblLower.Text = "At least 1 lower case letter";
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.ForeColor = System.Drawing.Color.Red;
            this.lblDigit.Location = new System.Drawing.Point(11, 94);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(76, 13);
            this.lblDigit.TabIndex = 28;
            this.lblDigit.Text = "At least 1 digit";
            // 
            // lbl8chars
            // 
            this.lbl8chars.AutoSize = true;
            this.lbl8chars.ForeColor = System.Drawing.Color.Red;
            this.lbl8chars.Location = new System.Drawing.Point(11, 118);
            this.lbl8chars.Name = "lbl8chars";
            this.lbl8chars.Size = new System.Drawing.Size(147, 13);
            this.lbl8chars.TabIndex = 29;
            this.lbl8chars.Text = "Must be at least 8 characters";
            // 
            // lblPwdMatch
            // 
            this.lblPwdMatch.AutoSize = true;
            this.lblPwdMatch.ForeColor = System.Drawing.Color.Red;
            this.lblPwdMatch.Location = new System.Drawing.Point(11, 171);
            this.lblPwdMatch.Name = "lblPwdMatch";
            this.lblPwdMatch.Size = new System.Drawing.Size(116, 13);
            this.lblPwdMatch.TabIndex = 30;
            this.lblPwdMatch.Text = "Passwords must match";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.ForeColor = System.Drawing.Color.Red;
            this.lblSpecial.Location = new System.Drawing.Point(11, 145);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(206, 13);
            this.lblSpecial.TabIndex = 31;
            this.lblSpecial.Text = "Must contain at least 1 symbol (*%!, etc)";
            // 
            // Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 371);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Enroll";
            this.Text = "Password Vault - Welcome!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxQuestion1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnswer1Confirm;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAnswer2Confirm;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxQuestion2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAnswer3Confirm;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxQuestion3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQ1Match;
        private System.Windows.Forms.Label lblQ2Match;
        private System.Windows.Forms.Label lblQ3Match;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPwdMatch;
        private System.Windows.Forms.Label lbl8chars;
        private System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblSpecial;

    }
}