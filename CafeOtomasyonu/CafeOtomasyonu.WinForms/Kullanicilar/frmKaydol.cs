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
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKaydol : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private Entities.Models.Kullanicilar _entity;
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        public frmKaydol(Entities.Models.Kullanicilar entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleAktifMi.DataBindings.Add("EditValue", _entity, "AktifMi");
            txtAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            memoEditAdres.DataBindings.Add("Text", _entity, "Adres");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi");
            txtParola.DataBindings.Add("Text", _entity, "Parola");
            txtSoru.DataBindings.Add("Text", _entity, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _entity, "Cevap");
            memoEditAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtParola.Text == txtParolaTekrar.Text)
            {
                _entity.KayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddOrUpdate(context, _entity))
                {
                    kullanicilarDal.Save(context);
                    var model = context.Kullanicilar.Max(k => k.Id);
                    kullaniciHareketleri.KullaniciId = model;
                    string aciklama = "Yeni kullanıcı eklendi";
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}