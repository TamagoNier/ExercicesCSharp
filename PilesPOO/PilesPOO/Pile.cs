using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesOutils
{
    /// <summary>
    /// Pile pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté.
    /// On retire toujours le dernier élément ajouté.
    /// </summary>
    class Pile
    {
        /// <summary>
        /// Nombre maximum d'élements de la pile
        /// </summary>
        private int nbMaxElt;

        /// <summary>
        /// Liste contenat les éléments de la pile
        /// </summary>
        private List<int> elements;

        /// <summary>
        /// Constructeur de la classe Pile
        /// </summary>
        /// <param name="nbMaxElt"></param>
        /// <param name="elements"></param>
        public Pile(int nbMaxElt)
        {
            this.NbMaxElt = nbMaxElt;
            this.elements = new List<int>();
        }

        /// <summary>
        /// renvoi ou modifie la valeur nbMaxElt
        /// </summary>
        public int NbMaxElt //Property
        {
            get {
                if (nbMaxElt > 0)
                {
                    return nbMaxElt;
                }
                else
                {
                    throw new Exception("Le nombre maximal doit etre supérieur à 0");
                }
                
            }
            set
            {
                nbMaxElt = value;
            }
        }

        public bool PileVide()
        {
            return this.elements.Count() == 0;
        }

        public bool PilePleine()
        {
            return this.elements.Count() == NbMaxElt;
        }

        public void Empiler(int nb)
        {
            if (this.PilePleine())
            {
                throw new Exception("La pile est pleine, impossible à empiler");
            }
            else
            {
                this.elements.Add(nb);
            }
        }
        public int Depiler()
        {
            if (this.PileVide())
            {
                throw new Exception("La Pile est vide, impossible de dépiler");
            }
            else
            {
                int indiceSommet = this.elements.Count - 1;
                int retour = this.elements[indiceSommet];
                this.elements.RemoveAt(indiceSommet);
                return retour;
            }
        }

    }
}
