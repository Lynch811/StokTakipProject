using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class FrmAnaSayfa : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        //FrmUrunler frUrun;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frUrun == null)
            //{
            //    frUrun = new FrmUrunler();
            //    frUrun.MdiParent = this;
            //    frUrun.Show();
            //}
        }
        //FrmMusteriler frMusteri;
        //private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frMusteri == null)
        //    {   
        //        frMusteri = new FrmMusteriler();
        //        frMusteri.MdiParent = this;
        //        frMusteri.Show();
        //    }
        //}
        //FrmFirmalar frFirma;
        //private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frFirma == null)
        //    {
        //        frFirma = new FrmFirmalar();
        //        frFirma.MdiParent = this;
        //        frFirma.Show();
        //    }
        //}
        //FrmPersonel frPersonel;
        //private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frPersonel == null)
        //    {
        //        frPersonel = new FrmPersonel();
        //        frPersonel.MdiParent = this;
        //        frPersonel.Show();
        //    }
        //}
        //FrmRehber frRehber;
        //private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frRehber == null)
        //    {
        //        frRehber = new FrmRehber();
        //        frRehber.MdiParent = this;
        //        frRehber.Show();
        //    }
        //}
        //FrmGiderler frGiderler;
        //private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frGiderler == null)
        //    {
        //        frGiderler = new FrmGiderler();
        //        frGiderler.MdiParent = this;
        //        frGiderler.Show();
        //    }
        //}
        //FrmBankalar frBankalar;
        //private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frBankalar == null)
        //    {
        //        frBankalar = new FrmBankalar();
        //        frBankalar.MdiParent = this;
        //        frBankalar.Show();
        //    }
        //}
        //FrmFaturalar frFaturalar;
        //private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frFaturalar == null)
        //    {
        //        frFaturalar = new FrmFaturalar();
        //        frFaturalar.MdiParent = this;
        //        frFaturalar.Show();
        //    }
        //}
        //FrmNotlar frNotlar;
        //private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frNotlar == null)
        //    {
        //        frNotlar = new FrmNotlar();
        //        frNotlar.MdiParent = this;
        //        frNotlar.Show();
        //    }
        //}

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        //FrmHareketler frHareket;
        //private void BtnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frHareket == null)
        //    {
        //        frHareket = new FrmHareketler();
        //        frHareket.MdiParent = this;
        //        frHareket.Show();
        //    }
        //}
        //FrmRaporlar frRapor;
        //private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frRapor == null)
        //    {
        //        frRapor = new FrmRaporlar();
        //        frRapor.MdiParent = this;
        //        frRapor.Show();
        //    }
        //}
        //FrmStoklar frStok;
        //private void BtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frStok == null)
        //    {
        //        frStok = new FrmStoklar();
        //        frStok.MdiParent = this;
        //        frStok.Show();
        //    }
        //}
        //FrmAyarlar frAyar;
        //private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (frAyar == null)
        //    {
        //        frAyar = new FrmAyarlar();
        //        frAyar.MdiParent = this;
        //        frAyar.Show();
        //    }
        //}

        //--------------------------------------------------------------------------------------------
        FrmUrunler frUrun;
        private void Btn_Urunler_Click(object sender, EventArgs e)
        {
            if (frUrun == null)
            {
                frUrun = new FrmUrunler();
                frUrun.MdiParent = this;
                frUrun.Show();
            }
        }
        FrmStoklar frStok;
        private void Btn_Stoklar_Click(object sender, EventArgs e)
        {
            if (frStok == null)
            {
                frStok = new FrmStoklar();
                frStok.MdiParent = this;
                frStok.Show();
            }
        }
        FrmMusteriler frMusteri;
        private void Btn_Musteriler_Click(object sender, EventArgs e)
        {
            if (frMusteri == null)
            {
                frMusteri = new FrmMusteriler();
                frMusteri.MdiParent = this;
                frMusteri.Show();
            }
        }
        FrmFirmalar frFirma;
        private void Btn_Firmalar_Click(object sender, EventArgs e)
        {
            if (frFirma == null)
            {
                frFirma = new FrmFirmalar();
                frFirma.MdiParent = this;
                frFirma.Show();
            }
        }
        FrmPersonel frPersonel;
        private void Btn_Personel_Click(object sender, EventArgs e)
        {
            if (frPersonel == null)
            {
                frPersonel = new FrmPersonel();
                frPersonel.MdiParent = this;
                frPersonel.Show();
            }
        }
        FrmGiderler frGiderler;
        private void Btn_Giderler_Click(object sender, EventArgs e)
        {
            if (frGiderler == null)
            {
                frGiderler = new FrmGiderler();
                frGiderler.MdiParent = this;
                frGiderler.Show();
            }
        }

        private void Btn_Kasa_Click(object sender, EventArgs e)
        {

        }
        FrmNotlar frNotlar;
        private void Btn_Notlar_Click(object sender, EventArgs e)
        {
            if (frNotlar == null)
            {
                frNotlar = new FrmNotlar();
                frNotlar.MdiParent = this;
                frNotlar.Show();
            }
        }
        FrmBankalar frBankalar;
        private void Btn_Banka_Click(object sender, EventArgs e)
        {
            if (frBankalar == null)
            {
                frBankalar = new FrmBankalar();
                frBankalar.MdiParent = this;
                frBankalar.Show();
            }
        }
        FrmRehber frRehber;
        private void Btn_Rehber_Click(object sender, EventArgs e)
        {
            if (frRehber == null)
            {
                frRehber = new FrmRehber();
                frRehber.MdiParent = this;
                frRehber.Show();
            }
        }
        FrmFaturalar frFaturalar;
        private void Btn_Fatura_Click(object sender, EventArgs e)
        {
            if (frFaturalar == null)
            {
                frFaturalar = new FrmFaturalar();
                frFaturalar.MdiParent = this;
                frFaturalar.Show();
            }
        }
        FrmHareketler frHareket;
        private void Btn_Hareket_Click(object sender, EventArgs e)
        {
            if (frHareket == null)
            {
                frHareket = new FrmHareketler();
                frHareket.MdiParent = this;
                frHareket.Show();
            }
        }
        FrmRaporlar frRapor;
        private void Btn_Rapor_Click(object sender, EventArgs e)
        {
            if (frRapor == null)
            {
                frRapor = new FrmRaporlar();
                frRapor.MdiParent = this;
                frRapor.Show();
            }
        }
        Ayarlar frAyar1;
        private void Btn_Ayar_Click(object sender, EventArgs e)
        {
            if (frAyar1 == null)
            {
                frAyar1 = new Ayarlar();
                frAyar1.MdiParent = this;
                frAyar1.Show();
            }
        }

        
    }
}
