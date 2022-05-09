﻿using System;
using System.Collections.Generic;

#nullable disable

namespace hackatOrga.Models
{
    public partial class Hackathon
    {
        public Hackathon()
        {
            Commentaires = new HashSet<Commentaire>();
            Evenements = new HashSet<Evenement>();
            Inscriptions = new HashSet<Inscription>();
        }

        public int IdH { get; set; }
        public DateTime DateDebut { get; set; }
        public TimeSpan? HeureDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public TimeSpan? HeureFin { get; set; }
        public string Lieu { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Theme { get; set; }
        public DateTime? DateLimite { get; set; }
        public int? NbPlaces { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Commentaire> Commentaires { get; set; }
        public virtual ICollection<Evenement> Evenements { get; set; }
        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}
