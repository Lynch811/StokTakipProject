using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TicariOtomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string Mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            TxtMail.Text = Mail;
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //---------------------------------deneme 1-------------------------------
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("ta3171317@gmail.com", "Talha1324!");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(TxtMail.Text);
            mesajim.From = new MailAddress("ta3171317@gmail.com");
            mesajim.Subject = TxtKonu.Text;
            mesajim.Body = RchMesaj.Text;
            istemci.Send(mesajim);


            //-------------------deneme 2---------------------
            //MailMessage message = new MailMessage();

            //SmtpClient client = new SmtpClient();

            //client.Credentials = new System.Net.NetworkCredential("ta3171317@gmail.com", "Talha1324!");

            //client.Host = "smtp-mail.outlook.com";

            //client.Port = 587;

            //client.UseDefaultCredentials = false;

            //client.DeliveryMethod = SmtpDeliveryMethod.Network;

            //client.EnableSsl = true;

            //message.To.Add(TxtMail.Text);

            //message.From = new MailAddress("ta3171317@gmail.com");

            //message.Subject = TxtMail.Text;

            //message.Body = RchMesaj.Text;

            //client.Send(message);

            //MessageBox.Show("Mail Gönderildi");

            //-----------------------------deneme 3--------------------------------
            //using (MailMessage mail = new MailMessage())
            //{
            //    mail.From = new MailAddress("ta3171317@gmail.com");
            //    mail.To.Add(TxtMail.Text);
            //    mail.Subject = TxtKonu.Text;
            //    mail.Body = RchMesaj.Text;
            //    mail.IsBodyHtml = true;
            //    //mail.Attachments.Add(new Attachment("C:\\file.zip"));

            //    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            //    {
            //        smtp.Credentials = new NetworkCredential("ta3171317@gmail.com", "kujuqvkhrxycfcbd");
            //        smtp.EnableSsl = false;
            //        smtp.Send(mail);
            //    }
            //}

        }
    }
}
