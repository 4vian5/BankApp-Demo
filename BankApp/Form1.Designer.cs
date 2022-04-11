namespace BankApp
{
    partial class Form1
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.accnoBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.checkingRadio = new System.Windows.Forms.RadioButton();
            this.savingRadio = new System.Windows.Forms.RadioButton();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.SavingRegisterBtn = new System.Windows.Forms.RadioButton();
            this.checkingRegisterBtn = new System.Windows.Forms.RadioButton();
            this.createAccBtn = new System.Windows.Forms.Button();
            this.exitLoginButton = new System.Windows.Forms.Button();
            this.registerExit = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Firebrick;
            this.infoLabel.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoLabel.Location = new System.Drawing.Point(27, 59);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(365, 48);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Online Banking";
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.info2.Location = new System.Drawing.Point(116, 108);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(185, 48);
            this.info2.TabIndex = 1;
            this.info2.Text = "System";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.LoginBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.LoginBtn.Location = new System.Drawing.Point(33, 219);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(336, 56);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Existing Customer";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.registerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.registerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.registerBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.registerBtn.Location = new System.Drawing.Point(33, 280);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(336, 56);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "New Customer";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // accnoBox
            // 
            this.accnoBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnoBox.Location = new System.Drawing.Point(93, 247);
            this.accnoBox.Name = "accnoBox";
            this.accnoBox.Size = new System.Drawing.Size(225, 26);
            this.accnoBox.TabIndex = 4;
            this.accnoBox.Visible = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(99, 210);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(207, 25);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Account Number";
            this.loginLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Lime;
            this.loginButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(35, 377);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(176, 54);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.Location = new System.Drawing.Point(120, 197);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(211, 25);
            this.registerLabel.TabIndex = 7;
            this.registerLabel.Text = "Register Account";
            this.registerLabel.Visible = false;
            // 
            // firstnameBox
            // 
            this.firstnameBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameBox.Location = new System.Drawing.Point(124, 247);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(225, 26);
            this.firstnameBox.TabIndex = 8;
            this.firstnameBox.Visible = false;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.Location = new System.Drawing.Point(123, 281);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(225, 26);
            this.LastNameBox.TabIndex = 9;
            this.LastNameBox.Visible = false;
            // 
            // checkingRadio
            // 
            this.checkingRadio.AutoSize = true;
            this.checkingRadio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingRadio.Location = new System.Drawing.Point(94, 285);
            this.checkingRadio.Name = "checkingRadio";
            this.checkingRadio.Size = new System.Drawing.Size(221, 27);
            this.checkingRadio.TabIndex = 10;
            this.checkingRadio.TabStop = true;
            this.checkingRadio.Text = "Checking Account";
            this.checkingRadio.UseVisualStyleBackColor = true;
            this.checkingRadio.Visible = false;
            // 
            // savingRadio
            // 
            this.savingRadio.AutoSize = true;
            this.savingRadio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingRadio.Location = new System.Drawing.Point(93, 328);
            this.savingRadio.Name = "savingRadio";
            this.savingRadio.Size = new System.Drawing.Size(195, 27);
            this.savingRadio.TabIndex = 11;
            this.savingRadio.TabStop = true;
            this.savingRadio.Text = "Saving Account";
            this.savingRadio.UseVisualStyleBackColor = true;
            this.savingRadio.Visible = false;
            // 
            // balanceBox
            // 
            this.balanceBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBox.Location = new System.Drawing.Point(123, 318);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(225, 26);
            this.balanceBox.TabIndex = 12;
            this.balanceBox.Visible = false;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.Location = new System.Drawing.Point(11, 250);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(98, 18);
            this.firstnameLabel.TabIndex = 13;
            this.firstnameLabel.Text = "First Name";
            this.firstnameLabel.Visible = false;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.Location = new System.Drawing.Point(12, 291);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(97, 18);
            this.lastnameLabel.TabIndex = 14;
            this.lastnameLabel.Text = "Last Name";
            this.lastnameLabel.Visible = false;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(38, 326);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(71, 18);
            this.balanceLabel.TabIndex = 15;
            this.balanceLabel.Text = "Balance";
            this.balanceLabel.Visible = false;
            // 
            // SavingRegisterBtn
            // 
            this.SavingRegisterBtn.AutoSize = true;
            this.SavingRegisterBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingRegisterBtn.Location = new System.Drawing.Point(122, 404);
            this.SavingRegisterBtn.Name = "SavingRegisterBtn";
            this.SavingRegisterBtn.Size = new System.Drawing.Size(195, 27);
            this.SavingRegisterBtn.TabIndex = 17;
            this.SavingRegisterBtn.TabStop = true;
            this.SavingRegisterBtn.Text = "Saving Account";
            this.SavingRegisterBtn.UseVisualStyleBackColor = true;
            this.SavingRegisterBtn.Visible = false;
            // 
            // checkingRegisterBtn
            // 
            this.checkingRegisterBtn.AutoSize = true;
            this.checkingRegisterBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingRegisterBtn.Location = new System.Drawing.Point(123, 361);
            this.checkingRegisterBtn.Name = "checkingRegisterBtn";
            this.checkingRegisterBtn.Size = new System.Drawing.Size(221, 27);
            this.checkingRegisterBtn.TabIndex = 16;
            this.checkingRegisterBtn.TabStop = true;
            this.checkingRegisterBtn.Text = "Checking Account";
            this.checkingRegisterBtn.UseVisualStyleBackColor = true;
            this.checkingRegisterBtn.Visible = false;
            // 
            // createAccBtn
            // 
            this.createAccBtn.BackColor = System.Drawing.Color.Lime;
            this.createAccBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccBtn.Location = new System.Drawing.Point(35, 455);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(176, 54);
            this.createAccBtn.TabIndex = 18;
            this.createAccBtn.Text = "Register";
            this.createAccBtn.UseVisualStyleBackColor = false;
            this.createAccBtn.Visible = false;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // exitLoginButton
            // 
            this.exitLoginButton.BackColor = System.Drawing.Color.Red;
            this.exitLoginButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLoginButton.Location = new System.Drawing.Point(235, 377);
            this.exitLoginButton.Name = "exitLoginButton";
            this.exitLoginButton.Size = new System.Drawing.Size(176, 54);
            this.exitLoginButton.TabIndex = 19;
            this.exitLoginButton.Text = "Exit";
            this.exitLoginButton.UseVisualStyleBackColor = false;
            this.exitLoginButton.Visible = false;
            this.exitLoginButton.Click += new System.EventHandler(this.exitLoginButton_Click);
            // 
            // registerExit
            // 
            this.registerExit.BackColor = System.Drawing.Color.Red;
            this.registerExit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerExit.Location = new System.Drawing.Point(235, 455);
            this.registerExit.Name = "registerExit";
            this.registerExit.Size = new System.Drawing.Size(176, 54);
            this.registerExit.TabIndex = 20;
            this.registerExit.Text = "Exit";
            this.registerExit.UseVisualStyleBackColor = false;
            this.registerExit.Visible = false;
            this.registerExit.Click += new System.EventHandler(this.registerExit_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.adminBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.adminBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.adminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.adminBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.adminBtn.Location = new System.Drawing.Point(33, 340);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(336, 56);
            this.adminBtn.TabIndex = 21;
            this.adminBtn.Text = "Admin Panel";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(414, 537);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.registerExit);
            this.Controls.Add(this.exitLoginButton);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.SavingRegisterBtn);
            this.Controls.Add(this.checkingRegisterBtn);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.savingRadio);
            this.Controls.Add(this.checkingRadio);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.accnoBox);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "Online Banking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox accnoBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.RadioButton checkingRadio;
        private System.Windows.Forms.RadioButton savingRadio;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.RadioButton SavingRegisterBtn;
        private System.Windows.Forms.RadioButton checkingRegisterBtn;
        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.Button exitLoginButton;
        private System.Windows.Forms.Button registerExit;
        private System.Windows.Forms.Button adminBtn;
    }
}

