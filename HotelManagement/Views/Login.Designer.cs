namespace Lab15
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            password = new TextBox();
            label3 = new Label();
            sign_btn = new Button();
            clear_btn = new Button();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Gold;
            login_btn.Cursor = Cursors.Hand;
            login_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.Black;
            login_btn.Location = new Point(83, 437);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(408, 43);
            login_btn.TabIndex = 3;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // username
            // 
            username.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            username.Location = new Point(83, 228);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(408, 35);
            username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 186);
            label1.Name = "label1";
            label1.Size = new Size(160, 33);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 289);
            label2.Name = "label2";
            label2.Size = new Size(154, 33);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // password
            // 
            password.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            password.Location = new Point(83, 328);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(408, 35);
            password.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 31);
            label3.Name = "label3";
            label3.Size = new Size(408, 46);
            label3.TabIndex = 5;
            label3.Text = "Hotel Management";
            // 
            // sign_btn
            // 
            sign_btn.BackColor = Color.Gray;
            sign_btn.Cursor = Cursors.Hand;
            sign_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sign_btn.ForeColor = Color.White;
            sign_btn.Location = new Point(83, 495);
            sign_btn.Name = "sign_btn";
            sign_btn.Size = new Size(273, 43);
            sign_btn.TabIndex = 4;
            sign_btn.Text = "Sign Up";
            sign_btn.UseVisualStyleBackColor = false;
            sign_btn.Click += sign_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.FlatStyle = FlatStyle.System;
            clear_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clear_btn.Location = new Point(362, 495);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(129, 43);
            clear_btn.TabIndex = 0;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(575, 559);
            Controls.Add(clear_btn);
            Controls.Add(sign_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(login_btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private TextBox username;
        private Label label1;
        private Label label2;
        private TextBox password;
        private Label label3;
        private Button sign_btn;
        private Button clear_btn;
    }
}
