
namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasaDurumlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaDurumlari));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnRezervEt = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenileListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
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
            this.labelControl1.Size = new System.Drawing.Size(1447, 46);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Masa Durumları";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnRezervEt);
            this.groupIslemler.Controls.Add(this.btnMasaAc);
            this.groupIslemler.Controls.Add(this.btnYenileListele);
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.btnSiparisEkle);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 665);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(1447, 105);
            this.groupIslemler.TabIndex = 5;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnRezervEt
            // 
            this.btnRezervEt.Enabled = false;
            this.btnRezervEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervEt.ImageOptions.Image")));
            this.btnRezervEt.Location = new System.Drawing.Point(288, 31);
            this.btnRezervEt.Name = "btnRezervEt";
            this.btnRezervEt.Size = new System.Drawing.Size(128, 69);
            this.btnRezervEt.TabIndex = 6;
            this.btnRezervEt.Text = "Rezerv Et";
            this.btnRezervEt.Click += new System.EventHandler(this.btnRezervEt_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Enabled = false;
            this.btnMasaAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaAc.ImageOptions.Image")));
            this.btnMasaAc.Location = new System.Drawing.Point(154, 31);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(128, 69);
            this.btnMasaAc.TabIndex = 5;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // btnYenileListele
            // 
            this.btnYenileListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenileListele.ImageOptions.SvgImage")));
            this.btnYenileListele.Location = new System.Drawing.Point(422, 31);
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
            this.btnKapat.Location = new System.Drawing.Point(1313, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(129, 69);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Enabled = false;
            this.btnSiparisEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisEkle.ImageOptions.SvgImage")));
            this.btnSiparisEkle.Location = new System.Drawing.Point(12, 31);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(136, 69);
            this.btnSiparisEkle.TabIndex = 0;
            this.btnSiparisEkle.Text = "Siparişler";
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1447, 619);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // frmMasaDurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1447, 770);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmMasaDurumlari";
            this.Text = "MasaDurumlari";
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnYenileListele;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSiparisEkle;
        private DevExpress.XtraEditors.SimpleButton btnRezervEt;
        private DevExpress.XtraEditors.SimpleButton btnMasaAc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}