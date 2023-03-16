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
    public partial class FrmGiderler : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmGiderler()
        {
            InitializeComponent();
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            GiderListesi();
            Temizle();
        }
        void GiderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            Txtid.Text = "";
            CmbAy.Text = "";
            CmbYil.Text = "";
            TxtElektrik.Text = "";
            TxtSu.Text = "";
            TxtDogalgaz.Text = "";
            TxtInternet.Text = "";
            TxtMaas.Text = "";
            TxtExtra.Text = "";
            RchNotlar.Text = "";
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Gider Kaydı kaydetme 
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_GIDERLER" +
                "(AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EXSTRA,NOTLAR) VALUES" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            komut.Parameters.AddWithValue("@p2", CmbYil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaas.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtExtra.Text));
            komut.Parameters.AddWithValue("@p9", RchNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider kaydı başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GiderListesi();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Gider Kayıtlarının butonlarda listelenmesi
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null) { 
            Txtid.Text = dr["ID"].ToString();
            CmbAy.Text = dr["AY"].ToString();
            CmbYil.Text = dr["YIL"].ToString();
            TxtElektrik.Text = dr["ELEKTRIK"].ToString();
            TxtSu.Text = dr["SU"].ToString();
            TxtDogalgaz.Text = dr["DOGALGAZ"].ToString();
            TxtInternet.Text = dr["INTERNET"].ToString();
            TxtMaas.Text = dr["MAASLAR"].ToString();
            TxtExtra.Text = dr["EXSTRA"].ToString();
            RchNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Gider kaydı silme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Gider Kaydını Sileceksiniz. Emin Misiniz?", "Gider Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_GIDERLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Gider kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GiderListesi();
                Temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Gider kaydı güncelleme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Gider kaydını güncellemek istediğinize emin misiniz?", "Gider Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_GIDERLER SET " +
                "AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EXSTRA=@p8,NOTLAR=@p9 WHERE ID=@p10",
                bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", CmbAy.Text);
                komut.Parameters.AddWithValue("@p2", CmbYil.Text);
                komut.Parameters.AddWithValue("@p3", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p4", TxtSu.Text);
                komut.Parameters.AddWithValue("@p5", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p6", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p7", TxtMaas.Text);
                komut.Parameters.AddWithValue("@p8", TxtExtra.Text);
                komut.Parameters.AddWithValue("@p9", RchNotlar.Text);
                komut.Parameters.AddWithValue("@p10", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Gider kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GiderListesi();
                Temizle();
            }
        }
    }
}
