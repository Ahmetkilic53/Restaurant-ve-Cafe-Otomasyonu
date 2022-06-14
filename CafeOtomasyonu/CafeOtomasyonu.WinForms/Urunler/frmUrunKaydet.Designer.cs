
namespace CafeOtomasyonu.WinForms.Urunler
{
    partial class frmUrunKaydet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunKaydet));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.calcBirimFiyati1 = new DevExpress.XtraEditors.CalcEdit();
            this.calcBirimFiyati2 = new DevExpress.XtraEditors.CalcEdit();
            this.calcBirimFiyati3 = new DevExpress.XtraEditors.CalcEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lookUpMenu = new DevExpress.XtraEditors.LookUpEdit();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(783, 46);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün Kayıt";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 583);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(783, 105);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 31);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(122, 69);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(649, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(129, 69);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl2.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(52, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 28);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Menü :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl3.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(52, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 28);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ürün Kodu :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl4.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(52, 246);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(125, 28);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Birim Fiyatı 1 :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl5.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(52, 201);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(125, 28);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Ürün Adı :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl6.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(52, 292);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(125, 28);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Birim Fiyatı 2:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl7.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(52, 336);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(125, 28);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Birim Fiyatı 2 :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl8.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(52, 381);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(125, 110);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "Açıklama :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl9.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(52, 500);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(125, 28);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Tarih :";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(193, 155);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKodu.Properties.Appearance.Options.UseFont = true;
            this.txtUrunKodu.Size = new System.Drawing.Size(294, 30);
            this.txtUrunKodu.TabIndex = 13;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(193, 199);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Properties.Appearance.Options.UseFont = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(294, 30);
            this.txtUrunAdi.TabIndex = 14;
            // 
            // calcBirimFiyati1
            // 
            this.calcBirimFiyati1.Location = new System.Drawing.Point(193, 248);
            this.calcBirimFiyati1.Name = "calcBirimFiyati1";
            this.calcBirimFiyati1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcBirimFiyati1.Properties.Appearance.Options.UseFont = true;
            this.calcBirimFiyati1.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyati1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyati1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyati1.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyati1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyati1.Properties.NullText = "0,00";
            this.calcBirimFiyati1.Size = new System.Drawing.Size(294, 30);
            this.calcBirimFiyati1.TabIndex = 15;
            // 
            // calcBirimFiyati2
            // 
            this.calcBirimFiyati2.Location = new System.Drawing.Point(193, 290);
            this.calcBirimFiyati2.Name = "calcBirimFiyati2";
            this.calcBirimFiyati2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcBirimFiyati2.Properties.Appearance.Options.UseFont = true;
            this.calcBirimFiyati2.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyati2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyati2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyati2.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyati2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyati2.Properties.NullText = "0,00";
            this.calcBirimFiyati2.Size = new System.Drawing.Size(294, 30);
            this.calcBirimFiyati2.TabIndex = 16;
            // 
            // calcBirimFiyati3
            // 
            this.calcBirimFiyati3.Location = new System.Drawing.Point(193, 334);
            this.calcBirimFiyati3.Name = "calcBirimFiyati3";
            this.calcBirimFiyati3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcBirimFiyati3.Properties.Appearance.Options.UseFont = true;
            this.calcBirimFiyati3.Properties.Appearance.Options.UseTextOptions = true;
            this.calcBirimFiyati3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcBirimFiyati3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcBirimFiyati3.Properties.DisplayFormat.FormatString = "C2";
            this.calcBirimFiyati3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcBirimFiyati3.Properties.NullText = "0,00";
            this.calcBirimFiyati3.Size = new System.Drawing.Size(294, 30);
            this.calcBirimFiyati3.TabIndex = 17;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(193, 380);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(543, 111);
            this.txtAciklama.TabIndex = 18;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(193, 497);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(543, 30);
            this.dateEdit1.TabIndex = 19;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(493, 113);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.NullText = "Resim Seçilmedi";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(243, 250);
            this.pictureEdit1.TabIndex = 20;
            // 
            // lookUpMenu
            // 
            this.lookUpMenu.Location = new System.Drawing.Point(193, 113);
            this.lookUpMenu.Name = "lookUpMenu";
            this.lookUpMenu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpMenu.Properties.Appearance.Options.UseFont = true;
            this.lookUpMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMenu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuAdi", "Menü")});
            this.lookUpMenu.Properties.DataSource = this.menuBindingSource;
            this.lookUpMenu.Properties.DisplayMember = "MenuAdi";
            this.lookUpMenu.Properties.NullText = "Menü Seçiniz";
            this.lookUpMenu.Properties.NullValuePrompt = "Menü Seçiniz";
            this.lookUpMenu.Properties.ValueMember = "Id";
            this.lookUpMenu.Size = new System.Drawing.Size(294, 30);
            this.lookUpMenu.TabIndex = 21;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(CafeOtomasyonu.Entities.Models.Menu);
            // 
            // frmUrunKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 688);
            this.Controls.Add(this.lookUpMenu);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.calcBirimFiyati3);
            this.Controls.Add(this.calcBirimFiyati2);
            this.Controls.Add(this.calcBirimFiyati1);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmUrunKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kaydetme";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtUrunKodu;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati1;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati2;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati3;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpMenu;
        private System.Windows.Forms.BindingSource menuBindingSource;
    }
}