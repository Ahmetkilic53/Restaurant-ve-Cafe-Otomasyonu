using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;

namespace CafeOtomasyonu.WinForms.Odemeler
{
    public partial class frmOdeme : DevExpress.XtraEditors.XtraForm
    {
        private string _satisKodu;
        private string _odemeTuru;
        public OdemeHareketleri odemeHareketleri;
        public bool kaydedildi;
        private decimal _kalan;
        public frmOdeme(string odemeturu,string satisKodu,decimal kalan)
        {
            InitializeComponent();
            _odemeTuru = odemeturu;
            _satisKodu = satisKodu;
            _kalan = kalan;
            if (_odemeTuru == "Nakit")
            {
                lblBaslik.Text = "Nakit Ödeme";
            }
            else if (_odemeTuru == "Kredi Kartı")

            {
                lblBaslik.Text = "Kredi Kartı İle Ödeme";
            }

            else if (_odemeTuru == "Yemek Kartı")

            {
                lblBaslik.Text = "Yemek Kartı İle Ödeme";
            }



        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            odemeHareketleri = new OdemeHareketleri
            {
                SatisKodu = _satisKodu,
                OdemeTuru = _odemeTuru,
                Odenen = calcOdenecekTutar.Value,
                Aciklama = txtAciklama.Text,
                Tarih = Convert.ToDateTime(dateEditTarih.Text)
            };
            kaydedildi = true;
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            calcOdenecekTutar.Value = _kalan;
        }
    }
}