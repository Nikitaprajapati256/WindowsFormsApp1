﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtpassword.Text=="admin")
            {
                //mbox -> for messageBox 
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
        }
    }
}
