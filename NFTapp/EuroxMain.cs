﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NFTapp.ConsoleComponents;

namespace NFTapp
{
    public partial class EuroxMain : Form
    {
        public EuroxMain()
        {
            InitializeComponent();
        }

        private void EuroxMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Aqua;
        }
    }
}
