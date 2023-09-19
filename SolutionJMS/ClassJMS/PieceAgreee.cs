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

        public PieceAgreee(int unNumero, string unLibelle, int unNombre, DateTime uneDate, string unConstructeur)
            : base(unNumero, unLibelle, unNombre)
        {
            this.dateAgrement = uneDate;
            this.nomConstructeur = unConstructeur;
        }

        public DateTime GetDateAgrement()
        {
            return this.dateAgrement;
        }
        public void RenouvelerAgrement(DateTime nouvelleDate)
        {
            this.dateAgrement = nouvelleDate;
        }
        
        public int CalculerDureeAgrement()
        {
            return DateTime.Now.Year - this.dateAgrement.Year;
        }

        public override bool AControler()
        {
            if(CalculerDureeAgrement() > 2)
            {
                return true;
            }
            return false;
        }
        public override string ObtenirInfos()
        {
            string infos = base.ObtenirInfos();
            string infosAgrees = "\nConstructeur : " + this.nomConstructeur;
            string dateAgrees = "\nDate Agrément : " + GetDateAgrement().ToShortDateString();
            return infos + infosAgrees + dateAgrees;
        }

    }
}