using PilesPOO.Tests;
using System;
//using MesOutils;


namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //TestPileVidePleine(5);

                //TesteEmpiler(3);
                //TesteEmpiler(5);

                //TesteEmpilerDepiler();

                //int nbSaisi = Utilitaires.SaisirNb();
                //Console.WriteLine("Nombre Saisi : " + nbSaisi);
                //nbSaisi = Utilitaires.SaisirNb();
                //Console.WriteLine("Nombre Saisi : " + nbSaisi);
                //nbSaisi = Utilitaires.SaisirNb();
                //Console.WriteLine("Nombre Saisi : " + nbSaisi);

                //String nbConverti = Convertir();
                //Console.WriteLine("Aprés Conversion : " + nbConverti ); 

                //TestPile.TestPileVide(5);
                //TestPile.TestEmpiler(2,1);
                //TestPile.TestEmpilerDepiler(4);

                string conv = Utilitaires.Conversion(156, 8);
                Console.WriteLine(conv);

                Console.WriteLine("Fin normale du programme");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Fin  du programme avec Erreur");
            }
            Console.ReadKey();
            
        }

        static string Convertir()
        {
            
                Console.WriteLine("Saisissez le nombre maximal d'éléments dans la liste.");
                int pNbElements = Utilitaires.SaisirNb();
                Console.WriteLine("Saisissez le nombre à convertir.");
                int pNbAConvertir = Utilitaires.SaisirNb();
                Console.WriteLine("Saissez la nouvelle base.");
                int pNewBase = Utilitaires.SaisirNb();

                Pile<Int32> unePile = new Pile<Int32>(pNbElements);
                string retour = "";

                while (pNbAConvertir != 0)
                {
                    unePile.Empiler(pNbAConvertir % pNewBase);
                    pNbAConvertir /= pNewBase;
                }

                while (!unePile.PileVide())
                {
                    int nbDepile = unePile.Depiler();
                    if (nbDepile >= 10)
                    {
                        retour += nbDepile.ToString("X");
                    }
                    else
                    {
                        retour += nbDepile.ToString();
                    }
                }
                return retour;   
        }
    }
}
