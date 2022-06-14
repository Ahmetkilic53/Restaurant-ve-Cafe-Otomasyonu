using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.Urunler;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDal musterilerDal = new MusterilerDal();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
        private int? _masaId = null;
        private string _satisKodu=null;
        private OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();
        private Entities.Models.Satislar satislar;
        private SatislarDal satislarDal = new SatislarDal();
        private Entities.Models.Masalar masalar;
        private MasalarDal MasalarDal = new MasalarDal();
        private UrunDal urunDal = new UrunDal();
        private bool _paketSiparis = false;
        private MenuDal menuDal = new MenuDal();
        private frmUrunSec frm = new frmUrunSec();


        public frmMasaSiparisleri(int? masaId=null,string masaAdi=null,string satisKodu=null,bool paketSiparis=false)
        {
            InitializeComponent();
            _masaId = masaId;
            _satisKodu = satisKodu;
            _paketSiparis = paketSiparis;
            context.MasaHareketleri.Where(m=>m.SatisKodu==_satisKodu).Load();
            context.OdemeHareketleri.Where(o=>o.SatisKodu==_satisKodu).Load();
            context.Urun.Load();
            gridControlSiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
            gridControlOdemeler.DataSource= context.OdemeHareketleri.Local.ToBindingList();
            lookUpMusteri.Properties.DataSource = musterilerDal.GetAll(context); 
            if (_masaId!=null)
            {
                lblBaslik.Text = masaAdi + "Siparişler";
                masalar = MasalarDal.GetByFilter(context, m => m.Id == _masaId);
            }
            else if (_masaId == null)
            {
                lblBaslik.Text = "Paket Siparişi veya Veresiye İşlemleri";
            }

            satislar = satislarDal.GetByFilter(context, s => s.SatisKodu == _satisKodu);
            if (satislar!=null)
            {
                lookUpMusteri.EditValue = satislar.MusteriId;
                txtSatisAciklama.Text = satislar.Aciklama;
                dateEditTarih.Text = satislar.SonIslemTarihi.ToString("dd.MM.yyyy");
            }

            
        }

        
        

        private void Btn_Click(object sender, EventArgs e)
        {
            var senderbtn = sender as SimpleButton;

            int urunId = Convert.ToInt32(senderbtn.Name);
            MasaHareketleri entity = new MasaHareketleri
            {

            };
            masaHareketleriDal.AddOrUpdate(context, entity);
        }

        void Hesapla()
        {
            calcIndirimToplami.Value = Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue);
            calcIndirimliToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calcOdenen.Value = Convert.ToDecimal(colOdenen.SummaryItem.SummaryValue);
            calcToplam.Value = calcIndirimToplami.Value + calcIndirimliToplam.Value;
            calcKalan.Value = calcIndirimliToplam.Value - calcOdenen.Value;

                ////İndirim Oranı

            if (calcToplam.Value !=0)
            {
                calcIndirimOrani.Value = 100 * Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue) /
                                         (Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) + 
                                         Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue));
            }
            else if (calcToplam.Value == 0)
            {
                calcIndirimOrani.Value = 0;
            }
        }
        private void btnMusteriTemizle_Click(object sender, EventArgs e)
        {
            lookUpMusteri.EditValue = null;
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili siparişin silinmesini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridViewSiparisler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Ödemenin silinmesini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewOdemeler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            frmUrunSec frm = new frmUrunSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    SatisKodu = _satisKodu,
                    MasaId = _masaId,
                    UrunId = frm.urunModel.Id,
                    Miktari = 1,
                    BirimFiyati = frm.urunModel.BirimFiyati1,
                    indirimTutari = 0,
                    Aciklama = "",
                    Tarih = DateTime.Now
                };
                if (masaHareketleriDal.AddOrUpdate(context,entity))
                {
                    
                }
            }
        }


        private void gridViewSiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnYenileListele_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount>0)
            {
                if (dateEditTarih.EditValue!=null)
                {
                    if (satislar == null)
                    {
                        satislar = new Entities.Models.Satislar();
                        satislar.SatisKodu = _satisKodu;
                    }

                    satislar.MusteriId = (int?)lookUpMusteri.EditValue;
                    satislar.Aciklama = txtSatisAciklama.Text;
                    satislar.SonIslemTarihi = Convert.ToDateTime(dateEditTarih.EditValue);
                    satislar.Kalan = calcKalan.Value;
                    satislar.Odenen = calcOdenen.Value;
                    satislar.Tutar = calcToplam.Value;
                    satislar.indirimToplami = calcIndirimToplami.Value;
                    satislar.PaketSiparisMi = _paketSiparis;
                    satislarDal.AddOrUpdate(context, satislar);
                    context.SaveChanges();  
                }
                else
                {
                    MessageBox.Show("Tarih girilmesi gerekiyor.", "Cafe Otomasyon");
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir kayıt bulunamadı.", "Cafe Otomasyon");
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Odemeler_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount>0)
            {
                var btn = sender as SimpleButton;
                frmOdeme frm = new frmOdeme(btn.Text, _satisKodu, calcKalan.Value);
                frm.ShowDialog();

                if (frm.kaydedildi)
                {
                    if (odemeHareketleriDal.AddOrUpdate(context, frm.odemeHareketleri))
                    {
                        gridViewOdemeler.RefreshData();
                        Hesapla();
                    }
                } 
            }
        }

        private void gridViewOdemeler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnSonuclandir_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount>0)
            {
                if (_masaId != null)
                {
                    if (calcKalan.Value > 0)
                    {

                        if (MessageBox.Show("Bu işlemi onaylarsanız müşteriye ait borç işlemi kaydedilecektir.",
                                "Cafe Otomasyon", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (satislar != null)
                            {
                                if (satislar.MusteriId == null)
                                {
                                    MessageBox.Show("Önce müşteriyi seçmelisiniz.", "Cafe Otomasyon");
                                }
                                else
                                {
                                    Sonuclandir();
                                    this.Close();
                                }
                            }
                        }



                    }
                    else if (calcKalan.Value == 0)
                    {
                        Sonuclandir();
                        this.Close();
                    }
                } 
            }
        }

        private void Sonuclandir()
        {
            masalar.SatisKodu = null;
            masalar.Durumu = false;
            masalar.Islem = null;
            masalar.KullaniciId = null;
            MasalarDal.AddOrUpdate(context, masalar);
            MasalarDal.Save(context);
        }

        private void repositoryFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int urunId = Convert.ToInt32(gridViewSiparisler.GetFocusedRowCellValue(colUrunId));
            var model = urunDal.GetByFilter(context, u => u.Id == urunId);
            barFiyat1.Caption = model.BirimFiyati1.ToString();
            barFiyat2.Caption = model.BirimFiyati2.ToString();
            barFiyat3.Caption = model.BirimFiyati3.ToString();


            radialMenu1.ShowPopup(MousePosition);
        }

        private void Fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewSiparisler.SetFocusedRowCellValue(colBirimFiyati,e.Item.Caption);
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}