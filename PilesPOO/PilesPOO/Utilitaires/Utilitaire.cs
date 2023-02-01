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
               Console.Write("Veuillez saisir une valeur : ");
               int nb = Convert.ToInt32(Console.ReadLine());
                return nb;
               
        }

    }
}

