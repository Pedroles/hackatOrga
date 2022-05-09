
namespace hackatOrga
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_coms = new System.Windows.Forms.ComboBox();
            this.cbx_events = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_stat = new System.Windows.Forms.Label();
            this.btn_mail = new System.Windows.Forms.Button();
            this.lbl_heure = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_h = new System.Windows.Forms.Label();
            this.lbl_ddebut = new System.Windows.Forms.Label();
            this.lbl_lieu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nbinscrits = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_places = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tableau de bord";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_coms
            // 
            this.cbx_coms.FormattingEnabled = true;
            this.cbx_coms.Location = new System.Drawing.Point(209, 84);
            this.cbx_coms.Name = "cbx_coms";
            this.cbx_coms.Size = new System.Drawing.Size(190, 23);
            this.cbx_coms.TabIndex = 1;
            this.cbx_coms.SelectedIndexChanged += new System.EventHandler(this.cbx_coms_SelectedIndexChanged);
            // 
            // cbx_events
            // 
            this.cbx_events.FormattingEnabled = true;
            this.cbx_events.Location = new System.Drawing.Point(209, 122);
            this.cbx_events.Name = "cbx_events";
            this.cbx_events.Size = new System.Drawing.Size(190, 23);
            this.cbx_events.TabIndex = 2;
            this.cbx_events.SelectedIndexChanged += new System.EventHandler(this.cbx_events_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sélectionner le hackathon : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sélectionner l\'évènement : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Statistiques :";
            // 
            // lbl_stat
            // 
            this.lbl_stat.AutoSize = true;
            this.lbl_stat.Location = new System.Drawing.Point(130, 167);
            this.lbl_stat.Name = "lbl_stat";
            this.lbl_stat.Size = new System.Drawing.Size(42, 15);
            this.lbl_stat.TabIndex = 6;
            this.lbl_stat.Text = "_______";
            // 
            // btn_mail
            // 
            this.btn_mail.Location = new System.Drawing.Point(486, 314);
            this.btn_mail.Name = "btn_mail";
            this.btn_mail.Size = new System.Drawing.Size(209, 44);
            this.btn_mail.TabIndex = 7;
            this.btn_mail.Text = "Envoyer un mail à l\'intervenant";
            this.btn_mail.UseVisualStyleBackColor = true;
            this.btn_mail.Click += new System.EventHandler(this.btn_mail_Click);
            // 
            // lbl_heure
            // 
            this.lbl_heure.AutoSize = true;
            this.lbl_heure.Location = new System.Drawing.Point(209, 286);
            this.lbl_heure.Name = "lbl_heure";
            this.lbl_heure.Size = new System.Drawing.Size(45, 15);
            this.lbl_heure.TabIndex = 10;
            this.lbl_heure.Text = "Heure :";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(49, 286);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(37, 15);
            this.lbl9.TabIndex = 11;
            this.lbl9.Text = "Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Lieu :";
            // 
            // lbl_h
            // 
            this.lbl_h.AutoSize = true;
            this.lbl_h.Location = new System.Drawing.Point(260, 286);
            this.lbl_h.Name = "lbl_h";
            this.lbl_h.Size = new System.Drawing.Size(42, 15);
            this.lbl_h.TabIndex = 15;
            this.lbl_h.Text = "_______";
            // 
            // lbl_ddebut
            // 
            this.lbl_ddebut.AutoSize = true;
            this.lbl_ddebut.Location = new System.Drawing.Point(92, 286);
            this.lbl_ddebut.Name = "lbl_ddebut";
            this.lbl_ddebut.Size = new System.Drawing.Size(42, 15);
            this.lbl_ddebut.TabIndex = 16;
            this.lbl_ddebut.Text = "_______";
            // 
            // lbl_lieu
            // 
            this.lbl_lieu.AutoSize = true;
            this.lbl_lieu.Location = new System.Drawing.Point(92, 237);
            this.lbl_lieu.Name = "lbl_lieu";
            this.lbl_lieu.Size = new System.Drawing.Size(42, 15);
            this.lbl_lieu.TabIndex = 17;
            this.lbl_lieu.Text = "_______";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre d\'inscrits :";
            // 
            // lbl_nbinscrits
            // 
            this.lbl_nbinscrits.AutoSize = true;
            this.lbl_nbinscrits.Location = new System.Drawing.Point(443, 167);
            this.lbl_nbinscrits.Name = "lbl_nbinscrits";
            this.lbl_nbinscrits.Size = new System.Drawing.Size(42, 15);
            this.lbl_nbinscrits.TabIndex = 19;
            this.lbl_nbinscrits.Text = "_______";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nombre de places :";
            // 
            // lbl_places
            // 
            this.lbl_places.AutoSize = true;
            this.lbl_places.Location = new System.Drawing.Point(443, 194);
            this.lbl_places.Name = "lbl_places";
            this.lbl_places.Size = new System.Drawing.Size(42, 15);
            this.lbl_places.TabIndex = 21;
            this.lbl_places.Text = "_______";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_places);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_nbinscrits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_lieu);
            this.Controls.Add(this.lbl_ddebut);
            this.Controls.Add(this.lbl_h);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl_heure);
            this.Controls.Add(this.btn_mail);
            this.Controls.Add(this.lbl_stat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_events);
            this.Controls.Add(this.cbx_coms);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_coms;
        private System.Windows.Forms.ComboBox cbx_events;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_stat;
        private System.Windows.Forms.Button btn_mail;
        private System.Windows.Forms.Label lbl_heure;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_h;
        private System.Windows.Forms.Label lbl_ddebut;
        private System.Windows.Forms.Label lbl_lieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nbinscrits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_places;
    }
}