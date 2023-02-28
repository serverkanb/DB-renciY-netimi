using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DbSinavNotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbfirstSinavNotu2Entities db=new DbfirstSinavNotu2Entities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[4].Visible= false;
            if (radioButton1.Checked == true)
            {
                DbfirstSinavNotu2Entities db = new DbfirstSinavNotu2Entities();
                //List<TBLOGRENCI> list = db.TBLOGRENCI.OrderBy(x => x.AD).ToList();
                // dataGridView1.DataSource = list;
                dataGridView1.DataSource = db.TBLOGRENCI.OrderBy(x => x.AD).ToList();

            }
            if (radioButton2.Checked == true)
            {
                //List<TBLOGRENCI> list2 = db.TBLOGRENCI.OrderByDescending(x => x.AD).ToList();
                //dataGridView1.DataSource = list2;
                dataGridView1.DataSource=db.TBLOGRENCI.OrderByDescending(x => x.AD).ToList();
            }
            if(radioButton3.Checked == true)
            {
                List<TBLOGRENCI>list3 = db.TBLOGRENCI.OrderBy(x => x.AD).Take(3).ToList();
                dataGridView1.DataSource = list3;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBLOGRENCI T = new TBLOGRENCI();
            T.AD=txtad.Text;
            T.SOYAD=txtsoyad.Text;
            db.TBLOGRENCI.Add(T);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtad.Text = "";
            txtsoyad.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dersler_Enter(object sender, EventArgs e)
        {

        }

        private void BtnNotListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNOT
                        select new { item.NOTID,item.TBLOGRENCI.AD,item.TBLDERS.DersAD, item.DERSID, item.OGRID, item.SINAV1, item.SINAV2, item.SINAV3, item.ORTALAMA, item.DURUM };
            dataGridView1.DataSource = query.ToList();

        }

        private void BtnOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=db.TBLDERS.ToList();
            dataGridView1.Columns[2].Visible = false;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(txtıd.Text);
            var x = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Sistemden Silindi");
            txtıd.Text = "";

        }

        private void Btngüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtıd.Text);
            var x = db.TBLOGRENCI.Find(id);
            x.AD = txtad.Text;
            x.SOYAD=txtsoyad.Text;
            x.FOTOGRAF=txtfotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLAR();

        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=db.TBLOGRENCI.Where(x=>x.AD==txtad.Text & x.SOYAD==txtsoyad.Text).ToList();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            string aranan=txtad.Text;
            var degerler = from item in db.TBLOGRENCI
                           where item.AD.Contains(aranan)
                           select item;
            dataGridView1.DataSource=degerler.ToList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            {
                var toplam = db.TBLNOT.Sum(p => p.SINAV1);
                MessageBox.Show("Toplam sınav1 puanı :" + toplam.ToString());
            }
            if(radioButton7.Checked==true)
            {
                bool deger = db.TBLOGRENCI.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK);
            }
            if(radioButton8.Checked==true)
            {
                var enyukseknot=db.TBLNOT.Max(p => p.SINAV1);
                MessageBox.Show(enyukseknot.ToString(), "En yüksek not");
            }
            if(radioButton9.Checked==true)
            {
                var enyuksekisim=db.TBLNOT.Max(p => p.SINAV1);
                dataGridView1.DataSource = db.NOTLAR().Where(p => p.SINAV1 == enyuksekisim).ToList();
            }
            if(btn80.Checked==true)
            {
                var query = from item in db.TBLNOT
                            select new { item.NOTID, item.TBLOGRENCI.AD, item.TBLDERS.DersAD, item.DERSID, item.OGRID, item.SINAV1,};
                dataGridView1.DataSource = query.Where(p => p.SINAV1 == 85).ToList();

            }

            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked==true)
            {
                int toplam = db.TBLOGRENCI.Count();
                MessageBox.Show(toplam.ToString(),"Toplam Öğrenci SAyısı",MessageBoxButtons.OK);
            }

            if(radioButton6.Checked==true)
            {
                var ortalama = db.TBLNOT.Average(p=>p.SINAV1);
                MessageBox.Show(ortalama.ToString(), "1. Sınav Ortalaması");

            }
            

      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ortalamasınav1=db.TBLNOT.Average(p=>p.SINAV1);
            txtortalama.Text = ortalamasınav1.ToString();
          
        }
    }
}
