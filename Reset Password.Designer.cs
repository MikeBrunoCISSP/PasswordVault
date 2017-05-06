namespace PasswordVault2
{
    partial class Reset_Password
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblPwdMatch = new System.Windows.Forms.Label();
            this.lbl8chars = new System.Windows.Forms.Label();
            this.lblDigit = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMustMatch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(128, 89);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.ForeColor = System.Drawing.Color.Red;
            this.lblSpecial.Location = new System.Drawing.Point(12, 109);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(194, 13);
            this.lblSpecial.TabIndex = 37;
            this.lblSpecial.Text = "Must contain at least 1 symbol (*%!, etc)";
            // 
            // lblPwdMatch
            // 
            this.lblPwdMatch.AutoSize = true;
            this.lblPwdMatch.ForeColor = System.Drawing.Color.Red;
            this.lblPwdMatch.Location = new System.Drawing.Point(12, 129);
            this.lblPwdMatch.Name = "lblPwdMatch";
            this.lblPwdMatch.Size = new System.Drawing.Size(115, 13);
            this.lblPwdMatch.TabIndex = 36;
            this.lblPwdMatch.Text = "Passwords must match";
            // 
            // lbl8chars
            // 
            this.lbl8chars.AutoSize = true;
            this.lbl8chars.ForeColor = System.Drawing.Color.Red;
            this.lbl8chars.Location = new System.Drawing.Point(12, 89);
            this.lbl8chars.Name = "lbl8chars";
            this.lbl8chars.Size = new System.Drawing.Size(144, 13);
            this.lbl8chars.TabIndex = 35;
            this.lbl8chars.Text = "Must be at least 8 characters";
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.ForeColor = System.Drawing.Color.Red;
            this.lblDigit.Location = new System.Drawing.Point(12, 70);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(73, 13);
            this.lblDigit.TabIndex = 34;
            this.lblDigit.Text = "At least 1 digit";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.ForeColor = System.Drawing.Color.Red;
            this.lblLower.Location = new System.Drawing.Point(12, 50);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(131, 13);
            this.lblLower.TabIndex = 33;
            this.lblLower.Text = "At least 1 lower case letter";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.ForeColor = System.Drawing.Color.Red;
            this.lblUpper.Location = new System.Drawing.Point(12, 30);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(133, 13);
            this.lblUpper.TabIndex = 32;
            this.lblUpper.Text = "At least 1 upper case letter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Your password must contain:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(103, 58);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '∙';
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 21);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(103, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '∙';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblMustMatch
            // 
            this.lblMustMatch.AutoSize = true;
            this.lblMustMatch.ForeColor = System.Drawing.Color.Red;
            this.lblMustMatch.Location = new System.Drawing.Point(7, 113);
            this.lblMustMatch.Name = "lblMustMatch";
            this.lblMustMatch.Size = new System.Drawing.Size(0, 13);
            this.lblMustMatch.TabIndex = 13;
            this.lblMustMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.lblMustMatch);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(228, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset Password";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(47, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 155);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.lblPwdMatch);
            this.Controls.Add(this.lbl8chars);
            this.Controls.Add(this.lblDigit);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reset_Password";
            this.Text = "Password Vault - Reset Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblPwdMatch;
        private System.Windows.Forms.Label lbl8chars;
        private System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMustMatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}