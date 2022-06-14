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

namespace CafeOtomasyonu.WinForms.Odemeler
{
    public partial class frmOdemeHareketleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();

        public frmOdemeHareketleri(string satisKodu=null)
        {
            InitializeComponent();
            if (satisKodu==null)
            {
                gridControl1.DataSource = odemeHareketleriDal.GetAll(context);
            }

            else if (satisKodu!=null)
            {
                gridControl1.DataSource = odemeHareketleriDal.GetAll(context,o =>o.SatisKodu==satisKodu);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenileListele_Click(object sender, EventArgs e)
        {

        }
    }
}