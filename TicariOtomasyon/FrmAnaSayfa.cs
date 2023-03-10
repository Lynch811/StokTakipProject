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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        FrmUrunler frUrun;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frUrun == null)
            {
                frUrun = new FrmUrunler();
                frUrun.MdiParent = this;
                frUrun.Show();
            }
        }
        FrmMusteriler frMusteri;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frMusteri == null)
            {   
                frMusteri = new FrmMusteriler();
                frMusteri.MdiParent = this;
                frMusteri.Show();
            }
        }
        FrmFirmalar frFirma;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFirma == null)
            {
                frFirma = new FrmFirmalar();
                frFirma.MdiParent = this;
                frFirma.Show();
            }
        }
        FrmPersonel frPersonel;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frPersonel == null)
            {
                frPersonel = new FrmPersonel();
                frPersonel.MdiParent = this;
                frPersonel.Show();
            }
        }
        FrmRehber frRehber;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frRehber == null)
            {
                frRehber = new FrmRehber();
                frRehber.MdiParent = this;
                frRehber.Show();
            }
        }
        FrmGiderler frGiderler;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frGiderler == null)
            {
                frGiderler = new FrmGiderler();
                frGiderler.MdiParent = this;
                frGiderler.Show();
            }
        }
        FrmBankalar frBankalar;
        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frBankalar == null)
            {
                frBankalar = new FrmBankalar();
                frBankalar.MdiParent = this;
                frBankalar.Show();
            }
        }
        FrmFaturalar frFaturalar;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFaturalar == null)
            {
                frFaturalar = new FrmFaturalar();
                frFaturalar.MdiParent = this;
                frFaturalar.Show();
            }
        }
        FrmNotlar frNotlar;
        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frNotlar == null)
            {
                frNotlar = new FrmNotlar();
                frNotlar.MdiParent = this;
                frNotlar.Show();
            }
        }
    }
}
