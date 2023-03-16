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
    public partial class FrmHareketler : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmHareketler()
        {
            InitializeComponent();
        }

        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            FirmaHareketiListeleme();
            MusteriHareketiListeleme();
        }

        void FirmaHareketiListeleme()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec FirmaHareketler",bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        void MusteriHareketiListeleme()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec MusteriHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
