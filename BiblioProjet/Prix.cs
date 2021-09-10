using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// classe pour les objet prix
namespace BiblioProjet
{
    public class Prix
    {
        private string idPrix;
        private string description;
        private int valeur;
        private int quantiteOriginale;
        private int quantiteDisponible;
        private string idCommanditaire;

        // constructeur
        public Prix(string id, string description, int valeur, int qteO, string idCommanditaire,int qteD = 0)
        {
            this.idPrix = id;
            this.description = description;
            this.valeur = valeur;
            this.quantiteOriginale = qteO;
            this.quantiteDisponible = qteO;
            this.idCommanditaire = idCommanditaire;
        }
        public string IdPrix
        {
            get { return this.idPrix; }
            set { this.idPrix = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int Valeur
        {
            get { return this.valeur; }
            set { this.valeur = value; }
        }
        public int QuantiteOriginale
        {
            get { return this.quantiteOriginale; }
            set { this.quantiteOriginale = value; }
        }
        public int QuantiteDisponible
        {
            get { return this.quantiteDisponible; }
            set { this.quantiteDisponible = value; }
        }
        public string IdCommanditaire
        {
            get { return this.idCommanditaire; }
            set { this.idCommanditaire = value; }
        }
        // methode pour deduire la quantite de prix
        public void Deduire(int quantite)
        {
            this.quantiteDisponible -= quantite;
        }
        public override string ToString()
        {
            return "Id prix: "+this.idPrix + " " +
                    "Description: " + this.description + " " +
                    "Valeur: " + this.valeur + "\n" +
                    "Qte originale: " + this.quantiteOriginale + " " +
                    "Disponible: " + this.quantiteDisponible + " " +
                    "Comanditaire: " + this.idCommanditaire +"\n";
        }
    }
}
