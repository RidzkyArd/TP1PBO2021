using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Barang
    {
        public string jenis { get; set; }
        public string harga { get; set; }
        public Barang(string jenis, string harga)
        {
            this.jenis = jenis;
            this.harga = harga;
        }
        public Barang()
        {
        }
    }
}
