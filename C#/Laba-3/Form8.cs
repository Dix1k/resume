﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Activated(object sender, EventArgs e)
        {
            this.label1.Text = "Приложение написано студентом потока ПИНб-21 \nВласовым Дмитрием Алексеевичем, 2005";
        }
    }
}
