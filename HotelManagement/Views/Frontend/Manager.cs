using HotelManagement.Bogus;
using HotelManagement.Dapper.Managers;
using HotelManagement.Views;
using Lab15.Context;
using Lab15.Dapper.Entities;
using Lab15.Entities;
using Lab15.Views.Kitchen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab15.Views.Frontend
{
    public partial class Manager : Form
    {
        Login login;
        ReservationContext context;
        BindingSource bindingSource;

        ReservationManager manager;


        private const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        public Manager(Login _login)
        {
            InitializeComponent();

            HideBtns();
            login = _login;

            manager = new();

            this.Load += (s, e) =>
            {
                int darkColor = ColorTranslator.ToWin32(Color.Black);
                DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref darkColor, sizeof(int));
            };
        }



        #region EF Manager_Load
        private async void Manager_Load(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    var reservations = context.Reservations.IgnoreQueryFilters().ToList();
                    bindingSource = new BindingSource { DataSource = reservations };

                    reservation_table.DataSource = bindingSource;
                    reserved_table.DataSource = await context.RservedRooms();
                    occupied_table.DataSource = await context.OccupiedRooms();

                    HideTableColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Dapper Manager_Load
        //private async void Manager_Load(object sender, EventArgs e)
        //{
        //    using (context = new())
        //    {
        //        try
        //        {
        //            //manager = new(context);
        //            //Trace.WriteLine(manager.GetByID(31));

        //            var reservations = manager.GetAll();
        //            bindingSource = new BindingSource { DataSource = reservations };

        //            reservation_table.DataSource = bindingSource;
        //            reserved_table.DataSource = await context.RservedRooms();
        //            occupied_table.DataSource = await context.OccupiedRooms();

        //            HideTableColumns();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        #endregion



        #region EF search_list_TextChanged
        private void search_list_TextChanged(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    string searchText = search_list.Text.Trim();

                    bindingSource.DataSource = context.Reservations.IgnoreQueryFilters().ToList()
                        .Where(R => R.Id.ToString().Contains(searchText) || R.FullName.ToLower().Contains(searchText.ToLower()))
                        .ToList();

                    reserv_list.DataSource = bindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Dapper search_list_TextChanged
        //private void search_list_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string searchText = search_list.Text.Trim();

        //        bindingSource.DataSource = manager.GetAll()
        //            .Where(R => R.Id.ToString().Contains(searchText) || R.FullName.ToLower().Contains(searchText.ToLower()))
        //            .ToList();

        //        reserv_list.DataSource = bindingSource;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion



        private void search_TextChanged(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    int.TryParse(search.Text, out int id);
                    bindingSource.DataSource = context.SearchReservation(id, search.Text);

                    //var r = context.Database.SqlQuery<Reservation>($"select * from reservation").ToList(); // SqlQuery<T> is Must match all in T
                    //var r = context.SearchReservation(12, null);

                    //foreach (var item in context.TestProc())
                    //    Trace.WriteLine(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        #region EF new_reserv_btn_Click
        private void new_reserv_btn_Click(object sender, EventArgs e)
        {
            //HideBtns();

            if (fname.Text != string.Empty && lname.Text != string.Empty && year.Text != string.Empty
                && phone_num.Text != string.Empty && email.Text != string.Empty && address.Text != string.Empty)
            {
                using (context = new())
                {
                    try
                    {
                        context.Reservations.Add(
                        new Reservation
                        {
                            FirstName = fname.Text,
                            LastName = lname.Text,
                            BirthDay = day.Text + "-" + month.Text + "-" + year.Text,
                            Gender = gender.Text,
                            PhoneNumber = phone_num.Text,
                            EmailAddress = email.Text,
                            NumberGuest = int.Parse(num_guest.Text),
                            StreetAddress = address.Text,
                            AptSuite = apt_suite.Text,
                            City = city.Text,
                            State = state.Text,
                            ZipCode = zip_code.Text,
                            RoomType = room_type.Text,
                            RoomFloor = room_floor.Text,
                            RoomNumber = room_no.Text,

                            TotalBill = 0,
                            PaymentType = "",
                            CardType = "",
                            CardNumber = "",
                            CardExp = "",
                            CardCvc = "",
                            FoodBill = 0,

                            ArrivalTime = entry_date.Value,
                            LeavingTime = departure_date.Value,

                            CheckIn = checkedin_chbox.Checked,
                            BreakFast = 0,
                            Lunch = 0,
                            Dinner = 0,
                            Cleaning = false,
                            Towel = false,
                            SSurprise = false,
                            SupplyStatus = false
                        });

                        context.SaveChanges();

                        RefreshBindingSource();
                        MessageBox.Show("Successfully Added!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please check data u entered..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Dapper new_reserv_btn_Click
        //private void new_reserv_btn_Click(object sender, EventArgs e)
        //{
        //    //HideBtns();

        //    if (fname.Text != string.Empty && lname.Text != string.Empty && year.Text != string.Empty
        //        && phone_num.Text != string.Empty && email.Text != string.Empty && address.Text != string.Empty)
        //    {
        //        try
        //        {
        //            manager.Insert(
        //            new ReservationDapper
        //            {
        //                First_Name = fname.Text,
        //                Last_Name = lname.Text,
        //                Birth_Day = day.Text + "-" + month.Text + "-" + year.Text,
        //                Gender = gender.Text,
        //                Phone_Number = phone_num.Text,
        //                Email_Address = email.Text,
        //                Number_Guest = int.Parse(num_guest.Text),
        //                Street_Address = address.Text,
        //                Apt_Suite = apt_suite.Text,
        //                City = city.Text,
        //                State = state.Text,
        //                Zip_Code = zip_code.Text,
        //                Room_Type = room_type.Text,
        //                Room_Floor = room_floor.Text,
        //                Room_Number = room_no.Text,

        //                Total_Bill = 0,
        //                Payment_Type = "",
        //                Card_Type = "",
        //                Card_Number = "",
        //                Card_Exp = "",
        //                Card_Cvc = "",
        //                Food_Bill = 0,

        //                Arrival_Time = entry_date.Value,
        //                Leaving_Time = departure_date.Value,

        //                Check_In = checkedin_chbox.Checked,
        //                Break_Fast = 0,
        //                Lunch = 0,
        //                Dinner = 0,
        //                Cleaning = false,
        //                Towel = false,
        //                S_Surprise = false,
        //                Supply_Status = false
        //            });

        //            RefreshBindingSource();
        //            MessageBox.Show("Successfully Added!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //        MessageBox.Show("Please check data u entered..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        #endregion



        #region EF edit_reserv_btn_Click
        private async void edit_reserv_btn_Click(object sender, EventArgs e)
        {
            ShowBtns();

            //if (bindingSource != null)
            //    bindingSource.Dispose();

            //reserv_list.DataSource = null;

            if (bindingSource.Current != null)
            {
                using (context = new())
                {
                    try
                    {
                        var reservations = context.Reservations.IgnoreQueryFilters().ToList();
                        bindingSource = new BindingSource { DataSource = reservations };

                        reserv_list.DataSource = bindingSource;

                        SelectedListIndexChanged();
                        RefreshBindingSource();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region Dapper edit_reserv_btn_Click
        //private async void edit_reserv_btn_Click(object sender, EventArgs e)
        //{
        //    ShowBtns();

        //    //if (bindingSource != null)
        //    //    bindingSource.Dispose();

        //    //reserv_list.DataSource = null;

        //    if (bindingSource.Current != null)
        //    {
        //        using (context = new())
        //        {
        //            try
        //            {
        //                var reservations = manager.GetAll();
        //                bindingSource = new BindingSource { DataSource = reservations };

        //                reserv_list.DataSource = bindingSource;

        //                SelectedListIndexChanged();
        //                RefreshBindingSource();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
        #endregion



        #region EF updata_btn_Click
        private void updata_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource.Current != null && MessageBox.Show("Are you sure you want to update this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (context = new())
                    {
                        context.Reservations.Update((Reservation)bindingSource.Current);
                        context.SaveChanges();

                        RefreshBindingSource();
                        MessageBox.Show("Reservation Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("No reservation selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Dapper updata_btn_Click
        //private void updata_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (bindingSource.Current != null && MessageBox.Show("Are you sure you want to update this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            var reservation = (ReservationDapper)bindingSource.Current;
        //            manager.Update(reservation);

        //            RefreshBindingSource();
        //            MessageBox.Show("Reservation Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //            MessageBox.Show("No reservation selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion



        #region EF delete_btn_Click
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (context = new())
                {
                    if (bindingSource.Current != null && MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.Reservations.Remove((Reservation)bindingSource.Current);
                        context.SaveChanges();

                        bindingSource.RemoveCurrent();

                        RefreshBindingSource();
                        MessageBox.Show("Reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No reservation selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region dapper delete_btn_Click
        //private void delete_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (bindingSource.Current != null && MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            var reservation = (ReservationDapper)bindingSource.Current;
        //            manager.Delete(reservation.Id);

        //            bindingSource.RemoveCurrent();

        //            RefreshBindingSource();
        //            MessageBox.Show("Reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //            MessageBox.Show("No reservation selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion



        #region EF RefreshBindingSource
        private async void RefreshBindingSource()
        {
            using (context = new ReservationContext())
            {
                try
                {
                    bindingSource.DataSource = context.Reservations.IgnoreQueryFilters().ToList();

                    reservation_table.DataSource = bindingSource;
                    reserv_list.DataSource = bindingSource;

                    reserved_table.DataSource = await context.RservedRooms();
                    occupied_table.DataSource = await context.OccupiedRooms();

                    HideTableColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Dapper RefreshBindingSource
        //private async void RefreshBindingSource()
        //{
        //    using (context = new ReservationContext())
        //    {
        //        try
        //        {
        //            bindingSource.DataSource = manager.GetAll();

        //            reservation_table.DataSource = bindingSource;
        //            reserv_list.DataSource = bindingSource;

        //            reserved_table.DataSource = await context.RservedRooms();
        //            occupied_table.DataSource = await context.OccupiedRooms();

        //            HideTableColumns();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        #endregion



        private void finalize_btn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Reservation selectedReservation)
                new Invoice(selectedReservation).ShowDialog();
            else
                MessageBox.Show("Please select a reservation first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void food_btn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Reservation selectedReservation)
                new FoodMenu(selectedReservation).ShowDialog();
            else
                MessageBox.Show("Please select a reservation first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        #region EF SelectedListIndexChanged
        private void SelectedListIndexChanged()
        {
            fname.DataBindings.Clear();
            lname.DataBindings.Clear();
            day.DataBindings.Clear();
            month.DataBindings.Clear();
            year.DataBindings.Clear();
            phone_num.DataBindings.Clear();
            gender.DataBindings.Clear();
            email.DataBindings.Clear();
            address.DataBindings.Clear();
            apt_suite.DataBindings.Clear();
            city.DataBindings.Clear();
            state.DataBindings.Clear();
            zip_code.DataBindings.Clear();
            num_guest.DataBindings.Clear();
            room_type.DataBindings.Clear();
            room_floor.DataBindings.Clear();
            room_no.DataBindings.Clear();
            entry_date.DataBindings.Clear();
            departure_date.DataBindings.Clear();
            checkedin_chbox.DataBindings.Clear();
            supply_chbox.DataBindings.Clear();
            //send_sms_chbox.DataBindings.Clear();

            fname.DataBindings.Add("Text", bindingSource, "firstname");
            lname.DataBindings.Add("Text", bindingSource, "lastname");
            day.DataBindings.Add("Text", bindingSource, "day");
            month.DataBindings.Add("Text", bindingSource, "month");
            year.DataBindings.Add("Text", bindingSource, "year");
            phone_num.DataBindings.Add("Text", bindingSource, "phonenumber");
            gender.DataBindings.Add("Text", bindingSource, "gender");
            email.DataBindings.Add("Text", bindingSource, "EmailAddress");
            address.DataBindings.Add("Text", bindingSource, "StreetAddress");
            apt_suite.DataBindings.Add("Text", bindingSource, "aptsuite");
            city.DataBindings.Add("Text", bindingSource, "city");
            state.DataBindings.Add("Text", bindingSource, "state");
            zip_code.DataBindings.Add("Text", bindingSource, "zipcode");
            num_guest.DataBindings.Add("Text", bindingSource, "NumberGuest");
            room_type.DataBindings.Add("Text", bindingSource, "RoomType");
            room_floor.DataBindings.Add("Text", bindingSource, "RoomFloor");
            room_no.DataBindings.Add("Text", bindingSource, "RoomNumber");

            //entry_date.DataBindings.Add("Value", bindingSource, "ArrivalTime");  // Use "Value" instead of "Text" for DateTimePicker
            //departure_date.DataBindings.Add("Value", bindingSource, "LeavingTime");
            entry_date.DataBindings.Add("Value", bindingSource, "ArrivalTime", true, DataSourceUpdateMode.OnValidation, DateTime.Today);
            departure_date.DataBindings.Add("Value", bindingSource, "LeavingTime", true, DataSourceUpdateMode.OnValidation, DateTime.Today.AddDays(1));

            checkedin_chbox.DataBindings.Add("Checked", bindingSource, "checkin", true, DataSourceUpdateMode.OnPropertyChanged);
            supply_chbox.DataBindings.Add("Checked", bindingSource, "SupplyStatus", true, DataSourceUpdateMode.OnPropertyChanged);
            //send_sms_chbox.DataBindings.Add("Checked", bindingSource, "", true, DataSourceUpdateMode.OnPropertyChanged);

            //day.Text = "hh";
            //day.Items.Add("hh");
        }
        #endregion

        #region Dapper SelectedListIndexChanged
        //private void SelectedListIndexChanged()
        //{
        //    fname.DataBindings.Clear();
        //    lname.DataBindings.Clear();
        //    day.DataBindings.Clear();
        //    month.DataBindings.Clear();
        //    year.DataBindings.Clear();
        //    phone_num.DataBindings.Clear();
        //    gender.DataBindings.Clear();
        //    email.DataBindings.Clear();
        //    address.DataBindings.Clear();
        //    apt_suite.DataBindings.Clear();
        //    city.DataBindings.Clear();
        //    state.DataBindings.Clear();
        //    zip_code.DataBindings.Clear();
        //    num_guest.DataBindings.Clear();
        //    room_type.DataBindings.Clear();
        //    room_floor.DataBindings.Clear();
        //    room_no.DataBindings.Clear();
        //    entry_date.DataBindings.Clear();
        //    departure_date.DataBindings.Clear();
        //    checkedin_chbox.DataBindings.Clear();
        //    supply_chbox.DataBindings.Clear();
        //    //send_sms_chbox.DataBindings.Clear();

        //    fname.DataBindings.Add("Text", bindingSource, "first_name");
        //    lname.DataBindings.Add("Text", bindingSource, "last_name");
        //    day.DataBindings.Add("Text", bindingSource, "day");
        //    month.DataBindings.Add("Text", bindingSource, "month");
        //    year.DataBindings.Add("Text", bindingSource, "year");
        //    phone_num.DataBindings.Add("Text", bindingSource, "phone_number");
        //    gender.DataBindings.Add("Text", bindingSource, "gender");
        //    email.DataBindings.Add("Text", bindingSource, "Email_Address");
        //    address.DataBindings.Add("Text", bindingSource, "Street_Address");
        //    apt_suite.DataBindings.Add("Text", bindingSource, "apt_suite");
        //    city.DataBindings.Add("Text", bindingSource, "city");
        //    state.DataBindings.Add("Text", bindingSource, "state");
        //    zip_code.DataBindings.Add("Text", bindingSource, "zip_code");
        //    num_guest.DataBindings.Add("Text", bindingSource, "Number_Guest");
        //    room_type.DataBindings.Add("Text", bindingSource, "Room_Type");
        //    room_floor.DataBindings.Add("Text", bindingSource, "Room_Floor");
        //    room_no.DataBindings.Add("Text", bindingSource, "Room_Number");

        //    //entry_date.DataBindings.Add("Value", bindingSource, "ArrivalTime");  // Use "Value" instead of "Text" for DateTimePicker
        //    //departure_date.DataBindings.Add("Value", bindingSource, "LeavingTime");
        //    entry_date.DataBindings.Add("Value", bindingSource, "Arrival_Time", true, DataSourceUpdateMode.OnValidation, DateTime.Today);
        //    departure_date.DataBindings.Add("Value", bindingSource, "Leaving_Time", true, DataSourceUpdateMode.OnValidation, DateTime.Today.AddDays(1));

        //    checkedin_chbox.DataBindings.Add("Checked", bindingSource, "check_in", true, DataSourceUpdateMode.OnPropertyChanged);
        //    supply_chbox.DataBindings.Add("Checked", bindingSource, "Supply_Status", true, DataSourceUpdateMode.OnPropertyChanged);
        //    //send_sms_chbox.DataBindings.Add("Checked", bindingSource, "", true, DataSourceUpdateMode.OnPropertyChanged);

        //    //day.Text = "hh";
        //    //day.Items.Add("hh");
        //}
        #endregion



        private void HideTableColumns()
        {
            reservation_table.Columns["fullname"].Visible = false;
            reservation_table.Columns["day"].Visible = false;
            reservation_table.Columns["month"].Visible = false;
            reservation_table.Columns["year"].Visible = false;

            reservation_table.Columns["CardExpMonth"].Visible = false;
            reservation_table.Columns["CardExpYear"].Visible = false;
        }


        private void logout_MouseEnter(object sender, EventArgs e)
        {
            new System.Windows.Forms.ToolTip().SetToolTip(logout, "Logout");
            logout.BackColor = Color.DarkGray;
        }


        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.BackColor = Color.Gainsboro;
        }


        private void refresh_MouseEnter(object sender, EventArgs e)
        {
            new System.Windows.Forms.ToolTip().SetToolTip(refresh, "Refresh");
            refresh.BackColor = Color.DarkGray;
        }


        private void refresh_MouseLeave(object sender, EventArgs e)
        {
            refresh.BackColor = Color.Gainsboro;
        }


        private void refresh_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Manager_Load(sender, e);

            HideBtns();
        }


        private void HideBtns()
        {
            reserv_list.Hide();
            updata_btn.Hide();
            delete_btn.Hide();
            search_list.Hide();
            pictureBox2.Hide();

            food_btn.Enabled = false;
            finalize_btn.Enabled = false;
        }


        private void ShowBtns()
        {
            reserv_list.Show();
            updata_btn.Show();
            delete_btn.Show();
            search_list.Show();
            pictureBox2.Show();

            food_btn.Enabled = true;
            finalize_btn.Enabled = true;
        }


        private bool isNavigatingBack = false;
        private void Frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isNavigatingBack)
                Application.Exit();
        }


        private void logout_Click(object sender, EventArgs e)
        {
            isNavigatingBack = true;

            this.Close();
            login.Show();

            login.ClearData();
        }


        private void clear_btn_Click(object sender, EventArgs e)
        {
            HideBtns();

            fname.Clear();
            lname.Clear();
            year.Clear();
            phone_num.Clear();
            gender.SelectedIndex = 0;
            email.Clear();
            address.Clear();
            apt_suite.Clear();
            city.Clear();
            zip_code.Clear();

            day.SelectedIndex = 0;
            month.SelectedIndex = 0;
            state.SelectedIndex = 0;
            num_guest.SelectedIndex = 0;
            room_type.SelectedIndex = 0;
            room_floor.SelectedIndex = 0;
            room_no.SelectedIndex = 0;

            checkedin_chbox.Checked = false;
            send_sms_chbox.Checked = false;
            supply_chbox.Checked = false;
        }


        private void generate_data_btn_Click(object sender, EventArgs e)
        {
            new Prompt2("Are you sure you want to generate fake data?", 1).ShowDialog();
            RefreshBindingSource();
        }


        private void benchmark_btn_Click(object sender, EventArgs e)
        {
            new Prompt2("Are you sure you want to benchmark between EF and Dapper?", 2).ShowDialog();
        }

    }
}
