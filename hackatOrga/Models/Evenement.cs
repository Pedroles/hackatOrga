using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Evenement
    {
        public Evenement()
        {
            Inscriptionevents = new HashSet<Inscriptionevent>();
        }

        public int IdEvent { get; set; }
        public string LibelleE { get; set; }
        public DateTime DateE { get; set; }
        public TimeSpan HeureE { get; set; }
        public TimeSpan DureeE { get; set; }
        public string SalleE { get; set; }
        public int? IdHackat { get; set; }
        public string Type { get; set; }
        public int? NbParticipants { get; set; }
        public string ThemeE { get; set; }
        public string NomIntervenant { get; set; }
        public string PrenomIntervenant { get; set; }
        public string MailIntervenant { get; set; }

        public virtual Hackathon IdHackatNavigation { get; set; }
        public virtual ICollection<Inscriptionevent> Inscriptionevents { get; set; }
    }
}
