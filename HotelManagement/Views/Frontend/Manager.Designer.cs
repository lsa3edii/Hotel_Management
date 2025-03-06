namespace Lab15.Views.Frontend
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            logout = new PictureBox();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            food_btn = new Button();
            supply_chbox = new CheckBox();
            send_sms_chbox = new CheckBox();
            departure_date = new DateTimePicker();
            label5 = new Label();
            entry_date = new DateTimePicker();
            room_no = new ComboBox();
            room_floor = new ComboBox();
            room_type = new ComboBox();
            num_guest = new ComboBox();
            checkedin_chbox = new CheckBox();
            label8 = new Label();
            label6 = new Label();
            finalize_btn = new Button();
            tabs_btn = new TabControl();
            reserv_btn = new TabPage();
            groupBox3 = new GroupBox();
            year = new TextBox();
            label15 = new Label();
            label14 = new Label();
            email = new TextBox();
            label13 = new Label();
            phone_num = new TextBox();
            state = new ComboBox();
            zip_code = new TextBox();
            city = new TextBox();
            apt_suite = new TextBox();
            gender = new ComboBox();
            month = new ComboBox();
            day = new ComboBox();
            label7 = new Label();
            lname = new TextBox();
            label1 = new Label();
            address = new TextBox();
            label2 = new Label();
            label4 = new Label();
            fname = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            clear_btn = new Button();
            reserv_list = new ComboBox();
            edit_reserv_btn = new Button();
            search_list = new TextBox();
            delete_btn = new Button();
            updata_btn = new Button();
            new_reserv_btn = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            seach_btn = new TabPage();
            reservation_table = new DataGridView();
            pictureBox1 = new PictureBox();
            search = new TextBox();
            panel9 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            room_btn = new TabPage();
            reserved_table = new DataGridView();
            occupied_table = new DataGridView();
            label12 = new Label();
            label9 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            label3 = new Label();
            refresh = new PictureBox();
            generate_data_btn = new Button();
            benchmark_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            groupBox1.SuspendLayout();
            tabs_btn.SuspendLayout();
            reserv_btn.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            seach_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservation_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            room_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reserved_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)occupied_table).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refresh).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Cursor = Cursors.Hand;
            logout.Image = (Image)resources.GetObject("logout.Image");
            logout.Location = new Point(18, 723);
            logout.Name = "logout";
            logout.Size = new Size(50, 50);
            logout.SizeMode = PictureBoxSizeMode.AutoSize;
            logout.TabIndex = 11;
            logout.TabStop = false;
            logout.Click += logout_Click;
            logout.MouseEnter += logout_MouseEnter;
            logout.MouseLeave += logout_MouseLeave;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.Location = new Point(0, 602);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 51);
            panel6.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(food_btn);
            groupBox1.Controls.Add(supply_chbox);
            groupBox1.Controls.Add(send_sms_chbox);
            groupBox1.Controls.Add(departure_date);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(entry_date);
            groupBox1.Controls.Add(room_no);
            groupBox1.Controls.Add(room_floor);
            groupBox1.Controls.Add(room_type);
            groupBox1.Controls.Add(num_guest);
            groupBox1.Controls.Add(checkedin_chbox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(finalize_btn);
            groupBox1.Location = new Point(437, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 546);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // food_btn
            // 
            food_btn.Cursor = Cursors.Hand;
            food_btn.FlatStyle = FlatStyle.System;
            food_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            food_btn.Location = new Point(25, 342);
            food_btn.Name = "food_btn";
            food_btn.Size = new Size(348, 43);
            food_btn.TabIndex = 6;
            food_btn.Text = "Food and Menu";
            food_btn.UseVisualStyleBackColor = true;
            food_btn.Click += food_btn_Click;
            // 
            // supply_chbox
            // 
            supply_chbox.AutoSize = true;
            supply_chbox.Cursor = Cursors.Hand;
            supply_chbox.Location = new Point(70, 441);
            supply_chbox.Name = "supply_chbox";
            supply_chbox.Size = new Size(259, 28);
            supply_chbox.TabIndex = 9;
            supply_chbox.Text = "Food/Supply Complete";
            supply_chbox.UseVisualStyleBackColor = true;
            // 
            // send_sms_chbox
            // 
            send_sms_chbox.AutoSize = true;
            send_sms_chbox.Cursor = Cursors.Hand;
            send_sms_chbox.Location = new Point(207, 407);
            send_sms_chbox.Name = "send_sms_chbox";
            send_sms_chbox.Size = new Size(138, 28);
            send_sms_chbox.TabIndex = 8;
            send_sms_chbox.Text = "Send sms?";
            send_sms_chbox.UseVisualStyleBackColor = true;
            // 
            // departure_date
            // 
            departure_date.Cursor = Cursors.Hand;
            departure_date.Location = new Point(8, 281);
            departure_date.Name = "departure_date";
            departure_date.Size = new Size(382, 32);
            departure_date.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 246);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 25;
            label5.Text = "Departure date";
            // 
            // entry_date
            // 
            entry_date.Cursor = Cursors.Hand;
            entry_date.Location = new Point(8, 192);
            entry_date.Name = "entry_date";
            entry_date.Size = new Size(382, 32);
            entry_date.TabIndex = 4;
            // 
            // room_no
            // 
            room_no.AutoCompleteCustomSource.AddRange(new string[] { "200", "", "201", "", "202", "", "203", "", "204", "", "205", "", "206", "", "207", "", "208", "", "209", "", "210", "", "211", "", "212", "", "213", "", "214", "", "215", "", "216", "", "217", "", "218", "", "219", "", "220", "221", "222", "223", "224", "225" });
            room_no.Cursor = Cursors.Hand;
            room_no.DropDownHeight = 360;
            room_no.DropDownStyle = ComboBoxStyle.DropDownList;
            room_no.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            room_no.FormattingEnabled = true;
            room_no.IntegralHeight = false;
            room_no.Items.AddRange(new object[] { "201       ", "202       ", "203       ", "204       ", "205       ", "206       ", "207       ", "208       ", "209       ", "210       ", "211       ", "212       ", "213       ", "214       ", "215       ", "216       ", "217       ", "218       ", "219       ", "220       ", "221       ", "222       ", "223       ", "224       ", "225       " });
            room_no.Location = new Point(202, 101);
            room_no.Name = "room_no";
            room_no.Size = new Size(188, 32);
            room_no.TabIndex = 3;
            // 
            // room_floor
            // 
            room_floor.AutoCompleteCustomSource.AddRange(new string[] { "1         ", "2         ", "3         ", "4         ", "5         " });
            room_floor.Cursor = Cursors.Hand;
            room_floor.DropDownHeight = 360;
            room_floor.DropDownStyle = ComboBoxStyle.DropDownList;
            room_floor.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            room_floor.FormattingEnabled = true;
            room_floor.IntegralHeight = false;
            room_floor.Items.AddRange(new object[] { "1         ", "2         ", "3         ", "4         ", "5         " });
            room_floor.Location = new Point(8, 101);
            room_floor.Name = "room_floor";
            room_floor.Size = new Size(188, 32);
            room_floor.TabIndex = 2;
            // 
            // room_type
            // 
            room_type.AutoCompleteCustomSource.AddRange(new string[] { "Single", "Double" });
            room_type.Cursor = Cursors.Hand;
            room_type.DropDownHeight = 360;
            room_type.DropDownStyle = ComboBoxStyle.DropDownList;
            room_type.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            room_type.FormattingEnabled = true;
            room_type.IntegralHeight = false;
            room_type.Items.AddRange(new object[] { "Single    ", "Double    " });
            room_type.Location = new Point(202, 52);
            room_type.Name = "room_type";
            room_type.Size = new Size(188, 32);
            room_type.TabIndex = 1;
            // 
            // num_guest
            // 
            num_guest.Cursor = Cursors.Hand;
            num_guest.DropDownHeight = 360;
            num_guest.DropDownStyle = ComboBoxStyle.DropDownList;
            num_guest.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            num_guest.FormattingEnabled = true;
            num_guest.IntegralHeight = false;
            num_guest.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            num_guest.Location = new Point(8, 52);
            num_guest.Name = "num_guest";
            num_guest.Size = new Size(188, 32);
            num_guest.TabIndex = 0;
            // 
            // checkedin_chbox
            // 
            checkedin_chbox.AutoSize = true;
            checkedin_chbox.Cursor = Cursors.Hand;
            checkedin_chbox.Location = new Point(53, 407);
            checkedin_chbox.Name = "checkedin_chbox";
            checkedin_chbox.Size = new Size(148, 28);
            checkedin_chbox.TabIndex = 7;
            checkedin_chbox.Text = "Checked In";
            checkedin_chbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(131, 158);
            label8.Name = "label8";
            label8.Size = new Size(136, 28);
            label8.TabIndex = 19;
            label8.Text = "Entry date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(116, 13);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 15;
            label6.Text = "Your Choices";
            // 
            // finalize_btn
            // 
            finalize_btn.Cursor = Cursors.Hand;
            finalize_btn.FlatStyle = FlatStyle.System;
            finalize_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            finalize_btn.Location = new Point(25, 482);
            finalize_btn.Name = "finalize_btn";
            finalize_btn.Size = new Size(348, 43);
            finalize_btn.TabIndex = 10;
            finalize_btn.Text = "Finalize Bill";
            finalize_btn.UseVisualStyleBackColor = true;
            finalize_btn.Click += finalize_btn_Click;
            // 
            // tabs_btn
            // 
            tabs_btn.Controls.Add(reserv_btn);
            tabs_btn.Controls.Add(seach_btn);
            tabs_btn.Controls.Add(room_btn);
            tabs_btn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabs_btn.Location = new Point(16, 79);
            tabs_btn.Name = "tabs_btn";
            tabs_btn.SelectedIndex = 0;
            tabs_btn.Size = new Size(1254, 629);
            tabs_btn.TabIndex = 10;
            // 
            // reserv_btn
            // 
            reserv_btn.BackColor = Color.WhiteSmoke;
            reserv_btn.Controls.Add(groupBox3);
            reserv_btn.Controls.Add(groupBox2);
            reserv_btn.Controls.Add(panel6);
            reserv_btn.Controls.Add(groupBox1);
            reserv_btn.Controls.Add(panel3);
            reserv_btn.Controls.Add(panel1);
            reserv_btn.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            reserv_btn.Location = new Point(4, 33);
            reserv_btn.Name = "reserv_btn";
            reserv_btn.Padding = new Padding(3);
            reserv_btn.Size = new Size(1246, 592);
            reserv_btn.TabIndex = 0;
            reserv_btn.Text = "Reservation";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gainsboro;
            groupBox3.Controls.Add(year);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(email);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(phone_num);
            groupBox3.Controls.Add(state);
            groupBox3.Controls.Add(zip_code);
            groupBox3.Controls.Add(city);
            groupBox3.Controls.Add(apt_suite);
            groupBox3.Controls.Add(gender);
            groupBox3.Controls.Add(month);
            groupBox3.Controls.Add(day);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lname);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(address);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(fname);
            groupBox3.Location = new Point(16, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(399, 546);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // year
            // 
            year.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            year.Location = new Point(269, 136);
            year.Name = "year";
            year.Size = new Size(121, 32);
            year.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(147, 364);
            label15.Name = "label15";
            label15.Size = new Size(105, 28);
            label15.TabIndex = 42;
            label15.Text = "Address";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(103, 283);
            label14.Name = "label14";
            label14.Size = new Size(192, 28);
            label14.TabIndex = 41;
            label14.Text = "E-mail Address";
            // 
            // email
            // 
            email.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            email.Location = new Point(12, 316);
            email.Name = "email";
            email.Size = new Size(378, 32);
            email.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(8, 197);
            label13.Name = "label13";
            label13.Size = new Size(189, 28);
            label13.TabIndex = 39;
            label13.Text = "Phone Number";
            // 
            // phone_num
            // 
            phone_num.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            phone_num.Location = new Point(8, 230);
            phone_num.Name = "phone_num";
            phone_num.Size = new Size(254, 32);
            phone_num.TabIndex = 5;
            // 
            // state
            // 
            state.Cursor = Cursors.Hand;
            state.DropDownHeight = 360;
            state.DropDownStyle = ComboBoxStyle.DropDownList;
            state.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            state.FormattingEnabled = true;
            state.IntegralHeight = false;
            state.Items.AddRange(new object[] { "ASU", "Cairo", "Giza", "Alexandria", "Dakahlia", "Red Sea", "Beheira", "Fayoum", "Gharbia", "Ismailia", "Menofia", "Minya", "Qalyubia", "New Valley", "Suez", "Aswan", "Assiut", "Beni Suef", "Port Said", "Damietta", "Sharkia", "South Sinai", "North Sinai", "Kafr El Sheikh", "Matrouh", "Luxor", "Qena", "Sohag", "CA", "TX" });
            state.Location = new Point(8, 493);
            state.Name = "state";
            state.Size = new Size(183, 32);
            state.TabIndex = 11;
            // 
            // zip_code
            // 
            zip_code.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            zip_code.Location = new Point(207, 493);
            zip_code.Name = "zip_code";
            zip_code.Size = new Size(183, 32);
            zip_code.TabIndex = 12;
            // 
            // city
            // 
            city.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            city.Location = new Point(207, 447);
            city.Name = "city";
            city.Size = new Size(183, 32);
            city.TabIndex = 10;
            // 
            // apt_suite
            // 
            apt_suite.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            apt_suite.Location = new Point(8, 447);
            apt_suite.Name = "apt_suite";
            apt_suite.Size = new Size(183, 32);
            apt_suite.TabIndex = 9;
            // 
            // gender
            // 
            gender.Cursor = Cursors.Hand;
            gender.DropDownHeight = 360;
            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            gender.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            gender.FormattingEnabled = true;
            gender.IntegralHeight = false;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(269, 230);
            gender.Name = "gender";
            gender.Size = new Size(121, 32);
            gender.TabIndex = 6;
            // 
            // month
            // 
            month.Cursor = Cursors.Hand;
            month.DropDownHeight = 360;
            month.DropDownStyle = ComboBoxStyle.DropDownList;
            month.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            month.FormattingEnabled = true;
            month.IntegralHeight = false;
            month.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            month.Location = new Point(139, 136);
            month.Name = "month";
            month.Size = new Size(121, 32);
            month.TabIndex = 3;
            // 
            // day
            // 
            day.Cursor = Cursors.Hand;
            day.DropDownHeight = 360;
            day.DropDownStyle = ComboBoxStyle.DropDownList;
            day.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            day.FormattingEnabled = true;
            day.IntegralHeight = false;
            day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            day.Location = new Point(8, 136);
            day.Name = "day";
            day.Size = new Size(121, 32);
            day.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(144, 103);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 22;
            label7.Text = "Birthday";
            // 
            // lname
            // 
            lname.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            lname.Location = new Point(207, 47);
            lname.Name = "lname";
            lname.Size = new Size(183, 32);
            lname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 197);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 19;
            label1.Text = "Gender";
            // 
            // address
            // 
            address.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            address.Location = new Point(8, 396);
            address.Name = "address";
            address.Size = new Size(382, 32);
            address.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 16);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 16);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 15;
            label4.Text = "First Name";
            // 
            // fname
            // 
            fname.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            fname.Location = new Point(8, 47);
            fname.Name = "fname";
            fname.Size = new Size(183, 32);
            fname.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(clear_btn);
            groupBox2.Controls.Add(reserv_list);
            groupBox2.Controls.Add(edit_reserv_btn);
            groupBox2.Controls.Add(search_list);
            groupBox2.Controls.Add(delete_btn);
            groupBox2.Controls.Add(updata_btn);
            groupBox2.Controls.Add(new_reserv_btn);
            groupBox2.Location = new Point(857, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 546);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.Gold;
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            clear_btn.ForeColor = SystemColors.ControlText;
            clear_btn.Location = new Point(189, 475);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(175, 65);
            clear_btn.TabIndex = 0;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // reserv_list
            // 
            reserv_list.Cursor = Cursors.Hand;
            reserv_list.DropDownStyle = ComboBoxStyle.DropDownList;
            reserv_list.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Italic);
            reserv_list.FormattingEnabled = true;
            reserv_list.Location = new Point(7, 68);
            reserv_list.Name = "reserv_list";
            reserv_list.Size = new Size(357, 32);
            reserv_list.TabIndex = 5;
            // 
            // edit_reserv_btn
            // 
            edit_reserv_btn.BackColor = Color.DarkSlateGray;
            edit_reserv_btn.Cursor = Cursors.Hand;
            edit_reserv_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            edit_reserv_btn.ForeColor = Color.White;
            edit_reserv_btn.Location = new Point(12, 421);
            edit_reserv_btn.Name = "edit_reserv_btn";
            edit_reserv_btn.Size = new Size(348, 43);
            edit_reserv_btn.TabIndex = 2;
            edit_reserv_btn.Text = "Edti Exisiting Reservation";
            edit_reserv_btn.UseVisualStyleBackColor = false;
            edit_reserv_btn.Click += edit_reserv_btn_Click;
            // 
            // search_list
            // 
            search_list.BackColor = Color.White;
            search_list.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            search_list.Location = new Point(44, 16);
            search_list.Name = "search_list";
            search_list.PlaceholderText = "Search..";
            search_list.Size = new Size(320, 35);
            search_list.TabIndex = 13;
            search_list.TextChanged += search_list_TextChanged;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Red;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(12, 357);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(348, 43);
            delete_btn.TabIndex = 4;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // updata_btn
            // 
            updata_btn.BackColor = Color.MediumSeaGreen;
            updata_btn.Cursor = Cursors.Hand;
            updata_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            updata_btn.ForeColor = Color.White;
            updata_btn.Location = new Point(12, 302);
            updata_btn.Name = "updata_btn";
            updata_btn.Size = new Size(348, 43);
            updata_btn.TabIndex = 3;
            updata_btn.Text = "Update";
            updata_btn.UseVisualStyleBackColor = false;
            updata_btn.Click += updata_btn_Click;
            // 
            // new_reserv_btn
            // 
            new_reserv_btn.BackColor = Color.RoyalBlue;
            new_reserv_btn.Cursor = Cursors.Hand;
            new_reserv_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            new_reserv_btn.ForeColor = Color.White;
            new_reserv_btn.Location = new Point(8, 475);
            new_reserv_btn.Name = "new_reserv_btn";
            new_reserv_btn.Size = new Size(175, 65);
            new_reserv_btn.TabIndex = 1;
            new_reserv_btn.Text = "New Reservation";
            new_reserv_btn.UseVisualStyleBackColor = false;
            new_reserv_btn.Click += new_reserv_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Location = new Point(131, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1124, 10);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 10);
            panel1.TabIndex = 0;
            // 
            // seach_btn
            // 
            seach_btn.BackColor = Color.WhiteSmoke;
            seach_btn.Controls.Add(reservation_table);
            seach_btn.Controls.Add(pictureBox1);
            seach_btn.Controls.Add(search);
            seach_btn.Controls.Add(panel9);
            seach_btn.Controls.Add(panel7);
            seach_btn.Controls.Add(panel8);
            seach_btn.Location = new Point(4, 33);
            seach_btn.Name = "seach_btn";
            seach_btn.Size = new Size(1246, 592);
            seach_btn.TabIndex = 2;
            seach_btn.Text = "Universal Search";
            // 
            // reservation_table
            // 
            reservation_table.AllowUserToAddRows = false;
            reservation_table.AllowUserToDeleteRows = false;
            reservation_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            reservation_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reservation_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservation_table.Location = new Point(6, 84);
            reservation_table.Name = "reservation_table";
            reservation_table.ReadOnly = true;
            reservation_table.RowHeadersWidth = 51;
            reservation_table.Size = new Size(1237, 502);
            reservation_table.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // search
            // 
            search.BackColor = Color.White;
            search.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            search.Location = new Point(239, 31);
            search.Name = "search";
            search.PlaceholderText = "Search..";
            search.Size = new Size(808, 35);
            search.TabIndex = 0;
            search.TextChanged += search_TextChanged;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkGray;
            panel9.Location = new Point(321, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(934, 10);
            panel9.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGray;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(133, 10);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SteelBlue;
            panel8.Location = new Point(131, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(190, 10);
            panel8.TabIndex = 2;
            // 
            // room_btn
            // 
            room_btn.Controls.Add(reserved_table);
            room_btn.Controls.Add(occupied_table);
            room_btn.Controls.Add(label12);
            room_btn.Controls.Add(label9);
            room_btn.Controls.Add(panel10);
            room_btn.Controls.Add(panel11);
            room_btn.Controls.Add(panel12);
            room_btn.Location = new Point(4, 33);
            room_btn.Name = "room_btn";
            room_btn.Size = new Size(1246, 592);
            room_btn.TabIndex = 3;
            room_btn.Text = "Room Availibility";
            room_btn.UseVisualStyleBackColor = true;
            // 
            // reserved_table
            // 
            reserved_table.AllowUserToAddRows = false;
            reserved_table.AllowUserToDeleteRows = false;
            reserved_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            reserved_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reserved_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reserved_table.Location = new Point(631, 56);
            reserved_table.Name = "reserved_table";
            reserved_table.ReadOnly = true;
            reserved_table.RowHeadersWidth = 51;
            reserved_table.Size = new Size(600, 522);
            reserved_table.TabIndex = 1;
            // 
            // occupied_table
            // 
            occupied_table.AllowUserToAddRows = false;
            occupied_table.AllowUserToDeleteRows = false;
            occupied_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            occupied_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            occupied_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            occupied_table.Location = new Point(15, 56);
            occupied_table.Name = "occupied_table";
            occupied_table.ReadOnly = true;
            occupied_table.RowHeadersWidth = 51;
            occupied_table.Size = new Size(600, 522);
            occupied_table.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(864, 23);
            label12.Name = "label12";
            label12.Size = new Size(117, 28);
            label12.TabIndex = 13;
            label12.Text = "Reserved";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(247, 23);
            label9.Name = "label9";
            label9.Size = new Size(122, 28);
            label9.TabIndex = 10;
            label9.Text = "Occupied";
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkGray;
            panel10.Location = new Point(517, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(735, 10);
            panel10.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DarkGray;
            panel11.Location = new Point(-2, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(323, 10);
            panel11.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.BackColor = Color.SteelBlue;
            panel12.Location = new Point(321, 1);
            panel12.Name = "panel12";
            panel12.Size = new Size(204, 10);
            panel12.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 14);
            label3.Name = "label3";
            label3.Size = new Size(215, 47);
            label3.TabIndex = 9;
            label3.Text = "Frontend";
            // 
            // refresh
            // 
            refresh.Cursor = Cursors.Hand;
            refresh.Image = (Image)resources.GetObject("refresh.Image");
            refresh.Location = new Point(1216, 723);
            refresh.Name = "refresh";
            refresh.Size = new Size(50, 50);
            refresh.SizeMode = PictureBoxSizeMode.AutoSize;
            refresh.TabIndex = 12;
            refresh.TabStop = false;
            refresh.Tag = "";
            refresh.Click += refresh_Click;
            refresh.MouseEnter += refresh_MouseEnter;
            refresh.MouseLeave += refresh_MouseLeave;
            // 
            // generate_data_btn
            // 
            generate_data_btn.BackColor = Color.Red;
            generate_data_btn.Cursor = Cursors.Hand;
            generate_data_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            generate_data_btn.ForeColor = Color.White;
            generate_data_btn.Location = new Point(324, 723);
            generate_data_btn.Name = "generate_data_btn";
            generate_data_btn.Size = new Size(371, 50);
            generate_data_btn.TabIndex = 15;
            generate_data_btn.Text = "Generate Fake Data";
            generate_data_btn.UseVisualStyleBackColor = false;
            generate_data_btn.Click += generate_data_btn_Click;
            // 
            // benchmark_btn
            // 
            benchmark_btn.BackColor = Color.DarkCyan;
            benchmark_btn.Cursor = Cursors.Hand;
            benchmark_btn.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold | FontStyle.Italic);
            benchmark_btn.ForeColor = Color.White;
            benchmark_btn.Location = new Point(701, 723);
            benchmark_btn.Name = "benchmark_btn";
            benchmark_btn.Size = new Size(257, 50);
            benchmark_btn.TabIndex = 16;
            benchmark_btn.Text = "Benchmark";
            benchmark_btn.UseVisualStyleBackColor = false;
            benchmark_btn.Click += benchmark_btn_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1287, 785);
            Controls.Add(benchmark_btn);
            Controls.Add(generate_data_btn);
            Controls.Add(refresh);
            Controls.Add(logout);
            Controls.Add(tabs_btn);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            FormClosing += Frontend_FormClosing;
            Load += Manager_Load;
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabs_btn.ResumeLayout(false);
            reserv_btn.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            seach_btn.ResumeLayout(false);
            seach_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservation_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            room_btn.ResumeLayout(false);
            room_btn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reserved_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)occupied_table).EndInit();
            ((System.ComponentModel.ISupportInitialize)refresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logout;
        private Panel panel6;
        private GroupBox groupBox1;
        private CheckBox checkedin_chbox;
        private Label label8;
        private TextBox dinner_qty;
        private Label label7;
        private TextBox lunch_qty;
        private Label label6;
        private TextBox breakfast_qty;
        private Button changeFood_btn;
        private TabControl tabs_btn;
        private TabPage reserv_btn;
        private Panel panel3;
        private Panel panel1;
        private Label label3;
        private GroupBox groupBox2;
        private Button new_reserv_btn;
        private TabPage seach_btn;
        private TabPage room_btn;
        private Panel panel9;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private PictureBox pictureBox1;
        private TextBox search;
        private DataGridView reservation_table;
        private Label label9;
        private Label label12;
        private Button edit_reserv_btn;
        private Button delete_btn;
        private Button updata_btn;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox address;
        private Label label2;
        private Label label4;
        private TextBox fname;
        private Button finalize_btn;
        private ComboBox reserv_list;
        private ComboBox room_no;
        private ComboBox room_floor;
        private ComboBox room_type;
        private ComboBox num_guest;
        private DateTimePicker departure_date;
        private Label label5;
        private DateTimePicker entry_date;
        private CheckBox supply_chbox;
        private CheckBox send_sms_chbox;
        private Button food_btn;
        private ComboBox gender;
        private ComboBox month;
        private ComboBox day;
        private TextBox lname;
        private Label label14;
        private TextBox email;
        private Label label13;
        private TextBox phone_num;
        private ComboBox state;
        private TextBox zip_code;
        private TextBox city;
        private TextBox apt_suite;
        private Label label15;
        private TextBox year;
        private DataGridView reserved_table;
        private DataGridView occupied_table;
        private PictureBox refresh;
        private Button clear_btn;
        private PictureBox pictureBox2;
        private TextBox search_list;
        private Button generate_data_btn;
        private Button benchmark_btn;
    }
}