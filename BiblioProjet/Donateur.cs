using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProjet
{
    // classe pour les donateurs, herite de la classe personne
    public class Donateur : Personne
    {
        private string idDonateur;
        private string adresse;
        private string telephone;
        private char typeCarte;
        private string numeroCarte;
        private string dateExpiration;
        private int totalPoints;

        public Donateur(string prenom = "", string surnom = "") : base(prenom, surnom){ }
        public Donateur(string prenom, string surnom, string id, string adresse, string telephone, char typeCarte, string numeroCarte, string dateExpiration, int totalPoints) : base(prenom, surnom)
        {
            this.idDonateur = id;
            this.adresse = adresse;
            this.telephone = telephone;
            this.typeCarte = typeCarte;
            this.numeroCarte = numeroCarte;
            this.dateExpiration = dateExpiration;
            this.totalPoints = totalPoints;
        }
        public string IdDonateur
        {
            get { return this.idDonateur; }
            set { this.idDonateur = value; }
        }
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value; }
        }
        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }
        public char TypeCarte
        {
            get { return this.typeCarte; }
            set { this.typeCarte = value; }
        }
        public string NumeroCarte
        {
            get { return this.numeroCarte; }
            set { this.numeroCarte = value; }
        }
        public string DateExpiration
        {
            get { return this.dateExpiration; }
            set { this.dateExpiration = value; }
        }
        public int TotalPoints
        {
            get { return this.totalPoints; }
            set { this.totalPoints = value; }
        }
        public override string ToString()
        {
            return "ID: " + idDonateur + " " +
                base.ToString() + " " +
                adresse + " " +
                telephone + "\n" + " Credit: " +
                typeCarte + " " +
                numeroCarte + " " +
                dateExpiration + " " +
                totalPoints +"\n";
        }
    }
}
