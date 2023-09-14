using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class PieceAgreee : Piece
    {
        private DateTime dateAgrement;
        private string nomConstructeur;

        public PieceAgreee(int numSerie, string libelle, int nbHeures, DateTime dateAgrement, string nomConstructeur)
            : base(numSerie, libelle, nbHeures)
        {
            this.dateAgrement = dateAgrement;
            this.nomConstructeur = nomConstructeur;
        }

        public void renouvelerAgrement(DateTime nouvelleDate)
        {
            this.dateAgrement = nouvelleDate;
        }
        /*
        public int CalculerDureeAgrement()
        {
         TODO
        }
        */


    }
}