namespace PasswordVault2
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCopyURL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lifeBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAccounts
            // 
            this.lstAccounts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 31;
            this.lstAccounts.Location = new System.Drawing.Point(13, 13);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(425, 314);
            this.lstAccounts.TabIndex = 0;
            this.lstAccounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAccounts_MouseDoubleClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::PasswordVault2.Properties.Resources.clipboard;
            this.btnCopy.Location = new System.Drawing.Point(259, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(38, 39);
            this.btnCopy.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCopy, "Copy password to clipboard");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PasswordVault2.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(13, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 39);
            this.btnAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnAdd, "Add a new account");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PasswordVault2.Properties.Resources.remove;
            this.btnDelete.Location = new System.Drawing.Point(47, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 39);
            this.btnDelete.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnDelete, "Remove the selected account");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PasswordVault2.Properties.Resources.change;
            this.btnEdit.Location = new System.Drawing.Point(88, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 39);
            this.btnEdit.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit the selected account");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCopyURL
            // 
            this.btnCopyURL.Image = global::PasswordVault2.Properties.Resources.globe;
            this.btnCopyURL.Location = new System.Drawing.Point(300, 19);
            this.btnCopyURL.Name = "btnCopyURL";
            this.btnCopyURL.Size = new System.Drawing.Size(38, 39);
            this.btnCopyURL.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnCopyURL, "Copy password and browse to account website");
            this.btnCopyURL.UseVisualStyleBackColor = true;
            this.btnCopyURL.Click += new System.EventHandler(this.btnCopyURL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.btnCopyURL);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(7, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Image = global::PasswordVault2.Properties.Resources.display;
            this.btnDisplay.Location = new System.Drawing.Point(341, 19);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(38, 39);
            this.btnDisplay.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnDisplay, "Display selected account password in a dialog box");
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(210, 19);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(38, 39);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "I";
            this.toolTip1.SetToolTip(this.btnImport, "Import entries from a csv file");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::PasswordVault2.Properties.Resources.export;
            this.btnExport.Location = new System.Drawing.Point(170, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(38, 39);
            this.btnExport.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnExport, "Export all account information to a file");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Image = global::PasswordVault2.Properties.Resources.password;
            this.btnChangePassword.Location = new System.Drawing.Point(129, 19);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(38, 39);
            this.btnChangePassword.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnChangePassword, "Change your password");
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Tool Tip:";
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::PasswordVault2.Properties.Resources.About;
            this.btnAbout.Location = new System.Drawing.Point(400, 414);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(38, 39);
            this.btnAbout.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnAbout, "About Password Vault");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Image = global::PasswordVault2.Properties.Resources.red_x;
            this.btnClearFilter.Location = new System.Drawing.Point(400, 329);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(38, 39);
            this.btnClearFilter.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnClearFilter, "About Password Vault");
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(54, 339);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(332, 34);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lifeBar
            // 
            this.lifeBar.Location = new System.Drawing.Point(25, 379);
            this.lifeBar.Name = "lifeBar";
            this.lifeBar.Size = new System.Drawing.Size(363, 10);
            this.lifeBar.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 470);
            this.Controls.Add(this.lifeBar);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Password Vault";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCopyURL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ProgressBar lifeBar;
    }
}

