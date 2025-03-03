using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15.Views
{
    public partial class Prompt1 : Form
    {
        public Prompt1(string text, int? user_id)
        {
            InitializeComponent();

            prompt_text.Text = text;

            if (user_id == null)
                id.Hide();
            else
                id.Text = user_id.ToString();
        }

    }
}
