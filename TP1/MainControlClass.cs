using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    class MainControlClass
    {
        public static void show(System.Windows.Forms.Control control, System.Windows.Forms.Control Isi)
        {
            Isi.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Isi.Controls.Add(control);
        }

        public static void showSide(System.Windows.Forms.Control control, System.Windows.Forms.Control Pinggir)
        {
            Pinggir.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Pinggir.Controls.Add(control);
        }

    }
}
