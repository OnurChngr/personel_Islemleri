using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelİslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text;            
            string ad = txtAd.Text;            
            string soyad = txtSoyad.Text;
            if (cmbBirim.SelectedIndex==0)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad+" "+"Yönetici");
            }
            if (cmbBirim.SelectedIndex == 1)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "Çalışan");
            }
            if (cmbBirim.SelectedIndex == 2)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "Hizmetli");
            }
            if (cmbİsBasla.SelectedIndex == 0)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "29 kasım 2019");
            }
            if (cmbİsBasla.SelectedIndex == 1)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "29 kasım 2018");
            }
            if (cmbİsBasla.SelectedIndex == 2)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "29 kasım 2017");
            }
            if (cmbDogYer.SelectedIndex == 0)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "İstanbul");
            }
            if (cmbDogYer.SelectedIndex == 1)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "Ankara");
            }
            if (cmbDogYer.SelectedIndex == 2)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "Burdur");
            }
            if (cmbDogTarih.SelectedIndex == 0)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "12 mart 1960");
            }
            if (cmbDogTarih.SelectedIndex == 1)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "17 eylül 1974");
            }
            if (cmbDogTarih.SelectedIndex == 2)
            {
                lstPersonel.Items.Add(tc + " " + ad + " " + soyad + " " + "26 aralık 1977");
            }

            
            
            
        }
    }
}
