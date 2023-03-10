using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicariOtomasyon
{
    public partial class FrmBankalar : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmBankalar()
        {
            InitializeComponent();
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            BankaListesi();
            SehirListesi();
            Temizle();
            FirmaListesi();
        }

        void BankaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void FirmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,AD FROM TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            LueFirma.Properties.ValueMember = "ID";
            LueFirma.Properties.DisplayMember = "AD";
            LueFirma.Properties.DataSource = dt;
        }

        void Temizle()
        {
            Txtid.Text = "";
            TxtBankaAd.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            TxtSube.Text = "";
            MskIban.Text = "";
            MskHesapNo.Text = "";
            TxtYetkili.Text = "";
            MskTelefon.Text = "";
            MskTarih.Text = "";
            TxtHesapTuru.Text = "";
            LueFirma.Text = "";
        }
        void SehirListesi()
        {
            //şehirlerin sql den çekilip listelenmesi
            SqlCommand komut = new SqlCommand("SELECT SehirAdi FROM TBL_SEHIRLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Banka kaydetme 
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_BANKALAR" +
                "(BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) VALUES" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@p2", CmbIl.Text);
            komut.Parameters.AddWithValue("@p3", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p4", TxtSube.Text);
            komut.Parameters.AddWithValue("@p5", MskIban.Text);
            komut.Parameters.AddWithValue("@p6", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", LueFirma.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka kaydı başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BankaListesi();
            Temizle();
        }

        private void CmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçili ile göre ilçenin gelmesi
            CmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT IlceAdi FROM TBL_ILCELER WHERE SehirId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Bankaların butonlarda listelenmesi
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtBankaAd.Text = dr["BANKAADI"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtSube.Text = dr["SUBE"].ToString();
                MskIban.Text = dr["IBAN"].ToString();
                MskHesapNo.Text = dr["HESAPNO"].ToString();
                TxtYetkili.Text = dr["YETKILI"].ToString();
                MskTelefon.Text = dr["TELEFON"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapTuru.Text = dr["HESAPTURU"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Banka kaydı silme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Banka Kaydını Sileceksiniz. Emin Misiniz?", "Banka Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_BANKALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Banka kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BankaListesi();
                Temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Banka güncelleme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Banka kaydını güncellemek istediğinize emin misiniz?", "Banka Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_BANKALAR SET " +
                "BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9," +
                "HESAPTURU=@p10,FIRMAID=@p11 WHERE ID=@p12",
                bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtBankaAd.Text);
                komut.Parameters.AddWithValue("@p2", CmbIl.Text);
                komut.Parameters.AddWithValue("@p3", CmbIlce.Text);
                komut.Parameters.AddWithValue("@p4", TxtSube.Text);
                komut.Parameters.AddWithValue("@p5", MskIban.Text);
                komut.Parameters.AddWithValue("@p6", MskHesapNo.Text);
                komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p9", MskTarih.Text);
                komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
                komut.Parameters.AddWithValue("@p11", LueFirma.EditValue);
                komut.Parameters.AddWithValue("@p12", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Banka kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BankaListesi();
                Temizle();
            }
        }
    }
}
 