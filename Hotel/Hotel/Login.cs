﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            Register rgt = new Register(this);
            rgt.Show();
            this.Hide();
        }
    }
}
