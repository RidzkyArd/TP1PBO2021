﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Pizza : UserControl
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Terima kasih telah membeli Pizza :D";
            string title = "";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SemuaBarang sb = new SemuaBarang();
            MainControlClass.show(sb, Isi);
        }
    }
}
