using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Pendu
{
    public partial class ConsolePendu : Form
    {
        private int Scorepartie;
        private int Scoremanche;
        private int CoupsRestants;
        private static string Mot_a_D;
        public char[] Mot_Courant;
        private static string[] Lexique;
        int _ticks;
        public String LettresCherches { get; set; }
        
       // public String Mot { get; set; }

        public ConsolePendu()
        {
            InitializeComponent();
            MainMenu mainMenu = new MainMenu();
            MenuItem menu = new MenuItem("Menu");          
            MenuItem Quitter = new MenuItem("Quitter");
            MenuItem Rejouer = new MenuItem("Rejouer");
            MenuItem Suivant = new MenuItem("Suivant");
            MenuItem Option = new MenuItem("Option");
            MenuItem lexique = new MenuItem("lexique");
            mainMenu.MenuItems.Add(menu);
            Quitter.Click += Quitter_Click;
            Rejouer.Click += Rejouer_Click;
            //Option.Click += Option_Click;
            Suivant.Click += Suivant_Click;
            lexique.Click += Lexique_Click;
            menu.MenuItems.Add(Option);
            menu.MenuItems.Add(lexique);
            menu.MenuItems.Add(Quitter);
            menu.MenuItems.Add(Rejouer);
            menu.MenuItems.Add(Suivant);
            base.Menu = mainMenu;
            List<> Lexique = new List<lexique.lexique>.list ();
            init_lexique();
            Mot_a_D = Lexique [new Random().Next(0, Lexique.Length)];
            CoupsRestants = Mot_a_D.Length + 2;
            Mot_Courant = new char[Mot_a_D.Length];
            LettresCherches = "";
            Scorepartie = 0;
            //CoupsRestants = 7;
            init_Mot_courant();
            this.Afficheur.Text = chars_to_string(Mot_Courant);
            this.Scorelabel.Text = Scorepartie.ToString();

            
             bool perdu = false;
             bool gagne = false;

            
            this.Chrono.Start();
            this.Chrono.Enabled = true;          
            this.Chrono2.Text = "00:00";
            
                        
           
        }
        private void Lexique_Click(object sender, EventArgs e)
        {
            lexique.lexique f1 = new lexique.lexique();
            f1.Show();
            
        }



        public void init_lexique()
        {
            /* Lexique[0] = "BONJOUR"; Lexique[1] = "AMENAGER"; Lexique[2] = "APPLICATION"; Lexique[3] = "INCONTOURNABLE"; Lexique[4] = "HUMOUR"; Lexique[5] = "INFERNALE"; Lexique[6] = "PHALLANGES"; Lexique[7] = "PROXY";
             Lexique[8] = "HABITUDES"; Lexique[9] = "MODIFICATION"; Lexique[10] = "INCARCERATION"; Lexique[11] = "REGLAGES"; Lexique[12] = "BASKET";
             Lexique[13] = "TRIOMPHE"; Lexique[14] = "DELEGUE"; Lexique[15] = "EMBARQUER"; Lexique[16] = "WHISKY";
             Lexique[16] = "DESTRUCTIF"; Lexique[17] = "PARTENAIRE"; Lexique[18] = "WHISKY"; Lexique[19] = "TROUBLES"; Lexique[20] = "DIGESTIF"; Lexique[21] = "WHISKY";
             Lexique[22] = "LIMITATIF"; Lexique[23] = "CARDINAL"; Lexique[24] = "REQUISITIONS"; Lexique[25] = "MARTIALE";
             Lexique[26] = "PRECARITE"; Lexique[27] = "DESTRUCTIF"; Lexique[28] = "PRAGMATIQUE"; Lexique[29] = "TRAGIQUEMENT";
             Lexique[30] = "DISJONCTEUR"; Lexique[31] = "POMPIER"; Lexique[32] = "SECTE"; Lexique[33] = "DOMINATEUR";
             Lexique[34] = "HISTORIQUE"; Lexique[35] = "DIMINUTIF"; Lexique[36] = "SANCTION"; Lexique[37] = "DETRACTEUR";
             Lexique[38] = "HERITAGE"; Lexique[39] = "MALNUTRITION"; Lexique[40] = "FRONTAL"; Lexique[41] = "BARICADER";
             Lexique[42] = "ADOPTER"; Lexique[43] = "WAGON"; Lexique[44] = "MANAGER"; Lexique[45] = "ZEBRE";
             Lexique[46] = "LUMIERE"; Lexique[47] = "ASTRE"; Lexique[48] = "NAVETTE"; Lexique[49] = "FICTION";
             Lexique[50] = "PATHOLOGIE"; Lexique[51] = "YACHT"; Lexique[52] = "MEDECINE"; Lexique[53] = "DIPLOMATE";
             Lexique[54] = "DROMADAIRE"; Lexique[55] = "MIETTES"; Lexique[56] = "POUSSIN"; Lexique[57] = "POUBELLE";
             Lexique[58] = "CRISE"; Lexique[59] = "BERLINE"; Lexique[60] = "PACTE"; Lexique[61] = "CRIMINEL";
             Lexique[62] = "ECLIPSE"; Lexique[63] = "BERET"; Lexique[64] = "PAVOISER"; Lexique[65] = "MAITRISE";
             Lexique[66] = "TELECHARGEMENT"; Lexique[67] = "PRAGMATISME"; Lexique[68] = "ESCALIERS"; Lexique[69] = "PRIMATE";
             Lexique[70] = "BRUIT"; Lexique[71] = "BOURAGE"; Lexique[72] = "DISTRACTION"; Lexique[73] = "BAROUDEUR";
             Lexique[74] = "MOUSTIQUES"; Lexique[75] = "GALVANISER"; Lexique[76] = "EXTINCTION"; Lexique[77] = "EXAGERATION";
             Lexique[77] = "ORDINATEUR"; Lexique[78] = "PERIPHERIQUE"; Lexique[79] = "BOULEVARD"; Lexique[80] = "PRIMATE";
             Lexique[81] = "CHATEAUX"; Lexique[82] = "TAXI"; Lexique[83] = "GALAXIE"; Lexique[84] = "AXIAL";
             Lexique[85] = "YEUX"; Lexique[86] = "TERRITORIAL"; Lexique[87] = "KANGOUROU"; Lexique[88] = "CHIEN";
             Lexique[89] = "FELLINE"; Lexique[90] = "PANDERIES";*/

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"lexique/lexique/bin/Debug/Source/lexique.xml";
            p.Start();

        }

        public void init_Mot_courant()
        {
            for (int i = 0; i < Mot_Courant.Length; i++)
            {
                Mot_Courant[i] = '?';
            }
        }

       
        public string chars_to_string(char[] c)
        {
            string chaine = "";
            for (int i = 0; i < c.Length; i++)
            {
                chaine = chaine + c[i];
            }
            return chaine;
        }

        public char String_tochar(string s)
        {
            return s[0];
        }
        public void TesteLettre(char lettre)
        {
            lettre = lettre.ToString().ToUpper()[0];
            if (!LettresCherches.Contains(lettre))
            {
                LettresCherches += lettre;
                if (!Mot_Courant.Contains(lettre))
                {
                    CoupsRestants--;
                }

                Mot_a_D = "";

                foreach (char l in Mot_Courant)
                {
                    if (LettresCherches.Contains(l))
                    {
                        Mot_a_D += l;
                    }
                    else
                    {
                        Mot_a_D += '?';
                    }
                }
            }
        }

        public void met_a_jour(Button b)
        {
            if (CoupsRestants != 0 && Mot_a_D != chars_to_string(Mot_Courant))
            {
                for (int i = 0; i < Mot_a_D.Length; i++)
                {
                    if (Mot_a_D[i] == b.Text[0])
                        Mot_Courant[i] = b.Text[0];
                }
                CoupsRestants--;
                this.Afficheur.Text = chars_to_string(Mot_Courant);
                this.Nombreessais.Text = CoupsRestants.ToString();
                b.Enabled = false;
                 if (Mot_a_D == chars_to_string(Mot_Courant))
                 {
                     /*this.label5.Text = "BRAVO C'EST GAGNE";
                     this.label5.Show();*/
                     MessageBox.Show("Bravo ! Vous avez gagné !");
                     Scorepartie += CoupsRestants;
                     this.Scorelabel.Text = Scorepartie.ToString();
                 }
                 else
                     if (CoupsRestants == 0)
                 {
                     this.label1.Text = Mot_a_D;
                     this.label1.Show();
                 }
            }
            

        }
        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            _ticks++ ;
            Chrono2.Text = _ticks.ToString();
            if (CoupsRestants == 0)
            {
                Chrono.Enabled = false;
                Chrono.Stop();
                _ticks = 0;

            }
            
        }

        public void reinitialise()
        {
            Mot_a_D = Lexique[new Random().Next(0, Lexique.Length)];
            CoupsRestants = Mot_a_D.Length + 2;
            Mot_Courant = new char[Mot_a_D.Length];
            init_Mot_courant();
            this.Afficheur.Text = chars_to_string(Mot_Courant);
            this.Nombreessais.Text = CoupsRestants.ToString();
            this.label1.Hide();

            this.A.Enabled = true; this.J.Enabled = true; this.S.Enabled = true;
            this.B.Enabled = true; this.K.Enabled = true; this.T.Enabled = true;
            this.C.Enabled = true; this.L.Enabled = true; this.U.Enabled = true;
            this.D.Enabled = true; this.M.Enabled = true; this.V.Enabled = true;
            this.E.Enabled = true; this.N.Enabled = true; this.W.Enabled = true;
            this.F.Enabled = true; this.O.Enabled = true; this.X.Enabled = true;
            this.G.Enabled = true; this.P.Enabled = true; this.Y.Enabled = true;
            this.H.Enabled = true; this.Q.Enabled = true; this.Z.Enabled = true;
            this.I.Enabled = true; this.R.Enabled = true; this.Tiret.Enabled = true;



        }
        
        private void A_Click(object sender, EventArgs e) 
        {
             met_a_jour(A);
           
        }

        private void B_Click(object sender, EventArgs e)
        {
            met_a_jour(B);
            
        }

        private void C_Click(object sender, EventArgs e)
        {
            met_a_jour(C);
           
        }

        private void D_Click(object sender, EventArgs e)
        {
            met_a_jour(D);
            
        }

        private void E_Click(object sender, EventArgs e)
        {
            met_a_jour(E);
          
        }

        private void F_Click(object sender, EventArgs e)
        {
            met_a_jour(F);
            Chrono.Start();
        }

        private void G_Click(object sender, EventArgs e)
        {
            met_a_jour(G);
            Chrono.Start();
        }

        private void H_Click(object sender, EventArgs e)
        {
            met_a_jour(H);
            Chrono.Start();
        }

        private void I_Click(object sender, EventArgs e)
        {
            met_a_jour(I);
            Chrono.Start();
        }

        private void J_Click(object sender, EventArgs e)
        {
            met_a_jour(J);
            Chrono.Start();
        }

        private void K_Click(object sender, EventArgs e)
        {
            met_a_jour(K);
            
        }

        private void L_Click(object sender, EventArgs e)
        {
            met_a_jour(L);
            
        }

        private void M_Click(object sender, EventArgs e)
        {
            met_a_jour(M);
            
        }

        private void N_Click(object sender, EventArgs e)
        {
            met_a_jour(N);
           
        }

        private void O_Click(object sender, EventArgs e)
        {
            met_a_jour(O);
            
        }

        private void P_Click(object sender, EventArgs e)
        {
            met_a_jour(P);
            
        }

        private void Q_Click(object sender, EventArgs e)
        {
            met_a_jour(Q);
           
        }

        private void R_Click(object sender, EventArgs e)
        {
            met_a_jour(R);
           
        }

        private void S_Click(object sender, EventArgs e)
        {
            met_a_jour(S);
           
        }

        private void T_Click(object sender, EventArgs e)
        {
            met_a_jour(T);
            
        }

        private void U_Click(object sender, EventArgs e)
        {
            met_a_jour(U);
           
        }

        private void V_Click(object sender, EventArgs e)
        {
            met_a_jour(V);
            
        }

        private void W_Click(object sender, EventArgs e)
        {
            met_a_jour(W);
            
        }

        private void X_Click(object sender, EventArgs e)
        {
            met_a_jour(X);
            
        }

        private void Y_Click(object sender, EventArgs e)
        {
            met_a_jour(Y);
           
        }
        private void Z_Click(object sender, EventArgs e)
        {
            met_a_jour(Z);
            
        }

        private void Tiret_Click(object sender, EventArgs e)
        {
            met_a_jour(Tiret);
        }

        public  void NumeroManche_TextChanged(object sender, EventArgs e)
        {
                      
          
            this.NumeroManche.Text = Pendu2.LancementDuPendu2.NBManches.ToString();
        }

        private void Mancheencours_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombreessais_TextChanged(object sender, EventArgs e)
        {

        }
               
        private void Rejouer_Click(object sender, EventArgs e)
        {
            if (CoupsRestants == 0)
            {
                Chrono.Enabled = false;
                Chrono.Stop();
                Chrono.Dispose();
                Chrono.Start();
                Chrono.Enabled = true;
                reinitialise();


            }
         
          
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
       
        private void Afficheur_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsolePendu_Load(object sender, EventArgs e)
        {

        }
       

        private void Chrono2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Chrono2_Click(object sender, EventArgs e)
        {

        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            Chrono.Enabled = true;
            reinitialise();
            Chrono.Start();
           
        }
    }
}
