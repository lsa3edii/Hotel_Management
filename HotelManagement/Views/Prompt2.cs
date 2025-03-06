using HotelManagement.Bogus;
using Lab15.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Views
{
    public partial class Prompt2 : Form
    {
        ReservationContext context;
        int flag;

        public Prompt2(string text, int flag)
        {
            InitializeComponent();

            prompt_text.Text = text;
            this.flag = flag;
        }


        private void yes_btn_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                var fakeData = ReservationFaker.GenerateData(10000);

                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    using (context = new())
                    {
                        context.Reservations.AddRange(fakeData);
                        context.SaveChanges();
                        MessageBox.Show("Fake data generated successfully!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }

            else if (flag == 2)
            {
                try
                {
                    string exePath = @"D:\\Hotel Management\\Benchmark\\bin\\Release\\net9.0\\Benchmark.exe";

                    var process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = exePath,
                            UseShellExecute = true,  // Allows opening a new window
                            CreateNoWindow = false
                        }
                    };

                    process.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Benchmark Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
