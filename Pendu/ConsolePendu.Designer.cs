namespace Pendu
{
    partial class ConsolePendu
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Langue = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Mancheencours = new System.Windows.Forms.TextBox();
            this.NumeroManche = new System.Windows.Forms.TextBox();
            this.Afficheur = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nombreessais = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.ScorePartie = new System.Windows.Forms.Label();
            this.Rejouer = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Chrono = new System.Windows.Forms.Timer(this.components);
            this.Chrono2 = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.Tiret = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Suivant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 359);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Langue
            // 
            this.Langue.FormattingEnabled = true;
            this.Langue.Location = new System.Drawing.Point(730, 63);
            this.Langue.Name = "Langue";
            this.Langue.Size = new System.Drawing.Size(120, 30);
            this.Langue.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(740, 182);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Mancheencours);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NumeroManche);
            this.splitContainer1.Size = new System.Drawing.Size(110, 88);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 3;
            // 
            // Mancheencours
            // 
            this.Mancheencours.Location = new System.Drawing.Point(3, 3);
            this.Mancheencours.Name = "Mancheencours";
            this.Mancheencours.Size = new System.Drawing.Size(104, 20);
            this.Mancheencours.TabIndex = 0;
            this.Mancheencours.Text = "Manche en cours";
            this.Mancheencours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mancheencours.TextChanged += new System.EventHandler(this.Mancheencours_TextChanged);
            // 
            // NumeroManche
            // 
            this.NumeroManche.Location = new System.Drawing.Point(3, 3);
            this.NumeroManche.Multiline = true;
            this.NumeroManche.Name = "NumeroManche";
            this.NumeroManche.Size = new System.Drawing.Size(104, 53);
            this.NumeroManche.TabIndex = 0;
            this.NumeroManche.TextChanged += new System.EventHandler(this.NumeroManche_TextChanged);
            // 
            // Afficheur
            // 
            this.Afficheur.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficheur.Location = new System.Drawing.Point(252, 63);
            this.Afficheur.Name = "Afficheur";
            this.Afficheur.Size = new System.Drawing.Size(408, 40);
            this.Afficheur.TabIndex = 4;
            this.Afficheur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Afficheur.TextChanged += new System.EventHandler(this.Afficheur_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(740, 300);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Nombreessais);
            this.splitContainer2.Size = new System.Drawing.Size(110, 87);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Nombre d\'Esssais";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nombreessais
            // 
            this.Nombreessais.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombreessais.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Nombreessais.Location = new System.Drawing.Point(3, 5);
            this.Nombreessais.Multiline = true;
            this.Nombreessais.Name = "Nombreessais";
            this.Nombreessais.Size = new System.Drawing.Size(104, 50);
            this.Nombreessais.TabIndex = 0;
            this.Nombreessais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombreessais.TextChanged += new System.EventHandler(this.Nombreessais_TextChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(740, 423);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Scorelabel);
            this.splitContainer3.Panel2.Controls.Add(this.ScorePartie);
            this.splitContainer3.Size = new System.Drawing.Size(110, 90);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "SCORE TOTAL";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelabel.Location = new System.Drawing.Point(3, 15);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(99, 33);
            this.Scorelabel.TabIndex = 1;
            this.Scorelabel.Text = "label2";
            this.Scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScorePartie
            // 
            this.ScorePartie.AutoSize = true;
            this.ScorePartie.Location = new System.Drawing.Point(4, 4);
            this.ScorePartie.Name = "ScorePartie";
            this.ScorePartie.Size = new System.Drawing.Size(0, 13);
            this.ScorePartie.TabIndex = 0;
            // 
            // Rejouer
            // 
            this.Rejouer.Location = new System.Drawing.Point(192, 455);
            this.Rejouer.Name = "Rejouer";
            this.Rejouer.Size = new System.Drawing.Size(145, 45);
            this.Rejouer.TabIndex = 7;
            this.Rejouer.Text = "Rejouer";
            this.Rejouer.UseVisualStyleBackColor = true;
            this.Rejouer.Click += new System.EventHandler(this.Rejouer_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(515, 455);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(145, 45);
            this.Quitter.TabIndex = 8;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 11;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chrono
            // 
            this.Chrono.Enabled = true;
            this.Chrono.Interval = 1000;
            this.Chrono.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Chrono2
            // 
            this.Chrono2.AcceptsReturn = true;
            this.Chrono2.AcceptsTab = true;
            this.Chrono2.Location = new System.Drawing.Point(730, 110);
            this.Chrono2.Name = "Chrono2";
            this.Chrono2.ReadOnly = true;
            this.Chrono2.Size = new System.Drawing.Size(100, 20);
            this.Chrono2.TabIndex = 29;
            this.Chrono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(7, 20);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(45, 20);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(58, 20);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(45, 20);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(109, 20);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(45, 20);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(160, 20);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(45, 20);
            this.D.TabIndex = 3;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(211, 20);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(45, 20);
            this.E.TabIndex = 4;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(262, 20);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(45, 20);
            this.F.TabIndex = 5;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(313, 20);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(45, 20);
            this.G.TabIndex = 6;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(7, 60);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(45, 20);
            this.H.TabIndex = 7;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(58, 60);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(45, 20);
            this.I.TabIndex = 8;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.I_Click);
            // 
            // J
            // 
            this.J.Location = new System.Drawing.Point(109, 60);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(45, 20);
            this.J.TabIndex = 9;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = true;
            this.J.Click += new System.EventHandler(this.J_Click);
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(160, 60);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(45, 20);
            this.K.TabIndex = 10;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            this.K.Click += new System.EventHandler(this.K_Click);
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(211, 60);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(45, 20);
            this.L.TabIndex = 11;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(262, 60);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(45, 20);
            this.M.TabIndex = 12;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            this.M.Click += new System.EventHandler(this.M_Click);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(313, 60);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(45, 20);
            this.N.TabIndex = 13;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // O
            // 
            this.O.Location = new System.Drawing.Point(7, 101);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(45, 20);
            this.O.TabIndex = 14;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            this.O.Click += new System.EventHandler(this.O_Click);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(58, 101);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(45, 20);
            this.P.TabIndex = 15;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // Q
            // 
            this.Q.Location = new System.Drawing.Point(109, 101);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(45, 20);
            this.Q.TabIndex = 16;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            this.Q.Click += new System.EventHandler(this.Q_Click);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(160, 101);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(45, 20);
            this.R.TabIndex = 17;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(211, 101);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(45, 20);
            this.S.TabIndex = 18;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(262, 101);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(45, 20);
            this.T.TabIndex = 19;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            this.T.Click += new System.EventHandler(this.T_Click);
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(313, 101);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(45, 20);
            this.U.TabIndex = 20;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.U_Click);
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(29, 137);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(45, 20);
            this.V.TabIndex = 23;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = true;
            this.V.Click += new System.EventHandler(this.V_Click);
            // 
            // W
            // 
            this.W.Location = new System.Drawing.Point(80, 137);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(45, 20);
            this.W.TabIndex = 24;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            this.W.Click += new System.EventHandler(this.W_Click);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(131, 137);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(45, 20);
            this.X.TabIndex = 25;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(182, 137);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(45, 20);
            this.Y.TabIndex = 26;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            this.Y.Click += new System.EventHandler(this.Y_Click);
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(234, 137);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(45, 20);
            this.Z.TabIndex = 27;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            this.Z.Click += new System.EventHandler(this.Z_Click);
            // 
            // Tiret
            // 
            this.Tiret.Location = new System.Drawing.Point(285, 137);
            this.Tiret.Name = "Tiret";
            this.Tiret.Size = new System.Drawing.Size(45, 20);
            this.Tiret.TabIndex = 28;
            this.Tiret.Text = "-";
            this.Tiret.UseVisualStyleBackColor = true;
            this.Tiret.Click += new System.EventHandler(this.Tiret_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tiret);
            this.groupBox1.Controls.Add(this.Z);
            this.groupBox1.Controls.Add(this.Y);
            this.groupBox1.Controls.Add(this.X);
            this.groupBox1.Controls.Add(this.W);
            this.groupBox1.Controls.Add(this.V);
            this.groupBox1.Controls.Add(this.U);
            this.groupBox1.Controls.Add(this.T);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Controls.Add(this.R);
            this.groupBox1.Controls.Add(this.Q);
            this.groupBox1.Controls.Add(this.P);
            this.groupBox1.Controls.Add(this.O);
            this.groupBox1.Controls.Add(this.N);
            this.groupBox1.Controls.Add(this.M);
            this.groupBox1.Controls.Add(this.L);
            this.groupBox1.Controls.Add(this.K);
            this.groupBox1.Controls.Add(this.J);
            this.groupBox1.Controls.Add(this.I);
            this.groupBox1.Controls.Add(this.H);
            this.groupBox1.Controls.Add(this.G);
            this.groupBox1.Controls.Add(this.F);
            this.groupBox1.Controls.Add(this.E);
            this.groupBox1.Controls.Add(this.D);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Location = new System.Drawing.Point(252, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(352, 455);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(145, 45);
            this.Suivant.TabIndex = 30;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // ConsolePendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Chrono2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Rejouer);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.Afficheur);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Langue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsolePendu";
            this.Text = "Pendu";
            this.Load += new System.EventHandler(this.ConsolePendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Langue;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox Mancheencours;
        private System.Windows.Forms.TextBox NumeroManche;
        private System.Windows.Forms.TextBox Afficheur;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Nombreessais;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox textBox2;
        
        private System.Windows.Forms.Button Rejouer;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Label ScorePartie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.TextBox Chrono2;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button J;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.Button W;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button Z;
        private System.Windows.Forms.Button Tiret;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer Chrono;
        private System.Windows.Forms.Button Suivant;
    }
}

