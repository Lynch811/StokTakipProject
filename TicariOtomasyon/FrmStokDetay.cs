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
    public partial class FrmStokDetay : Form
    {
        public string ad;
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmStokDetay()
        {
            InitializeComponent();
        }
       
        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_URUNLER WHERE URUNAD='" + ad + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
