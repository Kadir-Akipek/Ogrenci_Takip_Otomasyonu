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
            //DialogResult bize herhangi bir durumda programın önüne (ShowDialog açar gibi) bir uyarı mesajından sonucu verir.
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    //Uygulamadan çıkış yap.
                    Application.Exit();
                }
            }
        }
    }
}
