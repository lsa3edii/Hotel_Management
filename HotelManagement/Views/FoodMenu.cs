using Lab15.Context;
using Lab15.Entities;
using Lab15.Views.Frontend;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab15.Views.Kitchen
{
    public partial class FoodMenu : Form
    {
        ReservationContext context;
        BindingSource bindingSource;
        Reservation selectedReservation;

        private const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        public FoodMenu(Reservation _selectedReservation)
        {
            InitializeComponent();
            selectedReservation = _selectedReservation;

            breakfast_qty.Enabled = false;
            lunch_qty.Enabled = false;
            dinner_qty.Enabled = false;

            this.Load += (s, e) =>
            {
                int darkColor = ColorTranslator.ToWin32(Color.Black);
                DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref darkColor, sizeof(int));
            };
        }


        private void FoodMenu_Load(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    bindingSource = new BindingSource { DataSource = selectedReservation };

                    breakfast_qty.DataBindings.Add("text", bindingSource, "BreakFast");
                    lunch_qty.DataBindings.Add("text", bindingSource, "lunch");
                    dinner_qty.DataBindings.Add("text", bindingSource, "dinner");

                    cleaning_chbox.DataBindings.Add("Checked", bindingSource, "cleaning", true, DataSourceUpdateMode.OnPropertyChanged);
                    towels_chbox.DataBindings.Add("Checked", bindingSource, "towel", true, DataSourceUpdateMode.OnPropertyChanged);
                    surprise_chbox.DataBindings.Add("Checked", bindingSource, "ssurprise", true, DataSourceUpdateMode.OnPropertyChanged);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    bindingSource.EndEdit();
                    context.Reservations.Update(selectedReservation);
                    context.SaveChanges();
                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void pictureBox0_Click(object sender, EventArgs e)
        {
            breakfast_chbox.Checked = !breakfast_chbox.Checked;

            if (breakfast_chbox.Checked)
                breakfast_qty.Enabled = true;
            else
                breakfast_qty.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lunch_chbox.Checked = !lunch_chbox.Checked;

            if (lunch_chbox.Checked)
                lunch_qty.Enabled = true;
            else
                lunch_qty.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dinner_chbox.Checked = !dinner_chbox.Checked;

            if (dinner_chbox.Checked)
                dinner_qty.Enabled = true;
            else
                dinner_qty.Enabled = false;
        }


        private void breakfast_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (breakfast_chbox.Checked)
                breakfast_qty.Enabled = true;
            else
                breakfast_qty.Enabled = false;
        }

        private void lunch_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (lunch_chbox.Checked)
                lunch_qty.Enabled = true;
            else
                lunch_qty.Enabled = false;
        }

        private void dinner_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (dinner_chbox.Checked)
                dinner_qty.Enabled = true;
            else
                dinner_qty.Enabled = false;
        }
    
    }
}
