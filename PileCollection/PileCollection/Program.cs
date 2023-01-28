using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PileCollection
{
    class Program
    {
        struct Pile
        {
            public int maxElt; //Nb maximum d'elemt dans la pile
            public ArrayList tabElem; //tableau [0...maxElem] d'entiers
        }
        static void Main(string[] args)
        {
            try {

                //TestPileVidePleine(5);
                //TestPileVidePleine(0);
                //TesteEmpiler(5);
                //TesteEmpiler(20);

                //Console.WriteLine(RecupereLoremIpsum(3));
                //TesteSplit();
                TesteInversePhrase();


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }


        ///<summary>
        ///Initialise une nouvelle variable de type Pile
        ///Cette methode :
        ///     Crée un tableau de pNbElement
        ///     Initialise la variable maxElt
        ///</summary>
        ///<param name="pUnePile">Variable de type Pile à initialiser</param>
        ///<param name="pNbElemt">Nombre d'éléments maxi de la Pile</param>
        static void InitPile(ref Pile pUnePile, int pNbElem)
        {
            if (pNbElem > 0)
            {
                pUnePile.maxElt = pNbElem;
                pUnePile.tabElem = new ArrayList();
            }
            else
            {
                throw new Exception("Le nombre d'éléments ne peut pas etre supperieur ou egal à 0");
            }
        }


        ///<summary>
        ///Retourne un bool infiquant si la pile est vide.
        ///Une pile est vide si Capacity est egal à 0.
        ///</summary>
        ///<param name="pUnePile"></param>
        ///<returns></returns>
        static bool PileVide(Pile pUnePile)
        {
            return pUnePile.tabElem.Count == 0;
        }


        ///<summary>
        ///Retourne un bool indiquant si la pile est pleine
        ///La pile est pleine si Count est egale à maxElemt
        ///</summary>
        ///<param name="pUnePile"></param>
        ///<returns></returns>
        static bool PilePleine(Pile pUnePile)
        {
            return pUnePile.tabElem.Count == pUnePile.maxElt;
        }


        ///<summary>
        ///Cette méthode ajoute la valeur passée en paramétre au sommet de la pile
        ///Si la pile n'est pas pleine. 
        ///Si pile est pleine alors déclanchement d'exception.
        ///</summary>
        ///<param name="pUnePile">Pile sur laquelle il faut emplier</param>
        ///<pram name="pNb">Nombre à empiler</pram>
        static void Empiler(ref Pile pUnePile, Object pObj)
        {
            if (PilePleine(pUnePile)){
                throw new Exception("La pile est pleine, imopssible d'empiler");
                }
            else
                {
                 pUnePile.tabElem.Add(pObj);
            }
        }


        ///<summary>
        ///Renvoie la valeur située au sommet de la pile 
        ///Si la pile est vide : déclanche une exception 
        ///</summary>
        ///<param name="pUnePile">Pile à partir de laquelle il faut dépiler</param>
        ///<returns>Valeur depilée</returns>
        static object Depiler(ref Pile pUnePile)
        {
            if (PileVide(pUnePile))
            {
                throw new Exception("La Pile est vide, impossible de dépiler");
            }
            else {
                int indiceSommet = pUnePile.tabElem.Count - 1;
                object retour = pUnePile.tabElem[indiceSommet];
                pUnePile.tabElem.RemoveAt(indiceSommet);
                return retour;
            }
        }




        static void TestPileVidePleine(int nbElem)
        {
            Pile unePile = new Pile();
            InitPile(ref unePile, nbElem);
            if (PileVide(unePile))
            {
                Console.WriteLine("la pile est vide");
            }
            else
            {
                Console.WriteLine("la pile n'est pas vide");
            }
            if (PilePleine(unePile))
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
            Pile unePile = new Pile();
            InitPile(ref unePile, nbElem);
            Empiler(ref unePile, 2);
            Empiler(ref unePile, 14);
            Empiler(ref unePile, 6);
        }


        static void TesteEmpilerDepiler(int nbElem)
        {
            try
            {
                Pile unePile = new Pile();
                InitPile(ref unePile, 5);
                Empiler(ref unePile, 5);
                Empiler(ref unePile, 2);
                Empiler(ref unePile, 22);
                int valeurDepilee = (int)Depiler(ref unePile);
                Console.WriteLine("Valeur dépilée : " + valeurDepilee);
                Empiler(ref unePile, 17);
                valeurDepilee = (int)Depiler(ref unePile);
                Console.WriteLine("Valeur dépilée : " + valeurDepilee);
                valeurDepilee = (int)Depiler(ref unePile);
                Console.WriteLine("Valeur dépilée : " + valeurDepilee);
                valeurDepilee = (int)Depiler(ref unePile);
                Console.WriteLine("Valeur dépilée : " + valeurDepilee);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        ///<summary>
        ///Convertir un nombre en base 10 en base 8
        ///</summary>
        ///<param name="pNbElements">Nombre d'elements de la pile</param>
        ///<param name="pNbAConvertir">Nombre à convertir</param>
        ///<param name="pNewBase">Nouvelle base du nombre</param>
        ///<returns></returns>
        static string Convertir(int pNbElements, int pNbAConvertir, int pNewBase)
        {
            Pile restes = new Pile();
            InitPile(ref restes, pNbElements);
            string retour = "";

            do
            {
                Empiler(ref restes, pNbAConvertir % pNewBase);
                pNbAConvertir /= pNewBase;
            } while (!PilePleine(restes) && pNbAConvertir != 0);

            if (pNbAConvertir != 0)
            {
                throw new Exception("Espace Trop Petit");
            } 

            while (!PileVide(restes))
            {
                int nbDepile = (int)Depiler(ref restes);
                if(nbDepile >= 10)
                {
                    retour += nbDepile.ToString("X");
                }
                else {
                    retour += nbDepile.ToString();
                }
            }

            return retour;

        }


        static string RecupereLoremIpsum(int nbParagraphes)
        {
            HttpClient client = new HttpClient();


            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/text"));
            String url = $"https://loripsum.net/api/{nbParagraphes}/short/plaintext";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;

                return responseBody;
            }
            else
            {
                throw new Exception("Erreur API : " + response.StatusCode + " " + response.ReasonPhrase);
            }

        }

        static void TesteSplit()
        {
            string phrase = " Il fait toujours beau à Toulon";
            var tab = phrase.Split(' ');

            string valeurs = "rue;avenue;boulevard;place";
            tab = valeurs.Split(';');
        }

        static string InversePhrase(string phrase)
        {
            Pile maPile = new Pile();
            InitPile(ref maPile, 200);
            var tab = phrase.Split(' ');
            foreach(string mot in tab)
            {
                Empiler(ref maPile, mot);
            }
            string message = "";
            while (!PileVide(maPile))
            {
                message += " " + Depiler(ref maPile);
            }
            return message;
        }

        static string InversePhraseMieux(string phrase)
        {
            string message = "";
            var tab = phrase.Split(' '); 
            foreach(string mot in tab)
            {
                message = mot + " " + message;
            }
            return message;
        }

        static void TesteInversePhrase()
        {
            try
            {
                string phrase = RecupereLoremIpsum(3);
                Console.WriteLine(phrase);
                string phraseInversee = InversePhraseMieux(phrase);
                Console.WriteLine(phraseInversee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
