namespace Pendu2
{
    partial class LancementDuPendu2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LancementDuPendu2));
            this.DemandeChoixLangue = new System.Windows.Forms.Label();
            this.ChoixFR = new System.Windows.Forms.Button();
            this.ChoixEN = new System.Windows.Forms.Button();
            this.ChoixES = new System.Windows.Forms.Button();
            this.ChoixNiveauDeDifficulte = new System.Windows.Forms.GroupBox();
            this.NiveauDeDifficulte3 = new System.Windows.Forms.RadioButton();
            this.NiveauDeDifficulte1 = new System.Windows.Forms.RadioButton();
            this.NiveauDeDifficulte2 = new System.Windows.Forms.RadioButton();
            this.ChoixNBManches = new System.Windows.Forms.GroupBox();
            this.NombreManches4 = new System.Windows.Forms.RadioButton();
            this.NombreManches1 = new System.Windows.Forms.RadioButton();
            this.NombreManches3 = new System.Windows.Forms.RadioButton();
            this.NombreManches2 = new System.Windows.Forms.RadioButton();
            this.NettoyageNiveauDeDifficulte = new System.Windows.Forms.Button();
            this.Lancement = new System.Windows.Forms.Button();
            this.NettoyageNBManches = new System.Windows.Forms.Button();
            this.ChoixNiveauDeDifficulte.SuspendLayout();
            this.ChoixNBManches.SuspendLayout();
            this.SuspendLayout();
            // 
            // DemandeChoixLangue
            // 
            this.DemandeChoixLangue.AutoSize = true;
            this.DemandeChoixLangue.Location = new System.Drawing.Point(124, 28);
            this.DemandeChoixLangue.Name = "DemandeChoixLangue";
            this.DemandeChoixLangue.Size = new System.Drawing.Size(193, 13);
            this.DemandeChoixLangue.TabIndex = 0;
            this.DemandeChoixLangue.Text = "Dans quelle langue voulez-vous jouer ?";
            this.DemandeChoixLangue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChoixFR
            // 
            this.ChoixFR.Image = ((System.Drawing.Image)(resources.GetObject("ChoixFR.Image")));
            this.ChoixFR.Location = new System.Drawing.Point(50, 70);
            this.ChoixFR.Name = "ChoixFR";
            this.ChoixFR.Size = new System.Drawing.Size(80, 50);
            this.ChoixFR.TabIndex = 1;
            this.ChoixFR.UseVisualStyleBackColor = true;
            this.ChoixFR.Click += new System.EventHandler(this.ChoixFR_Click);
            // 
            // ChoixEN
            // 
            this.ChoixEN.Image = ((System.Drawing.Image)(resources.GetObject("ChoixEN.Image")));
            this.ChoixEN.Location = new System.Drawing.Point(180, 70);
            this.ChoixEN.Name = "ChoixEN";
            this.ChoixEN.Size = new System.Drawing.Size(80, 50);
            this.ChoixEN.TabIndex = 2;
            this.ChoixEN.UseVisualStyleBackColor = true;
            this.ChoixEN.Click += new System.EventHandler(this.ChoixEN_Click);
            // 
            // ChoixES
            // 
            this.ChoixES.Image = ((System.Drawing.Image)(resources.GetObject("ChoixES.Image")));
            this.ChoixES.Location = new System.Drawing.Point(310, 70);
            this.ChoixES.Name = "ChoixES";
            this.ChoixES.Size = new System.Drawing.Size(80, 50);
            this.ChoixES.TabIndex = 3;
            this.ChoixES.UseVisualStyleBackColor = true;
            this.ChoixES.Click += new System.EventHandler(this.ChoixES_Click);
            // 
            // ChoixNiveauDeDifficulte
            // 
            this.ChoixNiveauDeDifficulte.Controls.Add(this.NiveauDeDifficulte3);
            this.ChoixNiveauDeDifficulte.Controls.Add(this.NiveauDeDifficulte1);
            this.ChoixNiveauDeDifficulte.Controls.Add(this.NiveauDeDifficulte2);
            this.ChoixNiveauDeDifficulte.Location = new System.Drawing.Point(50, 146);
            this.ChoixNiveauDeDifficulte.Name = "ChoixNiveauDeDifficulte";
            this.ChoixNiveauDeDifficulte.Size = new System.Drawing.Size(120, 90);
            this.ChoixNiveauDeDifficulte.TabIndex = 4;
            this.ChoixNiveauDeDifficulte.TabStop = false;
            this.ChoixNiveauDeDifficulte.Text = "groupBox";
            this.ChoixNiveauDeDifficulte.Visible = false;
            this.ChoixNiveauDeDifficulte.Enter += new System.EventHandler(this.ChoixNiveauDeDifficulte_Enter);
            // 
            // NiveauDeDifficulte3
            // 
            this.NiveauDeDifficulte3.AutoSize = true;
            this.NiveauDeDifficulte3.Location = new System.Drawing.Point(6, 65);
            this.NiveauDeDifficulte3.Name = "NiveauDeDifficulte3";
            this.NiveauDeDifficulte3.Size = new System.Drawing.Size(85, 17);
            this.NiveauDeDifficulte3.TabIndex = 11;
            this.NiveauDeDifficulte3.TabStop = true;
            this.NiveauDeDifficulte3.Text = "radioButton3";
            this.NiveauDeDifficulte3.UseVisualStyleBackColor = true;
            this.NiveauDeDifficulte3.CheckedChanged += new System.EventHandler(this.NiveauDeDifficulte3_CheckedChanged);
            // 
            // NiveauDeDifficulte1
            // 
            this.NiveauDeDifficulte1.AutoSize = true;
            this.NiveauDeDifficulte1.Location = new System.Drawing.Point(6, 19);
            this.NiveauDeDifficulte1.Name = "NiveauDeDifficulte1";
            this.NiveauDeDifficulte1.Size = new System.Drawing.Size(85, 17);
            this.NiveauDeDifficulte1.TabIndex = 9;
            this.NiveauDeDifficulte1.TabStop = true;
            this.NiveauDeDifficulte1.Text = "radioButton1";
            this.NiveauDeDifficulte1.UseVisualStyleBackColor = true;
            this.NiveauDeDifficulte1.CheckedChanged += new System.EventHandler(this.NiveauDeDifficulte1_CheckedChanged);
            // 
            // NiveauDeDifficulte2
            // 
            this.NiveauDeDifficulte2.AutoSize = true;
            this.NiveauDeDifficulte2.Location = new System.Drawing.Point(6, 42);
            this.NiveauDeDifficulte2.Name = "NiveauDeDifficulte2";
            this.NiveauDeDifficulte2.Size = new System.Drawing.Size(85, 17);
            this.NiveauDeDifficulte2.TabIndex = 10;
            this.NiveauDeDifficulte2.TabStop = true;
            this.NiveauDeDifficulte2.Text = "radioButton2";
            this.NiveauDeDifficulte2.UseVisualStyleBackColor = true;
            this.NiveauDeDifficulte2.CheckedChanged += new System.EventHandler(this.NiveauDeDifficulte2_CheckedChanged);
            // 
            // ChoixNBManches
            // 
            this.ChoixNBManches.Controls.Add(this.NombreManches4);
            this.ChoixNBManches.Controls.Add(this.NombreManches1);
            this.ChoixNBManches.Controls.Add(this.NombreManches3);
            this.ChoixNBManches.Controls.Add(this.NombreManches2);
            this.ChoixNBManches.Location = new System.Drawing.Point(50, 257);
            this.ChoixNBManches.Name = "ChoixNBManches";
            this.ChoixNBManches.Size = new System.Drawing.Size(120, 115);
            this.ChoixNBManches.TabIndex = 5;
            this.ChoixNBManches.TabStop = false;
            this.ChoixNBManches.Text = "groupBox";
            this.ChoixNBManches.Visible = false;
            this.ChoixNBManches.Enter += new System.EventHandler(this.ChoixNBManches_Enter);
            // 
            // NombreManches4
            // 
            this.NombreManches4.AutoSize = true;
            this.NombreManches4.Location = new System.Drawing.Point(6, 88);
            this.NombreManches4.Name = "NombreManches4";
            this.NombreManches4.Size = new System.Drawing.Size(85, 17);
            this.NombreManches4.TabIndex = 12;
            this.NombreManches4.TabStop = true;
            this.NombreManches4.Text = "radioButton4";
            this.NombreManches4.UseVisualStyleBackColor = true;
            this.NombreManches4.CheckedChanged += new System.EventHandler(this.NombreManches4_CheckedChanged_1);
            // 
            // NombreManches1
            // 
            this.NombreManches1.AutoSize = true;
            this.NombreManches1.Location = new System.Drawing.Point(6, 19);
            this.NombreManches1.Name = "NombreManches1";
            this.NombreManches1.Size = new System.Drawing.Size(85, 17);
            this.NombreManches1.TabIndex = 9;
            this.NombreManches1.TabStop = true;
            this.NombreManches1.Text = "radioButton1";
            this.NombreManches1.UseVisualStyleBackColor = true;
            this.NombreManches1.CheckedChanged += new System.EventHandler(this.NombreManches1_CheckedChanged_1);
            // 
            // NombreManches3
            // 
            this.NombreManches3.AutoSize = true;
            this.NombreManches3.Location = new System.Drawing.Point(6, 65);
            this.NombreManches3.Name = "NombreManches3";
            this.NombreManches3.Size = new System.Drawing.Size(85, 17);
            this.NombreManches3.TabIndex = 11;
            this.NombreManches3.TabStop = true;
            this.NombreManches3.Text = "radioButton3";
            this.NombreManches3.UseVisualStyleBackColor = true;
            this.NombreManches3.CheckedChanged += new System.EventHandler(this.NombreManches3_CheckedChanged_1);
            // 
            // NombreManches2
            // 
            this.NombreManches2.AutoSize = true;
            this.NombreManches2.Location = new System.Drawing.Point(6, 42);
            this.NombreManches2.Name = "NombreManches2";
            this.NombreManches2.Size = new System.Drawing.Size(85, 17);
            this.NombreManches2.TabIndex = 10;
            this.NombreManches2.TabStop = true;
            this.NombreManches2.Text = "radioButton2";
            this.NombreManches2.UseVisualStyleBackColor = true;
            this.NombreManches2.CheckedChanged += new System.EventHandler(this.NombreManches2_CheckedChanged_1);
            // 
            // NettoyageNiveauDeDifficulte
            // 
            this.NettoyageNiveauDeDifficulte.Location = new System.Drawing.Point(240, 164);
            this.NettoyageNiveauDeDifficulte.Name = "NettoyageNiveauDeDifficulte";
            this.NettoyageNiveauDeDifficulte.Size = new System.Drawing.Size(120, 60);
            this.NettoyageNiveauDeDifficulte.TabIndex = 6;
            this.NettoyageNiveauDeDifficulte.Text = "button1";
            this.NettoyageNiveauDeDifficulte.UseVisualStyleBackColor = true;
            this.NettoyageNiveauDeDifficulte.Visible = false;
            this.NettoyageNiveauDeDifficulte.VisibleChanged += new System.EventHandler(this.Lancement_Visible);
            this.NettoyageNiveauDeDifficulte.Click += new System.EventHandler(this.NettoyageNiveauDeDifficulte_Click);
            // 
            // Lancement
            // 
            this.Lancement.Enabled = false;
            this.Lancement.Location = new System.Drawing.Point(50, 389);
            this.Lancement.Name = "Lancement";
            this.Lancement.Size = new System.Drawing.Size(340, 60);
            this.Lancement.TabIndex = 7;
            this.Lancement.Text = "button2";
            this.Lancement.UseVisualStyleBackColor = true;
            this.Lancement.Visible = false;
            this.Lancement.Click += new System.EventHandler(this.Lancement_Click);
            // 
            // NettoyageNBManches
            // 
            this.NettoyageNBManches.Location = new System.Drawing.Point(240, 295);
            this.NettoyageNBManches.Name = "NettoyageNBManches";
            this.NettoyageNBManches.Size = new System.Drawing.Size(120, 60);
            this.NettoyageNBManches.TabIndex = 8;
            this.NettoyageNBManches.Text = "button1";
            this.NettoyageNBManches.UseVisualStyleBackColor = true;
            this.NettoyageNBManches.Visible = false;
            this.NettoyageNBManches.VisibleChanged += new System.EventHandler(this.Lancement_Visible);
            this.NettoyageNBManches.Click += new System.EventHandler(this.NettoyageNBManches_Click);
            // 
            // LancementDuPendu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 461);
            this.Controls.Add(this.NettoyageNBManches);
            this.Controls.Add(this.Lancement);
            this.Controls.Add(this.NettoyageNiveauDeDifficulte);
            this.Controls.Add(this.ChoixNBManches);
            this.Controls.Add(this.ChoixNiveauDeDifficulte);
            this.Controls.Add(this.ChoixES);
            this.Controls.Add(this.ChoixEN);
            this.Controls.Add(this.ChoixFR);
            this.Controls.Add(this.DemandeChoixLangue);
            this.Name = "LancementDuPendu2";
            this.Text = "Configurer votre partie...";
            this.ChoixNiveauDeDifficulte.ResumeLayout(false);
            this.ChoixNiveauDeDifficulte.PerformLayout();
            this.ChoixNBManches.ResumeLayout(false);
            this.ChoixNBManches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DemandeChoixLangue;
        private System.Windows.Forms.Button ChoixFR;
        private System.Windows.Forms.Button ChoixEN;
        private System.Windows.Forms.Button ChoixES;
        private System.Windows.Forms.GroupBox ChoixNiveauDeDifficulte;
        private System.Windows.Forms.GroupBox ChoixNBManches;
        private System.Windows.Forms.Button NettoyageNiveauDeDifficulte;
        private System.Windows.Forms.Button Lancement;
        private System.Windows.Forms.Button NettoyageNBManches;
        private System.Windows.Forms.RadioButton NiveauDeDifficulte3;
        private System.Windows.Forms.RadioButton NiveauDeDifficulte1;
        private System.Windows.Forms.RadioButton NiveauDeDifficulte2;
        private System.Windows.Forms.RadioButton NombreManches4;
        private System.Windows.Forms.RadioButton NombreManches1;
        private System.Windows.Forms.RadioButton NombreManches3;
        private System.Windows.Forms.RadioButton NombreManches2;
    }
}

