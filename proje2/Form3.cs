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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_klvz1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci ekleme işlemi için Öğrenci groupBox'ında bulunan AD, SOYAD ve YAŞ kısımlarını doldurunuz ve Öğrenci Ekle butonuna tıklayınız " +
                "ID otomatik artan olduğundan ID kısmı boş bırakılacaktır" );
        }

        private void btn_klvz3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrenci silme işlemi önce Öğrencileri Listele butonuna basarak silmek istediğiniz öğrencinin ID sini öğreniniz " +
                "Öğrendikten sonra Öğrenci groupBox'ında ID kısmına seçtiğiniz ID yı yazınız ve Öğrenci Sil butonuna tıklayınız");
        }

        private void btn_klvz2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ders ekleme işlemi için Ders groupBox'ında bulunan AD kısmını doldurunuz ve Ders Ekle butonuna basınız " +
                "ID otomatik artan olduğundan ID kısmı boş bırakılacaktır");
        }

        private void btn_klvz4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ders silme işlemi önce Dersleri Listele butonuna basarak silmek istediğiniz dersin ID sini öğreniniz " +
                "Öğrendikten sonra Ders groupBox'ında ID kısmına seçtiğiniz ID yı yazınız ve Dersi Sil butonuna tıklayınız");
        }
    }
}
