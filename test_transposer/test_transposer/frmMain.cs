/*
 * Projet: Transposition de notes
 * 
 * Description: transposition simple d'une tonalité à une autre (sans # et bémols)
 *              Version 1 très simplifiée pour pouvoir créer une "base"
 * 
 * ODAKA M. || CFPT-I || IFDA-P3A
 * 
 * Date: 27.01.2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* TODO - QUESTIONS
 * 
 * Transposer()
 * Verifier si les entrées utilisateurs sont bien des notes 
 * Implémenter toutes les notes et ensuite créer chaque gammes (majeure et sa relative = pareil)
 * 
 */

// lien utile : http://www.aprlmusic.com/?p=11942 
namespace test_transposer
{

    public partial class frmMain : Form
    {
        // Variables 
        string notesUser = ""; // entrée utilisateur
        int GammeDeDepart = 0; //gamme de départ
        int GammeArrivee = 0; // gamme après transposition
        EnsembleGamme gamme;


        public frmMain()
        {
            InitializeComponent();
           // LesNotes = new EnsembleNote();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // afficher les notes dans les combobox (majeur de base)
            AfficherNotesDansCombobox(false); 
        }

        private void btnTransposer_Click(object sender, EventArgs e)
        {
            // récupérer l'entrée utilisateur 
            notesUser = tbxNotesPartition.Text;

            // Vérifier si l'utilisateur a bien entré quelque chose
            if (String.IsNullOrEmpty(notesUser))
            {
                lblEntry.ForeColor = Color.Red;
            }

                                                                        

            // Récupérer la gamme depuis laquelle on doit transposer
            GammeDeDepart = cmbTonaliteDepart.SelectedIndex;
            // Récupérer la gamme dans laquelle on doit transposer
            GammeArrivee = cmbTonaliteTransposee.SelectedIndex;

            // afficher les notes que l'utilisateur veut transposer (notes de départ)
            tbxResultDepart.Text = LesNotes.NotesDepart(notesUser);
            // afficher la transposition des notes 
            tbxResultTransposee.Text = LesNotes.TransposerNotes(GammeDeDepart, GammeArrivee);


        }


        /// <summary> 
        /// Ajouter les notes qui appartiennent soit à la liste majeure soit à la liste des notes mineures.
        /// </summary>
        /// <param name="mineur"> Savoir si le radioButton est coché ou non</param>
        public void AfficherNotesDansCombobox(bool mineur)
        {
            // vider les comboboxs
            cmbTonaliteDepart.Items.Clear();
            cmbTonaliteTransposee.Items.Clear();

            if (mineur == true)
            {

                // Ajouter les items dans les combobox 
                foreach (var note in LesNotes.NotesMin)
                {
                    cmbTonaliteDepart.Items.Add(note);
                    cmbTonaliteTransposee.Items.Add(note);
                }
            }
            else
            {
                // Ajouter les items dans les combobox 
                foreach (var note in LesNotes.NotesMaj)
                {
                    cmbTonaliteDepart.Items.Add(note);
                    cmbTonaliteTransposee.Items.Add(note);
                }
            }
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // message
        }

        private void ckbMineur_CheckedChanged(object sender, EventArgs e)
        {
            bool mineur = ckbMineur.Checked;

            AfficherNotesDansCombobox(mineur);
        }
    }
}
