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
   
    class EnsembleGamme
    {
        // variables
        private List<string> notesMaj;                  // pas en string mais en Note !
        private List<string> transpoMaj;
        private List<string> notesMin;
        private List<string> transpoMin;
        private string _gammeDepart;
        private string _gammeArrive;
        private int _indexNote;


        // propriétés
        public List<string> NotesMaj { get => notesMaj; }
        public string GammeDepart { get => _gammeDepart; set => _gammeDepart = value; }
        public string GammeArrive { get => _gammeArrive; set => _gammeArrive = value; }
        public int IndexNote { get => _indexNote; set => _indexNote = value; }
        public List<string> Transposition { get => transpoMaj; set => transpoMaj = value; }
        public List<string> TranspoMin { get => transpoMin; set => transpoMin = value; }
        public List<string> NotesMin { get => notesMin; set => notesMin = value; }


        // Constructeurs
        public EnsembleGamme()  
        {
            // Implémenter les liste majeures et mineures des notes et y ajouter les notes
            notesMaj = new List<string>();
            notesMaj.Add("Do");
            notesMaj.Add("Re");
            notesMaj.Add("Mi");
            notesMaj.Add("Fa");
            notesMaj.Add("Sol");
            notesMaj.Add("La");
            notesMaj.Add("Si");
            notesMaj.Add("Do octave");

            //transpoMaj = new List<string>();
            //transpoMaj.Add("Do unisson ");
            //transpoMaj.Add("Re");
            //transpoMaj.Add("Mi");
            //transpoMaj.Add("Fa");
            //transpoMaj.Add("Sol");
            //transpoMaj.Add("La");
            //transpoMaj.Add("Si");
            //transpoMaj.Add("Do octave");

            notesMin = new List<string>();
            notesMin.Add("Do unisson ");
            notesMin.Add("Re");
            notesMin.Add("Mi mineur");
            notesMin.Add("Fa");
            notesMin.Add("Sol");
            notesMin.Add("La mineur");
            notesMin.Add("Si");
            notesMin.Add("Do octave");

            //transpoMin = new List<string>();
            //transpoMin.Add("Do unisson ");
            //transpoMin.Add("Re");
            //transpoMin.Add("Mi");
            //transpoMin.Add("Fa");
            //transpoMin.Add("Sol");
            //transpoMin.Add("La");
            //transpoMin.Add("Si");
            //transpoMin.Add("Do octave");


        }

        // Méthodes

        /// <summary>
        /// Afficher les notes entrées par l'utilisateur au propre 
        /// </summary>
        /// <param name="noteUser"></param>
        /// <returns></returns>
        public string NotesDepart(string noteUser)
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
                for (int i = 0; i < intervalle; i++)
                {
                    
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
