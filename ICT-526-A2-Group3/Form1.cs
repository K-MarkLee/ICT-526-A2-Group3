﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT_526_A2_Group3
{
    public partial class FORMMAINMENU : Form
    {
        public FORMMAINMENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin  frm2 = new UserLogin();
            frm2.Show();
        }
    }
}
