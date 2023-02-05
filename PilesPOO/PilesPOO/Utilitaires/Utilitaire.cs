using System;

namespace MesOutils
{
    public abstract class Utilitaires
    {
        /// <summary>
        /// permet de 
        /// </summary>
        /// <returns></returns>
        public static int SaisirNb()
        {
               Console.Write(" ");
               int nb = Convert.ToInt32(Console.ReadLine());
               return nb;
               
        }

        /// <summary>
        /// Converti un nombre en base 10 en un nombre en base 2 à 16
        /// </summary>
        /// <param name="nbAConvertir"></param>
        /// <param name="newBase"></param>
        /// <returns></returns>
        public static string Conversion(int nbAConvertir, int newBase)
        {
            if (nbAConvertir <= 0)
            {
                throw new Exception("Le nombre à convertir doit etre superieur à 0");
            }
            if (newBase < 2 & newBase > 16)
            {
                throw new Exception("La nouvelle base doit être comprise entre 2 et 16");
            }

            int reste;
            string retour = "";

            while (nbAConvertir != 0)
            {
                reste = nbAConvertir % newBase;
                retour = reste.ToString("X") + retour;
                nbAConvertir /= newBase;

            }
            return retour;
        }

        
    }
}

