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
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private CafeContext context = new CafeContext();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        private KullaniciHareketleri entity = new KullaniciHareketleri();

        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla == true)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = Properties.Settings.Default.Parola;
                checkBeniHatirla.Checked = true;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtParola.Text = null;
                checkBeniHatirla.Checked = false;
            }
        }

        void BilgileriKaydet()
        {
            if (checkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola = txtParola.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }
        public frmKullaniciGirisi()
        {
            InitializeComponent();
            BilgileriGetir();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBeniHatirla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k =>
                k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtParola.Text);

            if (model != null)
            {
                giris = true;
                BilgileriKaydet();
                KullaniciAyarlari.kullaniciId = model.Id;
                entity.KullaniciId = model.Id;
                string aciklama = model.KullaniciAdi + " adlı kullanıcı sisteme giriş yaptı";
                kullaniciHareketleriDal.KullaniciHareketleriEkle(context, entity, aciklama);


                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            frmSifremiUnuttum frm = new frmSifremiUnuttum();
            frm.ShowDialog();
        }

        private void frmKullaniciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void frmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void lblKaydol_Click(object sender, EventArgs e)
        {
            frmKaydol frm = new frmKaydol(new Entities.Models.Kullanicilar());
            frm.ShowDialog();
        }

        private void txtParola_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}