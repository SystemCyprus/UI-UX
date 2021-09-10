
namespace SystemeTeletonElectronique
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDonateur = new System.Windows.Forms.TabPage();
            this.buttonQuitterDonateur = new System.Windows.Forms.Button();
            this.buttonAfficherDonateurs = new System.Windows.Forms.Button();
            this.buttonAjouterDonateur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerExpirationCarte = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumeroCarte = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonAmex = new System.Windows.Forms.RadioButton();
            this.radioButtonMaster = new System.Windows.Forms.RadioButton();
            this.radioButtonVisa = new System.Windows.Forms.RadioButton();
            this.textBoxTelephoneDonateur = new System.Windows.Forms.TextBox();
            this.textBoxAdresseDonateur = new System.Windows.Forms.TextBox();
            this.textBoxNomDonateur = new System.Windows.Forms.TextBox();
            this.textBoxPrenomDonateur = new System.Windows.Forms.TextBox();
            this.textBoxIdDonateur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDon = new System.Windows.Forms.TabPage();
            this.comboBoxPrix = new System.Windows.Forms.ComboBox();
            this.buttonQuitterDon = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAttribuerPrix = new System.Windows.Forms.Button();
            this.buttonAjouterDon = new System.Windows.Forms.Button();
            this.buttonAfficherDonnateursDon = new System.Windows.Forms.Button();
            this.buttonAfficherDons = new System.Windows.Forms.Button();
            this.textBoxIdDonateurDon = new System.Windows.Forms.TextBox();
            this.textBoxMontantDon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNombrePoints = new System.Windows.Forms.TextBox();
            this.textBoxIdDon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageComanditaire = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonAjouterCommanditaire = new System.Windows.Forms.Button();
            this.buttonQuitterCommanditaire = new System.Windows.Forms.Button();
            this.buttonAfficherCommanditaires = new System.Windows.Forms.Button();
            this.textBoxNomComanditaire = new System.Windows.Forms.TextBox();
            this.textBoxPrenomComanditaire = new System.Windows.Forms.TextBox();
            this.textBoxIdComanditaire = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPagePrix = new System.Windows.Forms.TabPage();
            this.textBoxIdCommanditairePrix = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.textBoxValeurPrix = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionPrix = new System.Windows.Forms.TextBox();
            this.textBoxIdPrix = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonAjouterPrix = new System.Windows.Forms.Button();
            this.buttonQuitterPrix = new System.Windows.Forms.Button();
            this.buttonAfficherCommanditairePrix = new System.Windows.Forms.Button();
            this.buttonAfficherPrix = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageDonateur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageDon.SuspendLayout();
            this.tabPageComanditaire.SuspendLayout();
            this.tabPagePrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDonateur);
            this.tabControl1.Controls.Add(this.tabPageDon);
            this.tabControl1.Controls.Add(this.tabPageComanditaire);
            this.tabControl1.Controls.Add(this.tabPagePrix);
            this.tabControl1.Location = new System.Drawing.Point(16, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 297);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageDonateur
            // 
            this.tabPageDonateur.BackColor = System.Drawing.Color.Orange;
            this.tabPageDonateur.Controls.Add(this.buttonQuitterDonateur);
            this.tabPageDonateur.Controls.Add(this.buttonAfficherDonateurs);
            this.tabPageDonateur.Controls.Add(this.buttonAjouterDonateur);
            this.tabPageDonateur.Controls.Add(this.groupBox1);
            this.tabPageDonateur.Controls.Add(this.textBoxTelephoneDonateur);
            this.tabPageDonateur.Controls.Add(this.textBoxAdresseDonateur);
            this.tabPageDonateur.Controls.Add(this.textBoxNomDonateur);
            this.tabPageDonateur.Controls.Add(this.textBoxPrenomDonateur);
            this.tabPageDonateur.Controls.Add(this.textBoxIdDonateur);
            this.tabPageDonateur.Controls.Add(this.label6);
            this.tabPageDonateur.Controls.Add(this.label5);
            this.tabPageDonateur.Controls.Add(this.label4);
            this.tabPageDonateur.Controls.Add(this.label3);
            this.tabPageDonateur.Controls.Add(this.label2);
            this.tabPageDonateur.Controls.Add(this.label1);
            this.tabPageDonateur.Location = new System.Drawing.Point(4, 25);
            this.tabPageDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDonateur.Name = "tabPageDonateur";
            this.tabPageDonateur.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDonateur.Size = new System.Drawing.Size(872, 268);
            this.tabPageDonateur.TabIndex = 0;
            this.tabPageDonateur.Text = "Donateur";
            // 
            // buttonQuitterDonateur
            // 
            this.buttonQuitterDonateur.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuitterDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitterDonateur.Location = new System.Drawing.Point(724, 208);
            this.buttonQuitterDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuitterDonateur.Name = "buttonQuitterDonateur";
            this.buttonQuitterDonateur.Size = new System.Drawing.Size(100, 28);
            this.buttonQuitterDonateur.TabIndex = 13;
            this.buttonQuitterDonateur.Text = "Quitter";
            this.buttonQuitterDonateur.UseVisualStyleBackColor = true;
            this.buttonQuitterDonateur.Click += new System.EventHandler(this.buttonQuitterDonateur_Click);
            // 
            // buttonAfficherDonateurs
            // 
            this.buttonAfficherDonateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficherDonateurs.Location = new System.Drawing.Point(467, 208);
            this.buttonAfficherDonateurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficherDonateurs.Name = "buttonAfficherDonateurs";
            this.buttonAfficherDonateurs.Size = new System.Drawing.Size(176, 28);
            this.buttonAfficherDonateurs.TabIndex = 12;
            this.buttonAfficherDonateurs.Text = "Afficher Donateurs";
            this.buttonAfficherDonateurs.UseVisualStyleBackColor = true;
            this.buttonAfficherDonateurs.Click += new System.EventHandler(this.buttonAfficherDonateurs_Click);
            // 
            // buttonAjouterDonateur
            // 
            this.buttonAjouterDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterDonateur.Location = new System.Drawing.Point(289, 209);
            this.buttonAjouterDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAjouterDonateur.Name = "buttonAjouterDonateur";
            this.buttonAjouterDonateur.Size = new System.Drawing.Size(160, 28);
            this.buttonAjouterDonateur.TabIndex = 11;
            this.buttonAjouterDonateur.TabStop = false;
            this.buttonAjouterDonateur.Text = "Ajouter Donateur";
            this.buttonAjouterDonateur.UseVisualStyleBackColor = true;
            this.buttonAjouterDonateur.Click += new System.EventHandler(this.buttonAjouterDonateur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerExpirationCarte);
            this.groupBox1.Controls.Add(this.textBoxNumeroCarte);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.radioButtonAmex);
            this.groupBox1.Controls.Add(this.radioButtonMaster);
            this.groupBox1.Controls.Add(this.radioButtonVisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(289, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(535, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carte de crédit";
            // 
            // dateTimePickerExpirationCarte
            // 
            this.dateTimePickerExpirationCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExpirationCarte.Location = new System.Drawing.Point(177, 76);
            this.dateTimePickerExpirationCarte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerExpirationCarte.Name = "dateTimePickerExpirationCarte";
            this.dateTimePickerExpirationCarte.Size = new System.Drawing.Size(185, 26);
            this.dateTimePickerExpirationCarte.TabIndex = 7;
            // 
            // textBoxNumeroCarte
            // 
            this.textBoxNumeroCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroCarte.Location = new System.Drawing.Point(177, 36);
            this.textBoxNumeroCarte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumeroCarte.Name = "textBoxNumeroCarte";
            this.textBoxNumeroCarte.Size = new System.Drawing.Size(185, 26);
            this.textBoxNumeroCarte.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date d\'expiration:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Numéro de carte:";
            // 
            // radioButtonAmex
            // 
            this.radioButtonAmex.AutoSize = true;
            this.radioButtonAmex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAmex.Location = new System.Drawing.Point(395, 86);
            this.radioButtonAmex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAmex.Name = "radioButtonAmex";
            this.radioButtonAmex.Size = new System.Drawing.Size(77, 24);
            this.radioButtonAmex.TabIndex = 10;
            this.radioButtonAmex.Text = "AmEX";
            this.radioButtonAmex.UseVisualStyleBackColor = true;
            this.radioButtonAmex.CheckedChanged += new System.EventHandler(this.radioButtonAmex_CheckedChanged);
            // 
            // radioButtonMaster
            // 
            this.radioButtonMaster.AutoSize = true;
            this.radioButtonMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaster.Location = new System.Drawing.Point(395, 58);
            this.radioButtonMaster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMaster.Name = "radioButtonMaster";
            this.radioButtonMaster.Size = new System.Drawing.Size(123, 24);
            this.radioButtonMaster.TabIndex = 9;
            this.radioButtonMaster.Text = "Master Card";
            this.radioButtonMaster.UseVisualStyleBackColor = true;
            this.radioButtonMaster.CheckedChanged += new System.EventHandler(this.radioButtonMaster_CheckedChanged);
            // 
            // radioButtonVisa
            // 
            this.radioButtonVisa.AutoSize = true;
            this.radioButtonVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVisa.Location = new System.Drawing.Point(395, 30);
            this.radioButtonVisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonVisa.Name = "radioButtonVisa";
            this.radioButtonVisa.Size = new System.Drawing.Size(63, 24);
            this.radioButtonVisa.TabIndex = 8;
            this.radioButtonVisa.Text = "Visa";
            this.radioButtonVisa.UseVisualStyleBackColor = true;
            this.radioButtonVisa.CheckedChanged += new System.EventHandler(this.radioButtonVisa_CheckedChanged);
            // 
            // textBoxTelephoneDonateur
            // 
            this.textBoxTelephoneDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephoneDonateur.Location = new System.Drawing.Point(119, 213);
            this.textBoxTelephoneDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTelephoneDonateur.Name = "textBoxTelephoneDonateur";
            this.textBoxTelephoneDonateur.Size = new System.Drawing.Size(132, 26);
            this.textBoxTelephoneDonateur.TabIndex = 5;
            // 
            // textBoxAdresseDonateur
            // 
            this.textBoxAdresseDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresseDonateur.Location = new System.Drawing.Point(119, 176);
            this.textBoxAdresseDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAdresseDonateur.Name = "textBoxAdresseDonateur";
            this.textBoxAdresseDonateur.Size = new System.Drawing.Size(132, 26);
            this.textBoxAdresseDonateur.TabIndex = 4;
            // 
            // textBoxNomDonateur
            // 
            this.textBoxNomDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomDonateur.Location = new System.Drawing.Point(119, 139);
            this.textBoxNomDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomDonateur.Name = "textBoxNomDonateur";
            this.textBoxNomDonateur.Size = new System.Drawing.Size(132, 26);
            this.textBoxNomDonateur.TabIndex = 3;
            // 
            // textBoxPrenomDonateur
            // 
            this.textBoxPrenomDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenomDonateur.Location = new System.Drawing.Point(119, 102);
            this.textBoxPrenomDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrenomDonateur.Name = "textBoxPrenomDonateur";
            this.textBoxPrenomDonateur.Size = new System.Drawing.Size(132, 26);
            this.textBoxPrenomDonateur.TabIndex = 2;
            // 
            // textBoxIdDonateur
            // 
            this.textBoxIdDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdDonateur.Location = new System.Drawing.Point(119, 65);
            this.textBoxIdDonateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdDonateur.Name = "textBoxIdDonateur";
            this.textBoxIdDonateur.Size = new System.Drawing.Size(132, 26);
            this.textBoxIdDonateur.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Téléphone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations Donateur";
            // 
            // tabPageDon
            // 
            this.tabPageDon.BackColor = System.Drawing.Color.Orange;
            this.tabPageDon.Controls.Add(this.comboBoxPrix);
            this.tabPageDon.Controls.Add(this.buttonQuitterDon);
            this.tabPageDon.Controls.Add(this.dateTimePicker1);
            this.tabPageDon.Controls.Add(this.buttonAttribuerPrix);
            this.tabPageDon.Controls.Add(this.buttonAjouterDon);
            this.tabPageDon.Controls.Add(this.buttonAfficherDonnateursDon);
            this.tabPageDon.Controls.Add(this.buttonAfficherDons);
            this.tabPageDon.Controls.Add(this.textBoxIdDonateurDon);
            this.tabPageDon.Controls.Add(this.textBoxMontantDon);
            this.tabPageDon.Controls.Add(this.label13);
            this.tabPageDon.Controls.Add(this.textBoxNombrePoints);
            this.tabPageDon.Controls.Add(this.textBoxIdDon);
            this.tabPageDon.Controls.Add(this.label12);
            this.tabPageDon.Controls.Add(this.label9);
            this.tabPageDon.Controls.Add(this.labelPoints);
            this.tabPageDon.Controls.Add(this.label8);
            this.tabPageDon.Controls.Add(this.label15);
            this.tabPageDon.Controls.Add(this.label7);
            this.tabPageDon.Location = new System.Drawing.Point(4, 25);
            this.tabPageDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDon.Name = "tabPageDon";
            this.tabPageDon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDon.Size = new System.Drawing.Size(872, 268);
            this.tabPageDon.TabIndex = 1;
            this.tabPageDon.Text = "Don";
            // 
            // comboBoxPrix
            // 
            this.comboBoxPrix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrix.FormattingEnabled = true;
            this.comboBoxPrix.Location = new System.Drawing.Point(624, 114);
            this.comboBoxPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPrix.Name = "comboBoxPrix";
            this.comboBoxPrix.Size = new System.Drawing.Size(176, 24);
            this.comboBoxPrix.TabIndex = 11;
            this.comboBoxPrix.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrix_SelectedIndexChanged);
            // 
            // buttonQuitterDon
            // 
            this.buttonQuitterDon.Location = new System.Drawing.Point(625, 201);
            this.buttonQuitterDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuitterDon.Name = "buttonQuitterDon";
            this.buttonQuitterDon.Size = new System.Drawing.Size(179, 28);
            this.buttonQuitterDon.TabIndex = 9;
            this.buttonQuitterDon.Text = "Quitter";
            this.buttonQuitterDon.UseVisualStyleBackColor = true;
            this.buttonQuitterDon.Click += new System.EventHandler(this.buttonQuitterDon_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 201);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // buttonAttribuerPrix
            // 
            this.buttonAttribuerPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttribuerPrix.Location = new System.Drawing.Point(624, 158);
            this.buttonAttribuerPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAttribuerPrix.Name = "buttonAttribuerPrix";
            this.buttonAttribuerPrix.Size = new System.Drawing.Size(179, 28);
            this.buttonAttribuerPrix.TabIndex = 8;
            this.buttonAttribuerPrix.Text = "Attribuer Prix";
            this.buttonAttribuerPrix.UseVisualStyleBackColor = true;
            this.buttonAttribuerPrix.Click += new System.EventHandler(this.buttonAttribuerPrix_Click);
            // 
            // buttonAjouterDon
            // 
            this.buttonAjouterDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterDon.Location = new System.Drawing.Point(375, 71);
            this.buttonAjouterDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAjouterDon.Name = "buttonAjouterDon";
            this.buttonAjouterDon.Size = new System.Drawing.Size(193, 28);
            this.buttonAjouterDon.TabIndex = 5;
            this.buttonAjouterDon.Text = "Ajouter Don";
            this.buttonAjouterDon.UseVisualStyleBackColor = true;
            this.buttonAjouterDon.Click += new System.EventHandler(this.buttonAjouterDon_Click);
            // 
            // buttonAfficherDonnateursDon
            // 
            this.buttonAfficherDonnateursDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficherDonnateursDon.Location = new System.Drawing.Point(375, 201);
            this.buttonAfficherDonnateursDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficherDonnateursDon.Name = "buttonAfficherDonnateursDon";
            this.buttonAfficherDonnateursDon.Size = new System.Drawing.Size(193, 28);
            this.buttonAfficherDonnateursDon.TabIndex = 7;
            this.buttonAfficherDonnateursDon.Text = "Afficher Donateurs";
            this.buttonAfficherDonnateursDon.UseVisualStyleBackColor = true;
            this.buttonAfficherDonnateursDon.Click += new System.EventHandler(this.buttonAfficherDonnateursDon_Click);
            // 
            // buttonAfficherDons
            // 
            this.buttonAfficherDons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficherDons.Location = new System.Drawing.Point(375, 158);
            this.buttonAfficherDons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficherDons.Name = "buttonAfficherDons";
            this.buttonAfficherDons.Size = new System.Drawing.Size(193, 28);
            this.buttonAfficherDons.TabIndex = 6;
            this.buttonAfficherDons.Text = "Afficher Dons";
            this.buttonAfficherDons.UseVisualStyleBackColor = true;
            this.buttonAfficherDons.Click += new System.EventHandler(this.buttonAfficherDons_Click);
            // 
            // textBoxIdDonateurDon
            // 
            this.textBoxIdDonateurDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdDonateurDon.Location = new System.Drawing.Point(131, 158);
            this.textBoxIdDonateurDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdDonateurDon.Name = "textBoxIdDonateurDon";
            this.textBoxIdDonateurDon.Size = new System.Drawing.Size(209, 26);
            this.textBoxIdDonateurDon.TabIndex = 3;
            this.textBoxIdDonateurDon.TextChanged += new System.EventHandler(this.textBoxIdDonateurDon_TextChanged);
            // 
            // textBoxMontantDon
            // 
            this.textBoxMontantDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontantDon.Location = new System.Drawing.Point(131, 114);
            this.textBoxMontantDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMontantDon.Name = "textBoxMontantDon";
            this.textBoxMontantDon.Size = new System.Drawing.Size(209, 26);
            this.textBoxMontantDon.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(73, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Date:";
            // 
            // textBoxNombrePoints
            // 
            this.textBoxNombrePoints.Enabled = false;
            this.textBoxNombrePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombrePoints.Location = new System.Drawing.Point(731, 69);
            this.textBoxNombrePoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombrePoints.Name = "textBoxNombrePoints";
            this.textBoxNombrePoints.Size = new System.Drawing.Size(71, 26);
            this.textBoxNombrePoints.TabIndex = 0;
            // 
            // textBoxIdDon
            // 
            this.textBoxIdDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdDon.Location = new System.Drawing.Point(131, 71);
            this.textBoxIdDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdDon.Name = "textBoxIdDon";
            this.textBoxIdDon.Size = new System.Drawing.Size(209, 26);
            this.textBoxIdDon.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Id donateur:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Montant:";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(621, 73);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(101, 20);
            this.labelPoints.TabIndex = 0;
            this.labelPoints.Text = "Total points:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(621, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Attribution du Prix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Informations Don";
            // 
            // tabPageComanditaire
            // 
            this.tabPageComanditaire.BackColor = System.Drawing.Color.Orange;
            this.tabPageComanditaire.Controls.Add(this.label19);
            this.tabPageComanditaire.Controls.Add(this.buttonAjouterCommanditaire);
            this.tabPageComanditaire.Controls.Add(this.buttonQuitterCommanditaire);
            this.tabPageComanditaire.Controls.Add(this.buttonAfficherCommanditaires);
            this.tabPageComanditaire.Controls.Add(this.textBoxNomComanditaire);
            this.tabPageComanditaire.Controls.Add(this.textBoxPrenomComanditaire);
            this.tabPageComanditaire.Controls.Add(this.textBoxIdComanditaire);
            this.tabPageComanditaire.Controls.Add(this.label16);
            this.tabPageComanditaire.Controls.Add(this.label17);
            this.tabPageComanditaire.Controls.Add(this.label18);
            this.tabPageComanditaire.Location = new System.Drawing.Point(4, 25);
            this.tabPageComanditaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageComanditaire.Name = "tabPageComanditaire";
            this.tabPageComanditaire.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageComanditaire.Size = new System.Drawing.Size(872, 268);
            this.tabPageComanditaire.TabIndex = 2;
            this.tabPageComanditaire.Text = "Comanditaire";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(27, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(245, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Informations Commanditaire";
            // 
            // buttonAjouterCommanditaire
            // 
            this.buttonAjouterCommanditaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterCommanditaire.Location = new System.Drawing.Point(497, 71);
            this.buttonAjouterCommanditaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAjouterCommanditaire.Name = "buttonAjouterCommanditaire";
            this.buttonAjouterCommanditaire.Size = new System.Drawing.Size(221, 28);
            this.buttonAjouterCommanditaire.TabIndex = 4;
            this.buttonAjouterCommanditaire.Text = "Ajouter Commanditaire";
            this.buttonAjouterCommanditaire.UseVisualStyleBackColor = true;
            this.buttonAjouterCommanditaire.Click += new System.EventHandler(this.buttonAjouterCommanditaire_Click);
            // 
            // buttonQuitterCommanditaire
            // 
            this.buttonQuitterCommanditaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitterCommanditaire.Location = new System.Drawing.Point(497, 196);
            this.buttonQuitterCommanditaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuitterCommanditaire.Name = "buttonQuitterCommanditaire";
            this.buttonQuitterCommanditaire.Size = new System.Drawing.Size(221, 28);
            this.buttonQuitterCommanditaire.TabIndex = 6;
            this.buttonQuitterCommanditaire.Text = "Quitter";
            this.buttonQuitterCommanditaire.UseVisualStyleBackColor = true;
            this.buttonQuitterCommanditaire.Click += new System.EventHandler(this.buttonQuitterCommanditaire_Click);
            // 
            // buttonAfficherCommanditaires
            // 
            this.buttonAfficherCommanditaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficherCommanditaires.Location = new System.Drawing.Point(497, 133);
            this.buttonAfficherCommanditaires.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficherCommanditaires.Name = "buttonAfficherCommanditaires";
            this.buttonAfficherCommanditaires.Size = new System.Drawing.Size(221, 28);
            this.buttonAfficherCommanditaires.TabIndex = 5;
            this.buttonAfficherCommanditaires.Text = "Afficher Commanditaires";
            this.buttonAfficherCommanditaires.UseVisualStyleBackColor = true;
            this.buttonAfficherCommanditaires.Click += new System.EventHandler(this.buttonAfficherCommanditaires_Click);
            // 
            // textBoxNomComanditaire
            // 
            this.textBoxNomComanditaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomComanditaire.Location = new System.Drawing.Point(169, 196);
            this.textBoxNomComanditaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNomComanditaire.Name = "textBoxNomComanditaire";
            this.textBoxNomComanditaire.Size = new System.Drawing.Size(209, 26);
            this.textBoxNomComanditaire.TabIndex = 3;
            // 
            // textBoxPrenomComanditaire
            // 
            this.textBoxPrenomComanditaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenomComanditaire.Location = new System.Drawing.Point(169, 133);
            this.textBoxPrenomComanditaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrenomComanditaire.Name = "textBoxPrenomComanditaire";
            this.textBoxPrenomComanditaire.Size = new System.Drawing.Size(209, 26);
            this.textBoxPrenomComanditaire.TabIndex = 2;
            // 
            // textBoxIdComanditaire
            // 
            this.textBoxIdComanditaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdComanditaire.Location = new System.Drawing.Point(169, 71);
            this.textBoxIdComanditaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdComanditaire.Name = "textBoxIdComanditaire";
            this.textBoxIdComanditaire.Size = new System.Drawing.Size(209, 26);
            this.textBoxIdComanditaire.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(112, 199);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(88, 137);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Prénom:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(136, 75);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Id:";
            // 
            // tabPagePrix
            // 
            this.tabPagePrix.BackColor = System.Drawing.Color.Orange;
            this.tabPagePrix.Controls.Add(this.textBoxIdCommanditairePrix);
            this.tabPagePrix.Controls.Add(this.textBoxQuantite);
            this.tabPagePrix.Controls.Add(this.textBoxValeurPrix);
            this.tabPagePrix.Controls.Add(this.textBoxDescriptionPrix);
            this.tabPagePrix.Controls.Add(this.textBoxIdPrix);
            this.tabPagePrix.Controls.Add(this.label21);
            this.tabPagePrix.Controls.Add(this.label22);
            this.tabPagePrix.Controls.Add(this.label23);
            this.tabPagePrix.Controls.Add(this.label24);
            this.tabPagePrix.Controls.Add(this.label25);
            this.tabPagePrix.Controls.Add(this.buttonAjouterPrix);
            this.tabPagePrix.Controls.Add(this.buttonQuitterPrix);
            this.tabPagePrix.Controls.Add(this.buttonAfficherCommanditairePrix);
            this.tabPagePrix.Controls.Add(this.buttonAfficherPrix);
            this.tabPagePrix.Controls.Add(this.label20);
            this.tabPagePrix.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePrix.Name = "tabPagePrix";
            this.tabPagePrix.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePrix.Size = new System.Drawing.Size(872, 268);
            this.tabPagePrix.TabIndex = 3;
            this.tabPagePrix.Text = "Prix";
            // 
            // textBoxIdCommanditairePrix
            // 
            this.textBoxIdCommanditairePrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCommanditairePrix.Location = new System.Drawing.Point(183, 213);
            this.textBoxIdCommanditairePrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdCommanditairePrix.Name = "textBoxIdCommanditairePrix";
            this.textBoxIdCommanditairePrix.Size = new System.Drawing.Size(132, 26);
            this.textBoxIdCommanditairePrix.TabIndex = 5;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantite.Location = new System.Drawing.Point(183, 176);
            this.textBoxQuantite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(132, 26);
            this.textBoxQuantite.TabIndex = 4;
            // 
            // textBoxValeurPrix
            // 
            this.textBoxValeurPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValeurPrix.Location = new System.Drawing.Point(183, 139);
            this.textBoxValeurPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxValeurPrix.Name = "textBoxValeurPrix";
            this.textBoxValeurPrix.Size = new System.Drawing.Size(132, 26);
            this.textBoxValeurPrix.TabIndex = 3;
            // 
            // textBoxDescriptionPrix
            // 
            this.textBoxDescriptionPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptionPrix.Location = new System.Drawing.Point(183, 102);
            this.textBoxDescriptionPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescriptionPrix.Name = "textBoxDescriptionPrix";
            this.textBoxDescriptionPrix.Size = new System.Drawing.Size(132, 26);
            this.textBoxDescriptionPrix.TabIndex = 2;
            // 
            // textBoxIdPrix
            // 
            this.textBoxIdPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdPrix.Location = new System.Drawing.Point(183, 65);
            this.textBoxIdPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdPrix.Name = "textBoxIdPrix";
            this.textBoxIdPrix.Size = new System.Drawing.Size(132, 26);
            this.textBoxIdPrix.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(24, 217);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 20);
            this.label21.TabIndex = 0;
            this.label21.Text = "Id Commanditaire:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(99, 180);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Quantité:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(77, 143);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Valeur/Points:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(73, 106);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "Description:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(149, 69);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Id:";
            // 
            // buttonAjouterPrix
            // 
            this.buttonAjouterPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterPrix.Location = new System.Drawing.Point(361, 64);
            this.buttonAjouterPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAjouterPrix.Name = "buttonAjouterPrix";
            this.buttonAjouterPrix.Size = new System.Drawing.Size(205, 28);
            this.buttonAjouterPrix.TabIndex = 6;
            this.buttonAjouterPrix.Text = "Ajouter Prix";
            this.buttonAjouterPrix.UseVisualStyleBackColor = true;
            this.buttonAjouterPrix.Click += new System.EventHandler(this.buttonAjouterPrix_Click);
            // 
            // buttonQuitterPrix
            // 
            this.buttonQuitterPrix.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuitterPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitterPrix.Location = new System.Drawing.Point(660, 139);
            this.buttonQuitterPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuitterPrix.Name = "buttonQuitterPrix";
            this.buttonQuitterPrix.Size = new System.Drawing.Size(129, 28);
            this.buttonQuitterPrix.TabIndex = 9;
            this.buttonQuitterPrix.Text = "Quitter";
            this.buttonQuitterPrix.UseVisualStyleBackColor = true;
            this.buttonQuitterPrix.Click += new System.EventHandler(this.buttonQuitterPrix_Click);
            // 
            // buttonAfficherCommanditairePrix
            // 
            this.buttonAfficherCommanditairePrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficherCommanditairePrix.Location = new System.Drawing.Point(361, 213);
            this.buttonAfficherCommanditairePrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficherCommanditairePrix.Name = "buttonAfficherCommanditairePrix";
            this.buttonAfficherCommanditairePrix.Size = new System.Drawing.Size(205, 28);
            this.buttonAfficherCommanditairePrix.TabIndex = 8;
            this.buttonAfficherCommanditairePrix.Text = "Afficher Commanditaire";
            this.buttonAfficherCommanditairePrix.UseVisualStyleBackColor = true;
            this.buttonAfficherCommanditairePrix.Click += new System.EventHandler(this.buttonAfficherCommanditairePrix_Click);
            // 
            // buttonAfficherPrix
            // 
            this.buttonAfficherPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficherPrix.Location = new System.Drawing.Point(361, 139);
            this.buttonAfficherPrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficherPrix.Name = "buttonAfficherPrix";
            this.buttonAfficherPrix.Size = new System.Drawing.Size(205, 28);
            this.buttonAfficherPrix.TabIndex = 7;
            this.buttonAfficherPrix.Text = "Afficher Prix";
            this.buttonAfficherPrix.UseVisualStyleBackColor = true;
            this.buttonAfficherPrix.Click += new System.EventHandler(this.buttonAfficherPrix_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(27, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Informations Prix";
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Enabled = false;
            this.richTextBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessages.Location = new System.Drawing.Point(16, 368);
            this.richTextBoxMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.Size = new System.Drawing.Size(873, 357);
            this.richTextBoxMessages.TabIndex = 1;
            this.richTextBoxMessages.Text = "";
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonAjouterDonateur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.CancelButton = this.buttonQuitterDonateur;
            this.ClientSize = new System.Drawing.Size(912, 741);
            this.Controls.Add(this.richTextBoxMessages);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Système Théleton Électronique STE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDonateur.ResumeLayout(false);
            this.tabPageDonateur.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageDon.ResumeLayout(false);
            this.tabPageDon.PerformLayout();
            this.tabPageComanditaire.ResumeLayout(false);
            this.tabPageComanditaire.PerformLayout();
            this.tabPagePrix.ResumeLayout(false);
            this.tabPagePrix.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDonateur;
        private System.Windows.Forms.Button buttonQuitterDonateur;
        private System.Windows.Forms.Button buttonAfficherDonateurs;
        private System.Windows.Forms.Button buttonAjouterDonateur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpirationCarte;
        private System.Windows.Forms.TextBox textBoxNumeroCarte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonAmex;
        private System.Windows.Forms.RadioButton radioButtonMaster;
        private System.Windows.Forms.RadioButton radioButtonVisa;
        private System.Windows.Forms.TextBox textBoxTelephoneDonateur;
        private System.Windows.Forms.TextBox textBoxAdresseDonateur;
        private System.Windows.Forms.TextBox textBoxNomDonateur;
        private System.Windows.Forms.TextBox textBoxPrenomDonateur;
        private System.Windows.Forms.TextBox textBoxIdDonateur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDon;
        private System.Windows.Forms.TextBox textBoxMontantDon;
        private System.Windows.Forms.TextBox textBoxIdDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageComanditaire;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.Button buttonQuitterDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAttribuerPrix;
        private System.Windows.Forms.Button buttonAjouterDon;
        private System.Windows.Forms.Button buttonAfficherDonnateursDon;
        private System.Windows.Forms.Button buttonAfficherDons;
        private System.Windows.Forms.TextBox textBoxIdDonateurDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNombrePoints;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonAjouterCommanditaire;
        private System.Windows.Forms.Button buttonQuitterCommanditaire;
        private System.Windows.Forms.Button buttonAfficherCommanditaires;
        private System.Windows.Forms.TextBox textBoxNomComanditaire;
        private System.Windows.Forms.TextBox textBoxPrenomComanditaire;
        private System.Windows.Forms.TextBox textBoxIdComanditaire;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPagePrix;
        private System.Windows.Forms.TextBox textBoxIdCommanditairePrix;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.TextBox textBoxValeurPrix;
        private System.Windows.Forms.TextBox textBoxDescriptionPrix;
        private System.Windows.Forms.TextBox textBoxIdPrix;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button buttonAjouterPrix;
        private System.Windows.Forms.Button buttonQuitterPrix;
        private System.Windows.Forms.Button buttonAfficherCommanditairePrix;
        private System.Windows.Forms.Button buttonAfficherPrix;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxPrix;
    }
}