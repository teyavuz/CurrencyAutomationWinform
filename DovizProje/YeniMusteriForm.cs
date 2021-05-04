using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizProje
{
    public partial class YeniMusteriForm : Form
    {
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        public YeniMusteriForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Musterilers musteri = new Musterilers();
                musteri.MusteriAdi = txtMusteriAdi.Text;
                musteri.MusteriSoyadi = txtMusteriSoyadi.Text;
                musteri.TelefonNumarasi = txtTelefonNo.Text;
                musteri.Adres = txtAdres.Text;
                db.Musterilers.Add(musteri);
                db.SaveChanges();

                txtMusteriAdi.Text = "";
                txtMusteriSoyadi.Text = "";
                txtTelefonNo.Text = "";
                txtAdres.Text = "";
            }
            catch
            {

                MessageBox.Show("LÜTFEN GİRDİLERİ DOĞRU YAPIN!");
            }
        }
    }
}
