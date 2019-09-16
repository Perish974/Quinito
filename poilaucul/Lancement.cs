using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;



namespace Pendu2
{
    /// <summary>
    /// Fenêtre de configuration niveau utilisateur
    /// </summary>

    public partial class LancementDuPendu2 : Form
    {
        /// <summary>
        /// Déclaration des variables de configuration niveau utilisateur
        /// </summary>

        public static bool FR;
        public static bool EN;
        public static bool ES;
        public static string NiveauDeDifficulte;
        public static int NBManches;

        public LancementDuPendu2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestion linguistique francophone du module de configuration niveau utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ChoixFR_Click(object sender, EventArgs e)
        {
            FR = true;
            ChoixNiveauDeDifficulte.Visible = true;
            ChoixNiveauDeDifficulte.Text = "Niveau de difficulté";
            NiveauDeDifficulte1.Text = "Facile";
            NiveauDeDifficulte2.Text = "Difficile";
            NiveauDeDifficulte3.Text = "Expert";
            ChoixNBManches.Visible = true;
            ChoixNBManches.Text = "Nombre de manches";
            NombreManches1.Text = "2 manches";
            NombreManches2.Text = "3 manches";
            NombreManches3.Text = "4 manches";
            NombreManches4.Text = "5 manches";
            NettoyageNBManches.Text = "Réinitialiser le nombre de manches";
            NettoyageNiveauDeDifficulte.Text = "Réinitialiser le niveau de difficulté";
            Lancement.Text = "C'est parti !!!";
        }

        /// <summary>
        /// Gestion linguistique anglophone du module de configuration niveau utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ChoixEN_Click(object sender, EventArgs e)
        {
            EN = true;
            ChoixNiveauDeDifficulte.Visible = true;
            ChoixNiveauDeDifficulte.Text = "Difficulty level";
            NiveauDeDifficulte1.Text = "Easy";
            NiveauDeDifficulte2.Text = "Difficult";
            NiveauDeDifficulte3.Text = "Expert";
            ChoixNBManches.Visible = true;
            ChoixNBManches.Text = "Number of rounds";
            NombreManches1.Text = "2 rounds";
            NombreManches2.Text = "3 rounds";
            NombreManches3.Text = "4 rounds";
            NombreManches4.Text = "5 rounds";
            NettoyageNBManches.Text = "Reset the number of rounds";
            NettoyageNiveauDeDifficulte.Text = "Reset the difficulty level";
            Lancement.Text = "Let's go !!!";
        }

        /// <summary>
        /// Gestion linguistique hispanophone du module de configuration niveau utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ChoixES_Click(object sender, EventArgs e)
        {
            ES = true;
            ChoixNiveauDeDifficulte.Visible = true;
            ChoixNiveauDeDifficulte.Text = "Nivel de dificultad";
            NiveauDeDifficulte1.Text = "Fácil";
            NiveauDeDifficulte2.Text = "Difícil";
            NiveauDeDifficulte3.Text = "Experto";
            ChoixNBManches.Visible = true;
            ChoixNBManches.Text = "Cantidad de rondas";
            NombreManches1.Text = "2 rondas";
            NombreManches2.Text = "3 rondas";
            NombreManches3.Text = "4 rondas";
            NombreManches4.Text = "5 rondas";
            NettoyageNBManches.Text = "Reajustar la cantidad de rondas";
            NettoyageNiveauDeDifficulte.Text = "Reajustar el nivel de dificultad";
            Lancement.Text = "Vamos, juguemos !!!";
        }

        /// <summary>
        /// Choix du niveau de difficulté de la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ChoixNiveauDeDifficulte_Enter(object sender, EventArgs e)
        {
            NettoyageNiveauDeDifficulte.Visible = true;
        }

        private void NiveauDeDifficulte1_CheckedChanged(object sender, EventArgs e)
        {
            NiveauDeDifficulte = "Facile";
            NiveauDeDifficulte2.Enabled = false;
            NiveauDeDifficulte3.Enabled = false;
        }

        private void NiveauDeDifficulte2_CheckedChanged(object sender, EventArgs e)
        {
            NiveauDeDifficulte = "Intermediaire";
            NiveauDeDifficulte1.Enabled = false;
            NiveauDeDifficulte3.Enabled = false;
        }

        private void NiveauDeDifficulte3_CheckedChanged(object sender, EventArgs e)
        {
            NiveauDeDifficulte = "Difficile";
            NiveauDeDifficulte1.Enabled = false;
            NiveauDeDifficulte2.Enabled = false;
        }

        /// <summary>
        /// Nettoyage de la sélection de configuration du niveau de difficulté de la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NettoyageNiveauDeDifficulte_Click(object sender, EventArgs e)
        {
            ChoixNiveauDeDifficulte.Enabled = true;
            foreach (Control ctrl in this.ChoixNiveauDeDifficulte.Controls)
            {
                NiveauDeDifficulte1.Enabled = true;
                NiveauDeDifficulte2.Enabled = true;
                NiveauDeDifficulte3.Enabled = true;
                NiveauDeDifficulte1.Checked = false;
                NiveauDeDifficulte2.Checked = false;
                NiveauDeDifficulte3.Checked = false;
            }
            NettoyageNiveauDeDifficulte.Visible = false;
        }

        /// <summary>
        /// Choix du nombre de manches de la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ChoixNBManches_Enter(object sender, EventArgs e)
        {
            NettoyageNBManches.Visible = true;
        }

        private void NombreManches1_CheckedChanged_1(object sender, EventArgs e)
        {
            NBManches = 2;
            NombreManches2.Enabled = false;
            NombreManches3.Enabled = false;
            NombreManches4.Enabled = false;
        }

        private void NombreManches2_CheckedChanged_1(object sender, EventArgs e)
        {
            NBManches = 3;
            NombreManches1.Enabled = false;
            NombreManches3.Enabled = false;
            NombreManches4.Enabled = false;
        }

        private void NombreManches3_CheckedChanged_1(object sender, EventArgs e)
        {
            NBManches = 4;
            NombreManches1.Enabled = false;
            NombreManches2.Enabled = false;
            NombreManches4.Enabled = false;
        }

        private void NombreManches4_CheckedChanged_1(object sender, EventArgs e)
        {
            NBManches = 5;
            NombreManches1.Enabled = false;
            NombreManches2.Enabled = false;
            NombreManches3.Enabled = false;
        }

        /// <summary>
        /// Nettoyage de la sélection de configuration du nombre de manches de la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NettoyageNBManches_Click(object sender, EventArgs e)
        {
            ChoixNBManches.Enabled = true;
            foreach (Control ctrl in this.ChoixNBManches.Controls)
            {
                NombreManches1.Enabled = true;
                NombreManches1.Checked = false;
                NombreManches2.Enabled = true;
                NombreManches2.Checked = false;
                NombreManches3.Enabled = true;
                NombreManches3.Checked = false;
                NombreManches4.Enabled = true;
                NombreManches4.Checked = false;
            }
            NettoyageNBManches.Visible = false;
        }

        /// <summary>
        /// Validation des sélections de configuration niveau utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private bool ConfigValide()
        {
            if (NettoyageNBManches.Visible == true && NettoyageNiveauDeDifficulte.Visible == true)
            {
                return true;
            }
            return false;
        }

        private void Lancement_Visible(object sender, EventArgs e)
        {
            if (ConfigValide() == true)
            {
                Lancement.Visible = true;
                Lancement.Enabled = true;
            }
            else
            {
                Lancement.Visible = false;
                Lancement.Enabled = false;
            }
        }



        private void Lancement_Click(object sender, EventArgs e)
            {
                Pendu.ConsolePendu f = new Pendu.ConsolePendu();
                f.Show();
                //this.Close();
            }



        


    }
}

    


    

