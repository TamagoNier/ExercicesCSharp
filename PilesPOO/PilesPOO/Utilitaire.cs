using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesOutils
{
    public abstract class Utilitaires
    {
        public static int SaisirNb()
        {
            int nb = 0;
            try    
            {                                    
                Console.WriteLine("Veuillez saisir une valeur : ");                    
                nb = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nb;
        }

        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.WriteLine("Veuillez saisir une valeur supérieure à " + pMin + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                    if(nb< pMin)
                    {
                        throw new Exception("Valeur trop petite");
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            } while (nb < pMin);
            return nb;
        }

        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.WriteLine("Veuillez saisir une valeur supérieure à " + pMin + " et inferieur à " + pMax + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                    if (nb < pMax ^ nb > pMax)
                    {
                        throw new Exception("Eurreur de valeur"); 
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            } while (nb < pMin & nb > pMax);
            return nb;
        }
    }
}

