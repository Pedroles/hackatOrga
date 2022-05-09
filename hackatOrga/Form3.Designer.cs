
namespace hackatOrga
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_rue = new System.Windows.Forms.Label();
            this.lbl_dateDebut = new System.Windows.Forms.Label();
            this.lbl_HeureDebut = new System.Windows.Forms.Label();
            this.lbl_dateFin = new System.Windows.Forms.Label();
            this.lbl_heureFin = new System.Windows.Forms.Label();
            this.lbl_lieu = new System.Windows.Forms.Label();
            this.lbl_image = new System.Windows.Forms.Label();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.lbl_dateLimite = new System.Windows.Forms.Label();
            this.lbl_nbPlaces = new System.Windows.Forms.Label();
            this.tbx_lieu = new System.Windows.Forms.TextBox();
            this.tbx_rue = new System.Windows.Forms.TextBox();
            this.tbx_ville = new System.Windows.Forms.TextBox();
            this.tbx_theme = new System.Windows.Forms.TextBox();
            this.tbx_nbPlaces = new System.Windows.Forms.TextBox();
            this.tbx_image = new System.Windows.Forms.TextBox();
            this.btn_CreerHackat = new System.Windows.Forms.Button();
            this.tbx_dateDebut = new System.Windows.Forms.MaskedTextBox();
            this.tbx_dateFin = new System.Windows.Forms.MaskedTextBox();
            this.tbx_heureFin = new System.Windows.Forms.MaskedTextBox();
            this.tbx_heureDebut = new System.Windows.Forms.MaskedTextBox();
            this.tbx_dateLimite = new System.Windows.Forms.MaskedTextBox();
            this.tbx_cp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_rue
            // 
            this.lbl_rue.AutoSize = true;
            this.lbl_rue.Location = new System.Drawing.Point(176, 220);
            this.lbl_rue.Name = "lbl_rue";
            this.lbl_rue.Size = new System.Drawing.Size(33, 15);
            this.lbl_rue.TabIndex = 0;
            this.lbl_rue.Text = "Rue :";
            this.lbl_rue.Click += new System.EventHandler(this.lbl_rue_Click);
            // 
            // lbl_dateDebut
            // 
            this.lbl_dateDebut.AutoSize = true;
            this.lbl_dateDebut.Location = new System.Drawing.Point(42, 75);
            this.lbl_dateDebut.Name = "lbl_dateDebut";
            this.lbl_dateDebut.Size = new System.Drawing.Size(167, 15);
            this.lbl_dateDebut.TabIndex = 1;
            this.lbl_dateDebut.Text = "Date de début (MM/JJ/AAAA):";
            // 
            // lbl_HeureDebut
            // 
            this.lbl_HeureDebut.AutoSize = true;
            this.lbl_HeureDebut.Location = new System.Drawing.Point(114, 104);
            this.lbl_HeureDebut.Name = "lbl_HeureDebut";
            this.lbl_HeureDebut.Size = new System.Drawing.Size(95, 15);
            this.lbl_HeureDebut.TabIndex = 2;
            this.lbl_HeureDebut.Text = "Heure de début :";
            // 
            // lbl_dateFin
            // 
            this.lbl_dateFin.AutoSize = true;
            this.lbl_dateFin.Location = new System.Drawing.Point(56, 133);
            this.lbl_dateFin.Name = "lbl_dateFin";
            this.lbl_dateFin.Size = new System.Drawing.Size(153, 15);
            this.lbl_dateFin.TabIndex = 3;
            this.lbl_dateFin.Text = "Date de fin (MM/JJ/AAAA) :";
            // 
            // lbl_heureFin
            // 
            this.lbl_heureFin.AutoSize = true;
            this.lbl_heureFin.Location = new System.Drawing.Point(131, 162);
            this.lbl_heureFin.Name = "lbl_heureFin";
            this.lbl_heureFin.Size = new System.Drawing.Size(78, 15);
            this.lbl_heureFin.TabIndex = 4;
            this.lbl_heureFin.Text = "Heure de fin :";
            // 
            // lbl_lieu
            // 
            this.lbl_lieu.AutoSize = true;
            this.lbl_lieu.Location = new System.Drawing.Point(174, 191);
            this.lbl_lieu.Name = "lbl_lieu";
            this.lbl_lieu.Size = new System.Drawing.Size(35, 15);
            this.lbl_lieu.TabIndex = 5;
            this.lbl_lieu.Text = "Lieu :";
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.Location = new System.Drawing.Point(472, 215);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(123, 15);
            this.lbl_image.TabIndex = 6;
            this.lbl_image.Text = "Image (Lien Internet) :";
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(560, 70);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(35, 15);
            this.lbl_ville.TabIndex = 7;
            this.lbl_ville.Text = "Ville :";
            // 
            // lbl_cp
            // 
            this.lbl_cp.AutoSize = true;
            this.lbl_cp.Location = new System.Drawing.Point(519, 99);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(76, 15);
            this.lbl_cp.TabIndex = 8;
            this.lbl_cp.Text = "Code postal :";
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.Location = new System.Drawing.Point(546, 133);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(49, 15);
            this.lbl_theme.TabIndex = 9;
            this.lbl_theme.Text = "Thème :";
            // 
            // lbl_dateLimite
            // 
            this.lbl_dateLimite.AutoSize = true;
            this.lbl_dateLimite.Location = new System.Drawing.Point(373, 160);
            this.lbl_dateLimite.Name = "lbl_dateLimite";
            this.lbl_dateLimite.Size = new System.Drawing.Size(222, 15);
            this.lbl_dateLimite.TabIndex = 10;
            this.lbl_dateLimite.Text = "Date limite d\'inscription (MM/JJ/AAAA) :";
            // 
            // lbl_nbPlaces
            // 
            this.lbl_nbPlaces.AutoSize = true;
            this.lbl_nbPlaces.Location = new System.Drawing.Point(481, 189);
            this.lbl_nbPlaces.Name = "lbl_nbPlaces";
            this.lbl_nbPlaces.Size = new System.Drawing.Size(114, 15);
            this.lbl_nbPlaces.TabIndex = 11;
            this.lbl_nbPlaces.Text = "Nombres de places :";
            // 
            // tbx_lieu
            // 
            this.tbx_lieu.Location = new System.Drawing.Point(229, 186);
            this.tbx_lieu.Name = "tbx_lieu";
            this.tbx_lieu.Size = new System.Drawing.Size(100, 23);
            this.tbx_lieu.TabIndex = 16;
            // 
            // tbx_rue
            // 
            this.tbx_rue.Location = new System.Drawing.Point(229, 215);
            this.tbx_rue.Name = "tbx_rue";
            this.tbx_rue.Size = new System.Drawing.Size(100, 23);
            this.tbx_rue.TabIndex = 17;
            // 
            // tbx_ville
            // 
            this.tbx_ville.Location = new System.Drawing.Point(614, 67);
            this.tbx_ville.Name = "tbx_ville";
            this.tbx_ville.Size = new System.Drawing.Size(100, 23);
            this.tbx_ville.TabIndex = 18;
            // 
            // tbx_theme
            // 
            this.tbx_theme.Location = new System.Drawing.Point(614, 125);
            this.tbx_theme.Name = "tbx_theme";
            this.tbx_theme.Size = new System.Drawing.Size(100, 23);
            this.tbx_theme.TabIndex = 20;
            // 
            // tbx_nbPlaces
            // 
            this.tbx_nbPlaces.Location = new System.Drawing.Point(614, 183);
            this.tbx_nbPlaces.Name = "tbx_nbPlaces";
            this.tbx_nbPlaces.Size = new System.Drawing.Size(100, 23);
            this.tbx_nbPlaces.TabIndex = 22;
            // 
            // tbx_image
            // 
            this.tbx_image.Location = new System.Drawing.Point(614, 212);
            this.tbx_image.Name = "tbx_image";
            this.tbx_image.Size = new System.Drawing.Size(261, 23);
            this.tbx_image.TabIndex = 23;
            // 
            // btn_CreerHackat
            // 
            this.btn_CreerHackat.Location = new System.Drawing.Point(325, 277);
            this.btn_CreerHackat.Name = "btn_CreerHackat";
            this.btn_CreerHackat.Size = new System.Drawing.Size(228, 31);
            this.btn_CreerHackat.TabIndex = 24;
            this.btn_CreerHackat.Text = "Créer le hackathon";
            this.btn_CreerHackat.UseVisualStyleBackColor = true;
            this.btn_CreerHackat.Click += new System.EventHandler(this.btn_CreerHackat_Click);
            // 
            // tbx_dateDebut
            // 
            this.tbx_dateDebut.Location = new System.Drawing.Point(229, 70);
            this.tbx_dateDebut.Mask = "00/00/0000";
            this.tbx_dateDebut.Name = "tbx_dateDebut";
            this.tbx_dateDebut.Size = new System.Drawing.Size(100, 23);
            this.tbx_dateDebut.TabIndex = 25;
            // 
            // tbx_dateFin
            // 
            this.tbx_dateFin.Location = new System.Drawing.Point(229, 128);
            this.tbx_dateFin.Mask = "00/00/0000";
            this.tbx_dateFin.Name = "tbx_dateFin";
            this.tbx_dateFin.Size = new System.Drawing.Size(100, 23);
            this.tbx_dateFin.TabIndex = 26;
            // 
            // tbx_heureFin
            // 
            this.tbx_heureFin.Location = new System.Drawing.Point(229, 157);
            this.tbx_heureFin.Mask = "00:00:00";
            this.tbx_heureFin.Name = "tbx_heureFin";
            this.tbx_heureFin.Size = new System.Drawing.Size(100, 23);
            this.tbx_heureFin.TabIndex = 27;
            // 
            // tbx_heureDebut
            // 
            this.tbx_heureDebut.Location = new System.Drawing.Point(229, 99);
            this.tbx_heureDebut.Mask = "00:00:00";
            this.tbx_heureDebut.Name = "tbx_heureDebut";
            this.tbx_heureDebut.Size = new System.Drawing.Size(100, 23);
            this.tbx_heureDebut.TabIndex = 28;
            // 
            // tbx_dateLimite
            // 
            this.tbx_dateLimite.Location = new System.Drawing.Point(614, 154);
            this.tbx_dateLimite.Mask = "00/00/0000";
            this.tbx_dateLimite.Name = "tbx_dateLimite";
            this.tbx_dateLimite.Size = new System.Drawing.Size(100, 23);
            this.tbx_dateLimite.TabIndex = 29;
            // 
            // tbx_cp
            // 
            this.tbx_cp.Location = new System.Drawing.Point(614, 96);
            this.tbx_cp.MaxLength = 5;
            this.tbx_cp.Name = "tbx_cp";
            this.tbx_cp.Size = new System.Drawing.Size(100, 23);
            this.tbx_cp.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 46);
            this.label1.TabIndex = 31;
            this.label1.Text = "Créer un nouvel hackathon :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_cp);
            this.Controls.Add(this.tbx_dateLimite);
            this.Controls.Add(this.tbx_heureDebut);
            this.Controls.Add(this.tbx_heureFin);
            this.Controls.Add(this.tbx_dateFin);
            this.Controls.Add(this.tbx_dateDebut);
            this.Controls.Add(this.btn_CreerHackat);
            this.Controls.Add(this.tbx_image);
            this.Controls.Add(this.tbx_nbPlaces);
            this.Controls.Add(this.tbx_theme);
            this.Controls.Add(this.tbx_ville);
            this.Controls.Add(this.tbx_rue);
            this.Controls.Add(this.tbx_lieu);
            this.Controls.Add(this.lbl_nbPlaces);
            this.Controls.Add(this.lbl_dateLimite);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.lbl_cp);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.lbl_lieu);
            this.Controls.Add(this.lbl_heureFin);
            this.Controls.Add(this.lbl_dateFin);
            this.Controls.Add(this.lbl_HeureDebut);
            this.Controls.Add(this.lbl_dateDebut);
            this.Controls.Add(this.lbl_rue);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rue;
        private System.Windows.Forms.Label lbl_dateDebut;
        private System.Windows.Forms.Label lbl_HeureDebut;
        private System.Windows.Forms.Label lbl_dateFin;
        private System.Windows.Forms.Label lbl_heureFin;
        private System.Windows.Forms.Label lbl_lieu;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.Label lbl_dateLimite;
        private System.Windows.Forms.Label lbl_nbPlaces;
        private System.Windows.Forms.TextBox tbx_lieu;
        private System.Windows.Forms.TextBox tbx_rue;
        private System.Windows.Forms.TextBox tbx_ville;
        private System.Windows.Forms.TextBox tbx_theme;
        private System.Windows.Forms.TextBox tbx_nbPlaces;
        private System.Windows.Forms.TextBox tbx_image;
        private System.Windows.Forms.Button btn_CreerHackat;
        private System.Windows.Forms.MaskedTextBox tbx_dateDebut;
        private System.Windows.Forms.MaskedTextBox tbx_dateFin;
        private System.Windows.Forms.MaskedTextBox tbx_heureFin;
        private System.Windows.Forms.MaskedTextBox tbx_heureDebut;
        private System.Windows.Forms.MaskedTextBox tbx_dateLimite;
        private System.Windows.Forms.TextBox tbx_cp;
        private System.Windows.Forms.Label label1;
    }
}