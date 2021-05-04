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
    public partial class GelirGiderTakibiForm : Form
    {
        DovizOtomasyonDBEntities db = new DovizOtomasyonDBEntities();
        public GelirGiderTakibiForm()
        {
            InitializeComponent();
        }

        private void GelirGiderTakibiForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Muhasebelers)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.DovizID.ToString();
                lw.SubItems.Add(item.GelirGiderTipleris.GelirGiderTipiAdi);
                lw.SubItems.Add(item.DovizID.ToString());
                lw.SubItems.Add(item.Miktar.ToString());
                lw.SubItems.Add(item.Aciklama);
                listView1.Items.Add(lw);
            }
        }
    }
}
