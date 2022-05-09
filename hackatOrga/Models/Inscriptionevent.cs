using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Inscriptionevent
    {
        public int IdIevent { get; set; }
        public int IdEvent { get; set; }
        public string NomIevent { get; set; }
        public string PrenomIevent { get; set; }
        public string MailIevent { get; set; }

        public virtual Evenement IdEventNavigation { get; set; }
    }
}
