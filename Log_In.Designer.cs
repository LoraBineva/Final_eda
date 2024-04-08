namespace Final_Eda
{
    partial class Log_In
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
            login_btn = new Button();
            username = new TextBox();
            log_in_lbl = new Label();
            username_lbl = new Label();
            password_lbl = new Label();
            password = new TextBox();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(62, 137, 207);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Gadugi", 14F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(68, 468);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(231, 42);
            login_btn.TabIndex = 0;
            login_btn.Text = "Log In";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(68, 281);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(231, 29);
            username.TabIndex = 1;
            // 
            // log_in_lbl
            // 
            log_in_lbl.AutoSize = true;
            log_in_lbl.BackColor = Color.Transparent;
            log_in_lbl.Font = new Font("Gadugi", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            log_in_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            log_in_lbl.Location = new Point(112, 152);
            log_in_lbl.Name = "log_in_lbl";
            log_in_lbl.Size = new Size(128, 44);
            log_in_lbl.TabIndex = 3;
            log_in_lbl.Text = "Log In";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.BackColor = Color.Transparent;
            username_lbl.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            username_lbl.Location = new Point(60, 234);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(124, 28);
            username_lbl.TabIndex = 4;
            username_lbl.Text = "Username:";
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.BackColor = Color.Transparent;
            password_lbl.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            password_lbl.ForeColor = Color.FromArgb(203, 212, 242);
            password_lbl.Location = new Point(60, 338);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(115, 28);
            password_lbl.TabIndex = 6;
            password_lbl.Text = "Password:";
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(68, 383);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(231, 29);
            password.TabIndex = 5;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_app;
            ClientSize = new Size(357, 776);
            Controls.Add(password_lbl);
            Controls.Add(password);
            Controls.Add(username_lbl);
            Controls.Add(log_in_lbl);
            Controls.Add(username);
            Controls.Add(login_btn);
            Name = "Log_In";
            Text = "Form1";
            Load += Log_In_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private TextBox username;
        private Label log_in_lbl;
        private Label username_lbl;
        private Label password_lbl;
        private TextBox password;
    }
}