using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DovizProje
{
    public partial class MevcutKurlarForm : Form
    {
        public MevcutKurlarForm()
        {
            InitializeComponent();
        }

        private void MevcutKurlarForm_Load(object sender, EventArgs e)
        {

            ArrayList Alist = new ArrayList();
            ArrayList Alist2 = new ArrayList();

            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            label21.Text = string.Format("{0}", tarih.ToShortDateString());
            string USDalis = "USD Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='USD']/ForexBuying").InnerXml;
            string USDsatis = "USD Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='USD']/ForexSelling").InnerXml;
            string USD = "USD Alış: " + USDalis + " " + " USD Satış: " + USDsatis;
            Alist.Add(USDalis);
            Alist2.Add(USDsatis);


            string AUDalis = "AUD Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='AUD']/ForexBuying").InnerXml;
            string AUDsatis = "AUD Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='AUD']/ForexSelling").InnerXml;
            string AUD = "AUD Alış: " + AUDalis + " " + " AUD Satış: " + AUDsatis;
            Alist.Add(AUDalis);
            Alist2.Add(AUDsatis);

            string DKKalis = "DKK Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='DKK']/ForexBuying").InnerXml;
            string DKKsatis = "DKK Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='DKK']/ForexSelling").InnerXml;
            string DKK = "DKK Alış: " + DKKalis + " " + " DKK Satış: " + DKKsatis;
            Alist.Add(DKKalis);
            Alist2.Add(DKKsatis);

            string EURalis = "EUR Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='EUR']/ForexBuying").InnerXml;
            string EURsatis = "EUR Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='EUR']/ForexSelling").InnerXml;
            string EUR = "EUR Alış: " + EURalis + " " + " EUR Satış: " + EURsatis;
            Alist.Add(EURalis);
            Alist2.Add(EURsatis);

            string GBPalis = "GBP Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='GBP']/ForexBuying").InnerXml;
            string GBPsatis = "GBP Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='GBP']/ForexSelling").InnerXml;
            string GBP = "GBP Alış: " + GBPalis + " " + " GBP Satış: " + GBPsatis;
            Alist.Add(GBPalis);
            Alist2.Add(GBPsatis);

            string CHFalis = "CHF Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='CHF']/ForexBuying").InnerXml;
            string CHFsatis = "CHF Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='CHF']/ForexSelling").InnerXml;
            string CHF = "CHF Alış: " + CHFalis + " " + " CHF Satış: " + CHFsatis;
            Alist.Add(CHFalis);
            Alist2.Add(CHFsatis);

            string SEKalis = "SEK Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='SEK']/ForexBuying").InnerXml;
            string SEKsatis = "SEK Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='SEK']/ForexSelling").InnerXml;
            string SEK = "SEK Alış: " + SEKalis + " " + " SEK Satış: " + SEKsatis;
            Alist.Add(SEKalis);
            Alist2.Add(SEKsatis);

            string CADalis = "CAD Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='CAD']/ForexBuying").InnerXml;
            string CADsatis = "CAD Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='CAD']/ForexSelling").InnerXml;
            string CAD = "CAD Alış: " + CADalis + " " + " CAD Satış: " + CADsatis;
            Alist.Add(CADalis);
            Alist2.Add(CADsatis);

            string KWDalis = "KWD Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='KWD']/ForexBuying").InnerXml;
            string KWDsatis = "KWD Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='KWD']/ForexSelling").InnerXml;
            string KWD = "KWD Alış: " + KWDalis + " " + " KWD Satış: " + KWDsatis;
            Alist.Add(KWDalis);
            Alist2.Add(KWDsatis);

            string NOKalis = "NOK Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='NOK']/ForexBuying").InnerXml;
            string NOKsatis = "NOK Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='NOK']/ForexSelling").InnerXml;
            string NOK = "NOK Alış: " + NOKalis + " " + " NOK Satış: " + NOKsatis;
            Alist.Add(NOKalis);
            Alist2.Add(NOKsatis);

            string SARalis = "SAR Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='SAR']/ForexBuying").InnerXml;
            string SARsatis = "SAR Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='SAR']/ForexSelling").InnerXml;
            string SAR = "SAR Alış: " + SARalis + " " + " SAR Satış: " + SARsatis;
            Alist.Add(SARalis);
            Alist2.Add(SARsatis);

            string JPYalis = "JPY Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexBuying").InnerXml;
            string JPYsatis = "JPY Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexSelling").InnerXml;
            string JPY = "JPY Alış: " + JPYalis + " " + " JPY Satış: " + JPYsatis;
            Alist.Add(JPYalis);
            Alist2.Add(JPYsatis);

            string BGNalis = "BGN Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='BGN']/ForexBuying").InnerXml;
            string BGNsatis = "BGN Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='BGN']/ForexSelling").InnerXml;
            string BGN = "BGN Alış: " + BGNalis + " " + " BGN Satış: " + BGNsatis;
            Alist.Add(BGNalis);
            Alist2.Add(BGNsatis);

            string RONalis = "RON Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='RON']/ForexBuying").InnerXml;
            string RONsatis = "RON Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='RON']/ForexSelling").InnerXml;
            string RON = "RON Alış: " + RONalis + " " + " RON Satış: " + RONsatis;
            Alist.Add(RONalis);
            Alist2.Add(RONsatis);

            string RUBalis = "RUB Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='RUB']/ForexBuying").InnerXml;
            string RUBsatis = "RUB Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='RUB']/ForexSelling").InnerXml;
            string RUB = "RUB Alış: " + RUBalis + " " + " RUB Satış: " + RUBsatis;
            Alist.Add(RUBalis);
            Alist2.Add(RUBsatis);

            string IRRalis = "IRR Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='IRR']/ForexBuying").InnerXml;
            string IRRsatis = "IRR Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='IRR']/ForexSelling").InnerXml;
            string IRR = "IRR Alış: " + IRRalis + " " + " IRR Satış: " + IRRsatis;
            Alist.Add(IRRalis);
            Alist2.Add(IRRsatis);

            string CNYalis = "CNY Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='CNY']/ForexBuying").InnerXml;
            string CNYsatis = "CNY Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='USD']/ForexSelling").InnerXml;
            string CNY = "CNY Alış: " + CNYalis + " " + " CNY Satış: " + CNYsatis;
            Alist.Add(CNYalis);
            Alist2.Add(CNYsatis);

            string PKRalis = "PKR Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='PKR']/ForexBuying").InnerXml;
            string PKRsatis = "PKR Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='PKR']/ForexSelling").InnerXml;
            string PKR = "PKR Alış: " + PKRalis + " " + " PKR Satış: " + PKRsatis;
            Alist.Add(PKRalis);
            Alist2.Add(PKRsatis);

            string QARalis = "QAR Alış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='QAR']/ForexBuying").InnerXml;
            string QARsatis = " QAR Satış: " + xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod ='QAR']/ForexSelling").InnerXml;
            string QAR = "QAR Alış: " + QARalis + " " + " QAR Satış: " + QARsatis;
            Alist.Add(QARalis);
            Alist2.Add(QARsatis);


            foreach (var item in Alist)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.ToString();
                listView1.Items.Add(lw);
            }

            foreach (var item in Alist2)
            {
                ListViewItem lw = new ListViewItem();
                lw.Text = item.ToString();
                listView2.Items.Add(lw);
            }


        }
    }
}
