using System;

namespace exercice_d_affectation_de_filieres_d_informatique
{
    class Program
    {
        public static void Main(string[] args)
        {

            string[] choix = new string[3];
            string[] filieres = { "abd", "asr", "gl" };
            // prenons l'expemple qu'il ya 2 etudiants qui candidatent pour les 3 options
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("entrez votre 1er choix ");
                choix[0] = Console.ReadLine();
                Console.WriteLine("entrez votre 2eme choix ");
                choix[1] = Console.ReadLine();
                Console.WriteLine("entrez votre 3eme choix ");
                choix[2] = Console.ReadLine();
            }
            bool etudiantAffecte = true;
            bool filiereEmpty = true;
            string filiere1 = "";
            string filiere2 = "";
            // supposons qu'on a deja leur notes de 1er annee
            int note1 = 14;
            int note2 = 13;
            for (int l = 0; l < 3; l++)
            {
                //tant que l'etudiant n'est affecte a aucune filiere
                while (!etudiantAffecte)
                {
                    //et la filiere n'est attribue a aucun etudiant
                    if (filiereEmpty)
                    {
                        //on affecte la filiere au choix premier du premier etudiant
                        filiere1 = choix[l];
                    }
                    // si la filiere est deja affecte au deuxieme etudiant
                    else if (filiere2 == choix[l])
                    {
                        // si la note du premier est > deuxieme
                        if (note1 > note2)
                        {
                            //la filiere est attribue au premier etudiant
                            filiere1 = choix[l];

                        }
                        else
                        {
                            //sinon la filiere reste affecte au deuxieme etudiant
                            filiere2 = choix[l];
                        }
                    }
                }
            }


        }

    }
}
