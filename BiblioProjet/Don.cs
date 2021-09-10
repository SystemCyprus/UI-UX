using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProjet
{
    // classe pour les objets dons
    public class Don
    {
        private string idDon;
        private string dateDon;
        private string idDonateur;
        private double montantDon;

        public Don(string id, string date, string idDonateur, double montant)
        {
            this.idDon = id;
            this.dateDon = date;
            this.idDonateur = idDonateur;
            this.montantDon = montant;
        }

        public string IdDon
        {
            get { return this.idDon; }
            set { this.idDon = value; }
        }
        public string DateDon
        {
            get { return this.dateDon; }
            set { this.dateDon = value; }
        }
        public string IdDonateur
        {
            get { return this.idDonateur; }
            set { this.idDonateur = value; }
        }
        public double MontantDon
        {
            get { return this.montantDon; }
            set { this.montantDon = value; }
        }

        public override string ToString()
        {
            return  "Id: " + this.idDon + " " +
                "Date: " + this.dateDon + " " +
                "Id donateur: " + this.idDonateur + " " +
                "Montant: " + this.montantDon.ToString() + "\n";
        }
    }
}
