using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BiblioProjet;

namespace SystemeTeletonElectronique
{
    public partial class FormMain : Form
    {
        // j'initialise le type de carte avec un espace, parce qu'on ne peut
        // faire = '' vide, et c'est pour ne pas forcer un type de carte par
        // defaut, mais obliger le user a le selectionner
        char typeCarte = ' ';
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                LireDonateurs();
                LireDons();
                LireCommanditaires();
                LirePrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActiveControl = textBoxIdDonateur;
            richTextBoxMessages.Text = Program.steGestionnaire.AfficherDonateurs();
            foreach (Prix p in Program.steGestionnaire.listPrix)
            {
                comboBoxPrix.Items.Add(p.IdPrix);
            }
            comboBoxPrix.SelectedIndex = 0;
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                EcrireDonateurs();
                EcrireDons();
                EcrireCommanditaires();
                EcrirePrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }


        private void buttonAjouterDonateur_Click(object sender, EventArgs e)
        {
            // regex pour valider le telephone
            Regex rgxTel = new Regex(@"^\d{10}$");
            // regex pour valider le numero de carte de credit
            Regex rgxCarte = new Regex(@"^\d{16}$");
            // validation niveau formulaire
            // aucun throw ne gère le guidage en ergonomie,
            // comme par recommendation microsoft sur les throw ;)
            if (string.IsNullOrEmpty(textBoxIdDonateur.Text.Trim()))
            {
                MessageBox.Show("L'id du donateur est nécéssaire");
                textBoxIdDonateur.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxPrenomDonateur.Text.Trim()))
            {
                MessageBox.Show("Le prenom du donateur est nécéssaire");
                textBoxPrenomDonateur.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxNomDonateur.Text.Trim()))
            {
                MessageBox.Show("Le nom du donateur est nécéssaire");
                textBoxNomDonateur.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxAdresseDonateur.Text.Trim()))
            {
                MessageBox.Show("Ladresse du donateur nécéssaire");
                textBoxAdresseDonateur.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxTelephoneDonateur.Text.Trim()))
            {
                MessageBox.Show("Le numéro de téléphone du donateur est nécéssaire");
                textBoxTelephoneDonateur.Focus();
            }
            else if (!rgxTel.IsMatch(textBoxTelephoneDonateur.Text))
            {
                MessageBox.Show("Le numéro de téléphone doit etre compose de 10 chiffres");
                textBoxTelephoneDonateur.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxNumeroCarte.Text.Trim()))
            {
                MessageBox.Show("Le numéro de carte de crédit est nécéssaire");
                textBoxNumeroCarte.Focus();
            }
            else if (!rgxCarte.IsMatch(textBoxNumeroCarte.Text))
            {
                MessageBox.Show("Le numéro de carte doit etre compose de 16 chiffres");
                textBoxNumeroCarte.Focus();
            }
            else if (typeCarte == ' ')
            {
                MessageBox.Show("Le type de carte de credit est nécéssaire");
            }
            else
            {
                // bloc try catch pour afficher les messages d'erreurs de la classe
                // et aussi ceux du système si jamais
                try
                {
                    // on s'assure que la carte n'expire pas avant la fin de la journée avec .AddDays(1)
                    if (dateTimePickerExpirationCarte.Value.AddDays(1) < DateTime.Now)
                        throw new Exception("La carte de credit est expiree");
                    // on ajoute le donateur à notre liste globale et obtient le compte total
                    string compte =
                        Program.steGestionnaire.AjouterDonateur(
                            textBoxPrenomDonateur.Text.Trim(),
                            textBoxNomDonateur.Text.Trim(),
                            textBoxIdDonateur.Text.Trim(),
                            textBoxAdresseDonateur.Text.Trim(),
                            textBoxTelephoneDonateur.Text.Trim(),
                            typeCarte,
                            textBoxNumeroCarte.Text.Trim(),
                            dateTimePickerExpirationCarte.Text).ToString();
                    // on remplit la boite a messages avec le nombre de donateurs
                    richTextBoxMessages.Text = "Donateur ajouté\n"
                         + "La liste contient " + compte + " donateurs";
                    // on reinitialise tous les user input si on a eu un succès
                    textBoxIdDonateurDon.Text = textBoxIdDonateur.Text;
                    tabControl1.SelectTab(tabPageDon);
                    textBoxIdDonateur.Text = "";
                    textBoxPrenomDonateur.Text = "";
                    textBoxNomDonateur.Text = "";
                    textBoxAdresseDonateur.Text = "";
                    textBoxTelephoneDonateur.Text = "";
                    textBoxNumeroCarte.Text = "";
                    typeCarte = ' ';
                }
                catch (Exception ex)
                {
                    // affichage du message erreur sans "crasher"
                    // messages du système ou de l'objet seulement
                    // (éventuellement une base de données)
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonAfficherDonateurs_Click(object sender, EventArgs e)
        {
            richTextBoxMessages.Text = Program.steGestionnaire.AfficherDonateurs();
        }
        private void radioButtonVisa_CheckedChanged(object sender, EventArgs e)
        {
            typeCarte = 'V';
        }
        private void radioButtonMaster_CheckedChanged(object sender, EventArgs e)
        {
            typeCarte = 'M';
        }
        private void radioButtonAmex_CheckedChanged(object sender, EventArgs e)
        {
            typeCarte = 'A';
        }
        private void buttonQuitterDon_Click(object sender, EventArgs e)
        {
            Program.Quitter();
        }

        private void buttonAjouterDon_Click(object sender, EventArgs e)
        {
            // regex pour valider le montant
            Regex rgxMontant = new Regex(@"^[1-9]\d*(\.\d+)?$");
            // validation niveau formulaire pour les dons
            if (string.IsNullOrEmpty(textBoxIdDon.Text.Trim()))
            {
                MessageBox.Show("L'id du don est nécéssaire");
                textBoxIdDon.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxMontantDon.Text.Trim()))
            {
                MessageBox.Show("Le montant du don est nécéssaire");
                textBoxMontantDon.Focus();
            }
            else if (!rgxMontant.IsMatch(textBoxMontantDon.Text))
            {
                MessageBox.Show("Le montant du don est invalide");
                textBoxMontantDon.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxIdDonateurDon.Text.Trim()))
            {
                MessageBox.Show("Le id du donateur pour ce don est nécéssaire");
                textBoxIdDonateurDon.Focus();
            }
            else
            {
                // tenter d'ajouter le don, en captant les erreurs systeme ou classe
                try
                {
                    // ajouter un nouveau don à notre liste globale de dons
                    string compte =
                        Program.steGestionnaire.AjouterDon(
                        textBoxIdDon.Text.Trim(),
                        dateTimePicker1.Text,
                        textBoxIdDonateurDon.Text.Trim(),
                        Double.Parse(textBoxMontantDon.Text)).ToString();
                    // confirmer l'ajout dans la boite a messages, avec le compte total de dons
                    richTextBoxMessages.Text = "Don ajouté\n" +
                        "La liste contient " + compte + " dons";
                    //afficher le nombre total de points pour ce donateur
                    textBoxNombrePoints.Text = Program.steGestionnaire.GetPoints(textBoxIdDonateurDon.Text).ToString();
                    // si on a eu un succès, on vide tous les champs
                    textBoxIdDon.Text = "";
                    dateTimePicker1.Text = "";
                    // textBoxIdDonateurDon.Text = ""; // on garde lui pour faciliter
                    textBoxMontantDon.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonAfficherDons_Click(object sender, EventArgs e)
        {
            richTextBoxMessages.Text = Program.steGestionnaire.AfficherDons();
        }
        private void buttonAfficherDonnateursDon_Click(object sender, EventArgs e)
        {
            richTextBoxMessages.Text = Program.steGestionnaire.AfficherDonateurs();
        }
        private void textBoxIdDonateurDon_TextChanged(object sender, EventArgs e)
        {
            textBoxNombrePoints.Text = Program.steGestionnaire.GetPoints(textBoxIdDonateurDon.Text).ToString();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // capter les changement de tabs
            // pour les accept et cancel button
            // et potentiellement d'autres fonctions
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    richTextBoxMessages.Text = Program.steGestionnaire.AfficherDonateurs();
                    this.AcceptButton = buttonAjouterDonateur;
                    this.CancelButton = buttonQuitterDonateur;
                    this.ActiveControl = textBoxIdDonateur;
                    break;
                case 1:
                    richTextBoxMessages.Text = Program.steGestionnaire.AfficherDons();
                    this.AcceptButton = buttonAjouterDon;
                    this.CancelButton = buttonQuitterDon;
                    this.ActiveControl = textBoxIdDon;
                    //afficher le nombre total de points pour ce donateur
                    textBoxNombrePoints.Text = Program.steGestionnaire.GetPoints(textBoxIdDonateurDon.Text).ToString();
                    break;
                case 2:
                    richTextBoxMessages.Text = Program.steGestionnaire.AfficherCommanditaires();
                    this.AcceptButton = buttonAjouterCommanditaire;
                    this.CancelButton = buttonQuitterCommanditaire;
                    this.ActiveControl = textBoxIdComanditaire;
                    break;
                case 3:
                    richTextBoxMessages.Text = Program.steGestionnaire.AfficherPrix();
                    this.AcceptButton = buttonAjouterPrix;
                    this.CancelButton = buttonQuitterPrix;
                    this.ActiveControl = textBoxIdPrix;
                    break;
            }
        }
        private void buttonAttribuerPrix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdDonateurDon.Text))
            {
                MessageBox.Show(
                    "L'id du donateur est nécéssaire pour connaitre le total des points",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                // attribuer le prix au donnateur de du don courrant
                // afficher le succès après les calculs et mises à jour
                try
                {
                    string compte = Program.steGestionnaire.AttribuerPrix(
                        textBoxIdDonateurDon.Text,
                        comboBoxPrix.SelectedItem.ToString()).ToString();
                    richTextBoxMessages.Text = "Un " +
                        compte
                        + " à été expédié au donateur";
                    // mettre a jour le label total points
                    textBoxNombrePoints.Text = Program.steGestionnaire.GetPoints(textBoxIdDonateurDon.Text).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void buttonQuitterDonateur_Click(object sender, EventArgs e)
        {
            Program.Quitter();
        }

        private void buttonAjouterCommanditaire_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdComanditaire.Text.Trim()))
            {
                MessageBox.Show("L'id du commanditaire est nécéssaire");
                textBoxIdComanditaire.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxPrenomComanditaire.Text.Trim()))
            {
                MessageBox.Show("Le prénom du commanditaire est nécéssaire");
                textBoxPrenomComanditaire.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxNomComanditaire.Text.Trim()))
            {
                MessageBox.Show("Le nom du commanditaire est nécéssaire");
                textBoxNomComanditaire.Focus();
            }
            else
            {
                try
                {
                    richTextBoxMessages.Text = "Commanditaire ajouté\n" +
                        "La liste contient " +
                    Program.steGestionnaire.AjouterCommanditaire(
                        textBoxIdComanditaire.Text.Trim(),
                        textBoxPrenomComanditaire.Text.Trim(),
                        textBoxNomComanditaire.Text.Trim())
                        + " commanditaires";

                    textBoxIdCommanditairePrix.Text = textBoxIdComanditaire.Text;
                    tabControl1.SelectTab(tabPagePrix);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonAfficherCommanditaires_Click(object sender, EventArgs e)
        {
            richTextBoxMessages.Text = Program.steGestionnaire.AfficherCommanditaires();
        }
        private void buttonQuitterCommanditaire_Click(object sender, EventArgs e)
        {
            Program.Quitter();
        }

        private void buttonAjouterPrix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdPrix.Text.Trim()))
            {
                MessageBox.Show("L'id du prix est nécéssaire");
                textBoxIdPrix.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxDescriptionPrix.Text.Trim()))
            {
                MessageBox.Show("Une description du prix est nécéssaire");
                textBoxDescriptionPrix.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxValeurPrix.Text.Trim()))
            {
                MessageBox.Show("Une valeur pour le prix est nécessaire");
                textBoxValeurPrix.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxQuantite.Text.Trim()))
            {
                MessageBox.Show("Une quantité de prix est nécéssaire");
                textBoxQuantite.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxIdCommanditairePrix.Text.Trim()))
            {
                MessageBox.Show("Lid d'un commanditaire est nécéssaire");
                textBoxIdCommanditairePrix.Focus();
            }
            else
            {
                try
                {
                    Regex rgxMontant = new Regex(@"^[1-9]\d*(\.\d+)?$");
                    if (!rgxMontant.IsMatch(textBoxValeurPrix.Text))
                    {
                        throw new Exception("La valeur du prix est invallide");
                    }
                    Regex rgxQuantite = new Regex(@"^[1-9]\d*$");
                    if (!rgxQuantite.IsMatch(textBoxQuantite.Text))
                    {
                        throw new Exception("La quantite du prix est invalide");
                    }
                    richTextBoxMessages.Text = "Prix ajouté\n" +
                        "La liste contient " +
                    Program.steGestionnaire.AjouterPrix(
                        textBoxIdPrix.Text,
                        textBoxDescriptionPrix.Text,
                        int.Parse(textBoxValeurPrix.Text),
                        int.Parse(textBoxQuantite.Text),
                        textBoxIdCommanditairePrix.Text).ToString()
                        + " prix";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonAfficherPrix_Click(object sender, EventArgs e)
        {
            richTextBoxMessages.Text = Program.steGestionnaire.AfficherPrix();
        }
        private void buttonAfficherCommanditairePrix_Click(object sender, EventArgs e)
        {
            richTextBoxMessages.Text = Program.steGestionnaire.AfficherCommanditaires();
        }
        private void buttonQuitterPrix_Click(object sender, EventArgs e)
        {
            Program.Quitter();
        }

        private bool EcrireDonateurs()
        {
            string path = "donateurs.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < Program.steGestionnaire.listDonateurs.Count; i++)
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                        Program.steGestionnaire.listDonateurs[i].Prenom,
                        Program.steGestionnaire.listDonateurs[i].Surnom,
                        Program.steGestionnaire.listDonateurs[i].IdDonateur,
                        Program.steGestionnaire.listDonateurs[i].Adresse,
                        Program.steGestionnaire.listDonateurs[i].Telephone,
                        Program.steGestionnaire.listDonateurs[i].TypeCarte,
                        Program.steGestionnaire.listDonateurs[i].NumeroCarte,
                        Program.steGestionnaire.listDonateurs[i].DateExpiration,
                        Program.steGestionnaire.listDonateurs[i].TotalPoints);
                }
                sw.Close();
                return true;
            }
        }
        private bool EcrireDons()
        {
            string path = "dons.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < Program.steGestionnaire.listDons.Count; i++)
                {
                    sw.WriteLine("{0}+{1}+{2}+{3}",
                        Program.steGestionnaire.listDons[i].IdDon,
                        Program.steGestionnaire.listDons[i].DateDon,
                        Program.steGestionnaire.listDons[i].IdDonateur,
                        Program.steGestionnaire.listDons[i].MontantDon);
                }
                sw.Close();
                return true;
            }
        }
        private bool EcrireCommanditaires()
        {
            string path = "commanditaires.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < Program.steGestionnaire.listCommanditaires.Count; i++)
                {
                    sw.WriteLine("{0},{1},{2}",
                        Program.steGestionnaire.listCommanditaires[i].Prenom,
                        Program.steGestionnaire.listCommanditaires[i].Surnom,
                        Program.steGestionnaire.listCommanditaires[i].IdCommanditaire);
                }
                sw.Close();
                return true;
            }
        }
        private bool EcrirePrix()
        {
            string path = "prix.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < Program.steGestionnaire.listPrix.Count; i++)
                {
                    sw.WriteLine("{0},{1},{2},{3},{4},{5}",
                        Program.steGestionnaire.listPrix[i].IdPrix,
                        Program.steGestionnaire.listPrix[i].Description,
                        Program.steGestionnaire.listPrix[i].Valeur,
                        Program.steGestionnaire.listPrix[i].QuantiteOriginale,
                        Program.steGestionnaire.listPrix[i].Valeur,
                        Program.steGestionnaire.listPrix[i].QuantiteDisponible);
                }
                sw.Close();
                return true;
            }
        }
        private bool LireDonateurs()
        {
            string[] strArray;
            string path = "donateurs.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {
                StreamReader sr = new StreamReader("donateurs.txt");
                string strLine = sr.ReadLine();
                Program.steGestionnaire.listDonateurs.Clear();
                while (strLine != null)
                {
                    strArray = strLine.Split(',');
                    Program.steGestionnaire.listDonateurs.Add(
                        new Donateur(
                            strArray[0],
                            strArray[1],
                            strArray[2],
                            strArray[3],
                            strArray[4],
                            char.Parse(strArray[5]),
                            strArray[6],
                            strArray[7],
                            int.Parse(strArray[8])));
                    strLine = sr.ReadLine();
                }
                sr.Close();
                return true;
            }
        }
        private bool LireDons()
        {
            string[] strArray;
            string path = "dons.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {

                StreamReader sr = new StreamReader("dons.txt");
                string strLine = sr.ReadLine();
                Program.steGestionnaire.listDons.Clear();
                while (strLine != null)
                {
                    strArray = strLine.Split('+');
                    Program.steGestionnaire.listDons.Add(
                        new Don(
                            strArray[0],
                            strArray[1],
                            strArray[2],
                            Double.Parse(strArray[3])));
                    strLine = sr.ReadLine();
                }
                sr.Close();
                return true;
            }
        }
        private bool LireCommanditaires()
        {
            string[] strArray;
            string path = "commanditaires.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {

                StreamReader sr = new StreamReader("commanditaires.txt");
                string strLine = sr.ReadLine();
                Program.steGestionnaire.listCommanditaires.Clear();
                while (strLine != null)
                {
                    strArray = strLine.Split(',');
                    Program.steGestionnaire.listCommanditaires.Add(
                        new Commanditaire(
                            strArray[0],
                            strArray[1],
                            strArray[2]));
                    strLine = sr.ReadLine();
                }
                sr.Close();
                return true;
            }
        }
        private bool LirePrix()
        {
            string[] strArray;
            string path = "prix.txt";
            if (!File.Exists(path))
            {
                throw new Exception(path + " pas trouve");
            }
            else
            {

                StreamReader sr = new StreamReader("prix.txt");
                string strLine = sr.ReadLine();
                Program.steGestionnaire.listPrix.Clear();
                while (strLine != null)
                {
                    strArray = strLine.Split(',');
                    Program.steGestionnaire.listPrix.Add(
                        new Prix(
                            strArray[0],
                            strArray[1],
                            int.Parse(strArray[2]),
                            int.Parse(strArray[3]),
                            strArray[4],
                            int.Parse(strArray[5])));
                    strLine = sr.ReadLine();
                }
                sr.Close();
                return true;
            }
        }

        private void comboBoxPrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxMessages.Text=
            Program.steGestionnaire.afficherItem(comboBoxPrix.SelectedItem.ToString());
        }
    }
}