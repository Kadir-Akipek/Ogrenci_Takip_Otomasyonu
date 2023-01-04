using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        finalEntities db = new finalEntities();


        //Öğrenci ekleme işlemi yapacağız
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            TBL_OGR t = new TBL_OGR();
            t.AD = txt_ogrenciAD.Text;
            t.SOYAD = txt_ogrenciSOYAD.Text;
            t.YAŞ = Convert.ToInt16(txt_ogrYAS.Text);
            db.TBL_OGR.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci listeye başarıyla eklenmiştir");
        }

        private void btn_ogrlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_OGR.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }


        //Öğrenci silme işlemi yapacağız
        private void btn_ogrenciSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ogrID.Text);
            var x = db.TBL_OGR.Find(id);
            db.TBL_OGR.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla silinişmtir");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_linqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //OrderBy metodu ile isimleri alfabetik sıraya göre yazdırdım
                dataGridView1.DataSource = db.TBL_OGR.OrderBy(p => p.AD).ToList();
                //4. ve 5. kolonları kullanıcıya görünmez hale getirdim
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }

            if (radioButton2.Checked == true)
            {
                //OrderByDescending metodu ile isimleri alfabetik sıranın tersine göre yazdırdım
                dataGridView1.DataSource = db.TBL_OGR.OrderByDescending(p => p.AD).ToList();
                //4. ve 5. kolonları kullanıcıya görünmez hale getirdim
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }

            if (radioButton3.Checked == true)
            {
                //liste3 e Take metoduyla sıralamak istediğim öğrenci sayısını girdim
                List<TBL_OGR> liste3 = db.TBL_OGR.OrderBy(p => p.AD).Take(5).ToList();
                dataGridView1.DataSource = liste3;
            }

            if (radioButton4.Checked == true)
            {
                //Count metoduyla OGR tablosundaki kişi sayısını saydırttım ve bu değeri toplam_ogrsayısı adlı değişkene atadım
                int toplam_ogrsayısı = db.TBL_OGR.Count();
                //MessageBox ile kullanıcıya mesaj olarak Toplam Öğrenci Sayısını gösterdim
                MessageBox.Show(toplam_ogrsayısı.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton5.Checked == true)
            {
                //Where ile şart koydum,şartın içine StartsWith metoduyla istediğim harfle başlayan verileri yazdırdım
                List<TBL_OGR> liste4 = db.TBL_OGR.Where(p => p.AD.StartsWith("E")).ToList();
                dataGridView1.DataSource = liste4;
            }

            if (radioButton6.Checked == true)
            {
                //Where ile şart koydum,şartın içine EndsWith metoduyla soyadları istediğim harf ile biten verileri yazdırdım
                List<TBL_OGR> liste5 = db.TBL_OGR.Where(p => p.SOYAD.EndsWith("K")).ToList();
                dataGridView1.DataSource = liste5;
            }

            if (radioButton7.Checked == true)
            {
                //Max metoduyla 2.sınavları büyükten küçüğe sıraladım
                var enyuksek = db.TBL_NOTLAR.Max(p => p.SINAV2);
                MessageBox.Show("2.sınavın en yüksek notu: " + enyuksek.ToString());
            }

            if (radioButton9.Checked == true)
            {
                //dataGridView1.DataSource = db.TBL_NOTLAR.OrderByDescending(p => p.SINAV1).ToList();
                //Notları listeledim
                dataGridView1.DataSource = db.TBL_NOTLAR.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                //Join ile Öğrenci Adını, Soyadını ve 1.sınavları birleştirip kullanıcıya gösterdim
                var sorgu = from d1 in db.TBL_NOTLAR
                            join d2 in db.TBL_OGR
                            on d1.OGR equals d2.ID 
                            select new
                            {
                                Öğrencinin_Adı = d2.AD,
                                Öğrencinin_Soyadı= d2.SOYAD,
                                Sınav_1 = d1.SINAV1
                            };
                dataGridView1.DataSource = sorgu.ToList();
            }

            if (radioButton10.Checked == true)
            {
                //dataGridView1.DataSource = db.TBL_NOTLAR.OrderBy(p => p.SINAV2).ToList();
                //Notlar tablosunu listeledim
                dataGridView1.DataSource = db.TBL_NOTLAR.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                //Join ile Öğrenci Adını, Soyadını ve 2.sınavları birleştirip kullanıcıya gösterdim
                //OrderBy ile 2.sınavları sıraladım
                var sorgu = from d1 in db.TBL_NOTLAR
                            join d2 in db.TBL_OGR
                            on d1.OGR equals d2.ID orderby d1.SINAV2
                            select new
                            {
                                Öğrencinin_Adı = d2.AD,
                                Öğrencinin_Soyadı = d2.SOYAD,
                                Sınav_2 = d1.SINAV2,
                            };
                dataGridView1.DataSource = sorgu.ToList();
            }
        }

        private void btn_derslistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_DERS.ToList();
        }

        private void btn_dersekle_Click(object sender, EventArgs e)
        {
            //Ders ekleme işlemi yaptım
            TBL_DERS t = new TBL_DERS();
            t.DERS_AD = Convert.ToString(txt_dersAD.Text);
            db.TBL_DERS.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ders başarıyla eklenmiştir");
        }

        private void btn_derssil_Click(object sender, EventArgs e)
        {
            //Ders silme işlemi yaptım
            int id = Convert.ToInt32(txt_dersID.Text);
            var x = db.TBL_DERS.Find(id);
            db.TBL_DERS .Remove(x);
            db.SaveChanges();
            MessageBox.Show("Ders başarıyla silinişmtir");
        }
        private void btn_kullanimkilavuzu_Click(object sender, EventArgs e)
        {
            Form3 yeni2 = new Form3();
            yeni2.Show();
        }

        private void txt_devamsizlik_TextChanged(object sender, EventArgs e)
        {
            devamsizlik(Convert.ToString(txt_devamsizlik.Text));
        }
        private void devamsizlik(string id)
        {
            var result = db.TBL_DEVAMSİZLİK.Where(x => x.OgrID.ToString().Equals(id)).ToList();
            dataGridView1.DataSource = result;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        //Bu kısımları yanlışlıkla çift tıklayıp açtım
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
