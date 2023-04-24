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
    public partial class FrmAyarlar : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmAyarlar()
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
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            AdminListesi();
        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_ADMIN VALUES (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKadi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Admin başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AdminListesi();
            
        }
    }
}
