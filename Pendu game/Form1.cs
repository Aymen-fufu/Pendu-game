using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Pendu_game
{
    public partial class Fenetre : Form
    {
        private bool IsClicked{ get; set; }

        public Fenetre()
        {
            InitializeComponent();
            btn_char.Enabled = false;
            IsClicked = false;
            ComboLettre(this, EventArgs.Empty);

            
        }
        
        private void Remplir()
        {
            combo_char.Items.Clear();
            for (int i = 0; i < 26; i++)
            {
                combo_char.Items.Add((char)('A' + i));
            }
            combo_char.SelectedIndex = 0;
        }
        static bool ContientUniquementLettresSansAccents(string input)
        {
            Regex regex = new Regex("^[A-Za-z]+$");
            return regex.IsMatch(input);
        }

        private void FenetreJeu(object sender, EventArgs e)
        {

        }

        private void ImagePendu(object sender, EventArgs e)
        {

        }

        private void BoutonLettre(object sender, EventArgs e)
        {
            try
            {
                
                char lettre = char.Parse(combo_char.SelectedItem.ToString());
                liste_char.Text += lettre;
                combo_char.Items.RemoveAt(combo_char.SelectedIndex);
                combo_char.SelectedIndex = 0;
            }
            catch
            {
                liste_char.Enabled = false;
            }

        }
       
        
        private void BoutonMot(object sender, EventArgs e)
        {

            
            if (mot_chercheur.Text.Length > 15)
            {
                MessageBox.Show("Le message est trop long (15 char max)");
                mot_chercheur.Text = "";
                mot_chercheur.Focus();
            }
            if (!ContientUniquementLettresSansAccents(mot_chercheur.Text))
            {
                MessageBox.Show("Le mot ne doit contenir des  lettres et non accentue");
                mot_chercheur.Text = "";
                mot_chercheur.Focus();
            }
            else
            {   
                IsClicked = true;
                MessageBox.Show("Le mot a ete enregistre");

            }
            if (IsClicked == true)
            {
                btn_char.Enabled = true;
                IsClicked = false;
                button2.Enabled = false;
                mot_chercheur.Enabled = false;
            }
            
        }

        private void TextePendu(object sender, EventArgs e)
        {

        }

        private void TexteChercheur(object sender, EventArgs e)
        {
            mot_chercheur.Focus();

        }

        private void ComboLettre(object sender, EventArgs e)
        {
            Remplir();
        }

        private void ListeChar(object sender, EventArgs e)
        {

        }

        private void BtnReset(object sender, EventArgs e)
        {
            btn_char.Enabled=false;
            liste_char.Items.Clear();
            textBox2.Clear();
            button2.Enabled=true;
        }
    }
    }

