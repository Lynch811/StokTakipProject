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
    public partial class Giris : Form
    {
        public string yetki;
        public int intyetki;
        public string Kullanici;

        SqlBaglanti bgl = new SqlBaglanti();
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            
            this.Opacity = 90;

        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }


        #region TXT

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (bunifuCheckbox1.Checked)
            {
                //karakteri göster.
                TxtSifre.isPassword = false;
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                TxtSifre.isPassword = true;
            }
        }
        private void TxtKadi_Enter(object sender, EventArgs e)
        {
            if (TxtKadi.Text == "Kullanıcı Adı")
                TxtKadi.Text = "";
        }

        private void TxtKadi_Leave(object sender, EventArgs e)
        {
            if (TxtKadi.Text == "")
                TxtKadi.Text = "Kullanıcı Adı";
        }

        private void TxtSifre_Enter(object sender, EventArgs e)
        {
            if (TxtSifre.Text == "Şifre")
                TxtSifre.Text = "";
        }

        private void TxtSifre_Leave(object sender, EventArgs e)
        {
            if (TxtSifre.Text == "")
                TxtSifre.Text = "Şifre";
        }

        #endregion

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Uygulamayı kapatmak üzeresin!", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }

                
        }

        bool move;
        int mause_x;
        int mause_y;
        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mause_x = e.X;
            mause_y = e.Y;
        }

        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
            if (move==true)
            {
                this.SetDesktopLocation(MousePosition.X - mause_x, MousePosition.Y - mause_y);
            }
        }

        private void Giris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string user = TxtKadi.Text;
            string pass = TxtSifre.Text;
            SqlCommand cmd = new SqlCommand("SELECT KULLANICIADI,SIFRE,YETKI FROM TBL_ADMIN", bgl.baglanti());
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kullanici = (dr["KULLANICIADI"].ToString());
                string Sifre = (dr["SIFRE"].ToString());
                yetki = (dr["YETKI"].ToString());
                if (user == Kullanici && pass == Sifre)
                {
                    intyetki = Int32.Parse(yetki);
                    AnaSayfa fr = new AnaSayfa();
                    fr.kullanici = TxtKadi.Text;
                    fr.FormClosed += new FormClosedEventHandler(FrmAnaSayfa_FormClosed);
                    fr.Show();
                    this.Hide();
                }

            }




            //SqlCommand komut = new SqlCommand("SELECT * FROM TBL_ADMIN WHERE KULLANICIADI=@p1 AND SIFRE=@p2", bgl.baglanti());
            //komut.Parameters.AddWithValue("@p1", TxtKadi.Text);
            //komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            //SqlDataReader dr = komut.ExecuteReader();
            //if (dr.Read())
            //{
            //    AnaSayfa fr = new AnaSayfa();
            //    fr.FormClosed += new FormClosedEventHandler(FrmAnaSayfa_FormClosed);
            //    fr.Show();
            //    this.Hide();

            //}
            //else
            //{
            //    MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            //bgl.baglanti().Close();



        }
        void FrmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

            private void TxtSifre_OnValueChanged(object sender, EventArgs e)
        {
          
            //checkBox işaretli ise
            if (bunifuCheckbox1.Checked)
            {
                //karakteri göster.
                TxtSifre.isPassword = false;
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                TxtSifre.isPassword = true;
            }
        }

        
    }
}
