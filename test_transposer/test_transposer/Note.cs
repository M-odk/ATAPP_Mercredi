/*
 * Projet: Transposition de notes
 * 
 * Description: Note --> classe qui représente une note de musique
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
    class Note
    {
        // variables
        private string _nom;
        private int _id;



        // propriétés
        public string Nom { get => _nom; set => _nom = value; }
        public int Id { get => _id; set => _id = value; }


        // Constructeurs
        public Note()
        {
        }

        public Note(string nom, int id)
        {
            _nom = nom;
            _id = id;
        }

       
    }
}
