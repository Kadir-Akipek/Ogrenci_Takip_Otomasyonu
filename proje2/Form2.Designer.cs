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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_ortalama = new System.Windows.Forms.TextBox();
            this.txt_sınav2 = new System.Windows.Forms.TextBox();
            this.txt_sınav1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ogrekle = new System.Windows.Forms.Button();
            this.btn_ogrlistele = new System.Windows.Forms.Button();
            this.btn_ogrenciSil = new System.Windows.Forms.Button();
            this.btn_cıkıs = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(932, 363);
            this.dataGridView1.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(13, 400);
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
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yaş";
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
            this.groupBox2.Location = new System.Drawing.Point(229, 400);
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
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ortalama);
            this.groupBox3.Controls.Add(this.txt_sınav2);
            this.groupBox3.Controls.Add(this.txt_sınav1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(456, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 162);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // txt_ortalama
            // 
            this.txt_ortalama.Location = new System.Drawing.Point(89, 101);
            this.txt_ortalama.Name = "txt_ortalama";
            this.txt_ortalama.Size = new System.Drawing.Size(100, 22);
            this.txt_ortalama.TabIndex = 17;
            // 
            // txt_sınav2
            // 
            this.txt_sınav2.Location = new System.Drawing.Point(89, 64);
            this.txt_sınav2.Name = "txt_sınav2";
            this.txt_sınav2.Size = new System.Drawing.Size(100, 22);
            this.txt_sınav2.TabIndex = 16;
            // 
            // txt_sınav1
            // 
            this.txt_sınav1.Location = new System.Drawing.Point(89, 28);
            this.txt_sınav1.Name = "txt_sınav1";
            this.txt_sınav1.Size = new System.Drawing.Size(100, 22);
            this.txt_sınav1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sınav2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ortalama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sınav1:";
            // 
            // btn_ogrekle
            // 
            this.btn_ogrekle.Location = new System.Drawing.Point(677, 463);
            this.btn_ogrekle.Name = "btn_ogrekle";
            this.btn_ogrekle.Size = new System.Drawing.Size(184, 39);
            this.btn_ogrekle.TabIndex = 3;
            this.btn_ogrekle.Text = "Öğrenci Ekle";
            this.btn_ogrekle.UseVisualStyleBackColor = true;
            this.btn_ogrekle.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ogrlistele
            // 
            this.btn_ogrlistele.Location = new System.Drawing.Point(677, 404);
            this.btn_ogrlistele.Name = "btn_ogrlistele";
            this.btn_ogrlistele.Size = new System.Drawing.Size(184, 40);
            this.btn_ogrlistele.TabIndex = 4;
            this.btn_ogrlistele.Text = "Öğrencileri Listele";
            this.btn_ogrlistele.UseVisualStyleBackColor = true;
            this.btn_ogrlistele.Click += new System.EventHandler(this.btn_ogrlistele_Click);
            // 
            // btn_ogrenciSil
            // 
            this.btn_ogrenciSil.Location = new System.Drawing.Point(677, 518);
            this.btn_ogrenciSil.Name = "btn_ogrenciSil";
            this.btn_ogrenciSil.Size = new System.Drawing.Size(184, 40);
            this.btn_ogrenciSil.TabIndex = 5;
            this.btn_ogrenciSil.Text = "Öğrenciyi Sil";
            this.btn_ogrenciSil.UseVisualStyleBackColor = true;
            this.btn_ogrenciSil.Click += new System.EventHandler(this.btn_ogrenciSil_Click);
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(13, 641);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(134, 62);
            this.btn_cıkıs.TabIndex = 6;
            this.btn_cıkıs.Text = "Çıkış Yap";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 715);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.btn_ogrenciSil);
            this.Controls.Add(this.btn_ogrlistele);
            this.Controls.Add(this.btn_ogrekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_ortalama;
        private System.Windows.Forms.TextBox txt_sınav2;
        private System.Windows.Forms.TextBox txt_sınav1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ogrekle;
        private System.Windows.Forms.Button btn_ogrlistele;
        private System.Windows.Forms.TextBox txt_ogrYAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ogrenciSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ogrID;
        private System.Windows.Forms.Button btn_cıkıs;
    }
}