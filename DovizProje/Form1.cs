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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alışSatışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlisSatisİslemleriForm Childform = new AlisSatisİslemleriForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Okan Atabaş 191307047 \n \n Taha Emre Yavuz 191307020 \n \n Yasin Çetin 191307055");

        }


        private void vezneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VezneEkleForm Childform = new VezneEkleForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void gelirGiderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderEklemeForm Childform = new GelirGiderEklemeForm();
            Childform.MdiParent = this;
            Childform.Show();

        }

        private void gelirGiderTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderTakibiForm Childform = new GelirGiderTakibiForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void mevutKurlarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MevcutKurlarForm Childform = new MevcutKurlarForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void günlükPanoGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukPanoGuncellemeForm Childform = new GunlukPanoGuncellemeForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void yeniDövizEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniDovizEklemeForm Childform = new YeniDovizEklemeForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void yeniMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniMusteriForm Childform = new YeniMusteriForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusterilerForm Childform = new MusterilerForm();
            Childform.MdiParent = this;
            Childform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
