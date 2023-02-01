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

                String nbConverti = Convertir();
                Console.WriteLine("Aprés Conversion : " + nbConverti ); 
                Console.WriteLine( "Fin normale du programme");
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

                Pile unePile = new Pile(pNbElements);
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

            static void TestPileVidePleine(int nbElem)
        {
            Pile unePile = new Pile(nbElem);
            if (unePile.PileVide())
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("la pile n'est pas vide");
            }
            if (unePile.PilePleine())
            {
                Console.WriteLine("la pile est pleine");
            }
            else
            {
                Console.WriteLine("la pile n'est pas pleine");
            }
        }

        static void TesteEmpiler(int nbElem)
        {
            Pile unePile = new Pile(nbElem);
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);
        }

        static void TesteEmpilerDepiler()
        {
            Pile unePile = new Pile(5);
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
    }
}
