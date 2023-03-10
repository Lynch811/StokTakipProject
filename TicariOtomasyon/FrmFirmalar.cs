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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void FirmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            TxtAd.Text = "";
            Txtid.Text = "";
            TxtKod1.Text = "";
            TxtKod2.Text = "";
            TxtKod3.Text = "";
            TxtMail.Text = "";
            TxtSektor.Text = "";
            TxtVergidaire.Text = "";
            TxtYetkili.Text = "";
            TxtYetkiliGorev.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            MskFax.Text = "";
            MskYetkiliTc.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            MskTelefon3.Text = "";
            RchAdres.Text = "";
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
        void CariKodAciklamalar()
        {
            SqlCommand komut = new SqlCommand("SELECT FIRMAKOD1 FROM TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RchKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            Temizle();
            SehirListesi();
            CariKodAciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //firmaların butonlarda listelenmesi
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();
                TxtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                TxtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                MskYetkiliTc.Text = dr["YETKILITC"].ToString();
                MskTelefon1.Text = dr["TELEFON1"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTelefon3.Text = dr["TELEFON3"].ToString();
                MskFax.Text = dr["FAX"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                TxtVergidaire.Text = dr["VERGIDAIRE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtKod1.Text = dr["OZELKOD1"].ToString();
                TxtKod2.Text = dr["OZELKOD2"].ToString();
                TxtKod3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //firma kaydetme 
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_FIRMALAR" +
                "(AD,SEKTOR,YETKILIADSOYAD,YETKILISTATU,YETKILITC,TELEFON1,TELEFON2,TELEFON3,FAX,MAIL,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) VALUES" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", TxtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p5", MskYetkiliTc.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", MskFax.Text);
            komut.Parameters.AddWithValue("@p10", TxtMail.Text);
            komut.Parameters.AddWithValue("@p11", CmbIl.Text);
            komut.Parameters.AddWithValue("@p12", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", TxtVergidaire.Text);
            komut.Parameters.AddWithValue("@p14", RchAdres.Text);
            komut.Parameters.AddWithValue("@p15", TxtKod1.Text);
            komut.Parameters.AddWithValue("@p16", TxtKod2.Text);
            komut.Parameters.AddWithValue("@p17", TxtKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FirmaListesi();
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Firma silme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Firma Kaydını Sileceksiniz. Emin Misiniz?", "Firma Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FIRMALAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Firma kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                FirmaListesi();
                Temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Firma güncelleme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Firma kaydını güncellemek istediğinize emin misiniz?", "Firma Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_FIRMALAR SET " +
                "AD=@p1,SEKTOR=@p2,YETKILIADSOYAD=@p3,YETKILISTATU=@p4,YETKILITC=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,FAX=@p9," +
                "MAIL=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 WHERE ID=@p18",
                bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSektor.Text);
                komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
                komut.Parameters.AddWithValue("@p4", TxtYetkiliGorev.Text);
                komut.Parameters.AddWithValue("@p5", MskYetkiliTc.Text);
                komut.Parameters.AddWithValue("@p6", MskTelefon1.Text);
                komut.Parameters.AddWithValue("@p7", MskTelefon2.Text);
                komut.Parameters.AddWithValue("@p8", MskTelefon3.Text);
                komut.Parameters.AddWithValue("@p9", MskFax.Text);
                komut.Parameters.AddWithValue("@p10", TxtMail.Text);
                komut.Parameters.AddWithValue("@p11", CmbIl.Text);
                komut.Parameters.AddWithValue("@p12", CmbIlce.Text);
                komut.Parameters.AddWithValue("@p13", TxtVergidaire.Text);
                komut.Parameters.AddWithValue("@p14", RchAdres.Text);
                komut.Parameters.AddWithValue("@p15", TxtKod1.Text);
                komut.Parameters.AddWithValue("@p16", TxtKod2.Text);
                komut.Parameters.AddWithValue("@p17", TxtKod3.Text);
                komut.Parameters.AddWithValue("@p18", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Firma kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirmaListesi();
                Temizle();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
