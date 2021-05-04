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
    public partial class YeniDovizEklemeForm : Form
    {
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        public YeniDovizEklemeForm()
        {
            InitializeComponent();
        }

        private void YeniDovizEklemeForm_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDovizAdi.Text != "" & txtMiktar.Text !="")
                {
                Dovizlers dov = new Dovizlers();
                dov.DovizAdi = txtDovizAdi.Text;
                dov.DovizKuru = Convert.ToDecimal(txtMiktar.Text);
                db.Dovizlers.Add(dov);
                db.SaveChanges();

                }

                txtDovizAdi.Text = "";
                txtMiktar.Text = "";

                listView1.Items.Clear();
                ListeDoldur();
                
            }
            catch 
            {

                MessageBox.Show("LÜTFEN GİRDİLERİ DOĞRU YAPINIZ!");
            }

            Envanters ev = new Envanters();
            

        }

         void ListeDoldur()
        {
            foreach (var item in db.Dovizlers)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.DovizID.ToString();
                lw.SubItems.Add(item.DovizAdi);
                lw.SubItems.Add(item.DovizKuru.ToString());
                listView1.Items.Add(lw);
            }
        }
    }
}
