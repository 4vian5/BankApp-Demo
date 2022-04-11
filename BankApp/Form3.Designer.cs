namespace BankApp
{
    partial class Form3
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
            this.info2 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.checkingBtn = new System.Windows.Forms.Button();
            this.savingBtn = new System.Windows.Forms.Button();
            this.accListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.info2.Location = new System.Drawing.Point(87, 71);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(185, 48);
            this.info2.TabIndex = 3;
            this.info2.Text = "System";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Firebrick;
            this.infoLabel.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoLabel.Location = new System.Drawing.Point(-2, 22);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(365, 48);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Online Banking";
            // 
            // infoPanel
            // 
            this.infoPanel.AutoSize = true;
            this.infoPanel.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoPanel.Location = new System.Drawing.Point(31, 22);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(304, 48);
            this.infoPanel.TabIndex = 4;
            this.infoPanel.Text = "Admin Panel";
            this.infoPanel.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(12, 230);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(109, 18);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username : ";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(118, 226);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(177, 26);
            this.usernameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(118, 258);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(177, 26);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 262);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 18);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password : ";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightCyan;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(39, 326);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(85, 32);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Maroon;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnBtn.Location = new System.Drawing.Point(210, 326);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(85, 32);
            this.returnBtn.TabIndex = 10;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Maroon;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(118, 402);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(85, 32);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Visible = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // checkingBtn
            // 
            this.checkingBtn.BackColor = System.Drawing.Color.LightCyan;
            this.checkingBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingBtn.Location = new System.Drawing.Point(39, 102);
            this.checkingBtn.Name = "checkingBtn";
            this.checkingBtn.Size = new System.Drawing.Size(264, 32);
            this.checkingBtn.TabIndex = 12;
            this.checkingBtn.Text = "View Checking Accounts";
            this.checkingBtn.UseVisualStyleBackColor = false;
            this.checkingBtn.Visible = false;
            this.checkingBtn.Click += new System.EventHandler(this.checkingBtn_Click);
            // 
            // savingBtn
            // 
            this.savingBtn.BackColor = System.Drawing.Color.LightCyan;
            this.savingBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingBtn.Location = new System.Drawing.Point(39, 140);
            this.savingBtn.Name = "savingBtn";
            this.savingBtn.Size = new System.Drawing.Size(264, 32);
            this.savingBtn.TabIndex = 13;
            this.savingBtn.Text = "View Saving Accounts";
            this.savingBtn.UseVisualStyleBackColor = false;
            this.savingBtn.Visible = false;
            this.savingBtn.Click += new System.EventHandler(this.savingBtn_Click);
            // 
            // accListBox
            // 
            this.accListBox.FormattingEnabled = true;
            this.accListBox.Location = new System.Drawing.Point(39, 178);
            this.accListBox.Name = "accListBox";
            this.accListBox.Size = new System.Drawing.Size(264, 212);
            this.accListBox.TabIndex = 14;
            this.accListBox.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(363, 456);
            this.Controls.Add(this.accListBox);
            this.Controls.Add(this.savingBtn);
            this.Controls.Add(this.checkingBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form3";
            this.Text = "7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label infoPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button checkingBtn;
        private System.Windows.Forms.Button savingBtn;
        private System.Windows.Forms.ListBox accListBox;
    }
}