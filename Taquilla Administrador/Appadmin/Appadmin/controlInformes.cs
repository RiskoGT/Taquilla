﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appadmin
{
    public partial class controlInformes : Form
    {
        public controlInformes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void controlInformes_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
             Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
