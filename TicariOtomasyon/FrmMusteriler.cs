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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
        void Temizle()
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            MskTc.Text = "";
            TxtVergidaire.Text = "";
            CmbIl.Text = "";
            CmbIlce.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            RchAdres.Text = "";
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
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
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            //müşteri kaydetme 
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_MUSTERILER" +
                "(AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) VALUES" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", MskTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", CmbIl.Text);
            komut.Parameters.AddWithValue("@p8", CmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", RchAdres.Text);
            komut.Parameters.AddWithValue("@p10", TxtVergidaire.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //müşterilerin butonlarda listelenmesi
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTc.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                CmbIl.Text = dr["IL"].ToString();
                CmbIlce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtVergidaire.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //müşteri silme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Müşteri Kaydını Sileceksiniz. Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_MUSTERILER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
                Temizle();
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //müşteri güncelleme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Müşteri kaydını güncellemek istediğinize emin misiniz?", "Müşteri Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_MUSTERILER SET " +
                "AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,VERGIDAIRE=@p9,ADRES=@p10 WHERE ID=@p11",
                bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
                komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
                komut.Parameters.AddWithValue("@p5", MskTc.Text);
                komut.Parameters.AddWithValue("@p6", TxtMail.Text);
                komut.Parameters.AddWithValue("@p7", CmbIl.Text);
                komut.Parameters.AddWithValue("@p8", CmbIlce.Text);
                komut.Parameters.AddWithValue("@p9", TxtVergidaire.Text);
                komut.Parameters.AddWithValue("@p10", RchAdres.Text);
                komut.Parameters.AddWithValue("@p11", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        
    }       
}
