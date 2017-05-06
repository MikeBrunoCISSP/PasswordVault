namespace PasswordVault2
{
    partial class Generate_Random_Password
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
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.chkLower = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Checked = true;
            this.chkUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpper.Location = new System.Drawing.Point(26, 25);
            this.chkUpper.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(230, 29);
            this.chkUpper.TabIndex = 0;
            this.chkUpper.Text = "Upper Case Letters";
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.CheckedChanged += new System.EventHandler(this.chkUpper_CheckedChanged);
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Checked = true;
            this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigits.Location = new System.Drawing.Point(26, 107);
            this.chkDigits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(98, 29);
            this.chkDigits.TabIndex = 1;
            this.chkDigits.Text = "Digits";
            this.chkDigits.UseVisualStyleBackColor = true;
            this.chkDigits.CheckedChanged += new System.EventHandler(this.chkDigits_CheckedChanged);
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Checked = true;
            this.chkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymbols.Location = new System.Drawing.Point(26, 148);
            this.chkSymbols.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(230, 29);
            this.chkSymbols.TabIndex = 2;
            this.chkSymbols.Text = "Symbols (e.g. # $ & )";
            this.chkSymbols.UseVisualStyleBackColor = true;
            this.chkSymbols.CheckedChanged += new System.EventHandler(this.chkSymbols_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerate.Location = new System.Drawing.Point(458, 284);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 44);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Length:";
            // 
            // nUDPasswordLength
            // 
            this.nUDPasswordLength.Location = new System.Drawing.Point(214, 279);
            this.nUDPasswordLength.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nUDPasswordLength.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nUDPasswordLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDPasswordLength.Name = "nUDPasswordLength";
            this.nUDPasswordLength.Size = new System.Drawing.Size(80, 31);
            this.nUDPasswordLength.TabIndex = 5;
            this.nUDPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(26, 66);
            this.chkLower.Margin = new System.Windows.Forms.Padding(6);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(230, 29);
            this.chkLower.TabIndex = 6;
            this.chkLower.Text = "Lower Case Letters";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // Generate_Random_Password
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 343);
            this.Controls.Add(this.chkLower);
            this.Controls.Add(this.nUDPasswordLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.chkDigits);
            this.Controls.Add(this.chkUpper);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Generate_Random_Password";
            this.Text = "Password Vault - Generate Random Password";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDPasswordLength;
        private System.Windows.Forms.CheckBox chkLower;
    }
}