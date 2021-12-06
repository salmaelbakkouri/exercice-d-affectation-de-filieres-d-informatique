using System;
using System.Collections.Generic;

namespace exercice_d_affectation_de_filieres_d_informatique

{
    class Program
    {
        static void Main(string[] args)
        {
            //creer les 3 options 
            Option genieLogiciel = new Option();
            genieLogiciel.nom = "GL";
            Console.WriteLine("entrez le nombre de places disponibles dans GL :");
            genieLogiciel.placesDisponibles = int.Parse(Console.ReadLine());

            Option ABaseDonnées = new Option();
            ABaseDonnées.nom = "ABD";
            Console.WriteLine("entrez le nombre de places disponibles dans ABD :");
            ABaseDonnées.placesDisponibles = int.Parse(Console.ReadLine());

            Option ASystemeReseau = new Option();
            ASystemeReseau.nom = "ASR";
            Console.WriteLine("entrez le nombre de places disponibles dans ASR :");
            ASystemeReseau.placesDisponibles = int.Parse(Console.ReadLine());

            Console.WriteLine("entrez le nombre des etudiants de la filiére informatique : ");
            int nbEtudiant = int.Parse(Console.ReadLine());

            //creer une liste des tuples contenant les etudiants et leurs choix
            var listEt = new List<Tuple<Etudiant, string, string, string>>();


            //entrer les etudiants et leurs choix
            for (int i = 0; i < nbEtudiant; i++)
            {
                Console.WriteLine("entrez le nom d'etudiant");
                string nomEt = Console.ReadLine();
                Console.WriteLine("entrez le prenom d'etudiant");
                string prenomEt = Console.ReadLine();
                Console.WriteLine("entrez la note d'etudiant de 1ère année :");  //utiliser la virgule ,
                float noteMoyEt = float.Parse(Console.ReadLine());
                Etudiant etudiant1 = new Etudiant(nomEt, prenomEt, noteMoyEt);

                Console.WriteLine("entrez le choix 1 ");
                string ch1 = Console.ReadLine();
                Console.WriteLine("entrez le choix 2");
                string ch2 = Console.ReadLine();
                Console.WriteLine("entrez le choix 3");
                string ch3 = Console.ReadLine();


                var tuple1 = Tuple.Create(etudiant1, ch1, ch2, ch3);
                listEt.Add(tuple1);

            }
            //classer la liste des etudiants par ses notes  de 1 ére année
            listEt.Sort((s1, s2) => s2.Item1.noteMoy.CompareTo(s1.Item1.noteMoy));

            //creer 3 listes des etudiants de 3 options pour l'affichage
            var listEtGL = new List<Etudiant>();
            var listEtABD = new List<Etudiant>();
            var listEtASR = new List<Etudiant>();

            //traiter les cas des options
            for (int k = 0; k < nbEtudiant; k++)
            {
                switch (listEt[k].Item2)
                {
                    case "GL":
                        if (genieLogiciel.placesDisponibles > 0)
                        {
                            Etudiant item1 = listEt[k].Item1;
                            listEtGL.Add(item1);
                            --genieLogiciel.placesDisponibles;
                        }
                        else
                        {

                            switch (listEt[k].Item3)
                            {
                                case "ABD":
                                    if (ABaseDonnées.placesDisponibles > 0)
                                    {
                                        Etudiant item2 = listEt[k].Item1;
                                        listEtABD.Add(item2);
                                        --ABaseDonnées.placesDisponibles;
                                    }
                                    else
                                    {
                                        if (listEt[k].Item4 == "ASR" && ASystemeReseau.placesDisponibles > 0)
                                        {
                                            Etudiant item3 = listEt[k].Item1;
                                            listEtASR.Add(item3);
                                            --ASystemeReseau.placesDisponibles;
                                        }
                                    }
                                    break;

                                case "ASR":
                                    if (ASystemeReseau.placesDisponibles > 0)
                                    {
                                        Etudiant item2 = listEt[k].Item1;
                                        listEtASR.Add(item2);
                                        --ASystemeReseau.placesDisponibles;
                                    }
                                    else
                                    {
                                        if (listEt[k].Item4 == "ABD" && ABaseDonnées.placesDisponibles > 0)
                                        {
                                            Etudiant item3 = listEt[k].Item1;
                                            listEtABD.Add(item3);
                                            --ABaseDonnées.placesDisponibles;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "ABD":
                        if (ABaseDonnées.placesDisponibles > 0)
                        {
                            Etudiant item1 = listEt[k].Item1;
                            listEtABD.Add(item1);
                            --ABaseDonnées.placesDisponibles;
                        }
                        else
                        {

                            switch (listEt[k].Item3)
                            {
                                case "GL":
                                    if (genieLogiciel.placesDisponibles > 0)
                                    {
                                        Etudiant item2 = listEt[k].Item1;
                                        listEtGL.Add(item2);
                                        --genieLogiciel.placesDisponibles;
                                    }
                                    else
                                    {
                                        if (listEt[k].Item4 == "ASR" && ASystemeReseau.placesDisponibles > 0)
                                        {
                                            Etudiant item3 = listEt[k].Item1;
                                            listEtASR.Add(item3);
                                            --ASystemeReseau.placesDisponibles;
                                        }
                                    }
                                    break;

                                case "ASR":
                                    if (ASystemeReseau.placesDisponibles > 0)
                                    {
                                        Etudiant item2 = listEt[k].Item1;
                                        listEtASR.Add(item2);
                                        --ASystemeReseau.placesDisponibles;
                                    }
                                    else
                                    {
                                        if (listEt[k].Item4 == "GL" && genieLogiciel.placesDisponibles > 0)
                                        {
                                            Etudiant item3 = listEt[k].Item1;
                                            listEtGL.Add(item3);
                                            --genieLogiciel.placesDisponibles;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                    case "ASR":
                        if (ASystemeReseau.placesDisponibles > 0)
                        {
                            Etudiant item1 = listEt[k].Item1;
                            listEtASR.Add(item1);
                            --ASystemeReseau.placesDisponibles;
                        }
                        else
                        {

                            switch (listEt[k].Item3)
                            {
                                case "ABD":
                                    if (ABaseDonnées.placesDisponibles > 0)
                                    {
                                        Etudiant item2 = listEt[k].Item1;
                                        listEtABD.Add(item2);
                                        --ABaseDonnées.placesDisponibles;
                                    }
                                    else
                                    {
                                        if (listEt[k].Item4 == "GL" && genieLogiciel.placesDisponibles > 0)
                                        {
                                            Etudiant item3 = listEt[k].Item1;
                                            listEtGL.Add(item3);
                                            --genieLogiciel.placesDisponibles;
                                        }
                                    }
                                    break;

                                case "GL":
                                    if (genieLogiciel.placesDisponibles > 0)
                                    {
                                        Etudiant item2 = listEt[k].Item1;
                                        listEtGL.Add(item2);
                                        --genieLogiciel.placesDisponibles;
                                    }
                                    else
                                    {
                                        if (listEt[k].Item4 == "ABD" && ABaseDonnées.placesDisponibles > 0)
                                        {
                                            Etudiant item3 = listEt[k].Item1;
                                            listEtABD.Add(item3);
                                            --ABaseDonnées.placesDisponibles;
                                        }
                                    }
                                    break;
                            }

                        }
                        break;

                }

            }

            //affichage des 3 listes des options
            Console.WriteLine("la liste de GL :");
            foreach (Etudiant item in listEtGL)
            {
                Console.WriteLine(item.nom + "\t" + item.prenom + "\t" + item.noteMoy);
            }
            Console.WriteLine("/////////////////////////////////////////////////");
            Console.WriteLine("la liste de ABD :");
            foreach (Etudiant item1 in listEtABD)
            {
                Console.WriteLine(item1.nom + "\t" + item1.prenom + "\t" + item1.noteMoy);
            }
            Console.WriteLine("/////////////////////////////////////////////////");
            Console.WriteLine("la liste de ASR :");

            foreach (Etudiant item2 in listEtASR)
            {
                Console.WriteLine(item2.nom + "\t" + item2.prenom + "\t" + item2.noteMoy);
            }
        }

    }
}
