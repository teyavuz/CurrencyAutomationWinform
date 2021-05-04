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
    public partial class VezneEkleForm : Form
    {
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        public VezneEkleForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Veznelers vezne = new Veznelers();
                vezne.VezneAdi = txtVezneAdi.Text;
                db.Veznelers.Add(vezne);
                db.SaveChanges();

                txtVezneAdi.Text = "";
            }
            catch 
            {
                MessageBox.Show("BİR HATA OLUŞTU!");                
            }
        }
    }
}
