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
    public partial class Ayarlar : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public Ayarlar()
        {
            InitializeComponent();
        }
        void AdminListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_ADMIN", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            TxtId.Text = "";
            TxtKadi.Text = "";
            TxtSifre.Text = "";
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            AdminListesi();
            Temizle();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //müşterilerin butonlarda listelenmesi
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtKadi.Text = dr["KULLANICIADI"].ToString();
                TxtSifre.Text = dr["SIFRE"].ToString();
            }
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_ADMIN VALUES (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKadi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Admin başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AdminListesi();
            Temizle();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Admin Kaydını Sileceksiniz. Emin Misiniz?", "Admin Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_ADMIN where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Admin kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminListesi();
                Temizle();
            }
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Admin kaydını güncellemek istediğinize emin misiniz?", "Admin Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_ADMIN SET KULLANICIADI=@p1,SIFRE=@p2 WHERE ID=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKadi.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.Parameters.AddWithValue("@p3", TxtId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Admin başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminListesi();
                Temizle();
            }
        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
