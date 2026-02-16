namespace Electro_Fih
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.txtboxEmail = new CustomControls.RJControls.RJTextBox();
            this.txtboxPassword = new CustomControls.RJControls.RJTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new Electro_Fih.RJControls.RJButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRegister = new Electro_Fih.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginPageLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginPageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(14)))), ((int)(((byte)(77)))));
            this.txtboxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(14)))), ((int)(((byte)(77)))));
            this.txtboxEmail.BorderRadius = 15;
            this.txtboxEmail.BorderSize = 2;
            this.txtboxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(14)))), ((int)(((byte)(77)))));
            this.txtboxEmail.Location = new System.Drawing.Point(204, 292);
            this.txtboxEmail.Multiline = false;
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxEmail.PasswordChar = false;
            this.txtboxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxEmail.PlaceholderText = "";
            this.txtboxEmail.Size = new System.Drawing.Size(250, 31);
            this.txtboxEmail.TabIndex = 0;
            this.txtboxEmail.Texts = "";
            this.txtboxEmail.UnderlinedStyle = false;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(14)))), ((int)(((byte)(77)))));
            this.txtboxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(14)))), ((int)(((byte)(77)))));
            this.txtboxPassword.BorderRadius = 15;
            this.txtboxPassword.BorderSize = 2;
            this.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(14)))), ((int)(((byte)(77)))));
            this.txtboxPassword.Location = new System.Drawing.Point(204, 368);
            this.txtboxPassword.Multiline = false;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtboxPassword.PasswordChar = true;
            this.txtboxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtboxPassword.PlaceholderText = "";
            this.txtboxPassword.Size = new System.Drawing.Size(250, 31);
            this.txtboxPassword.TabIndex = 1;
            this.txtboxPassword.Texts = "";
            this.txtboxPassword.UnderlinedStyle = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(211, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 22);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(211, 343);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 22);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Jelszó";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(38)))), ((int)(((byte)(217)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(38)))), ((int)(((byte)(217)))));
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(255, 434);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Bejelentkezés";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(270, 580);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 22);
            this.lblMessage.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(38)))), ((int)(((byte)(217)))));
            this.btnRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(38)))), ((int)(((byte)(217)))));
            this.btnRegister.BorderColor = System.Drawing.Color.White;
            this.btnRegister.BorderRadius = 15;
            this.btnRegister.BorderSize = 2;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(255, 500);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Regisztráció";
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(661, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 600);
            this.panel1.TabIndex = 7;
            // 
            // loginPageLogo
            // 
            this.loginPageLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPageLogo.BackgroundImage")));
            this.loginPageLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginPageLogo.Location = new System.Drawing.Point(762, 170);
            this.loginPageLogo.Name = "loginPageLogo";
            this.loginPageLogo.Size = new System.Drawing.Size(689, 456);
            this.loginPageLogo.TabIndex = 8;
            this.loginPageLogo.TabStop = false;
            this.loginPageLogo.Click += new System.EventHandler(this.loginPageLogo_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(14)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1609, 829);
            this.Controls.Add(this.loginPageLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electro-Fih";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.loginPageLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtboxEmail;
        private CustomControls.RJControls.RJTextBox txtboxPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private RJControls.RJButton btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private RJControls.RJButton btnRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox loginPageLogo;
    }
}