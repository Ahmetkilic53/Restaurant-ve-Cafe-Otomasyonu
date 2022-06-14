using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;

namespace CafeOtomasyonu.WinForms.Urunler
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private MenuDal menuDal = new MenuDal();
        private UrunDal urunDal = new UrunDal();
        private Urun _entity;
        private CafeContext context = new CafeContext();
        public bool kaydet = false;

        public frmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            _entity = entity;
            lookUpMenu.Properties.DataSource = menuDal.GetAll(context);
            lookUpMenu.DataBindings.Add("EditValue", _entity, "MenuId");
            txtUrunKodu.DataBindings.Add("Text", _entity, "UrunKodu");
            txtUrunAdi.DataBindings.Add("Text", _entity, "UrunAdi");
            calcBirimFiyati1.DataBindings.Add("Text", _entity, "BirimFiyati1", true);
            calcBirimFiyati2.DataBindings.Add("Text", _entity, "BirimFiyati2", true);
            calcBirimFiyati3.DataBindings.Add("Text", _entity, "BirimFiyati3", true);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            dateEdit1.DataBindings.Add("Text", _entity, "Tarih", true);
            if (_entity.Id != 0)
            {
                if (_entity.Resim != null)
                {
                    pictureEdit1.Image = Image.FromFile(_entity.Resim);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation() != "")

            {
                string hedefyol = $"{Application.StartupPath}\\Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                if (File.Exists(hedefyol))
                {
                    File.Delete(hedefyol);
                }
                File.Copy(pictureEdit1.GetLoadedImageLocation(), hedefyol);
                _entity.Resim = $"Image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
            }
            if (urunDal.AddOrUpdate(context, _entity))
            {
                urunDal.Save(context);
                kaydet = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}