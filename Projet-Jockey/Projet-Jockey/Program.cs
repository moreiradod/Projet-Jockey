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
            int[] tChevaux = new int[] { 0, 0, 0, 0 };
            bool bfin = false;
            Random random = new Random();
            string strNom;
            string strParis;

            Console.WriteLine("Bienvenue à la course des chevaux !!");
            Console.WriteLine("****************************************");
            Console.Write("Quel est votre nom ? ");
            strNom = Console.ReadLine();

            //Console.Write("salut {0}", strNom);
            Console.WriteLine("\n*       Les paris sont ouverts !       *");
            Console.WriteLine("****************************************");
            Console.Write("Sur quel cheval désirez vous misez (1,2,3 ou 4)? ");
            strParis = Console.ReadLine();
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Appuyez de manière répétée sur une touche pour faire avancer les chevaux. ");//Consigne de l'exercice.

            

            do
            {
                Console.ReadKey();
                Console.Clear(); //Nettoie la console, dès qu'une touche est pressée. 
                for (int i = 0; i < tChevaux.Length; i++)
                {
                    Console.CursorLeft = iArrive + 15;
                    Console.Write("|"); // détermine le point d'arrivé.
                    Console.CursorLeft = 0;
                    tChevaux[i] += random.Next(4);
                    Console.WriteLine("Cheval {0,2} : {1}#", i + 1, new string('-', tChevaux[i]));
                    if (tChevaux[i] > iArrive)
                    {
                        bfin = true;
                    }
                }
                    
            }
            while (!bfin);

            int iMeilleurDisatance = tChevaux.Max();
            int iMeilleurCheval = tChevaux.ToList().IndexOf(iMeilleurDisatance);
            Console.WriteLine("Le cheval {0} est vainqueur", iMeilleurCheval);
            Console.ReadKey();
        }
    }



}
    

