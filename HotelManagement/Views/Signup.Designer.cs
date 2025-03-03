namespace Lab15.Views
{
    partial class Signup
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
            sign_btn = new Button();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            label1 = new Label();
            username = new TextBox();
            label4 = new Label();
            confirm_pass = new TextBox();
            back_btn = new Button();
            clear_btn = new Button();
            SuspendLayout();
            // 
            // sign_btn
            // 
            sign_btn.BackColor = Color.Gray;
            sign_btn.Cursor = Cursors.Hand;
            sign_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sign_btn.ForeColor = Color.White;
            sign_btn.Location = new Point(83, 477);
            sign_btn.Name = "sign_btn";
            sign_btn.Size = new Size(284, 43);
            sign_btn.TabIndex = 4;
            sign_btn.Text = "Sign Up";
            sign_btn.UseVisualStyleBackColor = false;
            sign_btn.Click += sign_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 37);
            label3.Name = "label3";
            label3.Size = new Size(408, 46);
            label3.TabIndex = 12;
            label3.Text = "Hotel Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 243);
            label2.Name = "label2";
            label2.Size = new Size(154, 33);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // password
            // 
            password.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            password.Location = new Point(83, 282);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(408, 35);
            password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 140);
            label1.Name = "label1";
            label1.Size = new Size(160, 33);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // username
            // 
            username.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            username.Location = new Point(83, 182);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(408, 35);
            username.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(147, 349);
            label4.Name = "label4";
            label4.Size = new Size(281, 33);
            label4.TabIndex = 15;
            label4.Text = "Confirm Password";
            // 
            // confirm_pass
            // 
            confirm_pass.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            confirm_pass.Location = new Point(83, 388);
            confirm_pass.Name = "confirm_pass";
            confirm_pass.PasswordChar = '*';
            confirm_pass.PlaceholderText = "Confirm Password";
            confirm_pass.Size = new Size(408, 35);
            confirm_pass.TabIndex = 3;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.RoyalBlue;
            back_btn.Cursor = Cursors.Hand;
            back_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            back_btn.ForeColor = Color.White;
            back_btn.Location = new Point(12, 37);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(58, 43);
            back_btn.TabIndex = 0;
            back_btn.Text = "←";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.FlatStyle = FlatStyle.System;
            clear_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clear_btn.Location = new Point(373, 477);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(118, 43);
            clear_btn.TabIndex = 5;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(575, 559);
            Controls.Add(clear_btn);
            Controls.Add(back_btn);
            Controls.Add(label4);
            Controls.Add(confirm_pass);
            Controls.Add(sign_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            FormClosing += Signup_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sign_btn;
        private Label label3;
        private Label label2;
        private TextBox password;
        private Label label1;
        private TextBox username;
        private Label label4;
        private TextBox confirm_pass;
        private Button back_btn;
        private Button clear_btn;
    }
}