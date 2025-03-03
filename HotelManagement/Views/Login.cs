using Lab15.Context;
using Lab15.Entities;
using Lab15.Views;
using Lab15.Views.Frontend;
using Lab15.Views.Kitchen;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
//using HotelContext Context = new();

namespace Lab15
{
    public partial class Login : Form
    {
        UsersContext context;

        private const int DWMWA_CAPTION_COLOR = 35;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        public Login()
        {
            InitializeComponent();

            this.MaximizeBox = false;

            this.Load += (s, e) =>
            {
                int darkColor = ColorTranslator.ToWin32(Color.Black);
                DwmSetWindowAttribute(this.Handle, DWMWA_CAPTION_COLOR, ref darkColor, sizeof(int));
            };
        }


        public TextBox Username { get => username; }


        private bool CheckData()
        {
            if (username.Text != "" && password.Text != "")
                return true;

            return false;
        }


        public void ClearData()
        {
            username.Clear();
            password.Clear();

            //username.Focus();
        }


        private void sign_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Signup(this).Show();
        }


        private async void login_btn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                using (context = new())
                {
                    try
                    {
                        string uname = username.Text.Trim();
                        string pass = password.Text.Trim();

                        var user = context.Set<User>()
                                          .FirstOrDefault(u => u.Username == uname && u.Password == pass);

                        if (user != null)
                        {
                            if (user is FrontendUser)
                            {
                                MessageBox.Show("Successfully Login!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                new Manager(this).Show();
                                this.Hide();
                            }
                            else if (user is KitchenUser)
                            {
                                MessageBox.Show("Successfully Login!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                new RoomService(this).Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Invalid user role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please check your data!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        //private async void login_btn_Click(object sender, EventArgs e)
        //{
        //    if (!CheckData())
        //    {
        //        MessageBox.Show("Please check your data!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    using (context = new())
        //    {
        //        try
        //        {
        //            string uname = username.Text.Trim();
        //            string pass = password.Text.Trim();

        //            var user = await context.AuthenticateUser(uname, pass);

        //            if (user == null)
        //            {
        //                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            this.Hide();

        //            switch (user)
        //            {
        //                case FrontendUser:
        //                    new Manager(this).Show();
        //                    break;
        //                case KitchenUser:
        //                    new RoomService(this).Show();
        //                    break;
        //                default:
        //                    MessageBox.Show("Invalid user role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    this.Show();
        //                    break;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}


        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearData();
            //username.Focus();
        }
    }

}
