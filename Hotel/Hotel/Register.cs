using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Register : Form
    {
        Form fflogin;
        public Register(Form formfromlogin)
        {
            InitializeComponent();
            fflogin = formfromlogin;
        }

        private void bt_backlogin_Click(object sender, EventArgs e)
        {
            fflogin.Show();
            this.Close();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            fflogin.Show();
        }
    }
}
