namespace proje2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ogrID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ogrYAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ogrenciSOYAD = new System.Windows.Forms.TextBox();
            this.txt_ogrenciAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_dersAD = new System.Windows.Forms.TextBox();
            this.txt_dersID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ogrekle = new System.Windows.Forms.Button();
            this.btn_ogrlistele = new System.Windows.Forms.Button();
            this.btn_ogrenciSil = new System.Windows.Forms.Button();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btn_linqEntity = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.btn_derslistele = new System.Windows.Forms.Button();
            this.btn_dersekle = new System.Windows.Forms.Button();
            this.btn_derssil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_devamsizlik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kullanimkilavuzu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txt_ogrID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_ogrYAS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ogrenciSOYAD);
            this.groupBox1.Controls.Add(this.txt_ogrenciAD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(13, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_ogrID
            // 
            this.txt_ogrID.Location = new System.Drawing.Point(78, 31);
            this.txt_ogrID.Name = "txt_ogrID";
            this.txt_ogrID.Size = new System.Drawing.Size(100, 22);
            this.txt_ogrID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(9, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "ID:";
            // 
            // txt_ogrYAS
            // 
            this.txt_ogrYAS.Location = new System.Drawing.Point(78, 124);
            this.txt_ogrYAS.Name = "txt_ogrYAS";
            this.txt_ogrYAS.Size = new System.Drawing.Size(100, 22);
            this.txt_ogrYAS.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yaş:";
            // 
            // txt_ogrenciSOYAD
            // 
            this.txt_ogrenciSOYAD.Location = new System.Drawing.Point(78, 92);
            this.txt_ogrenciSOYAD.Name = "txt_ogrenciSOYAD";
            this.txt_ogrenciSOYAD.Size = new System.Drawing.Size(100, 22);
            this.txt_ogrenciSOYAD.TabIndex = 8;
            // 
            // txt_ogrenciAD
            // 
            this.txt_ogrenciAD.Location = new System.Drawing.Point(78, 63);
            this.txt_ogrenciAD.Name = "txt_ogrenciAD";
            this.txt_ogrenciAD.Size = new System.Drawing.Size(100, 22);
            this.txt_ogrenciAD.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYAD:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_dersAD);
            this.groupBox2.Controls.Add(this.txt_dersID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(229, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders";
            // 
            // txt_dersAD
            // 
            this.txt_dersAD.Location = new System.Drawing.Point(68, 66);
            this.txt_dersAD.Name = "txt_dersAD";
            this.txt_dersAD.Size = new System.Drawing.Size(100, 22);
            this.txt_dersAD.TabIndex = 11;
            // 
            // txt_dersID
            // 
            this.txt_dersID.Location = new System.Drawing.Point(68, 31);
            this.txt_dersID.Name = "txt_dersID";
            this.txt_dersID.Size = new System.Drawing.Size(100, 22);
            this.txt_dersID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "AD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // btn_ogrekle
            // 
            this.btn_ogrekle.Location = new System.Drawing.Point(13, 621);
            this.btn_ogrekle.Name = "btn_ogrekle";
            this.btn_ogrekle.Size = new System.Drawing.Size(200, 39);
            this.btn_ogrekle.TabIndex = 3;
            this.btn_ogrekle.Text = "Öğrenci Ekle";
            this.btn_ogrekle.UseVisualStyleBackColor = true;
            this.btn_ogrekle.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ogrlistele
            // 
            this.btn_ogrlistele.Location = new System.Drawing.Point(13, 575);
            this.btn_ogrlistele.Name = "btn_ogrlistele";
            this.btn_ogrlistele.Size = new System.Drawing.Size(200, 40);
            this.btn_ogrlistele.TabIndex = 4;
            this.btn_ogrlistele.Text = "Öğrencileri Listele";
            this.btn_ogrlistele.UseVisualStyleBackColor = true;
            this.btn_ogrlistele.Click += new System.EventHandler(this.btn_ogrlistele_Click);
            // 
            // btn_ogrenciSil
            // 
            this.btn_ogrenciSil.Location = new System.Drawing.Point(13, 666);
            this.btn_ogrenciSil.Name = "btn_ogrenciSil";
            this.btn_ogrenciSil.Size = new System.Drawing.Size(200, 40);
            this.btn_ogrenciSil.TabIndex = 5;
            this.btn_ogrenciSil.Text = "Öğrenciyi Sil";
            this.btn_ogrenciSil.UseVisualStyleBackColor = true;
            this.btn_ogrenciSil.Click += new System.EventHandler(this.btn_ogrenciSil_Click);
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(1094, 694);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(134, 62);
            this.btn_cıkıs.TabIndex = 6;
            this.btn_cıkıs.Text = "Çıkış Yap";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(964, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(196, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Öğrencileri A\'dan Z\'ye sırala";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(964, 131);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(196, 20);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Öğrencileri Z\'den A\'ya sırala";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(964, 169);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 5 kaydı listele";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(964, 206);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(210, 20);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Toplam öğrenci sayısını yazdır";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btn_linqEntity
            // 
            this.btn_linqEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_linqEntity.Location = new System.Drawing.Point(964, 12);
            this.btn_linqEntity.Name = "btn_linqEntity";
            this.btn_linqEntity.Size = new System.Drawing.Size(241, 65);
            this.btn_linqEntity.TabIndex = 11;
            this.btn_linqEntity.Text = "Seçilen radioButton sorgusunu çalıştır";
            this.btn_linqEntity.UseVisualStyleBackColor = true;
            this.btn_linqEntity.Click += new System.EventHandler(this.btn_linqEntity_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(964, 241);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(221, 20);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı E harfi ile başlayanları yazdır";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(964, 276);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(219, 20);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Soyadı K harfi  ile bitenleri yazdır";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(963, 381);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(220, 20);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "En yüksek 2. Sınav notunu listele";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(964, 312);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(163, 20);
            this.radioButton9.TabIndex = 17;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "1. Sınav notlarını yazdır";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(964, 345);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(264, 20);
            this.radioButton10.TabIndex = 18;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "2. Sınav notlarını küçükten büyüğe sırala";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // btn_derslistele
            // 
            this.btn_derslistele.Location = new System.Drawing.Point(229, 575);
            this.btn_derslistele.Name = "btn_derslistele";
            this.btn_derslistele.Size = new System.Drawing.Size(200, 40);
            this.btn_derslistele.TabIndex = 19;
            this.btn_derslistele.Text = "Verilen Dersleri Listele";
            this.btn_derslistele.UseVisualStyleBackColor = true;
            this.btn_derslistele.Click += new System.EventHandler(this.btn_derslistele_Click);
            // 
            // btn_dersekle
            // 
            this.btn_dersekle.Location = new System.Drawing.Point(229, 621);
            this.btn_dersekle.Name = "btn_dersekle";
            this.btn_dersekle.Size = new System.Drawing.Size(200, 40);
            this.btn_dersekle.TabIndex = 20;
            this.btn_dersekle.Text = "Ders Ekle";
            this.btn_dersekle.UseVisualStyleBackColor = true;
            this.btn_dersekle.Click += new System.EventHandler(this.btn_dersekle_Click);
            // 
            // btn_derssil
            // 
            this.btn_derssil.Location = new System.Drawing.Point(229, 666);
            this.btn_derssil.Name = "btn_derssil";
            this.btn_derssil.Size = new System.Drawing.Size(200, 40);
            this.btn_derssil.TabIndex = 21;
            this.btn_derssil.Text = "Ders Sil";
            this.btn_derssil.UseVisualStyleBackColor = true;
            this.btn_derssil.Click += new System.EventHandler(this.btn_derssil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_devamsizlik);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(444, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 162);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devamsızlık";
            // 
            // txt_devamsizlik
            // 
            this.txt_devamsizlik.Location = new System.Drawing.Point(60, 31);
            this.txt_devamsizlik.Name = "txt_devamsizlik";
            this.txt_devamsizlik.Size = new System.Drawing.Size(100, 22);
            this.txt_devamsizlik.TabIndex = 10;
            this.txt_devamsizlik.TextChanged += new System.EventHandler(this.txt_devamsizlik_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID:";
            // 
            // btn_kullanimkilavuzu
            // 
            this.btn_kullanimkilavuzu.Location = new System.Drawing.Point(1094, 621);
            this.btn_kullanimkilavuzu.Name = "btn_kullanimkilavuzu";
            this.btn_kullanimkilavuzu.Size = new System.Drawing.Size(134, 62);
            this.btn_kullanimkilavuzu.TabIndex = 22;
            this.btn_kullanimkilavuzu.Text = "Kullanım Kılavuzu";
            this.btn_kullanimkilavuzu.UseVisualStyleBackColor = true;
            this.btn_kullanimkilavuzu.Click += new System.EventHandler(this.btn_kullanimkilavuzu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 768);
            this.Controls.Add(this.btn_kullanimkilavuzu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_derssil);
            this.Controls.Add(this.btn_dersekle);
            this.Controls.Add(this.btn_derslistele);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.btn_linqEntity);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.btn_ogrenciSil);
            this.Controls.Add(this.btn_ogrlistele);
            this.Controls.Add(this.btn_ogrekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ogrenciSOYAD;
        private System.Windows.Forms.TextBox txt_ogrenciAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_dersAD;
        private System.Windows.Forms.TextBox txt_dersID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ogrekle;
        private System.Windows.Forms.Button btn_ogrlistele;
        private System.Windows.Forms.TextBox txt_ogrYAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ogrenciSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ogrID;
        private System.Windows.Forms.Button btn_cıkıs;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btn_linqEntity;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Button btn_derslistele;
        private System.Windows.Forms.Button btn_dersekle;
        private System.Windows.Forms.Button btn_derssil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_devamsizlik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kullanimkilavuzu;
    }
}