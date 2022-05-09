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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
            cbx_coms.DataSource = cnx.Hackathons.OrderBy(ev => ev.IdH).ToList();
            cbx_coms.DisplayMember = "theme";
            cbx_coms.ValueMember = "IdH";
        }

       private void cbx_coms_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
            Hackathon unHackat = (Hackathon)cbx_coms.SelectedItem;
            cbx_events.DataSource = cnx.Evenements.OrderBy(ev => ev.IdEvent).Where(ev => ev.Type == "initiation").Where(ev => ev.IdHackat == unHackat.IdH).ToList();
            cbx_events.DisplayMember = "libelleE";
            cbx_events.ValueMember = "idEvent";
            Evenement unEvent = (Evenement)cbx_events.SelectedItem;
            lbl_lieu.Text = unHackat.Rue + " " + unHackat.CodePostal + " " + unHackat.Ville;
            lbl_ddebut.Text = unEvent.DateE.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); //Affichage de la date au format jj/mm/aaaa
            lbl_h.Text = unEvent.HeureE.ToString();     
            double inscrits = cnx.Inscriptionevents.Where(a => a.IdEvent == unEvent.IdEvent).Count();
            lbl_nbinscrits.Text = inscrits.ToString();
            double places = (int)unEvent.NbParticipants;
            lbl_places.Text = places.ToString();
            double chiffre = inscrits / places;
            if (chiffre >= 0.7 && chiffre <= 1.0)
            {
                lbl_stat.Text = "Très attractif";
            }
            else if (chiffre >= 0.5 && chiffre < 0.7)
            {
                lbl_stat.Text = "Attractif";
            }
            else if (chiffre >= 0.3 && chiffre < 0.5)
            {
                lbl_stat.Text = "Peu attractif";

            }
            else
            {
                lbl_stat.Text = "Pas attractif";
            }
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbx_events_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbaudoin_hackatonContext cnx = new pbaudoin_hackatonContext();
            Hackathon unHackat = (Hackathon)cbx_coms.SelectedItem;
            Evenement unEvent = (Evenement)cbx_events.SelectedItem;
            lbl_lieu.Text = unHackat.Rue + " " + unHackat.CodePostal + " " + unHackat.Ville;
            lbl_ddebut.Text = unEvent.DateE.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); //Affichage de la date au format jj/mm/aaaa
            lbl_h.Text = unEvent.HeureE.ToString();
            double inscrits = cnx.Inscriptionevents.Where(a => a.IdEvent == unEvent.IdEvent).Count();
            lbl_nbinscrits.Text = inscrits.ToString();
            double places = (int)unEvent.NbParticipants;
            lbl_places.Text = places.ToString();
            double chiffre = inscrits / places;
            if (chiffre >= 0.7 && chiffre <= 1.0)
            {
                lbl_stat.Text = "Très attractif";
            }
            else if (chiffre >= 0.5 && chiffre < 0.7)
            {
                lbl_stat.Text = "Attractif";
            }
            else if (chiffre >= 0.3 && chiffre < 0.5)
            {
                lbl_stat.Text = "Peu attractif";

            }
            else
            {
                lbl_stat.Text = "Pas attractif";
            }

        }
    }
}
    


        
