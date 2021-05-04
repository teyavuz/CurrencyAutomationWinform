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
    public partial class GelirGiderEklemeForm : Form
    {
        public GelirGiderEklemeForm()
        {
            InitializeComponent();
        }
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        private void cmbGelirGider_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Muhasebelers muh = new Muhasebelers();
            try
            {
                if (cmbGelirGider.SelectedIndex == 0)
                {
                    muh.GelirGiderTipiID = 1;
                }
                else if (cmbGelirGider.SelectedIndex == 1)
                {
                    muh.GelirGiderTipiID = 2;
                }
                muh.DovizID = 4;
                muh.Miktar = Convert.ToDecimal(txtMiktar.Text);
                muh.Aciklama = txtAciklama.Text;
                db.Muhasebelers.Add(muh);
                db.SaveChanges();
                txtMiktar.Text = "";
                txtAciklama.Text = "";
                cmbGelirGider.SelectedIndex = -1;
                groupBox1.Visible = false;
            }
            
            catch 
            {
                MessageBox.Show("LÜTFEN GİRDİLERİ DOĞRU YAPINIZ!");
            }
        }
    }
}
