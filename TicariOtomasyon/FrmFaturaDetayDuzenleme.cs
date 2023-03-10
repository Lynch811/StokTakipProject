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
    public partial class FrmFaturaDetayDuzenleme : Form
    {
        public string duzenlemeid;
        SqlBaglanti bgl = new SqlBaglanti();

        public FrmFaturaDetayDuzenleme()
        {
            InitializeComponent();
        }

        private void FrmFaturaDetayDuzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunID.Text = duzenlemeid;

            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_FATURADETAY WHERE FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", duzenlemeid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAd.Text = dr["URUNAD"].ToString();
                TxtMiktar.Text = dr["MIKTAR"].ToString();
                TxtFiyat.Text = dr["FIYAT"].ToString();
                TxtTutar.Text = dr["TUTAR"].ToString();
                bgl.baglanti().Close();

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Fatura kaydı silme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Fatura ürün Kaydını Sileceksiniz. Emin Misiniz?", "Fatura Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura ürün kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(TxtFiyat.Text);
            miktar = Convert.ToDouble(TxtMiktar.Text);
            tutar = miktar * fiyat;
            TxtTutar.Text = tutar.ToString();

            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Fatura ürün kaydını güncellemek istediğinize emin misiniz?", "Fatura Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_FATURADETAY SET " +
                "URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 WHERE FATURAURUNID=@p5", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtMiktar.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut.Parameters.AddWithValue("@p5", TxtUrunID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura ürün kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
    }
}
