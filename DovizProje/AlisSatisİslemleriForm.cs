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
    public partial class AlisSatisİslemleriForm : Form
    {
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        public AlisSatisİslemleriForm()
        {
            InitializeComponent();
        }

        private void AlisSatisİslemleriForm_Load(object sender, EventArgs e)
        {
            
            EnvanterSirala();
            MusteriSirala();
            DovizSirala();
            VezneSirala();
            IslemSirala();

        }

        void MusteriSirala()
        {
            foreach (var item in db.Musterilers)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.MusteriID.ToString();
                lw.SubItems.Add(item.MusteriAdi);
                lw.SubItems.Add(item.MusteriSoyadi);
                lw.SubItems.Add(item.TelefonNumarasi);
                lw.SubItems.Add(item.Adres);
                lwMusteri.Items.Add(lw);
            }
        }
        void DovizSirala()
        {
            foreach (var item in db.Dovizlers)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.DovizID.ToString();
                lw.SubItems.Add(item.DovizAdi);
                lwDoviz.Items.Add(lw);
            }
        }
        void EnvanterSirala()
        {
            foreach (var item in db.Envanters)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.EnvanterID.ToString();
                lw.SubItems.Add(item.Dovizlers.DovizAdi);
                lw.SubItems.Add(item.Miktar.ToString());
                lwEnvanter.Items.Add(lw);
            }
        }
        void VezneSirala()
        {
            foreach (var item in db.Veznelers)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.VezneID.ToString();
                lw.SubItems.Add(item.VezneAdi);
                lwVezne.Items.Add(lw);
            }
        }
        void IslemSirala()
        {
            foreach (var item in db.AlisSatislars)
            {
            ListViewItem lw = new ListViewItem();
                lw.Text = item.AlisSatisID.ToString();
                lw.SubItems.Add(item.Musterilers.MusteriAdi + " " + item.Musterilers.MusteriSoyadi);
                lw.SubItems.Add(item.İslemTipiID.ToString());
                lw.SubItems.Add(item.Dovizlers.DovizAdi);
                lw.SubItems.Add(item.Miktar.ToString());
                lw.SubItems.Add(item.Veznelers.VezneAdi);
                
                lwAlisSatis.Items.Add(lw);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lwMusteri.Items.Clear();
            foreach (var item in db.Musterilers.Where(x => x.MusteriAdi.StartsWith(textBox1.Text)))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.MusteriID.ToString();
                lvi.SubItems.Add(item.MusteriAdi);
                lvi.SubItems.Add(item.MusteriSoyadi);
                lwMusteri.Items.Add(lvi);
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            string secilimusteri = "";
            int secilimusterint;
            ListViewItem listMusteri = lwMusteri.SelectedItems[0];
            secilimusteri = listMusteri.Text;
            secilimusterint = Convert.ToInt32(secilimusteri);

            string secilidoviz = "";
            int secilidovizint;
            ListViewItem listdoviz = lwDoviz.SelectedItems[0];
            secilidoviz = listdoviz.Text;
            secilidovizint = Convert.ToInt32(secilidoviz);

            string secilivezne = "";
            int secilivezneint;
            ListViewItem listvezne = lwVezne.SelectedItems[0];
            secilivezne = listvezne.Text;
            secilivezneint = Convert.ToInt32(secilivezne);
            

            AlisSatislars alis = new AlisSatislars();
            alis.MusteriID = secilimusterint;
            if (cmbİslem.SelectedIndex==0)
            {
                alis.İslemTipiID = 1;
            }
            else if (cmbİslem.SelectedIndex == 1)
            {
                alis.İslemTipiID = 2;
            }
            alis.DovizID = secilidovizint;
            alis.Miktar = Convert.ToDecimal(txtMiktar.Text);
            alis.VezneID = secilivezneint;
            db.AlisSatislars.Add(alis);
            db.SaveChanges();
            lwAlisSatis.Items.Clear();
            IslemSirala();

            var envanterislem = db.Envanters.FirstOrDefault(x => x.DovizID == secilidovizint);
            envanterislem.Miktar = envanterislem.Miktar - Convert.ToDecimal(txtMiktar.Text);
            db.SaveChanges();
            lwEnvanter.Items.Clear();
            EnvanterSirala();

            txtMiktar.Text = "";
            cmbİslem.SelectedIndex = -1;
        }
    }
}
