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
    public partial class FrmNotlar : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmNotlar()
        {
            InitializeComponent();
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            NotListele();
            Temizle();
        }

        void NotListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_NOTLAR",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Temizle()
        {
            Txtid.Text = "";
            TxtBaslik.Text = "";
            TxtDetay.Text = "";
            TxtHitap.Text = "";
            TxtOlusturan.Text = "";
            TxtSaat.Text = "";
            TxtTarih.Text = "";
          
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Not kaydetme 
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_NOTLAR" +
                "(TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) VALUES" +
                "(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtTarih.Text);
            komut.Parameters.AddWithValue("@p2", TxtSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", TxtDetay.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Notunuz başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NotListele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Notların butonlarda listelenmesi
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtTarih.Text = dr["TARIH"].ToString();
                TxtSaat.EditValue = dr["SAAT"].ToString();
                TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
                TxtHitap.Text = dr["HITAP"].ToString();
                TxtBaslik.Text = dr["BASLIK"].ToString();
                TxtDetay.Text = dr["DETAY"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Not kaydı silme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Not Kaydını Sileceksiniz. Emin Misiniz?", "Not Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From TBL_NOTLAR where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not kaydı başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NotListele();
                Temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Not güncelleme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Not kaydını güncellemek istediğinize emin misiniz?", "Not Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("UPDATE TBL_NOTLAR SET " +
                "TARIH=@p1,SAAT=@p2,BASLIK=@p3,DETAY=@p4,OLUSTURAN=@p5,HITAP=@p6 WHERE ID=@p7", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtTarih.Text);
                komut.Parameters.AddWithValue("@p2", TxtSaat.Text);
                komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
                komut.Parameters.AddWithValue("@p4", TxtDetay.Text);
                komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
                komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
                komut.Parameters.AddWithValue("@p7", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotListele();
                Temizle();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.metin = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
