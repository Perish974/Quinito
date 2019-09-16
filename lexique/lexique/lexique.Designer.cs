namespace lexique
{
    partial class lexique
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
            this.textLexique = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLexique = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.textBoxListe = new System.Windows.Forms.TextBox();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonEnlever = new System.Windows.Forms.Button();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.listBoxListe = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1Liste = new System.Windows.Forms.ListBox();
            this.radioButtonFr = new System.Windows.Forms.RadioButton();
            this.radioButtonEn = new System.Windows.Forms.RadioButton();
            this.radioButtonEs = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLexique
            // 
            this.textLexique.Location = new System.Drawing.Point(222, 30);
            this.textLexique.Multiline = true;
            this.textLexique.Name = "textLexique";
            this.textLexique.Size = new System.Drawing.Size(100, 250);
            this.textLexique.TabIndex = 0;
            this.textLexique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "merci de rentrer le mot";
            // 
            // buttonLexique
            // 
            this.buttonLexique.Location = new System.Drawing.Point(103, 367);
            this.buttonLexique.Name = "buttonLexique";
            this.buttonLexique.Size = new System.Drawing.Size(75, 23);
            this.buttonLexique.TabIndex = 2;
            this.buttonLexique.Text = "Ajouter";
            this.buttonLexique.UseVisualStyleBackColor = true;
            this.buttonLexique.Visible = false;
            this.buttonLexique.Click += new System.EventHandler(this.ButtonLexique_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Qutter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(50, 396);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(128, 23);
            this.buttonOuvrir.TabIndex = 4;
            this.buttonOuvrir.Text = "Editer la liste de mots";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Visible = false;
            this.buttonOuvrir.Click += new System.EventHandler(this.ButtonOuvrir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEs);
            this.groupBox1.Controls.Add(this.radioButtonEn);
            this.groupBox1.Controls.Add(this.radioButtonFr);
            this.groupBox1.Controls.Add(this.buttonAjout);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(6, 82);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(128, 23);
            this.buttonAjout.TabIndex = 13;
            this.buttonAjout.Text = "Enregistrer";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.ButtonAjout_Click);
            // 
            // textBoxListe
            // 
            this.textBoxListe.Location = new System.Drawing.Point(194, 342);
            this.textBoxListe.Multiline = true;
            this.textBoxListe.Name = "textBoxListe";
            this.textBoxListe.Size = new System.Drawing.Size(100, 206);
            this.textBoxListe.TabIndex = 6;
            this.textBoxListe.Visible = false;
            this.textBoxListe.TextChanged += new System.EventHandler(this.TextBoxListe_TextChanged);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(208, 554);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 8;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Visible = false;
            this.buttonEffacer.Click += new System.EventHandler(this.ButtonEffacer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(336, 95);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 10;
            this.buttonAjouter.Text = "==>";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // buttonEnlever
            // 
            this.buttonEnlever.Location = new System.Drawing.Point(336, 138);
            this.buttonEnlever.Name = "buttonEnlever";
            this.buttonEnlever.Size = new System.Drawing.Size(75, 23);
            this.buttonEnlever.TabIndex = 11;
            this.buttonEnlever.Text = "<==";
            this.buttonEnlever.UseVisualStyleBackColor = true;
            this.buttonEnlever.Click += new System.EventHandler(this.ButtonEnlever_Click);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Location = new System.Drawing.Point(428, 11);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(29, 13);
            this.labelFiltre.TabIndex = 12;
            this.labelFiltre.Text = "Filtre";
            // 
            // listBoxListe
            // 
            this.listBoxListe.FormattingEnabled = true;
            this.listBoxListe.Location = new System.Drawing.Point(422, 30);
            this.listBoxListe.Name = "listBoxListe";
            this.listBoxListe.Size = new System.Drawing.Size(100, 251);
            this.listBoxListe.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mot existants";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Effacer la Liste filtre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listBox1Liste
            // 
            this.listBox1Liste.FormattingEnabled = true;
            this.listBox1Liste.Location = new System.Drawing.Point(526, 434);
            this.listBox1Liste.Name = "listBox1Liste";
            this.listBox1Liste.Size = new System.Drawing.Size(120, 134);
            this.listBox1Liste.TabIndex = 17;
            this.listBox1Liste.Visible = false;
            // 
            // radioButtonFr
            // 
            this.radioButtonFr.AutoSize = true;
            this.radioButtonFr.Location = new System.Drawing.Point(81, 155);
            this.radioButtonFr.Name = "radioButtonFr";
            this.radioButtonFr.Size = new System.Drawing.Size(65, 17);
            this.radioButtonFr.TabIndex = 17;
            this.radioButtonFr.TabStop = true;
            this.radioButtonFr.Text = "Français";
            this.radioButtonFr.UseVisualStyleBackColor = true;
            // 
            // radioButtonEn
            // 
            this.radioButtonEn.AutoSize = true;
            this.radioButtonEn.Location = new System.Drawing.Point(81, 174);
            this.radioButtonEn.Name = "radioButtonEn";
            this.radioButtonEn.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEn.TabIndex = 18;
            this.radioButtonEn.TabStop = true;
            this.radioButtonEn.Text = "English";
            this.radioButtonEn.UseVisualStyleBackColor = true;
            // 
            // radioButtonEs
            // 
            this.radioButtonEs.AutoSize = true;
            this.radioButtonEs.Location = new System.Drawing.Point(81, 197);
            this.radioButtonEs.Name = "radioButtonEs";
            this.radioButtonEs.Size = new System.Drawing.Size(63, 17);
            this.radioButtonEs.TabIndex = 19;
            this.radioButtonEs.TabStop = true;
            this.radioButtonEs.Text = "Español";
            this.radioButtonEs.UseVisualStyleBackColor = true;
            // 
            // lexique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 452);
            this.Controls.Add(this.listBox1Liste);
            this.Controls.Add(this.buttonOuvrir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxListe);
            this.Controls.Add(this.labelFiltre);
            this.Controls.Add(this.buttonEnlever);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.textBoxListe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLexique);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLexique);
            this.Name = "lexique";
            this.Text = "Ajout de mots";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLexique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLexique;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOuvrir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxListe;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonEnlever;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.ListBox listBoxListe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1Liste;
        private System.Windows.Forms.RadioButton radioButtonEs;
        private System.Windows.Forms.RadioButton radioButtonEn;
        private System.Windows.Forms.RadioButton radioButtonFr;
    }
}

