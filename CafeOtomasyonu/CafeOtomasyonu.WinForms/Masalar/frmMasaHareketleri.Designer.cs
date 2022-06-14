
namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaHareketleri));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnYenileListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(1459, 46);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Hareket Durumu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnYenileListele);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 642);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1459, 105);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnYenileListele
            // 
            this.btnYenileListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenileListele.ImageOptions.SvgImage")));
            this.btnYenileListele.Location = new System.Drawing.Point(12, 31);
            this.btnYenileListele.Name = "btnYenileListele";
            this.btnYenileListele.Size = new System.Drawing.Size(128, 69);
            this.btnYenileListele.TabIndex = 3;
            this.btnYenileListele.Text = "Yenile-Listele";
            this.btnYenileListele.Click += new System.EventHandler(this.btnYenileListele_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(1325, 31);
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
            this.gridControl1.Size = new System.Drawing.Size(1459, 596);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.colUrunAdi,
            this.colMenuAdi,
            this.colMasaAdi,
            this.colMasaId,
            this.colUrunId,
            this.colMiktari,
            this.colBirimFiyati,
            this.colindirimTutari,
            this.colAciklama,
            this.colTarih,
            this.colMasalar,
            this.colUrun});
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
            this.colId.Width = 59;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.MinWidth = 25;
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            this.colSatisKodu.Width = 80;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "Urun.UrunAdi";
            this.colUrunAdi.MinWidth = 25;
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 4;
            this.colUrunAdi.Width = 201;
            // 
            // colMenuAdi
            // 
            this.colMenuAdi.Caption = "Menü";
            this.colMenuAdi.FieldName = "Urun.Menu.MenuAdi";
            this.colMenuAdi.MinWidth = 25;
            this.colMenuAdi.Name = "colMenuAdi";
            this.colMenuAdi.Visible = true;
            this.colMenuAdi.VisibleIndex = 3;
            this.colMenuAdi.Width = 187;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa Adı";
            this.colMasaAdi.FieldName = "Masalar.MasaAdi";
            this.colMasaAdi.MinWidth = 25;
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 2;
            this.colMasaAdi.Width = 130;
            // 
            // colMasaId
            // 
            this.colMasaId.FieldName = "MasaId";
            this.colMasaId.MinWidth = 25;
            this.colMasaId.Name = "colMasaId";
            this.colMasaId.Width = 94;
            // 
            // colUrunId
            // 
            this.colUrunId.FieldName = "UrunId";
            this.colUrunId.MinWidth = 25;
            this.colUrunId.Name = "colUrunId";
            this.colUrunId.Width = 94;
            // 
            // colMiktari
            // 
            this.colMiktari.FieldName = "Miktari";
            this.colMiktari.MinWidth = 25;
            this.colMiktari.Name = "colMiktari";
            this.colMiktari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktari", "SUM={0:0.##}")});
            this.colMiktari.Visible = true;
            this.colMiktari.VisibleIndex = 5;
            this.colMiktari.Width = 106;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.MinWidth = 25;
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 6;
            this.colBirimFiyati.Width = 95;
            // 
            // colindirimTutari
            // 
            this.colindirimTutari.DisplayFormat.FormatString = "C2";
            this.colindirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colindirimTutari.FieldName = "indirimTutari";
            this.colindirimTutari.MinWidth = 25;
            this.colindirimTutari.Name = "colindirimTutari";
            this.colindirimTutari.Visible = true;
            this.colindirimTutari.VisibleIndex = 7;
            this.colindirimTutari.Width = 100;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 357;
            // 
            // colTarih
            // 
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 9;
            this.colTarih.Width = 114;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.MinWidth = 25;
            this.colMasalar.Name = "colMasalar";
            this.colMasalar.Width = 94;
            // 
            // colUrun
            // 
            this.colUrun.FieldName = "Urun";
            this.colUrun.MinWidth = 25;
            this.colUrun.Name = "colUrun";
            this.colUrun.Width = 94;
            // 
            // frmMasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 747);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmMasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenileListele;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colindirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
    }
}