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
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public string kullanicirolu;
        public string kullanici;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
           
            Giris grs = (Giris)Application.OpenForms["Giris"];
            if (grs.intyetki == 0)
            {
            }
            if (grs.intyetki == 1)
            {
                Btn_Ayar.Visible = false;
            }
            if (grs.intyetki == 2)
            {
                Btn_Ayar.Visible = false;
                Btn_Kasa.Visible = false;
                Btn_Banka.Visible = false;
            }
            if (frAnasayfamodul == null)
            {
                frAnasayfamodul = new FrmAnaSayfaModul();
                frAnasayfamodul.MdiParent = this;
                frAnasayfamodul.Show();
            }

        }
        FrmUrunler frUrun;
        private void Btn_Urunler_Click_1(object sender, EventArgs e)
        {
            if (frUrun == null)
            {
                frUrun = new FrmUrunler();
                frUrun.MdiParent = this;
                frUrun.Show();
            }
        }
        FrmStoklar frStok;
        private void Btn_Stoklar_Click_1(object sender, EventArgs e)
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
        private void Btn_Firmalar_Click_1(object sender, EventArgs e)
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
        FrmKasa frKasa;
        private void Btn_Kasa_Click(object sender, EventArgs e)
        {
            if (frKasa == null)
            {
                frKasa = new FrmKasa();
                frKasa.ad = kullanici;
                frKasa.MdiParent = this;
                frKasa.Show();
            }
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
        Ayarlar frAyar;
        private void Btn_Ayar_Click(object sender, EventArgs e)
        {
            if (frAyar == null)
            {
                frAyar = new Ayarlar();
                frAyar.MdiParent = this;
                frAyar.Show();
            }
        }
        FrmAnaSayfaModul frAnasayfamodul;
        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            if (frAnasayfamodul == null)
            {
               frAnasayfamodul = new FrmAnaSayfaModul();
               frAnasayfamodul.MdiParent = this;
                frAnasayfamodul.Show();
            }
        }
    }
}
