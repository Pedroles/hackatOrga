
namespace hackatOrga
{
    partial class Form2
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
            this.lbl_libelle = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_heure = new System.Windows.Forms.Label();
            this.lbl_duree = new System.Windows.Forms.Label();
            this.lbl_salle = new System.Windows.Forms.Label();
            this.lbl_idH = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.tbx_libelle = new System.Windows.Forms.TextBox();
            this.tbx_salle = new System.Windows.Forms.TextBox();
            this.btn_creer = new System.Windows.Forms.Button();
            this.lbx_type = new System.Windows.Forms.ListBox();
            this.lbl_nbParticipants = new System.Windows.Forms.Label();
            this.lbl_themeE = new System.Windows.Forms.Label();
            this.lbl_intervenant = new System.Windows.Forms.Label();
            this.tbx_themeE = new System.Windows.Forms.TextBox();
            this.tbx_intervenant = new System.Windows.Forms.TextBox();
            this.tbx_date = new System.Windows.Forms.MaskedTextBox();
            this.tbx_heure = new System.Windows.Forms.MaskedTextBox();
            this.tbx_duree = new System.Windows.Forms.MaskedTextBox();
            this.cbx_idH = new System.Windows.Forms.ComboBox();
            this.tbx_nbParticipants = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_mail = new System.Windows.Forms.TextBox();
            this.tbx_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_libelle
            // 
            this.lbl_libelle.AutoSize = true;
            this.lbl_libelle.Location = new System.Drawing.Point(112, 84);
            this.lbl_libelle.Name = "lbl_libelle";
            this.lbl_libelle.Size = new System.Drawing.Size(47, 15);
            this.lbl_libelle.TabIndex = 0;
            this.lbl_libelle.Text = "Libellé :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(112, 118);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(120, 15);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date (MM/JJ/AAAA) :";
            // 
            // lbl_heure
            // 
            this.lbl_heure.AutoSize = true;
            this.lbl_heure.Location = new System.Drawing.Point(115, 150);
            this.lbl_heure.Name = "lbl_heure";
            this.lbl_heure.Size = new System.Drawing.Size(45, 15);
            this.lbl_heure.TabIndex = 2;
            this.lbl_heure.Text = "Heure :";
            // 
            // lbl_duree
            // 
            this.lbl_duree.AutoSize = true;
            this.lbl_duree.Location = new System.Drawing.Point(115, 179);
            this.lbl_duree.Name = "lbl_duree";
            this.lbl_duree.Size = new System.Drawing.Size(44, 15);
            this.lbl_duree.TabIndex = 3;
            this.lbl_duree.Text = "Durée :";
            // 
            // lbl_salle
            // 
            this.lbl_salle.AutoSize = true;
            this.lbl_salle.Location = new System.Drawing.Point(115, 203);
            this.lbl_salle.Name = "lbl_salle";
            this.lbl_salle.Size = new System.Drawing.Size(37, 15);
            this.lbl_salle.TabIndex = 4;
            this.lbl_salle.Text = "Salle :";
            // 
            // lbl_idH
            // 
            this.lbl_idH.AutoSize = true;
            this.lbl_idH.Location = new System.Drawing.Point(115, 232);
            this.lbl_idH.Name = "lbl_idH";
            this.lbl_idH.Size = new System.Drawing.Size(71, 15);
            this.lbl_idH.TabIndex = 5;
            this.lbl_idH.Text = "Hackathon :";
            this.lbl_idH.Click += new System.EventHandler(this.lbl_idH_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(115, 270);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(37, 15);
            this.lbl_type.TabIndex = 6;
            this.lbl_type.Text = "Type :";
            // 
            // tbx_libelle
            // 
            this.tbx_libelle.Location = new System.Drawing.Point(240, 84);
            this.tbx_libelle.Name = "tbx_libelle";
            this.tbx_libelle.Size = new System.Drawing.Size(100, 23);
            this.tbx_libelle.TabIndex = 7;
            this.tbx_libelle.TextChanged += new System.EventHandler(this.tbx_libelle_TextChanged);
            // 
            // tbx_salle
            // 
            this.tbx_salle.Location = new System.Drawing.Point(240, 200);
            this.tbx_salle.Name = "tbx_salle";
            this.tbx_salle.Size = new System.Drawing.Size(100, 23);
            this.tbx_salle.TabIndex = 11;
            this.tbx_salle.TextChanged += new System.EventHandler(this.tbx_salle_TextChanged);
            // 
            // btn_creer
            // 
            this.btn_creer.Enabled = false;
            this.btn_creer.Location = new System.Drawing.Point(507, 317);
            this.btn_creer.Name = "btn_creer";
            this.btn_creer.Size = new System.Drawing.Size(164, 58);
            this.btn_creer.TabIndex = 14;
            this.btn_creer.Text = "Créer le nouvel atelier";
            this.btn_creer.UseVisualStyleBackColor = true;
            this.btn_creer.Click += new System.EventHandler(this.btn_creer_Click);
            // 
            // lbx_type
            // 
            this.lbx_type.FormattingEnabled = true;
            this.lbx_type.ItemHeight = 15;
            this.lbx_type.Items.AddRange(new object[] {
            "initiation",
            "conference"});
            this.lbx_type.Location = new System.Drawing.Point(240, 261);
            this.lbx_type.Name = "lbx_type";
            this.lbx_type.Size = new System.Drawing.Size(125, 34);
            this.lbx_type.TabIndex = 15;
            this.lbx_type.SelectedIndexChanged += new System.EventHandler(this.lbx_type_SelectedIndexChanged);
            // 
            // lbl_nbParticipants
            // 
            this.lbl_nbParticipants.AutoSize = true;
            this.lbl_nbParticipants.Location = new System.Drawing.Point(483, 79);
            this.lbl_nbParticipants.Name = "lbl_nbParticipants";
            this.lbl_nbParticipants.Size = new System.Drawing.Size(138, 15);
            this.lbl_nbParticipants.TabIndex = 16;
            this.lbl_nbParticipants.Text = "Nombre de participants :";
            // 
            // lbl_themeE
            // 
            this.lbl_themeE.AutoSize = true;
            this.lbl_themeE.Location = new System.Drawing.Point(483, 108);
            this.lbl_themeE.Name = "lbl_themeE";
            this.lbl_themeE.Size = new System.Drawing.Size(133, 15);
            this.lbl_themeE.TabIndex = 17;
            this.lbl_themeE.Text = "Thème de l\'évènement :";
            // 
            // lbl_intervenant
            // 
            this.lbl_intervenant.AutoSize = true;
            this.lbl_intervenant.Location = new System.Drawing.Point(483, 137);
            this.lbl_intervenant.Name = "lbl_intervenant";
            this.lbl_intervenant.Size = new System.Drawing.Size(125, 15);
            this.lbl_intervenant.TabIndex = 18;
            this.lbl_intervenant.Text = "Nom de l\'intervenant :";
            this.lbl_intervenant.Click += new System.EventHandler(this.lbl_intervenant_Click);
            // 
            // tbx_themeE
            // 
            this.tbx_themeE.Enabled = false;
            this.tbx_themeE.Location = new System.Drawing.Point(640, 105);
            this.tbx_themeE.Name = "tbx_themeE";
            this.tbx_themeE.Size = new System.Drawing.Size(100, 23);
            this.tbx_themeE.TabIndex = 20;
            this.tbx_themeE.TextChanged += new System.EventHandler(this.tbx_themeE_TextChanged);
            // 
            // tbx_intervenant
            // 
            this.tbx_intervenant.Enabled = false;
            this.tbx_intervenant.Location = new System.Drawing.Point(640, 134);
            this.tbx_intervenant.Name = "tbx_intervenant";
            this.tbx_intervenant.Size = new System.Drawing.Size(100, 23);
            this.tbx_intervenant.TabIndex = 21;
            this.tbx_intervenant.TextChanged += new System.EventHandler(this.tbx_intervenant_TextChanged);
            // 
            // tbx_date
            // 
            this.tbx_date.Location = new System.Drawing.Point(240, 113);
            this.tbx_date.Mask = "00/00/0000";
            this.tbx_date.Name = "tbx_date";
            this.tbx_date.Size = new System.Drawing.Size(100, 23);
            this.tbx_date.TabIndex = 22;
            this.tbx_date.ValidatingType = typeof(System.DateTime);
            this.tbx_date.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbx_date_MaskInputRejected);
            // 
            // tbx_heure
            // 
            this.tbx_heure.Location = new System.Drawing.Point(240, 142);
            this.tbx_heure.Mask = "00:00:00";
            this.tbx_heure.Name = "tbx_heure";
            this.tbx_heure.Size = new System.Drawing.Size(100, 23);
            this.tbx_heure.TabIndex = 23;
            this.tbx_heure.ValidatingType = typeof(System.DateTime);
            // 
            // tbx_duree
            // 
            this.tbx_duree.Location = new System.Drawing.Point(240, 171);
            this.tbx_duree.Mask = "00:00:00";
            this.tbx_duree.Name = "tbx_duree";
            this.tbx_duree.Size = new System.Drawing.Size(100, 23);
            this.tbx_duree.TabIndex = 24;
            this.tbx_duree.ValidatingType = typeof(System.DateTime);
            // 
            // cbx_idH
            // 
            this.cbx_idH.FormattingEnabled = true;
            this.cbx_idH.Location = new System.Drawing.Point(240, 229);
            this.cbx_idH.Name = "cbx_idH";
            this.cbx_idH.Size = new System.Drawing.Size(207, 23);
            this.cbx_idH.TabIndex = 25;
            this.cbx_idH.SelectedIndexChanged += new System.EventHandler(this.cbx_idH_SelectedIndexChanged);
            // 
            // tbx_nbParticipants
            // 
            this.tbx_nbParticipants.Location = new System.Drawing.Point(640, 76);
            this.tbx_nbParticipants.Mask = "999";
            this.tbx_nbParticipants.Name = "tbx_nbParticipants";
            this.tbx_nbParticipants.Size = new System.Drawing.Size(100, 23);
            this.tbx_nbParticipants.TabIndex = 26;
            this.tbx_nbParticipants.ValidatingType = typeof(int);
            this.tbx_nbParticipants.TextChanged += new System.EventHandler(this.tbx_nbParticipants_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mail de l\'intervenant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Prénom de l\'intervenant :";
            // 
            // tbx_mail
            // 
            this.tbx_mail.Enabled = false;
            this.tbx_mail.Location = new System.Drawing.Point(640, 192);
            this.tbx_mail.Name = "tbx_mail";
            this.tbx_mail.Size = new System.Drawing.Size(100, 23);
            this.tbx_mail.TabIndex = 29;
            // 
            // tbx_prenom
            // 
            this.tbx_prenom.Enabled = false;
            this.tbx_prenom.Location = new System.Drawing.Point(640, 163);
            this.tbx_prenom.Name = "tbx_prenom";
            this.tbx_prenom.Size = new System.Drawing.Size(100, 23);
            this.tbx_prenom.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 46);
            this.label3.TabIndex = 31;
            this.label3.Text = "Créer un évènement :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_prenom);
            this.Controls.Add(this.tbx_mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nbParticipants);
            this.Controls.Add(this.cbx_idH);
            this.Controls.Add(this.tbx_duree);
            this.Controls.Add(this.tbx_heure);
            this.Controls.Add(this.tbx_date);
            this.Controls.Add(this.tbx_intervenant);
            this.Controls.Add(this.tbx_themeE);
            this.Controls.Add(this.lbl_intervenant);
            this.Controls.Add(this.lbl_themeE);
            this.Controls.Add(this.lbl_nbParticipants);
            this.Controls.Add(this.lbx_type);
            this.Controls.Add(this.btn_creer);
            this.Controls.Add(this.tbx_salle);
            this.Controls.Add(this.tbx_libelle);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_idH);
            this.Controls.Add(this.lbl_salle);
            this.Controls.Add(this.lbl_duree);
            this.Controls.Add(this.lbl_heure);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_libelle);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_libelle;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_heure;
        private System.Windows.Forms.Label lbl_duree;
        private System.Windows.Forms.Label lbl_salle;
        private System.Windows.Forms.Label lbl_idH;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox tbx_libelle;
        private System.Windows.Forms.TextBox tbx_salle;
        private System.Windows.Forms.Button btn_creer;
        private System.Windows.Forms.ListBox lbx_type;
        private System.Windows.Forms.Label lbl_nbParticipants;
        private System.Windows.Forms.Label lbl_themeE;
        private System.Windows.Forms.Label lbl_intervenant;
        private System.Windows.Forms.TextBox tbx_themeE;
        private System.Windows.Forms.TextBox tbx_intervenant;
        private System.Windows.Forms.MaskedTextBox tbx_date;
        private System.Windows.Forms.MaskedTextBox tbx_heure;
        private System.Windows.Forms.MaskedTextBox tbx_duree;
        private System.Windows.Forms.ComboBox cbx_idH;
        private System.Windows.Forms.MaskedTextBox tbx_nbParticipants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_mail;
        private System.Windows.Forms.TextBox tbx_prenom;
        private System.Windows.Forms.Label label3;
    }
}