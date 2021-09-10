using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProjet
{
    // classe pour les commanditaires, heritant de la classe personne
    public class Commanditaire : Personne
    {
        private string idCommanditaire;

        public Commanditaire(string prenom, string surnom, string id) : base(prenom, surnom)
        {
            this.idCommanditaire = id;
        }

        public string IdCommanditaire
        {
            get { return this.idCommanditaire; }
            set { this.idCommanditaire = value; }
        }

        public override string ToString()
        {
            return "Id commanditaire: " + this.idCommanditaire + " " +  base.ToString() + "\n";
        }
    }
}
