
namespace TP1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pinggir = new System.Windows.Forms.Panel();
            this.Atas = new System.Windows.Forms.Panel();
            this.Isi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profil = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cari = new System.Windows.Forms.Button();
            this.cb_harga = new System.Windows.Forms.ComboBox();
            this.cb_jenis = new System.Windows.Forms.ComboBox();
            this.btn_web = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.Pinggir.SuspendLayout();
            this.Atas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pinggir
            // 
            this.Pinggir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Pinggir.Controls.Add(this.cb_harga);
            this.Pinggir.Controls.Add(this.cb_jenis);
            this.Pinggir.Controls.Add(this.btn_cari);
            this.Pinggir.Location = new System.Drawing.Point(22, 104);
            this.Pinggir.Name = "Pinggir";
            this.Pinggir.Size = new System.Drawing.Size(120, 282);
            this.Pinggir.TabIndex = 0;
            // 
            // Atas
            // 
            this.Atas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Atas.Controls.Add(this.btn_logout);
            this.Atas.Controls.Add(this.btn_web);
            this.Atas.Controls.Add(this.btn_home);
            this.Atas.Location = new System.Drawing.Point(140, 26);
            this.Atas.Name = "Atas";
            this.Atas.Size = new System.Drawing.Size(394, 80);
            this.Atas.TabIndex = 1;
            // 
            // Isi
            // 
            this.Isi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Isi.Location = new System.Drawing.Point(140, 104);
            this.Isi.Name = "Isi";
            this.Isi.Size = new System.Drawing.Size(512, 282);
            this.Isi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "1901365";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ridzky Ardiansyah";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(534, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 80);
            this.panel1.TabIndex = 4;
            // 
            // profil
            // 
            this.profil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profil.Controls.Add(this.pictureBox1);
            this.profil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.profil.Location = new System.Drawing.Point(22, 26);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(120, 80);
            this.profil.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 389);
            this.panel2.TabIndex = 5;
            // 
            // btn_cari
            // 
            this.btn_cari.Location = new System.Drawing.Point(12, 104);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(88, 23);
            this.btn_cari.TabIndex = 0;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // cb_harga
            // 
            this.cb_harga.FormattingEnabled = true;
            this.cb_harga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.cb_harga.Location = new System.Drawing.Point(12, 61);
            this.cb_harga.Name = "cb_harga";
            this.cb_harga.Size = new System.Drawing.Size(88, 21);
            this.cb_harga.TabIndex = 2;
            this.cb_harga.Text = "Harga";
            // 
            // cb_jenis
            // 
            this.cb_jenis.FormattingEnabled = true;
            this.cb_jenis.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.cb_jenis.Location = new System.Drawing.Point(12, 34);
            this.cb_jenis.Name = "cb_jenis";
            this.cb_jenis.Size = new System.Drawing.Size(88, 21);
            this.cb_jenis.TabIndex = 1;
            this.cb_jenis.Text = "Jenis Barang";
            // 
            // btn_web
            // 
            this.btn_web.BackgroundImage = global::TP1.Properties.Resources.web;
            this.btn_web.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_web.Location = new System.Drawing.Point(163, 24);
            this.btn_web.Name = "btn_web";
            this.btn_web.Size = new System.Drawing.Size(75, 33);
            this.btn_web.TabIndex = 1;
            this.btn_web.Text = "WEB";
            this.btn_web.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_web.UseVisualStyleBackColor = true;
            this.btn_web.Click += new System.EventHandler(this.btn_web_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackgroundImage = global::TP1.Properties.Resources.logout;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_logout.Location = new System.Drawing.Point(275, 24);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 33);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP1.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(38, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = global::TP1.Properties.Resources.home;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.Location = new System.Drawing.Point(45, 24);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 33);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 413);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.Isi);
            this.Controls.Add(this.Atas);
            this.Controls.Add(this.Pinggir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Pinggir.ResumeLayout(false);
            this.Atas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.profil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pinggir;
        private System.Windows.Forms.Panel Atas;
        private System.Windows.Forms.Panel Isi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel profil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.ComboBox cb_harga;
        private System.Windows.Forms.ComboBox cb_jenis;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Button btn_web;
        private System.Windows.Forms.Button btn_logout;
    }
}