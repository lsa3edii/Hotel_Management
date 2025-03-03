namespace Lab15.Views.Kitchen
{
    partial class FoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            save_btn = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            dinner_qty = new TextBox();
            dinner_chbox = new CheckBox();
            pictureBox1 = new PictureBox();
            lunch_qty = new TextBox();
            lunch_chbox = new CheckBox();
            pictureBox0 = new PictureBox();
            breakfast_qty = new TextBox();
            breakfast_chbox = new CheckBox();
            label3 = new Label();
            panel1 = new Panel();
            surprise_chbox = new CheckBox();
            towels_chbox = new CheckBox();
            cleaning_chbox = new CheckBox();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // save_btn
            // 
            save_btn.Cursor = Cursors.Hand;
            save_btn.FlatStyle = FlatStyle.System;
            save_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            save_btn.Location = new Point(495, 517);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(291, 43);
            save_btn.TabIndex = 0;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(dinner_qty);
            panel3.Controls.Add(dinner_chbox);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lunch_qty);
            panel3.Controls.Add(lunch_chbox);
            panel3.Controls.Add(pictureBox0);
            panel3.Controls.Add(breakfast_qty);
            panel3.Controls.Add(breakfast_chbox);
            panel3.Location = new Point(12, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 466);
            panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dinner_qty
            // 
            dinner_qty.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dinner_qty.Location = new Point(27, 413);
            dinner_qty.Name = "dinner_qty";
            dinner_qty.PlaceholderText = "Quantity?";
            dinner_qty.Size = new Size(185, 35);
            dinner_qty.TabIndex = 5;
            // 
            // dinner_chbox
            // 
            dinner_chbox.AutoSize = true;
            dinner_chbox.Cursor = Cursors.Hand;
            dinner_chbox.Location = new Point(27, 383);
            dinner_chbox.Name = "dinner_chbox";
            dinner_chbox.Size = new Size(113, 24);
            dinner_chbox.TabIndex = 4;
            dinner_chbox.Text = "Dinner (25$)";
            dinner_chbox.UseVisualStyleBackColor = true;
            dinner_chbox.CheckedChanged += dinner_chbox_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(256, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lunch_qty
            // 
            lunch_qty.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lunch_qty.Location = new Point(256, 187);
            lunch_qty.Name = "lunch_qty";
            lunch_qty.PlaceholderText = "Quantity?";
            lunch_qty.Size = new Size(185, 35);
            lunch_qty.TabIndex = 3;
            // 
            // lunch_chbox
            // 
            lunch_chbox.AutoSize = true;
            lunch_chbox.Cursor = Cursors.Hand;
            lunch_chbox.Location = new Point(256, 157);
            lunch_chbox.Name = "lunch_chbox";
            lunch_chbox.Size = new Size(107, 24);
            lunch_chbox.TabIndex = 2;
            lunch_chbox.Text = "Lunch (15$)";
            lunch_chbox.UseVisualStyleBackColor = true;
            lunch_chbox.CheckedChanged += lunch_chbox_CheckedChanged;
            // 
            // pictureBox0
            // 
            pictureBox0.Cursor = Cursors.Hand;
            pictureBox0.Image = (Image)resources.GetObject("pictureBox0.Image");
            pictureBox0.Location = new Point(27, 22);
            pictureBox0.Name = "pictureBox0";
            pictureBox0.Size = new Size(185, 125);
            pictureBox0.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox0.TabIndex = 24;
            pictureBox0.TabStop = false;
            pictureBox0.Click += pictureBox0_Click;
            // 
            // breakfast_qty
            // 
            breakfast_qty.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            breakfast_qty.Location = new Point(27, 187);
            breakfast_qty.Name = "breakfast_qty";
            breakfast_qty.PlaceholderText = "Quantity?";
            breakfast_qty.Size = new Size(185, 35);
            breakfast_qty.TabIndex = 1;
            // 
            // breakfast_chbox
            // 
            breakfast_chbox.AutoSize = true;
            breakfast_chbox.Cursor = Cursors.Hand;
            breakfast_chbox.Location = new Point(27, 157);
            breakfast_chbox.Name = "breakfast_chbox";
            breakfast_chbox.Size = new Size(122, 24);
            breakfast_chbox.TabIndex = 0;
            breakfast_chbox.Text = "Breakfast (7$)";
            breakfast_chbox.UseVisualStyleBackColor = true;
            breakfast_chbox.CheckedChanged += breakfast_chbox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 32);
            label3.Name = "label3";
            label3.Size = new Size(293, 40);
            label3.TabIndex = 8;
            label3.Text = "Food and Menu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(surprise_chbox);
            panel1.Controls.Add(towels_chbox);
            panel1.Controls.Add(cleaning_chbox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(495, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 407);
            panel1.TabIndex = 25;
            // 
            // surprise_chbox
            // 
            surprise_chbox.AutoSize = true;
            surprise_chbox.Cursor = Cursors.Hand;
            surprise_chbox.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            surprise_chbox.Location = new Point(48, 167);
            surprise_chbox.Name = "surprise_chbox";
            surprise_chbox.Size = new Size(186, 28);
            surprise_chbox.TabIndex = 33;
            surprise_chbox.Text = "Sweet Surprise";
            surprise_chbox.UseVisualStyleBackColor = true;
            // 
            // towels_chbox
            // 
            towels_chbox.AutoSize = true;
            towels_chbox.Cursor = Cursors.Hand;
            towels_chbox.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            towels_chbox.Location = new Point(48, 123);
            towels_chbox.Name = "towels_chbox";
            towels_chbox.Size = new Size(102, 28);
            towels_chbox.TabIndex = 32;
            towels_chbox.Text = "Towels";
            towels_chbox.UseVisualStyleBackColor = true;
            // 
            // cleaning_chbox
            // 
            cleaning_chbox.AutoSize = true;
            cleaning_chbox.Cursor = Cursors.Hand;
            cleaning_chbox.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cleaning_chbox.Location = new Point(48, 78);
            cleaning_chbox.Name = "cleaning_chbox";
            cleaning_chbox.Size = new Size(126, 28);
            cleaning_chbox.TabIndex = 31;
            cleaning_chbox.Text = "Cleaning";
            cleaning_chbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 22);
            label1.Name = "label1";
            label1.Size = new Size(212, 33);
            label1.TabIndex = 26;
            label1.Text = "Special needs";
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 572);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(save_btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FoodMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            Load += FoodMenu_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_btn;
        private Panel panel3;
        private Label label3;
        private TextBox breakfast_qty;
        private CheckBox breakfast_chbox;
        private PictureBox pictureBox0;
        private PictureBox pictureBox2;
        private TextBox dinner_qty;
        private CheckBox dinner_chbox;
        private PictureBox pictureBox1;
        private TextBox lunch_qty;
        private CheckBox lunch_chbox;
        private Panel panel1;
        private CheckBox surprise_chbox;
        private CheckBox towels_chbox;
        private CheckBox cleaning_chbox;
        private Label label1;
    }
}