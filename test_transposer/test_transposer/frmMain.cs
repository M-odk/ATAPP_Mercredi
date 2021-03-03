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
 * Set/Get comme il faut les properties dans EnsembleNote
 * Récupérer les index des comboboxs : https://www.codeproject.com/Questions/430566/how-to-get-ID-on-an-item-in-combo-box
 * Faire le calcul entre les gammes (sans les clés, bémols diez etc...)
 * Afficher le résultat 
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
        EnsembleNote LesNotes;



        public frmMain()
        {
            InitializeComponent();
            LesNotes = new EnsembleNote();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // afficher les notes dans les combobox 
            AfficherNotesDansCombobox();
        }

        private void btnTransposer_Click(object sender, EventArgs e)
        {
            // récupérer l'entrée utilisateur 
            notesUser = tbxNotesPartition.Text;

            // Récupérer la gamme depuis laquelle on doit transposer
            GammeDeDepart = cmbTonaliteDepart.SelectedIndex;
            // Récupérer la gamme dans laquelle on doit transposer
            GammeArrivee = cmbTonaliteTransposee.SelectedIndex;

            // Envoyer à la méthode l'entrée utilisateur et afficher le résultat
            tbxResultDepart.Text = LesNotes.AfficherNotesdeDepart(notesUser);
            tbxResultTransposee.Text = LesNotes.TransposerNotes(GammeDeDepart, GammeArrivee);


        }

        /// <summary>
        /// Parcours la liste de notes pour ajouter chaque note dans les combobox
        /// </summary>
        public void AfficherNotesDansCombobox()
        {
            // Ajouter les items dans les combobox 
            foreach (var note in LesNotes.Notes)
            {
                cmbTonaliteDepart.Items.Add(note);
                cmbTonaliteTransposee.Items.Add(note);
            }

        }



        //public int RecupererItemID()
        //{

        //}



    }
}
