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
    }
}
