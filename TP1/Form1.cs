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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = Convert.ToString(tb_user.Text);
            user.password = Convert.ToString(tb_pass.Text);

            if (tb_pass.Text == "pbo123")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                string message = "Password yang anda masukan salah!!! ";
                string title = "";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_pass.Clear();
            }
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = '*';
        }
    }
}
