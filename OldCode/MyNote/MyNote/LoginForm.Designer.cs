namespace MyNote
{
    partial class LoginForm
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
            this.accountPrompt = new System.Windows.Forms.Label();
            this.passwordPrompt = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountPrompt
            // 
            this.accountPrompt.AutoSize = true;
            this.accountPrompt.Location = new System.Drawing.Point(44, 44);
            this.accountPrompt.Name = "accountPrompt";
            this.accountPrompt.Size = new System.Drawing.Size(47, 12);
            this.accountPrompt.TabIndex = 0;
            this.accountPrompt.Text = "帐  号:";
            // 
            // passwordPrompt
            // 
            this.passwordPrompt.AutoSize = true;
            this.passwordPrompt.Location = new System.Drawing.Point(44, 92);
            this.passwordPrompt.Name = "passwordPrompt";
            this.passwordPrompt.Size = new System.Drawing.Size(47, 12);
            this.passwordPrompt.TabIndex = 1;
            this.passwordPrompt.Text = "密  码:";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(97, 41);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(100, 21);
            this.account.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(97, 89);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(46, 144);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(64, 24);
            this.login.TabIndex = 4;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // quit
            // 
            this.quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quit.Location = new System.Drawing.Point(133, 144);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(64, 24);
            this.quit.TabIndex = 5;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quit;
            this.ClientSize = new System.Drawing.Size(240, 218);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Controls.Add(this.passwordPrompt);
            this.Controls.Add(this.accountPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountPrompt;
        private System.Windows.Forms.Label passwordPrompt;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button quit;
    }
}