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
    public partial class SemuaBarang : UserControl
    {
        public SemuaBarang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TV x = new TV();
            MainControlClass.show(x, Isi);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Laptop x = new Laptop();
            MainControlClass.show(x, Isi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pizza x = new Pizza();
            MainControlClass.show(x, Isi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kemeja x = new Kemeja();
            MainControlClass.show(x, Isi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kulkas x = new Kulkas();
            MainControlClass.show(x, Isi);
        }
    }
}
