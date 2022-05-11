
namespace hackatOrga
{
    partial class Form6
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_events = new System.Windows.Forms.ComboBox();
            this.cbx_hackat = new System.Windows.Forms.ComboBox();
            this.btn_intervenant = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_lieu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.lbl_salle = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_heure = new System.Windows.Forms.Label();
            this.lbl_placeholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Envoyer un mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sélectionner la conférence :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sélectionner le hackathon : ";
            // 
            // cbx_events
            // 
            this.cbx_events.FormattingEnabled = true;
            this.cbx_events.Location = new System.Drawing.Point(184, 119);
            this.cbx_events.Name = "cbx_events";
            this.cbx_events.Size = new System.Drawing.Size(190, 23);
            this.cbx_events.TabIndex = 6;
            // 
            // cbx_hackat
            // 
            this.cbx_hackat.FormattingEnabled = true;
            this.cbx_hackat.Location = new System.Drawing.Point(184, 81);
            this.cbx_hackat.Name = "cbx_hackat";
            this.cbx_hackat.Size = new System.Drawing.Size(190, 23);
            this.cbx_hackat.TabIndex = 5;
            this.cbx_hackat.SelectedIndexChanged += new System.EventHandler(this.cbx_hackat_SelectedIndexChanged);
            // 
            // btn_intervenant
            // 
            this.btn_intervenant.Location = new System.Drawing.Point(489, 230);
            this.btn_intervenant.Name = "btn_intervenant";
            this.btn_intervenant.Size = new System.Drawing.Size(137, 58);
            this.btn_intervenant.TabIndex = 9;
            this.btn_intervenant.Text = "Envoyer un mail à l\'intervenant";
            this.btn_intervenant.UseVisualStyleBackColor = true;
            this.btn_intervenant.Click += new System.EventHandler(this.btn_intervenant_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thème :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Salle :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Heure :";
            // 
            // lbl_lieu
            // 
            this.lbl_lieu.AutoSize = true;
            this.lbl_lieu.Location = new System.Drawing.Point(489, 119);
            this.lbl_lieu.Name = "lbl_lieu";
            this.lbl_lieu.Size = new System.Drawing.Size(32, 15);
            this.lbl_lieu.TabIndex = 19;
            this.lbl_lieu.Text = "_____";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Lieu :";
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.Location = new System.Drawing.Point(144, 201);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(32, 15);
            this.lbl_theme.TabIndex = 20;
            this.lbl_theme.Text = "_____";
            // 
            // lbl_salle
            // 
            this.lbl_salle.AutoSize = true;
            this.lbl_salle.Location = new System.Drawing.Point(144, 290);
            this.lbl_salle.Name = "lbl_salle";
            this.lbl_salle.Size = new System.Drawing.Size(32, 15);
            this.lbl_salle.TabIndex = 22;
            this.lbl_salle.Text = "_____";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(144, 230);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(32, 15);
            this.lbl_date.TabIndex = 23;
            this.lbl_date.Text = "_____";
            // 
            // lbl_heure
            // 
            this.lbl_heure.AutoSize = true;
            this.lbl_heure.Location = new System.Drawing.Point(144, 261);
            this.lbl_heure.Name = "lbl_heure";
            this.lbl_heure.Size = new System.Drawing.Size(32, 15);
            this.lbl_heure.TabIndex = 24;
            this.lbl_heure.Text = "_____";
            // 
            // lbl_placeholder
            // 
            this.lbl_placeholder.AutoSize = true;
            this.lbl_placeholder.Location = new System.Drawing.Point(144, 155);
            this.lbl_placeholder.Name = "lbl_placeholder";
            this.lbl_placeholder.Size = new System.Drawing.Size(0, 15);
            this.lbl_placeholder.TabIndex = 25;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 347);
            this.Controls.Add(this.lbl_placeholder);
            this.Controls.Add(this.lbl_heure);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_salle);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.lbl_lieu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_intervenant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_events);
            this.Controls.Add(this.cbx_hackat);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_events;
        private System.Windows.Forms.ComboBox cbx_hackat;
        private System.Windows.Forms.Button btn_intervenant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_lieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.Label lbl_salle;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_heure;
        private System.Windows.Forms.Label lbl_placeholder;
    }
}