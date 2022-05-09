using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace hackatOrga.Models
{
    public partial class bdpbaudoin6Context : DbContext
    {
        public bdpbaudoin6Context()
        {
        }

        public bdpbaudoin6Context(DbContextOptions<bdpbaudoin6Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Commentaire> Commentaires { get; set; }
        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; }
        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<Hackathon> Hackathons { get; set; }
        public virtual DbSet<Inscription> Inscriptions { get; set; }
        public virtual DbSet<Inscriptionevent> Inscriptionevents { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=192.168.4.1;port=3306;user=sqlpbaudoin;password=savary;database=bdpbaudoin6;sslmode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commentaire>(entity =>
            {
                entity.HasKey(e => e.IdCo)
                    .HasName("PRIMARY");

                entity.ToTable("commentaires");

                entity.HasIndex(e => e.IdHa, "indexHa");

                entity.Property(e => e.IdCo)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCo");

                entity.Property(e => e.Commentaire1)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("commentaire");

                entity.Property(e => e.IdHa)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHa");

                entity.HasOne(d => d.IdHaNavigation)
                    .WithMany(p => p.Commentaires)
                    .HasForeignKey(d => d.IdHa)
                    .HasConstraintName("commentaires_ibfk_1");
            });

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");

                entity.ToTable("doctrine_migration_versions");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version");

                entity.Property(e => e.ExecutedAt)
                    .HasColumnName("executed_at")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("execution_time")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("PRIMARY");

                entity.ToTable("evenement");

                entity.HasIndex(e => e.IdHackat, "crtx");

                entity.Property(e => e.IdEvent)
                    .HasColumnType("int(11)")
                    .HasColumnName("idEvent");

                entity.Property(e => e.DateE)
                    .HasColumnType("date")
                    .HasColumnName("dateE");

                entity.Property(e => e.DureeE).HasColumnName("dureeE");

                entity.Property(e => e.HeureE).HasColumnName("heureE");

                entity.Property(e => e.IdHackat)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackat")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LibelleE)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("libelleE");

                entity.Property(e => e.MailIntervenant)
                    .HasMaxLength(128)
                    .HasColumnName("mailIntervenant")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NbParticipants)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbParticipants")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NomIntervenant)
                    .HasMaxLength(128)
                    .HasColumnName("nomIntervenant")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrenomIntervenant)
                    .HasMaxLength(128)
                    .HasColumnName("prenomIntervenant")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SalleE)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("salleE");

                entity.Property(e => e.ThemeE)
                    .HasMaxLength(128)
                    .HasColumnName("themeE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdHackatNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdHackat)
                    .HasConstraintName("crtx");
            });

            modelBuilder.Entity<Hackathon>(entity =>
            {
                entity.HasKey(e => e.IdH)
                    .HasName("PRIMARY");

                entity.ToTable("hackathon");

                entity.Property(e => e.IdH)
                    .HasColumnType("int(11)")
                    .HasColumnName("idH");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(5)
                    .HasColumnName("codePostal")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.DateDebut)
                    .HasColumnType("date")
                    .HasColumnName("dateDebut");

                entity.Property(e => e.DateFin)
                    .HasColumnType("date")
                    .HasColumnName("dateFin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateLimite)
                    .HasColumnType("date")
                    .HasColumnName("dateLimite")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("heureDebut")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureFin)
                    .HasColumnName("heureFin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("image");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasColumnName("lieu")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NbPlaces)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbPlaces")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasColumnName("rue")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => e.IdI)
                    .HasName("PRIMARY");

                entity.ToTable("inscription");

                entity.HasIndex(e => e.IdHackathon, "idH");

                entity.HasIndex(e => e.IdParticipant, "idP");

                entity.Property(e => e.IdI)
                    .HasColumnType("int(10)")
                    .HasColumnName("idI");

                entity.Property(e => e.DateInscription)
                    .HasColumnType("date")
                    .HasColumnName("dateInscription")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackathon");

                entity.Property(e => e.IdParticipant)
                    .HasColumnType("int(11)")
                    .HasColumnName("idParticipant")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Texte)
                    .HasMaxLength(256)
                    .HasColumnName("texte")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdHackathon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inscription_ibfk_1");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdParticipant)
                    .HasConstraintName("inscription_ibfk_2");
            });

            modelBuilder.Entity<Inscriptionevent>(entity =>
            {
                entity.HasKey(e => e.IdIevent)
                    .HasName("PRIMARY");

                entity.ToTable("inscriptionevent");

                entity.HasIndex(e => e.IdEvent, "contrainte");

                entity.Property(e => e.IdIevent)
                    .HasColumnType("int(11)")
                    .HasColumnName("idIEvent");

                entity.Property(e => e.IdEvent)
                    .HasColumnType("int(11)")
                    .HasColumnName("idEvent");

                entity.Property(e => e.MailIevent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mailIEvent");

                entity.Property(e => e.NomIevent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nomIEvent");

                entity.Property(e => e.PrenomIevent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prenomIEvent");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.Inscriptionevents)
                    .HasForeignKey(d => d.IdEvent)
                    .HasConstraintName("inscriptionevent_ibfk_1");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PRIMARY");

                entity.ToTable("participant");

                entity.Property(e => e.IdP)
                    .HasColumnType("int(10)")
                    .HasColumnName("idP");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("cp");

                entity.Property(e => e.DateNaiss)
                    .HasColumnType("date")
                    .HasColumnName("dateNaiss");

                entity.Property(e => e.Login)
                    .HasMaxLength(30)
                    .HasColumnName("login")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("mail");

                entity.Property(e => e.MdpHash)
                    .HasMaxLength(128)
                    .HasColumnName("mdpHash")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("nom");

                entity.Property(e => e.NumTel)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("numTel");

                entity.Property(e => e.Portfolio)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("portfolio");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("prenom");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("roles")
                    .HasComment("(DC2Type:json)");

                entity.Property(e => e.Rue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rue");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ville");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
