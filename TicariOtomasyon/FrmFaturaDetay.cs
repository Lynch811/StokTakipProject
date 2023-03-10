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
    public partial class FrmFaturaDetay : Form
    {
        public string id;
        SqlBaglanti bgl = new SqlBaglanti();
        public FrmFaturaDetay()
        {
            InitializeComponent();
        }

        private void FrmFaturaDetay_Load(object sender, EventArgs e)
        {
            FaturaDetayListeleme();
        }

        void FaturaDetayListeleme()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_FATURADETAY WHERE FATURAID='" + id + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaDetayDuzenleme fr = new FrmFaturaDetayDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.duzenlemeid = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
        }
    }
}
