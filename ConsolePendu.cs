using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu
{
    public partial class Pendu : Form
    {
        private int Scorepartie;
        private int Scoremanche;
        private int Max_Tours;
        private static string Mot_a_D;
        public char[] Mot_Courant;
        private static string[] Lexique;
        public String LettresCherches { get; set; }
        public int CoupsRestants { get; set; }
        public String Mot { get; set; }

        public Pendu()
        {
            InitializeComponent();
            MainMenu mainMenu = new MainMenu();
            MenuItem menu = new MenuItem("Menu");          
            MenuItem Quitter = new MenuItem("Quitter");
            MenuItem Rejouer = new MenuItem("Rejouer");
            mainMenu.MenuItems.Add(menu);
            Quitter.Click += Quitter_Click;
            Rejouer.Click += Rejouer_Click;            
            menu.MenuItems.Add(Quitter);
            menu.MenuItems.Add(Rejouer);
            base.Menu = mainMenu;
            Lexique = new string[100];
            //init_lexique;
            Mot_a_D = Lexique [new Random().Next(0, Lexique.Length)];
            //Max_Tours = Mot_a_D.Length + 2;
            Mot_Courant = new char[Mot_a_D.Length];
            LettresCherches = "";
            Scorepartie = 0;
            CoupsRestants = 7;
            //init Mot_courant();
           // this.label1.Text = char.tostring(Mot_Courant);

            for (int i = 0; i < Mot_a_D.Length; i++)
             {
                 Mot_a_D += "*";
             }         

            void TesteLettre(char lettre)
            {  
                 lettre = lettre.ToString().ToUpper()[0];
                 if (!LettresCherches.Contains(lettre))
                 {
                     LettresCherches += lettre;
                     if (!Mot.Contains(lettre))
                     {
                         CoupsRestants--;
                     }

                     //Mot_a_D = "";
                     foreach (char l in Mot)
                     {
                         if (LettresCherches.Contains(l))
                         {
                             Mot_a_D += l;
                         }
                         else
                         {
                             Mot_a_D += '-';
                         }
                     }
                 }
            }

            bool perdu = false;
            bool gagne = false;

           /* if (!bon)
            {
                MessageBox.Show("Perdu ! Il vous reste " + (Max_Tours - CoupsRestants) + " essais.");
            }*/
            if (CoupsRestants == Max_Tours)
            {
                MessageBox.Show("Désolé... Vous avez perdu.");
                perdu = true;
            }
            if (Enumerable.SequenceEqual(lettres, trouvees))
            {
                MessageBox.Show("Bravo ! Vous avez gagné !");
                gagne = true;
            }
        }

        private void A_Click(object sender, EventArgs e)
        {

        }

        private void B_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void D_Click(object sender, EventArgs e)
        {

        }

        private void E_Click(object sender, EventArgs e)
        {

        }

        private void F_Click(object sender, EventArgs e)
        {

        }

        private void G_Click(object sender, EventArgs e)
        {

        }

        private void H_Click(object sender, EventArgs e)
        {

        }

        private void I_Click(object sender, EventArgs e)
        {

        }

        private void J_Click(object sender, EventArgs e)
        {

        }

        private void K_Click(object sender, EventArgs e)
        {

        }

        private void L_Click(object sender, EventArgs e)
        {

        }

        private void M_Click(object sender, EventArgs e)
        {

        }

        private void N_Click(object sender, EventArgs e)
        {

        }

        private void O_Click(object sender, EventArgs e)
        {

        }

        private void P_Click(object sender, EventArgs e)
        {

        }

        private void Q_Click(object sender, EventArgs e)
        {

        }

        private void R_Click(object sender, EventArgs e)
        {

        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void T_Click(object sender, EventArgs e)
        {

        }

        private void U_Click(object sender, EventArgs e)
        {

        }

        private void V_Click(object sender, EventArgs e)
        {

        }

        private void W_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {

        }

        private void Y_Click(object sender, EventArgs e)
        {

        }
        private void Z_Click(object sender, EventArgs e)
        {

        }

        private void Tiret_Click(object sender, EventArgs e)
        {

        }

        private void NumeroManche_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mancheencours_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombreessais_TextChanged(object sender, EventArgs e)
        {

        }
               
        private void Rejouer_Click(object sender, EventArgs e)
        {

        }

        private void Quitter_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
