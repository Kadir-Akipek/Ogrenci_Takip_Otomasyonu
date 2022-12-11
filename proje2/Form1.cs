using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            if (txt_kullaniciadi.Text == "administrator" && txt_sifre.Text == "1234")
            {
                MessageBox.Show("Hoş Geldiniz");
                Form2 yeni1 = new Form2();
                yeni1.Show();
                this.Hide();
            }
            if (txt_kullaniciadi.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre alanlarını boş bırakmayınız");
            }
            else if (txt_kullaniciadi.Text != "administrator" || txt_sifre.Text != "1234")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı lütfen tekrar deneyin");
            }
        }
    }
}
