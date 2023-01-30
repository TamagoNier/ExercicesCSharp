using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilesPOO
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
        public Pile(int nbMaxElt, List<int> elements)
        {
            this.NbMaxElt = nbMaxElt;
            this.elements = new List<int>();
        }

        public int NbMaxElt //Property
        {
            get {
                return nbMaxElt;
            }
            set
            {
                nbMaxElt = value;
            }
        }

        public bool PileVide(Pile unePile)
        {
            return unePile.elements.Count() == 0;
        }

    }
}
