using MesOutils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MesOutils.Utilitaires;


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

                //int nbSaisi = SaisirNb();
                //Console.WriteLine("Nombre Saisi : " + nbSaisi);
                //nbSaisi = SaisirNb(10);
                //Console.WriteLine("Nombre Saisi : " + nbSaisi);
                //nbSaisi = SaisirNb(10,30);
                //Console.WriteLine("Nombre Saisi : " + nbSaisi);

                Console.WriteLine("Aprés Conversion : " + Convertir()); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }

        static string Convertir()
        {
            Console.WriteLine("Saisissez le nombre maximal d'éléments dans la liste.");
            int pNbElements = SaisirNb();
            Console.WriteLine("Saisissez le nombre à convertir.");
            int pNbAConvertir = SaisirNb();
            Console.WriteLine("Saissez la nouvelle base.");
            int pNewBase = SaisirNb();

            Pile<Int32> restes = new Pile<Int32>(pNbElements);
            string retour = "";

            do
            {
                restes.Empiler(pNbAConvertir % pNewBase);
                pNbAConvertir /= pNewBase;
            } while (!restes.PilePleine() && pNbAConvertir != 0);

            if (pNbAConvertir != 0)
            {
                throw new Exception("Espace Trop Petit");
            }

            while (!restes.PileVide())
            {
                int nbDepile = restes.Depiler();
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
            Pile<Int32> unePile = new Pile<Int32>(nbElem);
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
            Pile<Int32> unePile = new Pile<Int32>(nbElem);
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);
        }

        static void TesteEmpilerDepiler()
        {
            Pile<Int32> unePile = new Pile<Int32>(5);
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
