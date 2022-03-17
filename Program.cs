using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace touchéCoulé
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le touché coulé");
            Console.WriteLine("Les regles du jeu sont simple allez voir sur Google si vous ne connaisez pas");
            Console.WriteLine("Appuyer sur une touche quand vous etes pret !");
            Console.ReadLine();
            
            int cible;
            
        }


        static void ConstuireMatrice(int[,] toucher)
        {
            int[,] touché = new int[10, 10];
            ModifierLaMatrice(ref touché);
            AfficherMatrice(touché);
            Console.WriteLine(touché);
        }


        static void AfficherMatrice(int[,] touché)
        {
            int NbrLigne = touché.GetLength(0);
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(touché[i, j]);
                }
                Console.WriteLine();
            }
            AfficherMatrice(touché);
        }
        static void ModifierLaMatrice(ref int[,] touché, int nombre)
        {
            touché[1, 1] = nombre;
        }

    }
    static void bateauCoulé(ref int[,] coulé, int coté)
    {
        int bateau1;
        int bateau2;
        int bateau3;
        int bateau4;
        Console.WriteLine("Tapez la colonne que vous voulez ciblé");
        Console.ReadLine();
        Console.WriteLine("Tapez la ligne que vous voulez ciblé");
        Console.ReadLine();
        if (
            bateau1 = ("coulé"){
            Console.WriteLine("Vous avez coulé un bateau");
            Console.ReadLine();

        }
        else (
                Console.WriteLine("A l'eau dommage");
        static void bateauTouché(ref int[,] coulé, int coté)
        {
            Console.WriteLine("Tapez la colonne que vous voulez ciblé");
            Console.ReadLine();
            Console.WriteLine("Tapez la ligne que vous voulez ciblé");
            Console.ReadLine();
            if (
            bateau1 = ("touché"){
                Console.WriteLine("Vous avez touché un bateau");
                Console.ReadLine();
            }
        }
    }



}



