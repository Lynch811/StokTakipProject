
namespace TicariOtomasyon
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtHitap = new DevExpress.XtraEditors.TextEdit();
            this.TxtOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.TxtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.TxtSaat = new DevExpress.XtraEditors.TimeEdit();
            this.TxtTarih = new DevExpress.XtraEditors.DateEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtDetay = new System.Windows.Forms.RichTextBox();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 132);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 20);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Saat:";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(11, 336);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1356, 340);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(143, 4);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnTemizle.Size = new System.Drawing.Size(38, 45);
            this.BtnTemizle.TabIndex = 9;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(790, 45);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 20);
            this.labelControl7.TabIndex = 67;
            this.labelControl7.Text = "Detay:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(406, 51);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 20);
            this.labelControl6.TabIndex = 66;
            this.labelControl6.Text = "Başlık:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(413, 132);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 20);
            this.labelControl5.TabIndex = 63;
            this.labelControl5.Text = "Hitap:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(383, 91);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 20);
            this.labelControl4.TabIndex = 62;
            this.labelControl4.Text = "Oluşturan:";
            // 
            // TxtHitap
            // 
            this.TxtHitap.Location = new System.Drawing.Point(468, 129);
            this.TxtHitap.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHitap.Name = "TxtHitap";
            this.TxtHitap.Properties.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHitap.Properties.Appearance.Options.UseFont = true;
            this.TxtHitap.Properties.MaxLength = 50;
            this.TxtHitap.Size = new System.Drawing.Size(268, 26);
            this.TxtHitap.TabIndex = 5;
            // 
            // TxtOlusturan
            // 
            this.TxtOlusturan.Location = new System.Drawing.Point(468, 88);
            this.TxtOlusturan.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOlusturan.Name = "TxtOlusturan";
            this.TxtOlusturan.Properties.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOlusturan.Properties.Appearance.Options.UseFont = true;
            this.TxtOlusturan.Properties.MaxLength = 50;
            this.TxtOlusturan.Size = new System.Drawing.Size(268, 26);
            this.TxtOlusturan.TabIndex = 4;
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Location = new System.Drawing.Point(468, 48);
            this.TxtBaslik.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBaslik.Properties.Appearance.Options.UseFont = true;
            this.TxtBaslik.Properties.MaxLength = 50;
            this.TxtBaslik.Size = new System.Drawing.Size(268, 26);
            this.TxtBaslik.TabIndex = 3;
            // 
            // TxtSaat
            // 
            this.TxtSaat.EditValue = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.TxtSaat.Location = new System.Drawing.Point(80, 129);
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Properties.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSaat.Properties.Appearance.Options.UseFont = true;
            this.TxtSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtSaat.Properties.Mask.BeepOnError = true;
            this.TxtSaat.Properties.Mask.EditMask = "t";
            this.TxtSaat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.TxtSaat.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TxtSaat.Size = new System.Drawing.Size(268, 26);
            this.TxtSaat.TabIndex = 2;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = null;
            this.TxtTarih.Location = new System.Drawing.Point(83, 88);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Size = new System.Drawing.Size(268, 26);
            this.TxtTarih.TabIndex = 1;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(98, 4);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnGuncelle.Size = new System.Drawing.Size(41, 45);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(53, 4);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnSil.Size = new System.Drawing.Size(41, 45);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(4, 4);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnKaydet.Size = new System.Drawing.Size(45, 45);
            this.BtnKaydet.TabIndex = 7;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtDetay
            // 
            this.TxtDetay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDetay.Location = new System.Drawing.Point(846, 42);
            this.TxtDetay.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDetay.MaxLength = 500;
            this.TxtDetay.Name = "TxtDetay";
            this.TxtDetay.Size = new System.Drawing.Size(452, 153);
            this.TxtDetay.TabIndex = 6;
            this.TxtDetay.Text = "";
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Location = new System.Drawing.Point(83, 48);
            this.Txtid.Margin = new System.Windows.Forms.Padding(2);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Size = new System.Drawing.Size(268, 26);
            this.Txtid.TabIndex = 49;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 91);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 20);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Tarih:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 51);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 20);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "ID:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1355, 319);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "groupControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(15, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1324, 53);
            this.groupControl1.TabIndex = 68;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.TxtOlusturan);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.Txtid);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.TxtHitap);
            this.groupControl3.Controls.Add(this.TxtBaslik);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.TxtSaat);
            this.groupControl3.Controls.Add(this.TxtDetay);
            this.groupControl3.Controls.Add(this.TxtTarih);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(15, 88);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1324, 216);
            this.groupControl3.TabIndex = 69;
            this.groupControl3.Text = " ";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 687);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox TxtDetay;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TimeEdit TxtSaat;
        private DevExpress.XtraEditors.DateEdit TxtTarih;
        private DevExpress.XtraEditors.TextEdit TxtHitap;
        private DevExpress.XtraEditors.TextEdit TxtOlusturan;
        private DevExpress.XtraEditors.TextEdit TxtBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}