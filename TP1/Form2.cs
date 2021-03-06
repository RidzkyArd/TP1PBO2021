using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SemuaBarang sb = new SemuaBarang();
            MainControlClass.show(sb,Isi);

        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            barang.jenis = Convert.ToString(cb_jenis.Text);
            barang.harga = Convert.ToString(cb_harga.Text);

            if (cb_jenis.Text == "Elektronik")
            {
                if (cb_harga.Text == "500rb - 1jt")
                {
                    Elektronik ele = new Elektronik();
                    MainControlClass.show(ele, Isi);
                }else if ((cb_harga.Text == "") || (cb_harga.Text == "Harga"))
                {
                    string message = "Pilih Harga Barang yang Dicari.";
                    string title = "";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Kosong kosong = new Kosong();
                    MainControlClass.show(kosong, Isi);
                }
            }
            else if (cb_jenis.Text == "Makanan")
            {
                if (cb_harga.Text == "100rb - 200rb")
                {
                    Makanan mkn = new Makanan();
                    MainControlClass.show(mkn, Isi);
                }
                else if ((cb_harga.Text == "") || (cb_harga.Text == "Harga"))
                {
                    string message = "Pilih Harga Barang yang Dicari.";
                    string title = "";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Kosong kosong = new Kosong();
                    MainControlClass.show(kosong, Isi);
                }
            }
            else if (cb_jenis.Text == "Baju")
            {
                if (cb_harga.Text == "200rb - 500rb")
                {
                    Baju bj = new Baju();
                    MainControlClass.show(bj, Isi);
                }
                else if ((cb_harga.Text == "") || (cb_harga.Text == "Harga"))
                {
                    string message = "Pilih Harga Barang yang Dicari.";
                    string title = "";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Kosong kosong = new Kosong();
                    MainControlClass.show(kosong, Isi);
                }
            }
            else
            {
                string message = "Pilih Jenis Barang yang Dicari.";
                string title = "";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cb_jenis.Text = "Jenis Barang";
            cb_harga.Text = "Harga";
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            SemuaBarang sb = new SemuaBarang();
            MainControlClass.show(sb, Isi);
            cb_jenis.Text = "Jenis Barang";
            cb_harga.Text = "Harga";
        }

        private void btn_web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bukalapak.com/");
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
