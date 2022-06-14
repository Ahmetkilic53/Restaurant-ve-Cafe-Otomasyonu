
namespace CafeOtomasyonu.WinForms.Odemeler
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnOnay = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.calcOdenecekTutar = new DevExpress.XtraEditors.CalcEdit();
            this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenecekTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnOnay);
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 272);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(576, 105);
            this.groupIslemler.TabIndex = 7;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnOnay
            // 
            this.btnOnay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOnay.ImageOptions.SvgImage")));
            this.btnOnay.Location = new System.Drawing.Point(301, 31);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(135, 69);
            this.btnOnay.TabIndex = 4;
            this.btnOnay.Text = "Onay";
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(442, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(129, 69);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(576, 46);
            this.lblBaslik.TabIndex = 9;
            this.lblBaslik.Text = "Ödeme";
            // 
            // calcOdenecekTutar
            // 
            this.calcOdenecekTutar.Location = new System.Drawing.Point(197, 58);
            this.calcOdenecekTutar.Name = "calcOdenecekTutar";
            this.calcOdenecekTutar.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcOdenecekTutar.Properties.Appearance.BackColor2 = System.Drawing.Color.Green;
            this.calcOdenecekTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcOdenecekTutar.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseBackColor = true;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseFont = true;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseForeColor = true;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseTextOptions = true;
            this.calcOdenecekTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcOdenecekTutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcOdenecekTutar.Properties.Mask.EditMask = "c";
            this.calcOdenecekTutar.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.calcOdenecekTutar.Properties.NullText = "₺0,00 ";
            this.calcOdenecekTutar.Size = new System.Drawing.Size(321, 30);
            this.calcOdenecekTutar.TabIndex = 11;
            // 
            // dateEditTarih
            // 
            this.dateEditTarih.EditValue = null;
            this.dateEditTarih.Location = new System.Drawing.Point(197, 94);
            this.dateEditTarih.Name = "dateEditTarih";
            this.dateEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditTarih.Properties.Appearance.Options.UseFont = true;
            this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Size = new System.Drawing.Size(356, 28);
            this.dateEditTarih.TabIndex = 13;
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
            this.labelControl9.Location = new System.Drawing.Point(27, 94);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(163, 27);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Tarih :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(197, 127);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(356, 127);
            this.txtAciklama.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl10.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(27, 128);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(163, 126);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Açıklama :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AppearancePressed.BorderColor = System.Drawing.Color.DimGray;
            this.labelControl1.AppearancePressed.Options.UseBorderColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(27, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(163, 27);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Ödenecek Tutar :";
            // 
            // btn
            // 
            this.btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn.ImageOptions.SvgImage")));
            this.btn.Location = new System.Drawing.Point(517, 58);
            this.btn.Name = "btn";
            this.btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn.Size = new System.Drawing.Size(36, 29);
            this.btn.TabIndex = 18;
            this.btn.Text = "...";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 377);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.dateEditTarih);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.calcOdenecekTutar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.groupIslemler);
            this.Name = "frmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenecekTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnOnay;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.CalcEdit calcOdenecekTutar;
        private DevExpress.XtraEditors.DateEdit dateEditTarih;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn;
    }
}