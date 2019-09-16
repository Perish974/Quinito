using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lexique
{
    public partial class lexique : Form
    {
        public lexique()
        {
            InitializeComponent();
        }

        private void ButtonLexique_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"Source\lexique.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            StreamReader sr = new StreamReader(fs, Encoding.Default);

            string s = sr.ReadLine();
            string a = textLexique.Text;

            string[] nombredemots = s.Split(' ');
            string[] nombredemotsliste = a.Split(' ');


            foreach (var element in nombredemots)

            {
                if (a.Equals(element))
                {
                    MessageBox.Show("Le mot '" + element + "' existe déjà");
                    textLexique.Text = String.Empty;
                    break;
                }

                else
                {
                    sw.Write(" " + textLexique.Text);
                    MessageBox.Show("Mot ajouté!");
                    textLexique.Text = String.Empty;
                    break;

                }
            }

            sw.Close();
            fs.Close();
            sr.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOuvrir_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"Source\lexique.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string s = sr.ReadToEnd();
            listBox1Liste.Items.Add(s);
            // textBoxListe.Text=(s);
            //while (!sr.EndOfStream)
            //{
            //    listBoxListe.Items.Add(sr.ReadLine());
            //}
            sr.Close();
            fs.Close();
        }

        private void ButtonEffacer_Click(object sender, EventArgs e)
        {
            textBoxListe.Text = string.Empty;
        }
        //ajout des mots à la liste Filtre
        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"Source\lexique.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            StreamReader sr = new StreamReader(fs, Encoding.Default);

            string s = sr.ReadToEnd();
            string a = textLexique.Text;

            string[] nombredemots = s.Split(' ');
            //  string[] nombredemotsliste = a.Split(' ');

            foreach (var element in nombredemots)


            {
                if (a.Equals(element))
                {
                    MessageBox.Show("Le mot '" + element + "' existe déjà");
                    textLexique.Text = String.Empty;


                    break;
                }

            }
            listBoxListe.Items.Add(a);
            textLexique.Text = String.Empty;

            sw.Close();
            fs.Close();
            sr.Close();
        }

        private void ButtonAjout_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"Source\lexique.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string s = sr.ReadLine();
            foreach (string item in listBoxListe.Items)
                sw.Write(" " + item);
            // sw.Write(listBoxListe.Items);
            // sw.Write(" " + textBoxFiltre.Text);
            MessageBox.Show("Mot(s) ajouté(s)!");


            listBoxListe.Items.Clear();
            sw.Close();
            fs.Close();
            sr.Close();
        }

        private void TextBoxListe_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            //listBoxListe.Text = String.Empty;
            listBoxListe.Items.Clear();

        }

        private void ButtonEnlever_Click(object sender, EventArgs e)
        {
            listBoxListe.Items.RemoveAt(listBoxListe.SelectedIndex);

        }
    }
}
