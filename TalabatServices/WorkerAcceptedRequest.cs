﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalabatServices
{
    //FormNum8
    public partial class WorkerAcceptedRequest : Form
    {
        public WorkerAcceptedRequest(int Req_ID)
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
