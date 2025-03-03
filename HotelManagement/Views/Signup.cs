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
//using HotelContext Context = new();


namespace Lab15.Views
{
    public partial class Signup : Form
    {
        UsersContext Context;
        Login login;


        private const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        public Signup(Login _login)
        {
            InitializeComponent();

            //using UsersContext _Context = new(); // using automatically disposes it when it goes out of scope.

            login = _login;

            this.Load += (s, e) =>
            {
                int darkColor = ColorTranslator.ToWin32(Color.Black);
                DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref darkColor, sizeof(int));
            };

            //Context.Database.Migrate();  // -> PMC: updata-database
        }


        private bool CheckData()
        {
            if (username.Text != "" && password.Text != "" && password.Text == confirm_pass.Text)
                return true;

            return false;
        }


        private void ClearData()
        {
            username.Clear();
            password.Clear();
            confirm_pass.Clear();

            //username.Focus();
        }


        private void sign_btn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                using (Context = new())
                {
                    try
                    {
                        Context.KitchenUsers.Add(
                            new KitchenUser()
                            {
                                Username = username.Text,
                                Password = password.Text
                            }
                        );


                        Trace.WriteLine($"Count: {Context.KitchenUsers.Count()}");

                        int result = Context.SaveChanges();
                        Trace.WriteLine($"{result} Rows Affected");


                        MessageBox.Show("Successfully Created.\nGo to Login!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        isNavigatingBack = true;
                        this.Close();
                        login.Show();


                        //var r = Context.KitchenUsers;
                        //foreach (var item in r)
                        //{
                        //    item.Username += "22"; // Tracked
                        //    //Context.Entry(item).State = EntityState.Modified; // Manually
                        //}
                        //Trace.WriteLine($".. {Context.SaveChanges()} Rows Affected");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please check your data!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
   

        private void back_btn_Click(object sender, EventArgs e)
        {
            isNavigatingBack = true;

            this.Close();
            login.Visible = true;

            login.ClearData();
        }


        private bool isNavigatingBack = false;
        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isNavigatingBack)
                Application.Exit();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearData();
            //username.Focus();
        }
    }

}
