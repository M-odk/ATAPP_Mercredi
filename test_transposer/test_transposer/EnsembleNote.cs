/*
 * Projet: Transposition de notes
 * 
 * Description: EnsembleNote --> classe pour transposer les notes et intéragir avec la vue (Form)
 * 
 * ODAKA M. || CFPT-I || IFDA-P3A
 * 
 * Date: 27.01.2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_transposer
{
    // une note contient un nom (pour l'instant)
    class EnsembleNote
    {
        // variables
        private List<string> notes;
        private List<string> transposition;
        private string _gammeDepart;
        private string _gammeArrive;
        private int _indexNote;


        // propriétés
        public List<string> Notes { get => notes; }
        public string GammeDepart { get => _gammeDepart; set => _gammeDepart = value; }
        public string GammeArrive { get => _gammeArrive; set => _gammeArrive = value; }
        public int IndexNote { get => _indexNote; set => _indexNote = value; }
        public List<string> Transposition { get => transposition; set => transposition = value; }


        // Constructeurs
        public EnsembleNote()
        {
            // Implémenter la liste des notes et y ajouter les notes
            notes = new List<string>();
            notes.Add("Do unisson ");
            notes.Add("Re");
            notes.Add("Mi");
            notes.Add("Fa");
            notes.Add("Sol");
            notes.Add("La");
            notes.Add("Si");
            notes.Add("Do octave");

            transposition = new List<string>();
            transposition.Add("Do unisson ");
            transposition.Add("Re");
            transposition.Add("Mi");
            transposition.Add("Fa");
            transposition.Add("Sol");
            transposition.Add("La");
            transposition.Add("Si");
            transposition.Add("Do octave");

        }

        // Méthodes

        /// <summary>
        /// Afficher les notes entrées par l'utilisateur au propre 
        /// </summary>
        /// <param name="noteUser"></param>
        /// <returns></returns>
        public string AfficherNotesdeDepart(string noteUser)
        {
            // Récupérer chaque notes 
            string[] noteUserArray = noteUser.Split(new char[] { '-', ' ', '/', '.' });
            string result = "";

            // parcourir et afficher sans le séparateur
            foreach (var note in noteUserArray)
            {
                result += note + " ";
            }

            return result;
        }

        /// <summary>
        /// Calcul pour transposer de la gamme de départ à la gamme d'arrivée
        /// </summary>
        /// <returns></returns>
        public string TransposerNotes(int noteDepart, int noteArrivee)
        {
            int intervalle = noteArrivee - noteDepart;
            string result = "";
            // ca veut dire que la gamme va monter
            if (intervalle > 0 )
            {
                // il faut décaler du nombre d'intervalle vers le haut (aigu)
                // même vision pour la liste, 1er élément s'enlève
                for (int i = 0; i < intervalle; i++)
                {
                    // retirer jusqu'a être à l'intervalle que l'on veut
                    transposition.RemoveAt(0);
                }
                
            }
            else if (intervalle < 0) // la gamme va descendre
            {
                // il faut décaler du nombre d'intervalle vers le bas (grave)

            }
            else // la gamme est la même
            {
                // message pour dire que ça ne change pas ? 

            }
            return result;
        }
    }
}
