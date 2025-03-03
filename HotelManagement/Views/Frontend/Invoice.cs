using Lab15.Context;
using Lab15.Entities;
using Microsoft.VisualBasic;
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

namespace Lab15.Views.Kitchen
{
    public partial class Invoice : Form
    {
        ReservationContext context;
        BindingSource bindingSource;
        Reservation selectedReservation;


        private const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        public Invoice(Reservation _selectedReservation)
        {
            InitializeComponent();

            selectedReservation = _selectedReservation;

            this.Load += (s, e) =>
            {
                int darkColor = ColorTranslator.ToWin32(Color.Black);
                DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref darkColor, sizeof(int));
            };
        }


        private void Invoice_Load(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    bindingSource = new BindingSource { DataSource = selectedReservation };
                    BindData();

                    if (selectedReservation.RoomType.Trim() == "Single")
                    {
                        current_bill.Text = "150";
                        tax.Text = "10";
                    }
                    else if (selectedReservation.RoomType.Trim() == "Double")
                    {
                        current_bill.Text = "300";
                        tax.Text = "20";
                    }

                    food_bill.Text = ((selectedReservation.BreakFast * 7) + (selectedReservation.Lunch * 15) + (selectedReservation.Dinner * 25)).ToString();
                    total.Text = (int.Parse(current_bill.Text) + int.Parse(food_bill.Text) + int.Parse(tax.Text)).ToString();

                    SaveData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void pay_btn_Click(object sender, EventArgs e)
        {
            using (context = new())
            {
                try
                {
                    if (payment.Text != string.Empty)
                    {
                        if (MessageBox.Show("Are you sure you want to pay this reservation?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bindingSource.EndEdit();
                            context.Reservations.Update(selectedReservation);

                            context.SaveChanges();
                            new Prompt1("Payment has been made successfully!", null).ShowDialog();
                        }
                    }
                    else
                        MessageBox.Show($"Please Check Data!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BindData()
        {
            food_bill.DataBindings.Add("text", bindingSource, "FoodBill");
            total.DataBindings.Add("text", bindingSource, "TotalBill");

            card.DataBindings.Add("text", bindingSource, "CardNumber");
            payment.DataBindings.Add("text", bindingSource, "PaymentType");
            month.DataBindings.Add("text", bindingSource, "CardExpMonth");
            year.DataBindings.Add("text", bindingSource, "CardExpYear");
            cvc.DataBindings.Add("text", bindingSource, "CardCvc");
            card_type.DataBindings.Add("text", bindingSource, "CardType");
        }


        private void SaveData()
        {
            try
            {
                selectedReservation.PaymentType = payment.Text;
                selectedReservation.CardType = card_type.Text;
                selectedReservation.CardNumber = card.Text;
                selectedReservation.CardExp = month.Text + "/" + year.Text;
                selectedReservation.CardCvc = cvc.Text;

                selectedReservation.FoodBill = int.Parse(food_bill.Text);
                selectedReservation.TotalBill = int.Parse(total.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payment.Text.Trim() == "Credit")
                card_type.Text = "MasterCard";

            else if (payment.Text.Trim() == "Debit")
                card_type.Text = "Visa";

            else if (payment.Text.Trim() == "Cash")
                card_type.Text = "N/A";

            bindingSource.EndEdit();
        }

    }
}
