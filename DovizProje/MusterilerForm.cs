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
    public partial class MusterilerForm : Form
    {
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        public MusterilerForm()
        {
            InitializeComponent();
        }

        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Musterilers)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.MusteriID.ToString();
                lw.SubItems.Add(item.MusteriAdi);
                lw.SubItems.Add(item.MusteriSoyadi);
                lw.SubItems.Add(item.TelefonNumarasi);
                lw.SubItems.Add(item.Adres);
                listView1.Items.Add(lw);
            }

        }
    }
}
