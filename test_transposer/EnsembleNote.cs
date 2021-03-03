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
        private string _nom;
        private int _id;
        private List<string> notes;



        // propriétés
        public string Nom { get => _nom; set => _nom = value; }
        public int Id { get => _id; set => _id = value; }
        public List<string> Notes { get => notes; }


        // Constructeurs
        public EnsembleNote()
        {
            // Implémenter la liste des notes et ajouter les notes
            notes = new List<string>();
            notes.Add("Do");
            notes.Add("Re");
            notes.Add("Mi");
            notes.Add("Fa");
            notes.Add("Sol");
            notes.Add("La");
            notes.Add("Si");
        }

        public EnsembleNote(string nom, int id)
        {
            _nom = nom;
            _id = id;
        }

        // Méthodes
        public string AffichageNotedeDepart(string noteUser)
        {
            // Récupérer chaque notes
            string[] noteUserArray = noteUser.Split('-');
            string result = "";

            foreach (var note in noteUserArray)
            {
                result += note + " ";
            }

            return result;
        }
    }
}
