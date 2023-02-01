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
            this.nbMaxElt = nbMaxElt;
            // création de l'objet elements 
            this.elements = new List<int>();
        }

        
       /// <summary>
       /// retourne vrai si la pile ne contient aucun élément
       /// </summary>
       /// <returns>vrai ou faux</returns>

        public bool PileVide()
        {
            return this.elements.Count() == 0;
        }

        /// <summary>
        /// retourne vrai si la pile contient le nombre maximum d'éléments
        /// </summary>
        /// <returns>vrai ou faux</returns>
        public bool PilePleine()
        {
            return this.elements.Count() == this.nbMaxElt;
        }
        /// <summary>
        /// Rajoute l'élément passé en paramètre dans la pile si la pile
        /// n'est pas pleine, sinon déclenche une exception
        /// </summary>
        /// <param name="nb">nombre à empiler</param>
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
        /// <summary>
        /// Renvoie le dernier élément empilé si la pile n'est pas vide. Déclenche une exception si la pile 
        /// est vide
        /// </summary>
        /// <returns></returns>
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
