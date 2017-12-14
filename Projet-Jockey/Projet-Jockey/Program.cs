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
            int[] tChevaux = new int[] { 0, 0, 0, 0 }; //déclaration d'un tableau
            bool bfin = false;
            Random random = new Random();
            string strNom;
            int iParis;
            

            Console.WriteLine("Bienvenue à la course des chevaux !!");
            Console.WriteLine("****************************************");
            Console.Write("Quel est votre nom ? ");
            strNom = Console.ReadLine();
            Console.WriteLine("\n*       Les paris sont ouverts !       *");
            Console.WriteLine("****************************************");
            Console.Write("Sur quel cheval désirez-vous miser (1,2,3 ou 4)? ");
            iParis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************\n");
            Console.WriteLine("Appuyez de manière répétée sur une touche pour faire avancer les chevaux. ");//Consigne de l'exercice.

            

            do
            {
                Console.ReadKey();
                Console.Clear(); //Nettoie la console, dès qu'une touche est pressée. 
                for (int i = 0; i < tChevaux.Length; i++)
                {
                    Console.CursorLeft = iArrive + 13;
                    Console.Write("|"); // détermine le point d'arrivé.
                    Console.CursorLeft = 0;
                    tChevaux[i] += random.Next(4);
                    Console.WriteLine("Cheval {0,2} : {1}#", i + 1, new string('-', tChevaux[i])); //génère le "cheval" + le numéro du cheval.

                    if (tChevaux[i] > iArrive)
                    {
                        bfin = true;
                    }
                }
                    
            }
            while (!bfin); //Qunad un cheval dépasse la ligne le programme s'arrete.

            int iMeilleurDisatance = tChevaux.Max();
            int iMeilleurCheval = tChevaux.ToList().IndexOf(iMeilleurDisatance);

            if(iMeilleurCheval+1 == iParis)
            {
                Console.WriteLine("\nFécilitaions {0}, le cheval {1} à gagné.", strNom, iParis);
            }

            else
            {
                Console.WriteLine("\nDommage {0}, le cheval {1} a perdu, peut-être la prochaine fois.", strNom, iParis);
            }

            
            Console.Write("****************************************");
            Console.WriteLine("\nPresser sur la touche Escape deux fois pour fermer le programme");

            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                if (result.Key == ConsoleKey.Escape)
                {
                    Console.ReadKey();
                    break;
                }

            }
            
            
        }
    }



}
    

