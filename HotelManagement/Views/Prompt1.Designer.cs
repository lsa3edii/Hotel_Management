namespace Lab15.Views
{
    partial class Prompt1
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
            prompt_text = new Label();
            ok_btn = new Button();
            id = new Label();
            SuspendLayout();
            // 
            // prompt_text
            // 
            prompt_text.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            prompt_text.ForeColor = Color.White;
            prompt_text.Location = new Point(12, 38);
            prompt_text.Name = "prompt_text";
            prompt_text.Size = new Size(671, 56);
            prompt_text.TabIndex = 9;
            prompt_text.Text = "Report..!\r\nEntry successfully updated into database. For USER ID:\r\n";
            // 
            // ok_btn
            // 
            ok_btn.Cursor = Cursors.Hand;
            ok_btn.DialogResult = DialogResult.OK;
            ok_btn.FlatStyle = FlatStyle.System;
            ok_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ok_btn.Location = new Point(549, 193);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(239, 43);
            ok_btn.TabIndex = 0;
            ok_btn.Text = "OK";
            ok_btn.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            id.ForeColor = Color.White;
            id.Location = new Point(689, 66);
            id.Name = "id";
            id.Size = new Size(99, 28);
            id.TabIndex = 11;
            id.Text = "user_id";
            // 
            // Prompt1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 250);
            Controls.Add(id);
            Controls.Add(ok_btn);
            Controls.Add(prompt_text);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prompt1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prompt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label prompt_text;
        private Button ok_btn;
        private Label id;
    }
}