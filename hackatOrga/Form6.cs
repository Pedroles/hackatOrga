using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hackatOrga.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Globalization;
using System.Net.Mail;
using System.Net;
namespace hackatOrga
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bdpbaudoin6Context cnx = new bdpbaudoin6Context();
            cbx_hackat.DataSource = cnx.Hackathons.OrderBy(ev => ev.IdH).ToList();
            cbx_hackat.DisplayMember = "theme";
            cbx_hackat.ValueMember = "IdH";
            /*pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "nohadenid@gmail.com",
                    Password = "a"
                }
            };
            MailAddress FromEmail = new MailAddress("nohadenid@gmail.com");
            MailAddress ToEmail = new MailAddress("pierreb18800@gmail.com");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "test",
                Body = "test",
            };
            Message.To.Add(ToEmail);

            try
            {
                client.Send(Message);
                MessageBox.Show("Bien envoyé");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quelque chose ne marche pas \n" + ex.InnerException.Message, "Erreur");
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_hackat_SelectedIndexChanged(object sender, EventArgs e)
        {
            bdpbaudoin6Context cnx = new bdpbaudoin6Context();
            Hackathon unHackat = (Hackathon)cbx_hackat.SelectedItem;
            cbx_events.DataSource = cnx.Evenements.OrderBy(ev => ev.IdEvent).Where(ev => ev.Type == "conference").Where(ev => ev.IdHackat == unHackat.IdH).ToList();
            cbx_events.DisplayMember = "libelleE";
            cbx_events.ValueMember = "idEvent";

            Evenement unEvent = (Evenement)cbx_events.SelectedItem;
            if (unEvent is null)
            {
                lbl_theme.Text = "______";
                lbl_lieu.Text = "______";
                lbl_date.Text = "______";
                lbl_heure.Text = "______";
                lbl_salle.Text = "______";
                lbl_placeholder.Text = "Ce hackathon ne contient pas de conférence, veuillez en choisir un autre.";
            }
            else
            {
                lbl_lieu.Text = unHackat.Rue + " " + unHackat.CodePostal + " " + unHackat.Ville;
                lbl_date.Text = unEvent.DateE.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); //Affichage de la date au format jj/mm/aaaa
                lbl_heure.Text = unEvent.HeureE.ToString();
                lbl_salle.Text = unEvent.SalleE.ToString();
                lbl_theme.Text = unEvent.ThemeE.ToString();
                lbl_placeholder.Text = "";
            }
            
        }

        private void btn_intervenant_Click(object sender, EventArgs e)
        {

        }
    }
}
