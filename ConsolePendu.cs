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
        private static string M_a_D;
        //public char[] Mot_Courant;
        private static string[] Lexique;
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
            Scorepartie = 0;
            menu.MenuItems.Add(Quitter);
            menu.MenuItems.Add(Rejouer);
            Menu = mainMenu;
            Lexique = new string[100];
            //init_lexique;
            M_a_D = Lexique [new Random().Next(0, Lexique.Length)];
            Max_Tours = M_a_D.Length + 2;



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

      
    }
}
