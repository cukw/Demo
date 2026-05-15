namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pwdText = new TextBox();
            loginText = new TextBox();
            pwd = new Label();
            login = new Label();
            auth = new Button();
            LoginGuest = new Button();
            FormName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pwdText
            // 
            pwdText.Location = new Point(121, 273);
            pwdText.Name = "pwdText";
            pwdText.Size = new Size(240, 23);
            pwdText.TabIndex = 0;
            // 
            // loginText
            // 
            loginText.Location = new Point(121, 227);
            loginText.Name = "loginText";
            loginText.Size = new Size(240, 23);
            loginText.TabIndex = 1;
            // 
            // pwd
            // 
            pwd.AutoSize = true;
            pwd.Location = new Point(124, 257);
            pwd.Name = "pwd";
            pwd.Size = new Size(49, 15);
            pwd.TabIndex = 2;
            pwd.Text = "Пароль";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(124, 212);
            login.Name = "login";
            login.Size = new Size(41, 15);
            login.TabIndex = 3;
            login.Text = "Логин";
            // 
            // auth
            // 
            auth.BackColor = Color.MediumSpringGreen;
            auth.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            auth.Location = new Point(194, 302);
            auth.Name = "auth";
            auth.Size = new Size(75, 23);
            auth.TabIndex = 4;
            auth.Text = "Войти";
            auth.UseVisualStyleBackColor = false;
            auth.Click += auth_Click;
            // 
            // LoginGuest
            // 
            LoginGuest.FlatStyle = FlatStyle.System;
            LoginGuest.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginGuest.Location = new Point(184, 331);
            LoginGuest.Name = "LoginGuest";
            LoginGuest.Size = new Size(95, 23);
            LoginGuest.TabIndex = 5;
            LoginGuest.Text = "Войти как гость";
            LoginGuest.UseVisualStyleBackColor = true;
            LoginGuest.Click += LoginGuest_Click;
            // 
            // FormName
            // 
            FormName.AutoSize = true;
            FormName.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormName.Location = new Point(97, 9);
            FormName.Name = "FormName";
            FormName.Size = new Size(292, 40);
            FormName.TabIndex = 6;
            FormName.Text = "Окно авторизации";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(159, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(pictureBox1);
            Controls.Add(FormName);
            Controls.Add(LoginGuest);
            Controls.Add(auth);
            Controls.Add(login);
            Controls.Add(pwd);
            Controls.Add(loginText);
            Controls.Add(pwdText);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pwdText;
        private TextBox loginText;
        private Label pwd;
        private Label login;
        private Button auth;
        private Button LoginGuest;
        private Label FormName;
        private PictureBox pictureBox1;
    }
}
