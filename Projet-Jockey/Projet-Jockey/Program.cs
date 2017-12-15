/***************
 * Projet: Jockey
 * Auteur: Daniel
 * Date: 12.12.17
 * Classe: 1M4I1C
 * Version c#: visual studio pro 2017
 * OS: win 10 pro
 * 
 * But: Réaliser une course de chevaux
 *************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Jockey
{
    class Program
    {
        const int iArrive = 50;
        static void Main(string[] args)
        {
            int[] tChevaux = new int[] { 0, 0, 0, 0 }; //Déclaration du tableau.
            bool bfin = false; //Déclaration du bool, qui permet de savoir quand un cheval gagne.
            bool btest = true;//Déclaration du bool pour le try catch.
            ConsoleKeyInfo result; //Permet de quitter le programme avec une touche.
            Random random = new Random();//Déclaration un random.
            int iParis = 0;
            int iParis2 = 0;
            int iParis3 = 0;
            int iParis4 = 0;//Déclaration des paris.
            int iNbJoueurs; //Déclaration du nombre de joueurs. 
            string strJoueur = "joueur";
            string strJoueur2 = "joueur2";
            string strJoueur3 = "joueur3";
            string strJoueur4 = "joueur4";//Déclaration des joueurs.          

            Console.WriteLine("* Bienvenue à la course de chevaux !!  *");
            Console.WriteLine("****************************************");
            Console.Write("Combien de joueurs êtes-vous ? ");
            iNbJoueurs = Convert.ToInt32(Console.ReadLine());

            switch (iNbJoueurs)
            {
                case 1:
                    Console.Write("Quel est votre nom ? ");
                    strJoueur = Console.ReadLine();
                    Console.WriteLine("\n*       Les paris sont ouverts !       *");
                    Console.WriteLine("****************************************");
                    do
                    {
                        try //Permet de ne pas avoir d'erreur, si l'utilisateur met une lettre, alors que nous voulons un nomnbre.
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur);
                            iParis = Convert.ToInt32(Console.ReadLine());

                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis < 1 || iParis > 4); //Tant que le chiffre saisie n'est pas entre 1 et 4 on le redemande.
                    break;

                case 2:
                    Console.Write("Quel est votre nom joueur 1 ? ");
                    strJoueur = Console.ReadLine();
                    Console.Write("Quel est votre nom joueur 2 ? ");
                    strJoueur2 = Console.ReadLine();
                    Console.WriteLine("\n*       Les paris sont ouverts !       *");
                    Console.WriteLine("****************************************");
                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur);
                            iParis = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis < 1 || iParis > 4);

                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ?", strJoueur2);
                            iParis2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis2 < 1 || iParis2 > 4);
                    break;

                case 3:
                    Console.Write("Quel est votre nom joueur 1 ? ");
                    strJoueur = Console.ReadLine();
                    Console.Write("Quel est votre nom joueur 2 ? ");
                    strJoueur2 = Console.ReadLine();
                    Console.Write("Quel est votre nom joueur 3 ? ");
                    strJoueur3 = Console.ReadLine();
                    Console.WriteLine("\n*       Les paris sont ouverts !       *");
                    Console.WriteLine("****************************************");
                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur);
                            iParis = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis < 1 || iParis > 4);

                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur2);
                            iParis2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis2 < 1 || iParis2 > 4);

                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur3);
                            iParis3 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis3 < 1 || iParis3 > 4);
                    break;

                case 4:
                    Console.Write("Quel est votre nom joueur 1 ? ");
                    strJoueur = Console.ReadLine();
                    Console.Write("Quel est votre nom joueur 2 ? ");
                    strJoueur2 = Console.ReadLine();
                    Console.Write("Quel est votre nom joueur 3 ? ");
                    strJoueur3 = Console.ReadLine();
                    Console.Write("Quel est votre nom joueur 4 ? ");
                    strJoueur4 = Console.ReadLine();
                    Console.WriteLine("\n*       Les paris sont ouverts !       *");
                    Console.WriteLine("****************************************");
                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur);
                            iParis = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis < 1 || iParis > 4);

                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur2);
                            iParis2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis2 < 1 || iParis2 > 4);

                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur3);
                            iParis3 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis3 < 1 || iParis3 > 4);

                    do
                    {
                        try
                        {
                            Console.Write("{0},sur quel cheval désirez-vous miser (1,2,3 ou 4) ? ", strJoueur4);
                            iParis4 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            btest = false;
                        }
                    } while (iParis4 < 1 || iParis4 > 4);
                    break;
            }

            Console.WriteLine("****************************************\n");
            Console.WriteLine("Appuyez de manière répétée sur une touche pour faire avancer les chevaux. ");//Instruction pour le bon fonctionnement du jeu.

            do
            {
                Console.ReadKey();
                Console.Clear(); //Nettoie la console, dès qu'une touche est pressée. 
                for (int i = 0; i < tChevaux.Length; i++)
                {
                    Console.CursorLeft = iArrive + 13;
                    Console.Write("|"); //Détermine le point d'arrivé.
                    Console.CursorLeft = 0;
                    tChevaux[i] += random.Next(4);
                    Console.WriteLine("Cheval {0,2} : {1}#", i + 1, new string('-', tChevaux[i])); //Génère le "cheval" + le numéro du cheval.

                    if (tChevaux[i] > iArrive)
                    {
                        bfin = true;
                    }
                }
            }
            while (!bfin); //Qunad un cheval dépasse la ligne le programme s'arrete.

            int iMeilleurDisatance = tChevaux.Max();
            int iMeilleurCheval = tChevaux.ToList().IndexOf(iMeilleurDisatance);


            if (iMeilleurCheval + 1 == iParis)
            {
                Console.WriteLine("\nFécilitaions {0}, le cheval {1} à gagné.", strJoueur, iParis);
            }

            else if (iMeilleurCheval + 1 == iParis2)
            {
                Console.WriteLine("\nFécilitaions {0}, le cheval {1} à gagné.", strJoueur2, iParis2);
            }
            else if (iMeilleurCheval + 1 == iParis3)
            {
                Console.WriteLine("\nFécilitaions {0}, le cheval {1} à gagné.", strJoueur3, iParis3);
            }
            else if (iMeilleurCheval + 1 == iParis4)
            {
                Console.WriteLine("\nFécilitaions {0}, le cheval {1} à gagné.", strJoueur4, iParis4);
            }
            else
            {
                Console.WriteLine("\nDommage vous avez perdu, peut-être la prochaine fois.");
            }

            Console.Write("\n****************************************");
            Console.WriteLine("\nPresser sur la touche Escape une fois pour fermer le programme");


            do
            {
                result = Console.ReadKey();
            } while (result.Key != ConsoleKey.Escape);
        }
    }



}





