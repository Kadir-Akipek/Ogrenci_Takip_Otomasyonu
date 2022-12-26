﻿using System;
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
            //Öğrencileri A dan Z ye sırala
            if (radioButton1.Checked == true)
            {
                dataGridView1.DataSource = db.TBL_OGR.OrderBy(p => p.AD).ToList();
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            //Öğrencileri Z den A ya sırala
            if (radioButton2.Checked == true)
            {
                dataGridView1.DataSource = db.TBL_OGR.OrderByDescending(p => p.AD).ToList();
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            //İlk 5 kaydı listele
            if (radioButton3.Checked == true)
            {
                List<TBL_OGR> liste3 = db.TBL_OGR.OrderBy(p => p.AD).Take(5).ToList();
                dataGridView1.DataSource = liste3;
            }
            //Toplam öğrenci sayısını yazdır
            if (radioButton4.Checked == true)
            {
                int toplam_ogrsayısı = db.TBL_OGR.Count();
                MessageBox.Show(toplam_ogrsayısı.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Adı E harfi ile başlayanları yazdır
            if (radioButton5.Checked == true)
            {
                List<TBL_OGR> liste4 = db.TBL_OGR.Where(p => p.AD.StartsWith("E")).ToList();
                dataGridView1.DataSource = liste4;
            }
            //Soyadı K harfi ile bitenleri yazdır
            if (radioButton6.Checked == true)
            {
                List<TBL_OGR> liste5 = db.TBL_OGR.Where(p => p.SOYAD.EndsWith("K")).ToList();
                dataGridView1.DataSource = liste5;
            }
            //En yüksek 2.Sınav notunu listele
            if (radioButton7.Checked == true)
            {
                var enyuksek = db.TBL_NOTLAR.Max(p => p.SINAV2);
                MessageBox.Show("2.sınavın en yüksek notu: " + enyuksek.ToString());
            }
            /*
            if (radioButton8.Checked == true)
            {
                List<TBL_NOTLAR> liste6 = db.TBL_NOTLAR.ToList();
                dataGridView1.DataSource = liste6;
            }
            */
            if (radioButton9.Checked == true)
            {
                //dataGridView1.DataSource = db.TBL_NOTLAR.OrderByDescending(p => p.SINAV1).ToList();
                dataGridView1.DataSource = db.TBL_NOTLAR.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
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
                dataGridView1.DataSource = db.TBL_NOTLAR.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
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

        private void btn_devamsizlik_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_DEVAMSİZLİK.ToList();

        }

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
    }
}
