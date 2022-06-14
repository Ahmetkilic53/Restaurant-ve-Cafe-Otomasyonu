
namespace CafeOtomasyonu.WinForms.Urunler
{
    partial class frmUrunSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunSec));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1408, 46);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün Seçim Sayfası";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSec);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 565);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1408, 105);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnSec
            // 
            this.btnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSec.ImageOptions.SvgImage")));
            this.btnSec.Location = new System.Drawing.Point(1140, 31);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(128, 69);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(1274, 31);
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
            this.gridControl1.Size = new System.Drawing.Size(1408, 519);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMenuId,
            this.colUrunKodu,
            this.colUrunAdi,
            this.colBirimFiyati1,
            this.colBirimFiyati2,
            this.colBirimFiyati3,
            this.colAciklama,
            this.colTarih,
            this.colResim,
            this.colMenu,
            this.colMenuAdi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 43;
            // 
            // colMenuId
            // 
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.MinWidth = 25;
            this.colMenuId.Name = "colMenuId";
            this.colMenuId.Width = 94;
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.Caption = "Ürün Kodu";
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.MinWidth = 25;
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 2;
            this.colUrunKodu.Width = 137;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.MinWidth = 25;
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 3;
            this.colUrunAdi.Width = 134;
            // 
            // colBirimFiyati1
            // 
            this.colBirimFiyati1.FieldName = "BirimFiyati1";
            this.colBirimFiyati1.MinWidth = 25;
            this.colBirimFiyati1.Name = "colBirimFiyati1";
            this.colBirimFiyati1.Visible = true;
            this.colBirimFiyati1.VisibleIndex = 4;
            this.colBirimFiyati1.Width = 87;
            // 
            // colBirimFiyati2
            // 
            this.colBirimFiyati2.FieldName = "BirimFiyati2";
            this.colBirimFiyati2.MinWidth = 25;
            this.colBirimFiyati2.Name = "colBirimFiyati2";
            this.colBirimFiyati2.Visible = true;
            this.colBirimFiyati2.VisibleIndex = 5;
            this.colBirimFiyati2.Width = 81;
            // 
            // colBirimFiyati3
            // 
            this.colBirimFiyati3.FieldName = "BirimFiyati3";
            this.colBirimFiyati3.MinWidth = 25;
            this.colBirimFiyati3.Name = "colBirimFiyati3";
            this.colBirimFiyati3.Visible = true;
            this.colBirimFiyati3.VisibleIndex = 6;
            this.colBirimFiyati3.Width = 84;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 348;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 8;
            this.colTarih.Width = 91;
            // 
            // colResim
            // 
            this.colResim.FieldName = "Resim";
            this.colResim.MinWidth = 25;
            this.colResim.Name = "colResim";
            this.colResim.Width = 124;
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "Menu.MenuAdi";
            this.colMenu.MinWidth = 25;
            this.colMenu.Name = "colMenu";
            this.colMenu.Width = 94;
            // 
            // colMenuAdi
            // 
            this.colMenuAdi.Caption = "Menü";
            this.colMenuAdi.FieldName = "Menu.MenuAdi";
            this.colMenuAdi.MinWidth = 25;
            this.colMenuAdi.Name = "colMenuAdi";
            this.colMenuAdi.Visible = true;
            this.colMenuAdi.VisibleIndex = 1;
            this.colMenuAdi.Width = 137;
            // 
            // frmUrunSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 670);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmUrunSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Seçim Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
    }
}