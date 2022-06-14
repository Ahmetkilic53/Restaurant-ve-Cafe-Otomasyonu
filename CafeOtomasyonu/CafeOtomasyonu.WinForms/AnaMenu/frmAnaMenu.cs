using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Kullanicilar;
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Menuler;
using CafeOtomasyonu.WinForms.Musteriler;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.RaporDosyalari;
using CafeOtomasyonu.WinForms.Satislar;
using CafeOtomasyonu.WinForms.Urunler;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace CafeOtomasyonu.WinForms.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CafeContext context = new CafeContext();
        
        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public frmAnaMenu()
        {
            InitializeComponent();
            frmKullaniciGirisi frm = new frmKullaniciGirisi();
            frm.ShowDialog();
        }

        private void btnKullaniciHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmUrunler();
            FormGetir(frm);
        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMasalar();
            FormGetir(frm);
        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMenuler();
            frm.ShowDialog();
        }

        private void btnMasaSiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMasaDurumlari();
            FormGetir(frm);
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMusteriler();
            FormGetir(frm);
        }

        private void btnSatislar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmSatislar();
            FormGetir(frm);
        }

        private void btnOdemeHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmOdemeHareketleri();
            FormGetir(frm);
        }

        private void btnPaketSiparisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket sipariş işlemini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                var model = context.SatisKodu.First();
                string satisKodu = model.SatisTanimi + model.Sayi;
                model.Sayi++;
                context.SaveChanges();
                XtraForm frm = new frmMasaSiparisleri(satisKodu: satisKodu,paketSiparis:true);
                frm.ShowDialog(); 
            }
        }

        private void btnRaporGoruntule_ItemClick(object sender, ItemClickEventArgs e)
        {
            rptSatislar report = new rptSatislar();
            frmRaporGoruntule frm = new frmRaporGoruntule(report);
            frm.ShowDialog();
        }

        private void btnMasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmMasaHareketleri();
            frm.ShowDialog();
        }

        private void btnMenuHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmMasaHareketleri();
            frm.ShowDialog();
        }

        private void btnUrunHareketleri2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmMasaHareketleri();
            frm.ShowDialog();

        }

        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDashboard();
            frm.ShowDialog();
        }
    }
}