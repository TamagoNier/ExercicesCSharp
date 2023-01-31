using PilesPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                TestPileVidePleine(5);

                TesteEmpiler(3);
                TesteEmpiler(5);

                TesteEmpilerDepiler();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
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
