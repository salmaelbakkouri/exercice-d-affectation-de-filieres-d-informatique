using System;
using System.Collections.Generic;
using System.Text;

namespace exercice_d_affectation_de_filieres_d_informatique
{
    class Etudiant
    {
        public string nom;
        public string prenom;
        public string noteMoy;

        public Etudiant(string nomEt, string prenomEt, float noteMoyEt)
        {
            NomEt = nomEt;
            PrenomEt = prenomEt;
            NoteMoyEt = noteMoyEt;
        }

        public string NomEt { get; }
        public string PrenomEt { get; }
        public float NoteMoyEt { get; }
    }
}
