﻿
namespace CafeOtomasyonu.WinForms.Odemeler
{
    partial class frmOdemeHareketleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeHareketleri));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnYenileListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1386, 46);
            this.lblBaslik.TabIndex = 10;
            this.lblBaslik.Text = "Ödeme Hareketleri";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnYenileListele);
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 608);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(1386, 105);
            this.groupIslemler.TabIndex = 11;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnYenileListele
            // 
            this.btnYenileListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenileListele.ImageOptions.SvgImage")));
            this.btnYenileListele.Location = new System.Drawing.Point(12, 31);
            this.btnYenileListele.Name = "btnYenileListele";
            this.btnYenileListele.Size = new System.Drawing.Size(128, 69);
            this.btnYenileListele.TabIndex = 5;
            this.btnYenileListele.Text = "Yenile-Listele";
            this.btnYenileListele.Click += new System.EventHandler(this.btnYenileListele_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(1252, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(129, 69);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1386, 562);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.colOdemeTuru,
            this.colOdenen,
            this.colAciklama,
            this.colTarih});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.Caption = "Satış Kodu";
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.MinWidth = 25;
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SatisKodu", "Satis : {0}")});
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            this.colSatisKodu.Width = 94;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.DisplayFormat.FormatString = "C2";
            this.colOdemeTuru.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdemeTuru.FieldName = "OdemeTuru";
            this.colOdemeTuru.MinWidth = 25;
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OdemeTuru", "{0:C2}")});
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 2;
            this.colOdemeTuru.Width = 94;
            // 
            // colOdenen
            // 
            this.colOdenen.DisplayFormat.FormatString = "C2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.MinWidth = 25;
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odenen", "{0:C2}")});
            this.colOdenen.Visible = true;
            this.colOdenen.VisibleIndex = 3;
            this.colOdenen.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 4;
            this.colAciklama.Width = 94;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            this.colTarih.Width = 94;
            // 
            // frmOdemeHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 713);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmOdemeHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraEditors.SimpleButton btnYenileListele;
    }
}