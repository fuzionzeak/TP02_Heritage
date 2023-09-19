using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class PieceNonAgreee : Piece
    {
        #region attributs privés
        private string etat;
        private int seuil;
        #endregion

        #region constructeur
        public PieceNonAgreee(int unNumero, string unLibelle, int unNombre, int unSeuil)
            :base(unNumero, unLibelle, unNombre)
        {
            this.etat = "VERT";
            this.seuil = unSeuil;
        }
        #endregion
        #region methodes
        
    }
}