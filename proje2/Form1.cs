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

        //Giriş panelinin kodlarını girdim
        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            //Eğer kullaıncı adı ve şifre doğru ise giriş yapılsın
            if (txt_kullaniciadi.Text == "administrator" && txt_sifre.Text == "1234")
            {
                DialogResult dialogResult = MessageBox.Show("Hoş Geldiniz", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 yeni1 = new Form2();
                yeni1.Show();
                this.Hide();
            }
            //Eğer kullanıcı adı veya şifre kısmı boş bırakılırsa giriş başarısız olsun ve kullanıcıya hata mesajı göndersin
            if (txt_kullaniciadi.Text == "" || txt_sifre.Text == "")
            {
                DialogResult dialogResult = MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre alanlarını boş bırakmayınız", "Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Eğer kullanıcı adı veya şifre hatalı girilirse giriş işlemi başarısız olsun ve kullanıcıya hata mesajı göndersin
            else if (txt_kullaniciadi.Text != "administrator" || txt_sifre.Text != "1234")
            {
                DialogResult dialogResult = MessageBox.Show("Kullanıcı Adı veya Şifre hatalı lütfen tekrar deneyin", "Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_kullaniciadi.Focus();
        }
    }
}
