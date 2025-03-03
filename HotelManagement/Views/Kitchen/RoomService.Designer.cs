namespace Lab15.Views.Kitchen
{
    partial class RoomService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomService));
            label3 = new Label();
            tabs_btn = new TabControl();
            todo_btn = new TabPage();
            label10 = new Label();
            label9 = new Label();
            floorno = new TextBox();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            surprise_chbox = new CheckBox();
            towels_chbox = new CheckBox();
            cleaning_chbox = new CheckBox();
            supplyStatus_chbox = new CheckBox();
            label8 = new Label();
            dinner_qty = new TextBox();
            label7 = new Label();
            lunch_qty = new TextBox();
            label6 = new Label();
            breakfast_qty = new TextBox();
            changeFood_btn = new Button();
            label5 = new Label();
            roomNo = new TextBox();
            label4 = new Label();
            roomType = new TextBox();
            label2 = new Label();
            phone = new TextBox();
            label1 = new Label();
            name = new TextBox();
            update_btn = new Button();
            listBox = new ListBox();
            panel3 = new Panel();
            panel1 = new Panel();
            overview_btn = new TabPage();
            table = new DataGridView();
            panel5 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            logout = new PictureBox();
            refresh = new PictureBox();
            tabs_btn.SuspendLayout();
            todo_btn.SuspendLayout();
            groupBox1.SuspendLayout();
            overview_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 17);
            label3.Name = "label3";
            label3.Size = new Size(306, 47);
            label3.TabIndex = 6;
            label3.Text = "Room Service";
            // 
            // tabs_btn
            // 
            tabs_btn.Controls.Add(todo_btn);
            tabs_btn.Controls.Add(overview_btn);
            tabs_btn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabs_btn.Location = new Point(34, 82);
            tabs_btn.Name = "tabs_btn";
            tabs_btn.SelectedIndex = 0;
            tabs_btn.Size = new Size(1175, 629);
            tabs_btn.TabIndex = 7;
            // 
            // todo_btn
            // 
            todo_btn.BackColor = Color.WhiteSmoke;
            todo_btn.Controls.Add(label10);
            todo_btn.Controls.Add(label9);
            todo_btn.Controls.Add(floorno);
            todo_btn.Controls.Add(panel6);
            todo_btn.Controls.Add(groupBox1);
            todo_btn.Controls.Add(label5);
            todo_btn.Controls.Add(roomNo);
            todo_btn.Controls.Add(label4);
            todo_btn.Controls.Add(roomType);
            todo_btn.Controls.Add(label2);
            todo_btn.Controls.Add(phone);
            todo_btn.Controls.Add(label1);
            todo_btn.Controls.Add(name);
            todo_btn.Controls.Add(update_btn);
            todo_btn.Controls.Add(listBox);
            todo_btn.Controls.Add(panel3);
            todo_btn.Controls.Add(panel1);
            todo_btn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            todo_btn.Location = new Point(4, 33);
            todo_btn.Name = "todo_btn";
            todo_btn.Padding = new Padding(3);
            todo_btn.Size = new Size(1167, 592);
            todo_btn.TabIndex = 0;
            todo_btn.Text = "TODO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(797, 41);
            label10.Name = "label10";
            label10.Size = new Size(144, 28);
            label10.TabIndex = 17;
            label10.Text = "On the line";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 377);
            label9.Name = "label9";
            label9.Size = new Size(122, 28);
            label9.TabIndex = 16;
            label9.Text = "Floor No.";
            // 
            // floorno
            // 
            floorno.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            floorno.Location = new Point(22, 413);
            floorno.Name = "floorno";
            floorno.ReadOnly = true;
            floorno.Size = new Size(314, 35);
            floorno.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.Location = new Point(0, 602);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 51);
            panel6.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(surprise_chbox);
            groupBox1.Controls.Add(towels_chbox);
            groupBox1.Controls.Add(cleaning_chbox);
            groupBox1.Controls.Add(supplyStatus_chbox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dinner_qty);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lunch_qty);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(breakfast_qty);
            groupBox1.Controls.Add(changeFood_btn);
            groupBox1.Location = new Point(362, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 436);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Todo";
            // 
            // surprise_chbox
            // 
            surprise_chbox.AutoSize = true;
            surprise_chbox.Cursor = Cursors.Hand;
            surprise_chbox.Enabled = false;
            surprise_chbox.FlatStyle = FlatStyle.Popup;
            surprise_chbox.Location = new Point(252, 279);
            surprise_chbox.Name = "surprise_chbox";
            surprise_chbox.Size = new Size(142, 28);
            surprise_chbox.TabIndex = 5;
            surprise_chbox.Text = "S_Surprise";
            surprise_chbox.UseVisualStyleBackColor = true;
            // 
            // towels_chbox
            // 
            towels_chbox.AutoSize = true;
            towels_chbox.Cursor = Cursors.Hand;
            towels_chbox.Enabled = false;
            towels_chbox.FlatStyle = FlatStyle.Popup;
            towels_chbox.Location = new Point(144, 279);
            towels_chbox.Name = "towels_chbox";
            towels_chbox.Size = new Size(99, 28);
            towels_chbox.TabIndex = 4;
            towels_chbox.Text = "Towels";
            towels_chbox.UseVisualStyleBackColor = true;
            // 
            // cleaning_chbox
            // 
            cleaning_chbox.AutoSize = true;
            cleaning_chbox.Cursor = Cursors.Hand;
            cleaning_chbox.Enabled = false;
            cleaning_chbox.FlatStyle = FlatStyle.Popup;
            cleaning_chbox.Location = new Point(12, 279);
            cleaning_chbox.Name = "cleaning_chbox";
            cleaning_chbox.Size = new Size(123, 28);
            cleaning_chbox.TabIndex = 3;
            cleaning_chbox.Text = "Cleaning";
            cleaning_chbox.UseVisualStyleBackColor = true;
            // 
            // supplyStatus_chbox
            // 
            supplyStatus_chbox.AutoSize = true;
            supplyStatus_chbox.Cursor = Cursors.Hand;
            supplyStatus_chbox.Location = new Point(82, 328);
            supplyStatus_chbox.Name = "supplyStatus_chbox";
            supplyStatus_chbox.Size = new Size(244, 28);
            supplyStatus_chbox.TabIndex = 6;
            supplyStatus_chbox.Text = "Food / Supply Status";
            supplyStatus_chbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 167);
            label8.Name = "label8";
            label8.Size = new Size(96, 28);
            label8.TabIndex = 19;
            label8.Text = "Dinner";
            // 
            // dinner_qty
            // 
            dinner_qty.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dinner_qty.Location = new Point(23, 203);
            dinner_qty.Name = "dinner_qty";
            dinner_qty.ReadOnly = true;
            dinner_qty.Size = new Size(363, 35);
            dinner_qty.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(216, 67);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 17;
            label7.Text = "Lunch";
            // 
            // lunch_qty
            // 
            lunch_qty.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lunch_qty.Location = new Point(216, 103);
            lunch_qty.Name = "lunch_qty";
            lunch_qty.ReadOnly = true;
            lunch_qty.Size = new Size(170, 35);
            lunch_qty.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 67);
            label6.Name = "label6";
            label6.Size = new Size(127, 28);
            label6.TabIndex = 15;
            label6.Text = "Breakfast";
            // 
            // breakfast_qty
            // 
            breakfast_qty.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            breakfast_qty.Location = new Point(23, 103);
            breakfast_qty.Name = "breakfast_qty";
            breakfast_qty.ReadOnly = true;
            breakfast_qty.Size = new Size(170, 35);
            breakfast_qty.TabIndex = 0;
            // 
            // changeFood_btn
            // 
            changeFood_btn.Cursor = Cursors.Hand;
            changeFood_btn.FlatStyle = FlatStyle.System;
            changeFood_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            changeFood_btn.Location = new Point(31, 374);
            changeFood_btn.Name = "changeFood_btn";
            changeFood_btn.Size = new Size(348, 43);
            changeFood_btn.TabIndex = 7;
            changeFood_btn.Text = "Change Food";
            changeFood_btn.UseVisualStyleBackColor = true;
            changeFood_btn.Click += changeFood_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(184, 274);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 12;
            label5.Text = "Room No.";
            // 
            // roomNo
            // 
            roomNo.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roomNo.Location = new Point(182, 310);
            roomNo.Name = "roomNo";
            roomNo.ReadOnly = true;
            roomNo.Size = new Size(154, 35);
            roomNo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 274);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 10;
            label4.Text = "Room Type";
            // 
            // roomType
            // 
            roomType.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roomType.Location = new Point(22, 310);
            roomType.Name = "roomType";
            roomType.ReadOnly = true;
            roomType.Size = new Size(154, 35);
            roomType.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 173);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 8;
            label2.Text = "Phone";
            // 
            // phone
            // 
            phone.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            phone.Location = new Point(22, 209);
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Size = new Size(314, 35);
            phone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 72);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // name
            // 
            name.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            name.Location = new Point(22, 108);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(314, 35);
            name.TabIndex = 1;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.MediumSeaGreen;
            update_btn.Cursor = Cursors.Hand;
            update_btn.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(797, 528);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(348, 43);
            update_btn.TabIndex = 0;
            update_btn.Text = "Update Changes";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(797, 72);
            listBox.Name = "listBox";
            listBox.Size = new Size(348, 436);
            listBox.TabIndex = 6;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Location = new Point(70, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 10);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 10);
            panel1.TabIndex = 0;
            // 
            // overview_btn
            // 
            overview_btn.Controls.Add(table);
            overview_btn.Controls.Add(panel5);
            overview_btn.Controls.Add(panel4);
            overview_btn.Controls.Add(panel2);
            overview_btn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            overview_btn.Location = new Point(4, 33);
            overview_btn.Name = "overview_btn";
            overview_btn.Padding = new Padding(3);
            overview_btn.Size = new Size(1167, 592);
            overview_btn.TabIndex = 1;
            overview_btn.Text = "Overview";
            overview_btn.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(-4, 16);
            table.Name = "table";
            table.ReadOnly = true;
            table.RowHeadersWidth = 51;
            table.Size = new Size(1175, 580);
            table.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGray;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(77, 10);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Location = new Point(182, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1088, 10);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(75, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 10);
            panel2.TabIndex = 1;
            // 
            // logout
            // 
            logout.Cursor = Cursors.Hand;
            logout.Image = (Image)resources.GetObject("logout.Image");
            logout.Location = new Point(34, 723);
            logout.Name = "logout";
            logout.Size = new Size(50, 50);
            logout.SizeMode = PictureBoxSizeMode.AutoSize;
            logout.TabIndex = 8;
            logout.TabStop = false;
            logout.Click += logout_Click;
            logout.MouseEnter += pictureBox_MouseEnter;
            logout.MouseLeave += pictureBox_MouseLeave;
            // 
            // refresh
            // 
            refresh.Cursor = Cursors.Hand;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(1155, 723);
            refresh.Name = "refresh";
            refresh.Size = new Size(50, 50);
            refresh.SizeMode = PictureBoxSizeMode.AutoSize;
            refresh.TabIndex = 13;
            refresh.TabStop = false;
            refresh.Click += refresh_Click;
            refresh.MouseEnter += refresh_MouseEnter;
            refresh.MouseLeave += refresh_MouseLeave;
            // 
            // RoomService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1248, 785);
            Controls.Add(refresh);
            Controls.Add(logout);
            Controls.Add(tabs_btn);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RoomService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            FormClosing += RoomService_FormClosing;
            Load += RoomService_Load;
            tabs_btn.ResumeLayout(false);
            todo_btn.ResumeLayout(false);
            todo_btn.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            overview_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TabControl tabs_btn;
        private TabPage todo_btn;
        private TabPage overview_btn;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private DataGridView table;
        private ListBox listBox;
        private Button update_btn;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox roomNo;
        private Label label4;
        private TextBox roomType;
        private Label label2;
        private TextBox phone;
        private Label label1;
        private TextBox name;
        private Label label8;
        private TextBox dinner_qty;
        private Label label7;
        private TextBox lunch_qty;
        private Label label6;
        private TextBox breakfast_qty;
        private Button changeFood_btn;
        private CheckBox supplyStatus_chbox;
        private Panel panel6;
        private PictureBox logout;
        private Label label10;
        private Label label9;
        private TextBox floorno;
        private CheckBox surprise_chbox;
        private CheckBox towels_chbox;
        private CheckBox cleaning_chbox;
        private PictureBox refresh;
    }
}