
namespace TicariOtomasyon
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.Btn_AnaSayfa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Urunler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Stoklar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Musteriler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Firmalar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Personel = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Giderler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Kasa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Notlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Banka = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Rehber = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Fatura = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Hareket = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Rapor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Btn_Ayar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Btn_AnaSayfa,
            this.Btn_Urunler,
            this.Btn_Stoklar,
            this.Btn_Musteriler,
            this.Btn_Firmalar,
            this.Btn_Personel,
            this.Btn_Giderler,
            this.Btn_Kasa,
            this.Btn_Notlar,
            this.Btn_Banka,
            this.Btn_Rehber,
            this.Btn_Fatura,
            this.Btn_Hareket,
            this.Btn_Rapor,
            this.Btn_Ayar});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(98, 852);
            this.accordionControl1.TabIndex = 3;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // Btn_AnaSayfa
            // 
            this.Btn_AnaSayfa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_AnaSayfa.ImageOptions.SvgImage")));
            this.Btn_AnaSayfa.Name = "Btn_AnaSayfa";
            this.Btn_AnaSayfa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_AnaSayfa.Text = "Ana Sayfa";
            // 
            // Btn_Urunler
            // 
            this.Btn_Urunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Urunler.ImageOptions.SvgImage")));
            this.Btn_Urunler.Name = "Btn_Urunler";
            this.Btn_Urunler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Urunler.Text = "Ürünler";
            this.Btn_Urunler.Click += new System.EventHandler(this.Btn_Urunler_Click);
            // 
            // Btn_Stoklar
            // 
            this.Btn_Stoklar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Stoklar.ImageOptions.SvgImage")));
            this.Btn_Stoklar.Name = "Btn_Stoklar";
            this.Btn_Stoklar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Stoklar.Text = "Stoklar";
            this.Btn_Stoklar.Click += new System.EventHandler(this.Btn_Stoklar_Click);
            // 
            // Btn_Musteriler
            // 
            this.Btn_Musteriler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Musteriler.ImageOptions.SvgImage")));
            this.Btn_Musteriler.Name = "Btn_Musteriler";
            this.Btn_Musteriler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Musteriler.Text = "Müşteriler";
            this.Btn_Musteriler.Click += new System.EventHandler(this.Btn_Musteriler_Click);
            // 
            // Btn_Firmalar
            // 
            this.Btn_Firmalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Firmalar.ImageOptions.SvgImage")));
            this.Btn_Firmalar.Name = "Btn_Firmalar";
            this.Btn_Firmalar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Firmalar.Text = "Firmalar";
            this.Btn_Firmalar.Click += new System.EventHandler(this.Btn_Firmalar_Click);
            // 
            // Btn_Personel
            // 
            this.Btn_Personel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Personel.ImageOptions.SvgImage")));
            this.Btn_Personel.Name = "Btn_Personel";
            this.Btn_Personel.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Personel.Text = "Personel";
            this.Btn_Personel.Click += new System.EventHandler(this.Btn_Personel_Click);
            // 
            // Btn_Giderler
            // 
            this.Btn_Giderler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Giderler.ImageOptions.SvgImage")));
            this.Btn_Giderler.Name = "Btn_Giderler";
            this.Btn_Giderler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Giderler.Text = "Giderler";
            this.Btn_Giderler.Click += new System.EventHandler(this.Btn_Giderler_Click);
            // 
            // Btn_Kasa
            // 
            this.Btn_Kasa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Kasa.ImageOptions.SvgImage")));
            this.Btn_Kasa.Name = "Btn_Kasa";
            this.Btn_Kasa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Kasa.Text = "Kasa";
            this.Btn_Kasa.Click += new System.EventHandler(this.Btn_Kasa_Click);
            // 
            // Btn_Notlar
            // 
            this.Btn_Notlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Notlar.ImageOptions.SvgImage")));
            this.Btn_Notlar.Name = "Btn_Notlar";
            this.Btn_Notlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Notlar.Text = "Notlar";
            this.Btn_Notlar.Click += new System.EventHandler(this.Btn_Notlar_Click);
            // 
            // Btn_Banka
            // 
            this.Btn_Banka.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Banka.ImageOptions.SvgImage")));
            this.Btn_Banka.Name = "Btn_Banka";
            this.Btn_Banka.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Banka.Text = "Bankalar";
            this.Btn_Banka.Click += new System.EventHandler(this.Btn_Banka_Click);
            // 
            // Btn_Rehber
            // 
            this.Btn_Rehber.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Rehber.ImageOptions.SvgImage")));
            this.Btn_Rehber.Name = "Btn_Rehber";
            this.Btn_Rehber.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Rehber.Text = "Rehber";
            this.Btn_Rehber.Click += new System.EventHandler(this.Btn_Rehber_Click);
            // 
            // Btn_Fatura
            // 
            this.Btn_Fatura.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Fatura.ImageOptions.SvgImage")));
            this.Btn_Fatura.Name = "Btn_Fatura";
            this.Btn_Fatura.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Fatura.Text = "Fatura";
            this.Btn_Fatura.Click += new System.EventHandler(this.Btn_Fatura_Click);
            // 
            // Btn_Hareket
            // 
            this.Btn_Hareket.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Hareket.ImageOptions.SvgImage")));
            this.Btn_Hareket.Name = "Btn_Hareket";
            this.Btn_Hareket.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Hareket.Text = "Hareketler";
            this.Btn_Hareket.Click += new System.EventHandler(this.Btn_Hareket_Click);
            // 
            // Btn_Rapor
            // 
            this.Btn_Rapor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Rapor.ImageOptions.SvgImage")));
            this.Btn_Rapor.Name = "Btn_Rapor";
            this.Btn_Rapor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Rapor.Text = "Raporlar";
            this.Btn_Rapor.Click += new System.EventHandler(this.Btn_Rapor_Click);
            // 
            // Btn_Ayar
            // 
            this.Btn_Ayar.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.Btn_Ayar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_Ayar.ImageOptions.SvgImage")));
            this.Btn_Ayar.Name = "Btn_Ayar";
            this.Btn_Ayar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Btn_Ayar.Text = "Ayarlar";
            this.Btn_Ayar.Click += new System.EventHandler(this.Btn_Ayar_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1918, 31);
            this.fluentDesignFormControl1.TabIndex = 4;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // FrmAnaSayfa
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 883);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAnaSayfa";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_AnaSayfa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Urunler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Stoklar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Musteriler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Firmalar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Personel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Giderler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Kasa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Notlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Banka;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Rehber;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Fatura;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Hareket;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Rapor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btn_Ayar;
    }
}

