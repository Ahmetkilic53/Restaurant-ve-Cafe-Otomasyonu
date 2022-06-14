﻿using DevExpress.XtraEditors;
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

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaRezerv : DevExpress.XtraEditors.XtraForm
    {
        private int _masaId;
        public bool islemyapildi;
        private Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();
        private CafeContext context = new CafeContext();
        public frmMasaRezerv(int masaId)
        {
            _masaId = masaId;
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            masalar.Islem = txtIslem.Text;
            masalar.SonIslemTarihi = Convert.ToDateTime( dateEditTarih.EditValue);
            masalar.KullaniciId = KullaniciAyarlari.kullaniciId;
            masalar.RezerveMi = true;

            masalarDal.Save(context);
            islemyapildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}