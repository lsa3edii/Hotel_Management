namespace Lab15.Views.Kitchen
{
    partial class Invoice
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
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            payment = new ComboBox();
            month = new ComboBox();
            label5 = new Label();
            cvc = new TextBox();
            card = new TextBox();
            label6 = new Label();
            current_bill = new Label();
            food_bill = new Label();
            tax = new Label();
            total = new Label();
            pay_btn = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            card_type = new Label();
            year = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F);
            label4.Location = new Point(12, 37);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 12;
            label4.Text = "Reservation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 13;
            label1.Text = "Current bill";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13.8F);
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 14;
            label2.Text = "Food bill";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 13.8F);
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 15;
            label3.Text = "Payment";
            // 
            // payment
            // 
            payment.Cursor = Cursors.Hand;
            payment.DropDownHeight = 200;
            payment.DropDownStyle = ComboBoxStyle.DropDownList;
            payment.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment.FormattingEnabled = true;
            payment.IntegralHeight = false;
            payment.Items.AddRange(new object[] { "Credit    ", "Debit     ", "Cash      " });
            payment.Location = new Point(12, 290);
            payment.Name = "payment";
            payment.Size = new Size(167, 33);
            payment.TabIndex = 16;
            payment.SelectedIndexChanged += payment_SelectedIndexChanged;
            // 
            // month
            // 
            month.Cursor = Cursors.Hand;
            month.DropDownHeight = 200;
            month.DropDownStyle = ComboBoxStyle.DropDownList;
            month.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            month.FormattingEnabled = true;
            month.IntegralHeight = false;
            month.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            month.Location = new Point(12, 344);
            month.Name = "month";
            month.Size = new Size(140, 33);
            month.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(161, 347);
            label5.Name = "label5";
            label5.Size = new Size(18, 28);
            label5.TabIndex = 18;
            label5.Text = "/";
            // 
            // cvc
            // 
            cvc.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cvc.Location = new Point(306, 344);
            cvc.Name = "cvc";
            cvc.PasswordChar = '*';
            cvc.PlaceholderText = "cvc";
            cvc.Size = new Size(88, 32);
            cvc.TabIndex = 20;
            // 
            // card
            // 
            card.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            card.Location = new Point(188, 291);
            card.Name = "card";
            card.PlaceholderText = "9999-9999-9999-9999";
            card.Size = new Size(600, 32);
            card.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(655, 38);
            label6.Name = "label6";
            label6.Size = new Size(89, 27);
            label6.TabIndex = 22;
            label6.Text = "Price :";
            // 
            // current_bill
            // 
            current_bill.AutoSize = true;
            current_bill.Font = new Font("Century Schoolbook", 13.8F);
            current_bill.Location = new Point(676, 83);
            current_bill.Name = "current_bill";
            current_bill.Size = new Size(66, 28);
            current_bill.TabIndex = 23;
            current_bill.Text = "Price";
            // 
            // food_bill
            // 
            food_bill.AutoSize = true;
            food_bill.Font = new Font("Century Schoolbook", 13.8F);
            food_bill.Location = new Point(676, 128);
            food_bill.Name = "food_bill";
            food_bill.Size = new Size(66, 28);
            food_bill.TabIndex = 24;
            food_bill.Text = "Price";
            // 
            // tax
            // 
            tax.AutoSize = true;
            tax.Font = new Font("Century Schoolbook", 13.8F);
            tax.Location = new Point(676, 174);
            tax.Name = "tax";
            tax.Size = new Size(66, 28);
            tax.TabIndex = 25;
            tax.Text = "Price";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Century Schoolbook", 13.8F);
            total.Location = new Point(676, 219);
            total.Name = "total";
            total.Size = new Size(66, 28);
            total.TabIndex = 26;
            total.Text = "Price";
            // 
            // pay_btn
            // 
            pay_btn.BackColor = Color.RoyalBlue;
            pay_btn.Cursor = Cursors.Hand;
            pay_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            pay_btn.ForeColor = Color.White;
            pay_btn.Location = new Point(543, 396);
            pay_btn.Name = "pay_btn";
            pay_btn.Size = new Size(245, 43);
            pay_btn.TabIndex = 27;
            pay_btn.Text = "Pay";
            pay_btn.UseVisualStyleBackColor = false;
            pay_btn.Click += pay_btn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 13.8F);
            label11.Location = new Point(530, 174);
            label11.Name = "label11";
            label11.Size = new Size(52, 28);
            label11.TabIndex = 28;
            label11.Text = "Tax";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(530, 219);
            label12.Name = "label12";
            label12.Size = new Size(75, 27);
            label12.TabIndex = 29;
            label12.Text = "Total";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 13.8F);
            label13.Location = new Point(408, 346);
            label13.Name = "label13";
            label13.Size = new Size(135, 28);
            label13.TabIndex = 30;
            label13.Text = "Card Type :";
            // 
            // card_type
            // 
            card_type.AutoSize = true;
            card_type.Font = new Font("Century Schoolbook", 13.8F);
            card_type.Location = new Point(543, 346);
            card_type.Name = "card_type";
            card_type.Size = new Size(117, 28);
            card_type.TabIndex = 31;
            card_type.Text = "Unknown";
            // 
            // year
            // 
            year.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            year.Location = new Point(188, 345);
            year.Name = "year";
            year.PlaceholderText = "year";
            year.Size = new Size(100, 32);
            year.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 13.8F);
            label8.Location = new Point(655, 83);
            label8.Name = "label8";
            label8.Size = new Size(25, 28);
            label8.TabIndex = 34;
            label8.Text = "$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 13.8F);
            label9.Location = new Point(655, 128);
            label9.Name = "label9";
            label9.Size = new Size(25, 28);
            label9.TabIndex = 35;
            label9.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 13.8F);
            label10.Location = new Point(655, 174);
            label10.Name = "label10";
            label10.Size = new Size(25, 28);
            label10.TabIndex = 36;
            label10.Text = "$";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 13.8F);
            label15.Location = new Point(655, 219);
            label15.Name = "label15";
            label15.Size = new Size(25, 28);
            label15.TabIndex = 37;
            label15.Text = "$";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(year);
            Controls.Add(card_type);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pay_btn);
            Controls.Add(total);
            Controls.Add(tax);
            Controls.Add(food_bill);
            Controls.Add(current_bill);
            Controls.Add(label6);
            Controls.Add(card);
            Controls.Add(cvc);
            Controls.Add(label5);
            Controls.Add(month);
            Controls.Add(payment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            Load += Invoice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox payment;
        private ComboBox month;
        private Label label5;
        private TextBox cvc;
        private TextBox card;
        private Label label6;
        private Label current_bill;
        private Label food_bill;
        private Label tax;
        private Label total;
        private Button pay_btn;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label card_type;
        private TextBox year;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label15;
    }
}