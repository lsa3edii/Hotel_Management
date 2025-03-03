using Lab15.Context;
using Lab15.Entities;
using Microsoft.EntityFrameworkCore;
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

namespace Lab15.Views.Kitchen
{
    public partial class RoomService : Form
    {
        Login login;
        ReservationContext context;
        BindingSource bindingSource;


        private const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        public RoomService(Login _login)
        {
            InitializeComponent();

            login = _login;
            //tabs_btn.SelectedIndex = 1;

            this.Load += (s, e) =>
            {
                int darkColor = ColorTranslator.ToWin32(Color.Black);
                DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref darkColor, sizeof(int));
            };
        }


        private void RoomService_Load(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    var reservation = context.Reservations.ToList();
                    bindingSource = new BindingSource { DataSource = reservation };

                    listBox.DataSource = bindingSource;
                    table.DataSource = bindingSource;

                    SelectedListIndexChanged();
                    HideTableColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            if (supplyStatus_chbox.Checked)
            {
                int.TryParse((listBox.SelectedItem.ToString().Split("|")[0]), out int id);

                try
                {
                    using (context = new())
                    {
                        var reservations = context.Reservations.Find(id);

                        if (reservations != null && MessageBox.Show("Are you sure you want to update the supply status?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            reservations.SupplyStatus = true;
                            context.SaveChanges();
                            RefreshListBox();

                            supplyStatus_chbox.Checked = false;
                            new Prompt1("Report..!\nEntry successfully updated into database. For USER ID:\r\n", id).ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please check supply status!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void RefreshListBox()
        {
            using (context = new())
            {
                var reservations = context.Reservations.ToList();

                bindingSource.DataSource = reservations;
                //bindingSource.ResetBindings(false); // Refresh UI
            }
        }


        private void HideTableColumns()
        {
            table.Columns["fullname"].Visible = false;
            table.Columns["birthday"].Visible = false;
            table.Columns["day"].Visible = false;
            table.Columns["month"].Visible = false;
            table.Columns["year"].Visible = false;
            table.Columns["gender"].Visible = false;
            table.Columns["emailaddress"].Visible = false;
            table.Columns["numberguest"].Visible = false;
            table.Columns["streetaddress"].Visible = false;
            table.Columns["aptsuite"].Visible = false;
            table.Columns["city"].Visible = false;
            table.Columns["state"].Visible = false;
            table.Columns["zipcode"].Visible = false;
            table.Columns["totalbill"].Visible = false;
            table.Columns["paymenttype"].Visible = false;
            table.Columns["cardtype"].Visible = false;
            table.Columns["cardnumber"].Visible = false;
            table.Columns["cardexp"].Visible = false;
            table.Columns["gender"].Visible = false;
            table.Columns["cardcvc"].Visible = false;
            table.Columns["arrivaltime"].Visible = false;
            table.Columns["leavingtime"].Visible = false;
            table.Columns["checkin"].Visible = false;
            table.Columns["CardExpMonth"].Visible = false;
            table.Columns["CardExpYear"].Visible = false;
        }


        private void SelectedListIndexChanged()
        {
            name.DataBindings.Add("text", bindingSource, "fullname");
            phone.DataBindings.Add("text", bindingSource, "phonenumber");
            roomType.DataBindings.Add("text", bindingSource, "roomtype");
            roomNo.DataBindings.Add("text", bindingSource, "roomnumber");
            floorno.DataBindings.Add("text", bindingSource, "roomfloor");
            breakfast_qty.DataBindings.Add("text", bindingSource, "breakfast");
            lunch_qty.DataBindings.Add("text", bindingSource, "lunch");
            dinner_qty.DataBindings.Add("text", bindingSource, "dinner");

            cleaning_chbox.DataBindings.Add("Checked", bindingSource, "cleaning", true, DataSourceUpdateMode.OnPropertyChanged);
            towels_chbox.DataBindings.Add("Checked", bindingSource, "towel", true, DataSourceUpdateMode.OnPropertyChanged);
            surprise_chbox.DataBindings.Add("Checked", bindingSource, "ssurprise", true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplyStatus_chbox.Checked = false;
        }



        private bool isNavigatingBack = false;
        private void RoomService_FormClosing(object sender, FormClosingEventArgs e)
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

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            new System.Windows.Forms.ToolTip().SetToolTip(logout, "Logout");
            logout.BackColor = Color.DarkGray;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
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
            RoomService_Load(sender, e);
        }


        private void changeFood_btn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Reservation selectedReservation)
                new FoodMenu(selectedReservation).ShowDialog(); // Open as a modal dialog
            else
                MessageBox.Show("Please select a reservation first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
