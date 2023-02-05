using MesOutils;
using System;

namespace PilesPOO.Tests
{
    internal abstract class TestPile
    {

        /// <summary>
        /// Teste si la methode PileVide fonctionne
        /// </summary>
        /// <param name="nbElem"></param>
        public static void TestPileVide(int nbElem)
        {
            Pile<Int32> unePile = new Pile<Int32>();
            if (unePile.PileVide())
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("la pile n'est pas vide");
            }
        }

        /// <summary>
        /// Teste la fonction empiler 
        /// si empiler echoue renvoie une exception
        /// </summary>
        /// <param name="nbElem"></param>
        /// <param name="nb"></param>
        public static void TestEmpiler(int nbElem, int nb)
        {
            try
            {
                Pile<Int32> pile = new Pile<Int32>();
                pile.Empiler(nb);
                Console.WriteLine("Empilé avec succées");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void TestEmpilerDepiler()
        {
            Pile<Int32> unePile = new Pile<Int32>();
            unePile.Empiler(5);
            unePile.Empiler(2);
            unePile.Empiler(22);
            int valeurDepilee = unePile.Depiler();
            Console.WriteLine("Valeur dépilée : " + valeurDepilee);
            unePile.Empiler(17);
            valeurDepilee = unePile.Depiler();
            Console.WriteLine("Valeur dépilée : " + valeurDepilee);
            valeurDepilee = unePile.Depiler();
            Console.WriteLine("Valeur dépilée : " + valeurDepilee);
            valeurDepilee = unePile.Depiler();
            Console.WriteLine("Valeur dépilée : " + valeurDepilee);
            valeurDepilee = unePile.Depiler();
            Console.WriteLine("Valeur dépilée : " + valeurDepilee);
        }

        /// <summary>
        /// Cette methode demande la saisie des nombre à convertir 
        /// et la nouvelle base
        /// </summary>
        public static void TestConversion()
        {
            Console.WriteLine("Saisissez le nombre à convertir :  ");
            int nbAConvertir = Utilitaires.SaisirNb();
            Console.WriteLine();
            int newBase = Utilitaires.SaisirNb();
            // Appel de la surcharge pour effectuer la conversion 
            TestConversion(nbAConvertir, newBase);
        }

        public static void TestConversion(int nbAConvertir, int newBase)
        {
            try
            {
                string valeurConvertie = Utilitaires.Conversion(nbAConvertir, newBase);
                Console.WriteLine("valeurConvertie convertie : " + valeurConvertie);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
