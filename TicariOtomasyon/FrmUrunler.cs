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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            MskYil.Text = "";
            NudAdet.Text = "";
            TxtAlis.Text = "";
            TxtSatis.Text = "";
            RchDetay.Text = "";
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //ürün kaydetme 
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //ürün silme 
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürün Kaydını Sileceksiniz. Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("DELETE FROM TBL_URUNLER WHERE ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //ürünelerin butonlarda listenlemesi 
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                TxtAd.Text = dr["URUNAD"].ToString();
                TxtMarka.Text = dr["MARKA"].ToString();
                TxtModel.Text = dr["MODEL"].ToString();
                MskYil.Text = dr["YIL"].ToString();
                NudAdet.Value = decimal.Parse(dr["ADET"].ToString());
                TxtAlis.Text = dr["ALISFIYAT"].ToString();
                TxtSatis.Text = dr["SATISFIYAT"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //ürün güncelleme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Ürünü güncellemek istediğinize emin misiniz?", "Ürün Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand(
                "UPDATE TBL_URUNLER SET URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4," +
                "ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 WHERE ID=@P9", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtAd.Text);
                komut.Parameters.AddWithValue("@P2", TxtMarka.Text);
                komut.Parameters.AddWithValue("@P3", TxtModel.Text);
                komut.Parameters.AddWithValue("@P4", MskYil.Text);
                komut.Parameters.AddWithValue("@P5", int.Parse((NudAdet.Value).ToString()));
                komut.Parameters.AddWithValue("@P6", decimal.Parse(TxtAlis.Text));
                komut.Parameters.AddWithValue("@P7", decimal.Parse(TxtSatis.Text));
                komut.Parameters.AddWithValue("@P8", RchDetay.Text);
                komut.Parameters.AddWithValue("@P9", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün başarılı bir şekilde güncellendi", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
            }

                
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}


//TBL_URUNLER yu = new TBL_URUNLER();
//yu.URUNAD = TxtAd.Text;
//yu.MARKA = TxtMarka.Text;
//yu.MODEL = TxtModel.Text;
//yu.YIL = MskYil.Text;
////yu.ADET = int.Parse((NudAdet.Value).ToString());
//yu.ALISFIYAT = decimal.Parse(TxtAlis.Text);
//yu.SATISFIYAT = decimal.Parse(TxtSatis.Text);
//yu.DETAY = RchDetay.Text;
//_ent.TBL_URUNLER.Add(yu);
//_ent.SaveChanges();
//MessageBox.Show("Ürün sisteme eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
//listele();


//DboTicariOtomasyonEntities1 _ent = new DboTicariOtomasyonEntities1();
//gridControl1.DataSource = _ent.TBL_URUNLER.ToList();