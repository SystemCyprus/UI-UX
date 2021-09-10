using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProjet
{
    public class GestionnaireSTE
    {
        // listes pour chacune des 4 classes que nous allons manipuler
        public List<Donateur> listDonateurs = new List<Donateur>();
        public List<Commanditaire> listCommanditaires = new List<Commanditaire>();
        public List<Don> listDons = new List<Don>();
        public List<Prix> listPrix = new List<Prix>();

        public int AjouterDonateur(string prenom, string surnom, string id, string adresse, string telephone, char typeCarte, string numeroCarte, string dateExpiration)
        {
            //on s'assure que le id est unique en verifiant chacun des items de la liste
            foreach (Donateur donateur in listDonateurs)
            {
                if (id.Equals(donateur.IdDonateur))
                {
                    // si il y a doublon, on affiche un message et on retourne au catch
                    // sans executer le reste de la fonction
                    throw new Exception("Un donateur avec l'id " + id + " existe deja!");
                }
            }
            // si on se rend ici, tout est ok, on cree l'objet et on l'ajoute a la liste
            Donateur nouveauDonateur = new Donateur(prenom, surnom, id, adresse, telephone, typeCarte, numeroCarte, dateExpiration, 0);
            listDonateurs.Add(nouveauDonateur);
            // on retourne le compte des objet actuels de cette liste
            return listDonateurs.Count();
        }
        public int AjouterCommanditaire(string id, string prenom, string surnom)
        {
            //on s'assure que le id est unique en verifiant chacun des items de la liste
            foreach (Commanditaire commanditaire in listCommanditaires)
            {
                if (id.Equals(commanditaire.IdCommanditaire))
                {
                    // si il y a doublon, on affiche un message et on retourne au catch
                    // sans executer le reste de la fonction
                    throw new Exception("Un commanditaire avec l'id " + id + " existe deja!");
                }
            }
            // creation  d'un objet commanditaire avec les infos validées
            Commanditaire nouveauCommanditaire = new Commanditaire(prenom, surnom, id);
            // ajout de l'objet a notre liste
            listCommanditaires.Add(nouveauCommanditaire);
            // retour du compte total de commanditaires
            return listCommanditaires.Count();
        }
        public int AjouterDon(string id, string date, string idDonateur, double montant)
        {
            //on s'assure que le id est unique en verifiant chacun des items de la liste
            foreach (Don don in listDons)
            {
                if (id.Equals(don.IdDon))
                {
                    // si il y a doublon, on affiche un message et on retourne au catch
                    // sans executer le reste de la fonction
                    throw new Exception("Un don avec l'id " + id + " existe deja!");
                }
            }
            // on s'assure que le id du donnateur recu existe dans notre liste
            bool donateurExiste = false;
            foreach(Donateur donateur in listDonateurs)
            {
                if (donateur.IdDonateur.Equals(idDonateur))
                    donateurExiste = true;
            }
            if (!donateurExiste) // message d'erreur et retour sans executer le reste du code
                throw new Exception("Aucun donateur avec l'id " + idDonateur + " n'à pas été trouvé");

            // creation de l'objet si tout est ok
            Don nouveauDon = new Don(id, date, idDonateur, montant);
            // calculer et ajouter les points du don au total du donateur
            listDons.Add(nouveauDon);
            // ajouter les points pour le montant de ce don
            AjouterPoints(idDonateur, montant);
            // retourne le compte de la liste actuelle de dons
            return listDons.Count();
        }
        public int AjouterPrix(string id, string description, int valeur, int qteO, string idCommanditaire)
        {
            //on s'assure que le id est unique en verifiant chacun des items de la liste
            foreach (Prix prix in listPrix)
            {
                if (id.Equals(prix.IdPrix))
                {
                    // si il y a doublon, on affiche un message et on retourne au catch
                    // sans executer le reste de la fonction
                    throw new Exception("Un prix avec l'id " + id + " existe deja!");
                }
            }
            // on s'assure que le id commanditaire existe dans la liste
            bool commanditaireExiste = false;
            foreach (Commanditaire commanditaire in listCommanditaires)
            {
                if (commanditaire.IdCommanditaire.Equals(idCommanditaire))
                    commanditaireExiste = true;
            }
            if (!commanditaireExiste) // message d'erreur si l'id n'est pas trouvé
                throw new Exception("Aucun commanditaire avec l'id " + idCommanditaire + " n'à pas été trouvé");

            // creation du prix si tout est ok
            Prix nouveauPrix = new Prix(id, description, valeur, qteO, idCommanditaire);
            // ajout de l'objet a la liste des dons
            listPrix.Add(nouveauPrix);
            // retourne le compte actuel de dons
            return listPrix.Count();
        }
        public string AfficherDonateurs()
        {
            // on concatene les ToString de chaque objet dans la liste et on la retourne
            string strDonateurs = "";
            foreach (Donateur donateur in listDonateurs)
            {
                strDonateurs += donateur.ToString() + "\n";
            }
            if (strDonateurs == "")
                strDonateurs = "La liste des donateurs est vide";
            return strDonateurs;
        }
        public string AfficherCommanditaires()
        {
            // on concatene les ToString de chaque objet dans la liste et on la retourne
            string strCommanditaires = "";
            foreach (Commanditaire commanditaire in listCommanditaires)
            {
                strCommanditaires += commanditaire.ToString() + "\n";
            }
            if (strCommanditaires == "")
                strCommanditaires = "La liste des commanditaires est vide";
            return strCommanditaires;
        }
        public string AfficherDons()
        {
            // on concatene les ToString de chaque objet dans la liste et on la retourne
            string strDons = "";
            foreach (Don don in listDons)
            {
                strDons += don.ToString() + "\n";
            }
            if (strDons == "")
                strDons = "La liste des dons est vide";
            return strDons;
        }
        public string AfficherPrix()
        {
            // on concatene les ToString de chaque objet dans la liste et on la retourne
            string strPrix = "";
            foreach (Prix pr in listPrix)
            {
                strPrix += pr.ToString() + "\n";
            }
            if (strPrix == "")
                strPrix = "La liste des prix est vide";
            return strPrix;
        }
        public void AjouterPoints(string idDonateur, double montant)
        {
            // calcul du nombre de points en fonction du montant du don
            int totalPoints = 0;
            if (montant >= 500)
                totalPoints += 5;
            else if (montant >= 350)
                totalPoints += 3;
            else if (montant >= 200)
                totalPoints += 2;
            else if (montant >= 50)
                totalPoints += 1;

            // boucler la liste pour trouver le donnateur actuel et ajouter ses points
            foreach (Donateur donateur in listDonateurs)
                if (idDonateur.Equals(donateur.IdDonateur))
                    donateur.TotalPoints += totalPoints;
        }
        public int AttribuerPrix(string idDonateur, string idPrix)
        {
            // objet que on declare, pour ensuite assigner celui qu'on cherche avant de le manipuler
            Donateur donateur = new Donateur();
            foreach (Donateur d in listDonateurs)
                if (idDonateur.Equals(d.IdDonateur))
                    donateur = d;
            // on trouve le prix correspondant au idprix recu, et nous avons aussi le donateur dans une variable
            foreach (Prix p in listPrix)
                if (idPrix.Equals(p.IdPrix))
                {
                    if (p.QuantiteDisponible <= 0) // message d'erreur si il n'y a plus de ce prix
                        throw new Exception("Ce prix n'est plus disponnible");
                    if (donateur.TotalPoints <= p.Valeur) // message d'erreur si le donateur n'a pas assez de points
                        throw new Exception("Le donateur n'a pas assez de points pour ce prix");
                    // si on se rend ici, on deduit la quantite de prix de 1
                    p.Deduire(1);
                    // et on deduit le nombre de points que vaut le prix, au nombre total des points du donateur
                    donateur.TotalPoints -= p.Valeur;
                }
            // on retourne le compte de la liste
            return listPrix.Count();
        }
        public int GetPoints(string idDonateur)
        {
            // fonction qui retourne le nombre total de points d'un donnateur
            // avec l'id du donateur, on loop la liste pour trouver le bon et on retourne les points
            int points = 0;
            foreach (Donateur donateur in listDonateurs)
                if (idDonateur.Equals(donateur.IdDonateur))
                    return donateur.TotalPoints;
            return points;
        }
        public string afficherItem(string idPrix)
        {
            // message par defaut si jamais la liste est vide
            string str = "Ce prix n'existe pas";
            // on cherche la liste pour trouver le bon idprix, et retourne son ToString
            foreach (Prix p in listPrix)
            {
                if (idPrix == p.IdPrix)
                {
                    str = p.ToString();
                }
            }
            return str;
        }
    }
}
