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
    public partial class GunlukPanoGuncellemeForm : Form
    {
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        public GunlukPanoGuncellemeForm()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string number = "";
            int numberint;
            ListViewItem item = listView2.SelectedItems[0];
            number = item.SubItems[0].Text;
            numberint = Convert.ToInt32(number);
            var doviz = db.Dovizlers.FirstOrDefault(x => x.DovizID == numberint);
            doviz.DovizKuru = Convert.ToDecimal(txtMiktar.Text);
            db.SaveChanges();
            listView1.Items.Clear();
            ListeDoldur();
            
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

        private void GunlukPanoGuncellemeForm_Load(object sender, EventArgs e)
        {
            ListeDoldur();
            foreach (var item in db.Dovizlers)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.DovizID.ToString();
                lw.SubItems.Add(item.DovizAdi);
                listView2.Items.Add(lw);
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
        }
    }
}
