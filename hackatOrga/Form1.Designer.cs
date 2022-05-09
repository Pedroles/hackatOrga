
namespace hackatOrga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnSatellites = new System.Windows.Forms.Button();
            this.btnCo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(189, 150);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(179, 101);
            this.btnImprimer.TabIndex = 0;
            this.btnImprimer.Text = "Imprimer la liste des participants d\'un hackathon";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(374, 150);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(178, 101);
            this.btnCrea.TabIndex = 1;
            this.btnCrea.Text = "Créer un nouvel hackathon";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnSatellites
            // 
            this.btnSatellites.Location = new System.Drawing.Point(189, 257);
            this.btnSatellites.Name = "btnSatellites";
            this.btnSatellites.Size = new System.Drawing.Size(179, 101);
            this.btnSatellites.TabIndex = 2;
            this.btnSatellites.Text = "Créer un atelier ou une nouvelle conference";
            this.btnSatellites.UseVisualStyleBackColor = true;
            this.btnSatellites.Click += new System.EventHandler(this.btnSatellites_Click);
            // 
            // btnCo
            // 
            this.btnCo.Location = new System.Drawing.Point(374, 257);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(178, 101);
            this.btnCo.TabIndex = 3;
            this.btnCo.Text = "Accéder au tableau de bord";
            this.btnCo.UseVisualStyleBackColor = true;
            this.btnCo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hackat\'Orga";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.btnSatellites);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.btnImprimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnSatellites;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Label label1;
    }
}

