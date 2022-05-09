using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Commentaire
    {
        public int IdCo { get; set; }
        public int IdHa { get; set; }
        public string Commentaire1 { get; set; }

        public virtual Hackathon IdHaNavigation { get; set; }
    }
}
