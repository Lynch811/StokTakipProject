
namespace TicariOtomasyon
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtKadi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1346, 54);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "groupControl1";
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
            this.BtnKaydet.Size = new System.Drawing.Size(44, 48);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click_1);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(52, 9);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnSil.Size = new System.Drawing.Size(39, 37);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(95, 4);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnGuncelle.Size = new System.Drawing.Size(42, 48);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click_1);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(141, 4);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnTemizle.Size = new System.Drawing.Size(40, 48);
            this.BtnTemizle.TabIndex = 18;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(177, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Location = new System.Drawing.Point(279, 45);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(345, 40);
            this.TxtId.TabIndex = 27;
            // 
            // TxtKadi
            // 
            this.TxtKadi.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKadi.Location = new System.Drawing.Point(279, 118);
            this.TxtKadi.Name = "TxtKadi";
            this.TxtKadi.Size = new System.Drawing.Size(345, 40);
            this.TxtKadi.TabIndex = 26;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(279, 187);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(345, 40);
            this.TxtSifre.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(872, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(12, 360);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1346, 316);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtId);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.pictureBox1);
            this.groupControl2.Controls.Add(this.TxtKadi);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.TxtSifre);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(12, 72);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1346, 283);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = " ";
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 687);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtKadi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}