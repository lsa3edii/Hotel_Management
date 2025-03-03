namespace HotelManagement.Views
{
    partial class Prompt2
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
            no_btn = new Button();
            prompt_text = new Label();
            yes_btn = new Button();
            SuspendLayout();
            // 
            // no_btn
            // 
            no_btn.Cursor = Cursors.Hand;
            no_btn.DialogResult = DialogResult.No;
            no_btn.FlatStyle = FlatStyle.System;
            no_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            no_btn.Location = new Point(549, 181);
            no_btn.Name = "no_btn";
            no_btn.Size = new Size(239, 43);
            no_btn.TabIndex = 1;
            no_btn.Text = "No";
            no_btn.UseVisualStyleBackColor = true;
            // 
            // prompt_text
            // 
            prompt_text.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            prompt_text.ForeColor = Color.White;
            prompt_text.Location = new Point(12, 26);
            prompt_text.Name = "prompt_text";
            prompt_text.Size = new Size(776, 102);
            prompt_text.TabIndex = 13;
            prompt_text.Text = "Text";
            // 
            // yes_btn
            // 
            yes_btn.BackColor = Color.LightSeaGreen;
            yes_btn.Cursor = Cursors.Hand;
            yes_btn.DialogResult = DialogResult.Yes;
            yes_btn.FlatStyle = FlatStyle.System;
            yes_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            yes_btn.ForeColor = Color.White;
            yes_btn.Location = new Point(12, 181);
            yes_btn.Name = "yes_btn";
            yes_btn.Size = new Size(239, 43);
            yes_btn.TabIndex = 0;
            yes_btn.Text = "Yes";
            yes_btn.UseVisualStyleBackColor = false;
            yes_btn.Click += yes_btn_Click;
            // 
            // Prompt2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 250);
            Controls.Add(yes_btn);
            Controls.Add(no_btn);
            Controls.Add(prompt_text);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prompt2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prompt2";
            ResumeLayout(false);
        }

        #endregion

        private Button no_btn;
        private Label prompt_text;
        private Button yes_btn;
    }
}