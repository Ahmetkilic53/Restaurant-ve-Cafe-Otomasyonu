
namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    partial class frmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGirisi));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSifremiUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.lblKaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.checkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureEdit1.Location = new System.Drawing.Point(-11, 162);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(537, 160);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSifremiUnuttum);
            this.groupControl1.Controls.Add(this.btnGirisYap);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 312);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(509, 108);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSifremiUnuttum.ImageOptions.Image")));
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(136, 38);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(150, 56);
            this.btnSifremiUnuttum.TabIndex = 4;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGirisYap.ImageOptions.SvgImage")));
            this.btnGirisYap.Location = new System.Drawing.Point(12, 38);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(118, 56);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(380, 38);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(117, 56);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.EditValue = "";
            this.txtKullaniciAdi.Location = new System.Drawing.Point(54, 55);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.SvgImage")));
            this.txtKullaniciAdi.Properties.NullText = "Kullanıcı Adınızı Giriniz";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(398, 44);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // txtParola
            // 
            this.txtParola.EditValue = "";
            this.txtParola.Location = new System.Drawing.Point(54, 105);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.Options.UseBackColor = true;
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtParola.Properties.ContextImageOptions.SvgImage")));
            this.txtParola.Properties.NullText = "Parolanızı Giriniz";
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(398, 44);
            this.txtParola.TabIndex = 6;
            this.txtParola.EditValueChanged += new System.EventHandler(this.txtParola_EditValueChanged);
            // 
            // lblKaydol
            // 
            this.lblKaydol.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydol.Appearance.Options.UseFont = true;
            this.lblKaydol.Location = new System.Drawing.Point(392, 155);
            this.lblKaydol.Name = "lblKaydol";
            this.lblKaydol.Size = new System.Drawing.Size(60, 24);
            this.lblKaydol.TabIndex = 7;
            this.lblKaydol.Text = "Kaydol";
            this.lblKaydol.Click += new System.EventHandler(this.lblKaydol_Click);
            // 
            // checkBeniHatirla
            // 
            this.checkBeniHatirla.Location = new System.Drawing.Point(54, 160);
            this.checkBeniHatirla.Name = "checkBeniHatirla";
            this.checkBeniHatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBeniHatirla.Properties.Appearance.Options.UseFont = true;
            this.checkBeniHatirla.Properties.Caption = "Beni Hatırla";
            this.checkBeniHatirla.Size = new System.Drawing.Size(170, 25);
            this.checkBeniHatirla.TabIndex = 8;
            this.checkBeniHatirla.CheckedChanged += new System.EventHandler(this.checkBeniHatirla_CheckedChanged);
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
            this.labelControl1.Size = new System.Drawing.Size(509, 46);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Kullanıcı Girişi";
            // 
            // frmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 420);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.checkBeniHatirla);
            this.Controls.Add(this.lblKaydol);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKullaniciGirisi_FormClosing);
            this.Load += new System.EventHandler(this.frmKullaniciGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSifremiUnuttum;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblKaydol;
        private DevExpress.XtraEditors.CheckEdit checkBeniHatirla;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}