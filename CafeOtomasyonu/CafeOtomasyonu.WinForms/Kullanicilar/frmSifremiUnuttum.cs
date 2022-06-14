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
    public partial class frmSifremiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var entity = kullanicilarDal.GetByFilter(context,
                k => k.KullaniciAdi == txtKullaniciAdiEmail.Text || k.Email == txtKullaniciAdiEmail.Text);
            if (entity != null)
            {
                if (entity.HatirlatmaSorusu == txtSoru.Text && entity.Cevap == txtCevap.Text)
                {
                    if (txtYeniParola.Text == txtYeniParolaTekrar.Text)
                    {
                        entity.Parola = txtYeniParola.Text;
                        if (kullanicilarDal.AddOrUpdate(context, entity))
                        {
                            kullanicilarDal.Save(context);
                            kullaniciHareketleri.KullaniciId = entity.Id;
                            string aciklama = entity.KullaniciAdi + " adlı kullanıcı parolası yenilendi";
                            kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen soru veya cevap yanlış.");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}