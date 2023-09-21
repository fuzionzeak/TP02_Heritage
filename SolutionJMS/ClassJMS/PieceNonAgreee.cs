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
        public string GetEtat()
        {
            return this.etat;
        }


        public void ChangerEtat (string unEtat)
        {
            this.etat = unEtat.ToUpper();
        }

        public override bool AControler()
        {
            bool controleOK = false;
            if(this.etat == "VERT" && base.nbHeures >= this.seuil)
            {
                controleOK = true;
                this.etat = "ORANGE";
            }
            return controleOK;
        }

    }
}