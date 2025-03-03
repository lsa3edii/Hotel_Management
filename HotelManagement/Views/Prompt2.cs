using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Views
{
    public partial class Prompt2 : Form
    {
        public Prompt2(string text)
        {
            InitializeComponent();
            prompt_text.Text = text;
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
