namespace TraineWinForm
{
    partial class Connection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_rechercheRetraitMedicament = new System.Windows.Forms.Panel();
            this.b_rechercheReapprovisionnementMedic = new System.Windows.Forms.Button();
            this.b_modifierRajouterMedic = new System.Windows.Forms.Button();
            this.b_rechecherMedicamentInfo = new System.Windows.Forms.Button();
            this.l_localisationMedicament = new System.Windows.Forms.Label();
            this.b_RetraitMedicament = new System.Windows.Forms.Button();
            this.tb_rechercheTypeMedic = new System.Windows.Forms.TextBox();
            this.l_typeMedic = new System.Windows.Forms.Label();
            this.tb_recherchePrincipeActifMedic = new System.Windows.Forms.TextBox();
            this.l_principeActifMedic = new System.Windows.Forms.Label();
            this.l_recherchePar = new System.Windows.Forms.Label();
            this.tb_rechercheCodeMedic = new System.Windows.Forms.TextBox();
            this.l_rechercheCodeMedic = new System.Windows.Forms.Label();
            this.l_rechercheNomMedic = new System.Windows.Forms.Label();
            this.tb_rechercheNomMedic = new System.Windows.Forms.TextBox();
            this.l_retraitMedicament = new System.Windows.Forms.Label();
            this.tb_motDePasse = new System.Windows.Forms.TextBox();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.b_connection = new System.Windows.Forms.Button();
            this.l_motDePasse = new System.Windows.Forms.Label();
            this.l_identifiant = new System.Windows.Forms.Label();
            this.p_connection = new System.Windows.Forms.Panel();
            this.dgv_medicamentRechercher = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrincipeActif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seuilCritique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_medicamentChoisi = new System.Windows.Forms.Label();
            this.p_retraitMedicament = new System.Windows.Forms.Panel();
            this.p_modificationComplete = new System.Windows.Forms.Panel();
            this.cb_medicamentMasqué = new System.Windows.Forms.CheckBox();
            this.b_modificationComplete = new System.Windows.Forms.Button();
            this.p_panelDegestionStock = new System.Windows.Forms.Panel();
            this.b_gestionMedicament = new System.Windows.Forms.Button();
            this.nud_choixTailleRetraitMedicament = new System.Windows.Forms.NumericUpDown();
            this.p_acceuil = new System.Windows.Forms.Panel();
            this.l_acceuil = new System.Windows.Forms.Label();
            this.b_Deconnection = new System.Windows.Forms.Button();
            this.p_rechercheRetraitMedicament.SuspendLayout();
            this.p_connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicamentRechercher)).BeginInit();
            this.p_retraitMedicament.SuspendLayout();
            this.p_modificationComplete.SuspendLayout();
            this.p_panelDegestionStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_choixTailleRetraitMedicament)).BeginInit();
            this.p_acceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_rechercheRetraitMedicament
            // 
            this.p_rechercheRetraitMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_rechercheRetraitMedicament.Controls.Add(this.b_rechercheReapprovisionnementMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.b_modifierRajouterMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.b_rechecherMedicamentInfo);
            this.p_rechercheRetraitMedicament.Controls.Add(this.l_localisationMedicament);
            this.p_rechercheRetraitMedicament.Controls.Add(this.b_RetraitMedicament);
            this.p_rechercheRetraitMedicament.Controls.Add(this.tb_rechercheTypeMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.l_typeMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.tb_recherchePrincipeActifMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.l_principeActifMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.l_recherchePar);
            this.p_rechercheRetraitMedicament.Controls.Add(this.tb_rechercheCodeMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.l_rechercheCodeMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.l_rechercheNomMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.tb_rechercheNomMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.l_retraitMedicament);
            this.p_rechercheRetraitMedicament.Location = new System.Drawing.Point(15, 42);
            this.p_rechercheRetraitMedicament.Name = "p_rechercheRetraitMedicament";
            this.p_rechercheRetraitMedicament.Size = new System.Drawing.Size(388, 304);
            this.p_rechercheRetraitMedicament.TabIndex = 6;
            this.p_rechercheRetraitMedicament.Visible = false;
            // 
            // b_rechercheReapprovisionnementMedic
            // 
            this.b_rechercheReapprovisionnementMedic.BackColor = System.Drawing.Color.White;
            this.b_rechercheReapprovisionnementMedic.Location = new System.Drawing.Point(24, 211);
            this.b_rechercheReapprovisionnementMedic.Name = "b_rechercheReapprovisionnementMedic";
            this.b_rechercheReapprovisionnementMedic.Size = new System.Drawing.Size(194, 23);
            this.b_rechercheReapprovisionnementMedic.TabIndex = 17;
            this.b_rechercheReapprovisionnementMedic.Text = "Recherche pour réapprovisionnement";
            this.b_rechercheReapprovisionnementMedic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_rechercheReapprovisionnementMedic.UseVisualStyleBackColor = false;
            this.b_rechercheReapprovisionnementMedic.Visible = false;
            // 
            // b_modifierRajouterMedic
            // 
            this.b_modifierRajouterMedic.BackColor = System.Drawing.Color.White;
            this.b_modifierRajouterMedic.Location = new System.Drawing.Point(24, 269);
            this.b_modifierRajouterMedic.Name = "b_modifierRajouterMedic";
            this.b_modifierRajouterMedic.Size = new System.Drawing.Size(194, 23);
            this.b_modifierRajouterMedic.TabIndex = 16;
            this.b_modifierRajouterMedic.Text = "Modifier/Rajouter un médicament";
            this.b_modifierRajouterMedic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_modifierRajouterMedic.UseVisualStyleBackColor = false;
            this.b_modifierRajouterMedic.Visible = false;
            // 
            // b_rechecherMedicamentInfo
            // 
            this.b_rechecherMedicamentInfo.BackColor = System.Drawing.Color.White;
            this.b_rechecherMedicamentInfo.Location = new System.Drawing.Point(24, 240);
            this.b_rechecherMedicamentInfo.Name = "b_rechecherMedicamentInfo";
            this.b_rechecherMedicamentInfo.Size = new System.Drawing.Size(194, 23);
            this.b_rechecherMedicamentInfo.TabIndex = 15;
            this.b_rechecherMedicamentInfo.Text = "Recherche pour informations";
            this.b_rechecherMedicamentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_rechecherMedicamentInfo.UseVisualStyleBackColor = false;
            this.b_rechecherMedicamentInfo.Visible = false;
            // 
            // l_localisationMedicament
            // 
            this.l_localisationMedicament.AutoSize = true;
            this.l_localisationMedicament.Location = new System.Drawing.Point(154, 187);
            this.l_localisationMedicament.Name = "l_localisationMedicament";
            this.l_localisationMedicament.Size = new System.Drawing.Size(16, 13);
            this.l_localisationMedicament.TabIndex = 11;
            this.l_localisationMedicament.Text = "er";
            this.l_localisationMedicament.Visible = false;
            // 
            // b_RetraitMedicament
            // 
            this.b_RetraitMedicament.BackColor = System.Drawing.Color.White;
            this.b_RetraitMedicament.Location = new System.Drawing.Point(24, 182);
            this.b_RetraitMedicament.Name = "b_RetraitMedicament";
            this.b_RetraitMedicament.Size = new System.Drawing.Size(124, 23);
            this.b_RetraitMedicament.TabIndex = 14;
            this.b_RetraitMedicament.Text = "Recherche pour retrait";
            this.b_RetraitMedicament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_RetraitMedicament.UseVisualStyleBackColor = false;
            // 
            // tb_rechercheTypeMedic
            // 
            this.tb_rechercheTypeMedic.Location = new System.Drawing.Point(237, 121);
            this.tb_rechercheTypeMedic.Name = "tb_rechercheTypeMedic";
            this.tb_rechercheTypeMedic.Size = new System.Drawing.Size(137, 20);
            this.tb_rechercheTypeMedic.TabIndex = 13;
            // 
            // l_typeMedic
            // 
            this.l_typeMedic.Location = new System.Drawing.Point(21, 121);
            this.l_typeMedic.Name = "l_typeMedic";
            this.l_typeMedic.Size = new System.Drawing.Size(172, 17);
            this.l_typeMedic.TabIndex = 12;
            this.l_typeMedic.Text = "Type du médicament";
            // 
            // tb_recherchePrincipeActifMedic
            // 
            this.tb_recherchePrincipeActifMedic.Location = new System.Drawing.Point(237, 149);
            this.tb_recherchePrincipeActifMedic.Name = "tb_recherchePrincipeActifMedic";
            this.tb_recherchePrincipeActifMedic.Size = new System.Drawing.Size(137, 20);
            this.tb_recherchePrincipeActifMedic.TabIndex = 11;
            // 
            // l_principeActifMedic
            // 
            this.l_principeActifMedic.Location = new System.Drawing.Point(21, 149);
            this.l_principeActifMedic.Name = "l_principeActifMedic";
            this.l_principeActifMedic.Size = new System.Drawing.Size(172, 17);
            this.l_principeActifMedic.TabIndex = 10;
            this.l_principeActifMedic.Text = "Principe actif du médicament";
            // 
            // l_recherchePar
            // 
            this.l_recherchePar.Location = new System.Drawing.Point(21, 35);
            this.l_recherchePar.Name = "l_recherchePar";
            this.l_recherchePar.Size = new System.Drawing.Size(190, 23);
            this.l_recherchePar.TabIndex = 9;
            this.l_recherchePar.Text = "Recherche par : ";
            this.l_recherchePar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_rechercheCodeMedic
            // 
            this.tb_rechercheCodeMedic.Location = new System.Drawing.Point(237, 95);
            this.tb_rechercheCodeMedic.Name = "tb_rechercheCodeMedic";
            this.tb_rechercheCodeMedic.Size = new System.Drawing.Size(137, 20);
            this.tb_rechercheCodeMedic.TabIndex = 7;
            // 
            // l_rechercheCodeMedic
            // 
            this.l_rechercheCodeMedic.Location = new System.Drawing.Point(21, 98);
            this.l_rechercheCodeMedic.Name = "l_rechercheCodeMedic";
            this.l_rechercheCodeMedic.Size = new System.Drawing.Size(172, 17);
            this.l_rechercheCodeMedic.TabIndex = 7;
            this.l_rechercheCodeMedic.Text = "Code du médicament";
            // 
            // l_rechercheNomMedic
            // 
            this.l_rechercheNomMedic.Location = new System.Drawing.Point(21, 72);
            this.l_rechercheNomMedic.Name = "l_rechercheNomMedic";
            this.l_rechercheNomMedic.Size = new System.Drawing.Size(190, 20);
            this.l_rechercheNomMedic.TabIndex = 7;
            this.l_rechercheNomMedic.Text = "Nom du médicament";
            // 
            // tb_rechercheNomMedic
            // 
            this.tb_rechercheNomMedic.Location = new System.Drawing.Point(237, 69);
            this.tb_rechercheNomMedic.Name = "tb_rechercheNomMedic";
            this.tb_rechercheNomMedic.Size = new System.Drawing.Size(137, 20);
            this.tb_rechercheNomMedic.TabIndex = 8;
            // 
            // l_retraitMedicament
            // 
            this.l_retraitMedicament.Location = new System.Drawing.Point(0, 0);
            this.l_retraitMedicament.Name = "l_retraitMedicament";
            this.l_retraitMedicament.Size = new System.Drawing.Size(374, 25);
            this.l_retraitMedicament.TabIndex = 7;
            this.l_retraitMedicament.Text = "Recherche d\'un médicament";
            this.l_retraitMedicament.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_motDePasse
            // 
            this.tb_motDePasse.Location = new System.Drawing.Point(104, 54);
            this.tb_motDePasse.Name = "tb_motDePasse";
            this.tb_motDePasse.Size = new System.Drawing.Size(100, 20);
            this.tb_motDePasse.TabIndex = 2;
            this.tb_motDePasse.UseSystemPasswordChar = true;
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(104, 14);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(100, 20);
            this.tb_identifiant.TabIndex = 1;
            // 
            // b_connection
            // 
            this.b_connection.BackColor = System.Drawing.Color.White;
            this.b_connection.Location = new System.Drawing.Point(104, 91);
            this.b_connection.Name = "b_connection";
            this.b_connection.Size = new System.Drawing.Size(100, 29);
            this.b_connection.TabIndex = 0;
            this.b_connection.Text = "Entrer";
            this.b_connection.UseVisualStyleBackColor = false;
            this.b_connection.Click += new System.EventHandler(this.b_connection_Click);
            // 
            // l_motDePasse
            // 
            this.l_motDePasse.AutoSize = true;
            this.l_motDePasse.Location = new System.Drawing.Point(8, 60);
            this.l_motDePasse.Name = "l_motDePasse";
            this.l_motDePasse.Size = new System.Drawing.Size(71, 13);
            this.l_motDePasse.TabIndex = 4;
            this.l_motDePasse.Text = "Mot de passe";
            // 
            // l_identifiant
            // 
            this.l_identifiant.AutoSize = true;
            this.l_identifiant.Location = new System.Drawing.Point(5, 14);
            this.l_identifiant.Name = "l_identifiant";
            this.l_identifiant.Size = new System.Drawing.Size(53, 13);
            this.l_identifiant.TabIndex = 3;
            this.l_identifiant.Text = "Identifiant";
            // 
            // p_connection
            // 
            this.p_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_connection.Controls.Add(this.l_identifiant);
            this.p_connection.Controls.Add(this.l_motDePasse);
            this.p_connection.Controls.Add(this.b_connection);
            this.p_connection.Controls.Add(this.tb_identifiant);
            this.p_connection.Controls.Add(this.tb_motDePasse);
            this.p_connection.Location = new System.Drawing.Point(414, 253);
            this.p_connection.Name = "p_connection";
            this.p_connection.Size = new System.Drawing.Size(217, 128);
            this.p_connection.TabIndex = 5;
            // 
            // dgv_medicamentRechercher
            // 
            this.dgv_medicamentRechercher.AllowUserToAddRows = false;
            this.dgv_medicamentRechercher.AllowUserToDeleteRows = false;
            this.dgv_medicamentRechercher.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_medicamentRechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_medicamentRechercher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicamentRechercher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nom,
            this.Type,
            this.TypeMesure,
            this.PrincipeActif,
            this.Stock,
            this.seuilCritique,
            this.localisation});
            this.dgv_medicamentRechercher.Location = new System.Drawing.Point(11, 15);
            this.dgv_medicamentRechercher.Name = "dgv_medicamentRechercher";
            this.dgv_medicamentRechercher.ReadOnly = true;
            this.dgv_medicamentRechercher.Size = new System.Drawing.Size(642, 102);
            this.dgv_medicamentRechercher.TabIndex = 7;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // TypeMesure
            // 
            this.TypeMesure.HeaderText = "Type mesure";
            this.TypeMesure.Name = "TypeMesure";
            this.TypeMesure.ReadOnly = true;
            // 
            // PrincipeActif
            // 
            this.PrincipeActif.HeaderText = "Principe actif";
            this.PrincipeActif.Name = "PrincipeActif";
            this.PrincipeActif.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // seuilCritique
            // 
            this.seuilCritique.HeaderText = "Seuil critique";
            this.seuilCritique.Name = "seuilCritique";
            this.seuilCritique.ReadOnly = true;
            this.seuilCritique.Visible = false;
            // 
            // localisation
            // 
            this.localisation.HeaderText = "Localisation";
            this.localisation.Name = "localisation";
            this.localisation.ReadOnly = true;
            this.localisation.Visible = false;
            // 
            // l_medicamentChoisi
            // 
            this.l_medicamentChoisi.AutoSize = true;
            this.l_medicamentChoisi.Location = new System.Drawing.Point(3, 0);
            this.l_medicamentChoisi.Name = "l_medicamentChoisi";
            this.l_medicamentChoisi.Size = new System.Drawing.Size(149, 13);
            this.l_medicamentChoisi.TabIndex = 8;
            this.l_medicamentChoisi.Text = "Veuiller choisir un médicament";
            // 
            // p_retraitMedicament
            // 
            this.p_retraitMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_retraitMedicament.Controls.Add(this.p_modificationComplete);
            this.p_retraitMedicament.Controls.Add(this.p_panelDegestionStock);
            this.p_retraitMedicament.Controls.Add(this.dgv_medicamentRechercher);
            this.p_retraitMedicament.Location = new System.Drawing.Point(414, 12);
            this.p_retraitMedicament.Name = "p_retraitMedicament";
            this.p_retraitMedicament.Size = new System.Drawing.Size(662, 230);
            this.p_retraitMedicament.TabIndex = 9;
            this.p_retraitMedicament.Visible = false;
            // 
            // p_modificationComplete
            // 
            this.p_modificationComplete.Controls.Add(this.cb_medicamentMasqué);
            this.p_modificationComplete.Controls.Add(this.b_modificationComplete);
            this.p_modificationComplete.Location = new System.Drawing.Point(8, 128);
            this.p_modificationComplete.Name = "p_modificationComplete";
            this.p_modificationComplete.Size = new System.Drawing.Size(209, 56);
            this.p_modificationComplete.TabIndex = 11;
            this.p_modificationComplete.Visible = false;
            // 
            // cb_medicamentMasqué
            // 
            this.cb_medicamentMasqué.AutoSize = true;
            this.cb_medicamentMasqué.Location = new System.Drawing.Point(9, 5);
            this.cb_medicamentMasqué.Name = "cb_medicamentMasqué";
            this.cb_medicamentMasqué.Size = new System.Drawing.Size(189, 17);
            this.cb_medicamentMasqué.TabIndex = 1;
            this.cb_medicamentMasqué.Text = "Masqué les médicaments existants";
            this.cb_medicamentMasqué.UseVisualStyleBackColor = true;
            // 
            // b_modificationComplete
            // 
            this.b_modificationComplete.Location = new System.Drawing.Point(9, 28);
            this.b_modificationComplete.Name = "b_modificationComplete";
            this.b_modificationComplete.Size = new System.Drawing.Size(132, 23);
            this.b_modificationComplete.TabIndex = 0;
            this.b_modificationComplete.Text = "Mise à jour du stock";
            this.b_modificationComplete.UseVisualStyleBackColor = true;
            // 
            // p_panelDegestionStock
            // 
            this.p_panelDegestionStock.Controls.Add(this.l_medicamentChoisi);
            this.p_panelDegestionStock.Controls.Add(this.b_gestionMedicament);
            this.p_panelDegestionStock.Controls.Add(this.nud_choixTailleRetraitMedicament);
            this.p_panelDegestionStock.Location = new System.Drawing.Point(11, 161);
            this.p_panelDegestionStock.Name = "p_panelDegestionStock";
            this.p_panelDegestionStock.Size = new System.Drawing.Size(615, 50);
            this.p_panelDegestionStock.TabIndex = 11;
            this.p_panelDegestionStock.Visible = false;
            // 
            // b_gestionMedicament
            // 
            this.b_gestionMedicament.BackColor = System.Drawing.Color.White;
            this.b_gestionMedicament.Location = new System.Drawing.Point(77, 20);
            this.b_gestionMedicament.Name = "b_gestionMedicament";
            this.b_gestionMedicament.Size = new System.Drawing.Size(111, 20);
            this.b_gestionMedicament.TabIndex = 10;
            this.b_gestionMedicament.Text = "Retrait médicament";
            this.b_gestionMedicament.UseVisualStyleBackColor = false;
            this.b_gestionMedicament.Visible = false;
            // 
            // nud_choixTailleRetraitMedicament
            // 
            this.nud_choixTailleRetraitMedicament.Location = new System.Drawing.Point(6, 20);
            this.nud_choixTailleRetraitMedicament.Name = "nud_choixTailleRetraitMedicament";
            this.nud_choixTailleRetraitMedicament.Size = new System.Drawing.Size(62, 20);
            this.nud_choixTailleRetraitMedicament.TabIndex = 9;
            this.nud_choixTailleRetraitMedicament.Visible = false;
            // 
            // p_acceuil
            // 
            this.p_acceuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_acceuil.Controls.Add(this.l_acceuil);
            this.p_acceuil.Controls.Add(this.b_Deconnection);
            this.p_acceuil.Location = new System.Drawing.Point(15, 12);
            this.p_acceuil.Name = "p_acceuil";
            this.p_acceuil.Size = new System.Drawing.Size(388, 22);
            this.p_acceuil.TabIndex = 10;
            this.p_acceuil.Visible = false;
            // 
            // l_acceuil
            // 
            this.l_acceuil.AutoSize = true;
            this.l_acceuil.Location = new System.Drawing.Point(99, 4);
            this.l_acceuil.Name = "l_acceuil";
            this.l_acceuil.Size = new System.Drawing.Size(0, 13);
            this.l_acceuil.TabIndex = 11;
            // 
            // b_Deconnection
            // 
            this.b_Deconnection.BackColor = System.Drawing.Color.Red;
            this.b_Deconnection.Location = new System.Drawing.Point(3, -1);
            this.b_Deconnection.Name = "b_Deconnection";
            this.b_Deconnection.Size = new System.Drawing.Size(90, 23);
            this.b_Deconnection.TabIndex = 12;
            this.b_Deconnection.Text = "Déconnection";
            this.b_Deconnection.UseVisualStyleBackColor = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 593);
            this.Controls.Add(this.p_acceuil);
            this.Controls.Add(this.p_retraitMedicament);
            this.Controls.Add(this.p_connection);
            this.Controls.Add(this.p_rechercheRetraitMedicament);
            this.Name = "Connection";
            this.Text = " Médistock";
            this.p_rechercheRetraitMedicament.ResumeLayout(false);
            this.p_rechercheRetraitMedicament.PerformLayout();
            this.p_connection.ResumeLayout(false);
            this.p_connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicamentRechercher)).EndInit();
            this.p_retraitMedicament.ResumeLayout(false);
            this.p_modificationComplete.ResumeLayout(false);
            this.p_modificationComplete.PerformLayout();
            this.p_panelDegestionStock.ResumeLayout(false);
            this.p_panelDegestionStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_choixTailleRetraitMedicament)).EndInit();
            this.p_acceuil.ResumeLayout(false);
            this.p_acceuil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_rechercheRetraitMedicament;
        private System.Windows.Forms.Label l_retraitMedicament;
        private System.Windows.Forms.TextBox tb_rechercheCodeMedic;
        private System.Windows.Forms.Label l_rechercheCodeMedic;
        private System.Windows.Forms.Label l_rechercheNomMedic;
        private System.Windows.Forms.TextBox tb_rechercheNomMedic;
        private System.Windows.Forms.TextBox tb_recherchePrincipeActifMedic;
        private System.Windows.Forms.Label l_principeActifMedic;
        private System.Windows.Forms.Label l_recherchePar;
        private System.Windows.Forms.TextBox tb_rechercheTypeMedic;
        private System.Windows.Forms.Label l_typeMedic;
        private System.Windows.Forms.TextBox tb_motDePasse;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.Button b_connection;
        private System.Windows.Forms.Label l_motDePasse;
        private System.Windows.Forms.Label l_identifiant;
        private System.Windows.Forms.Panel p_connection;
        private System.Windows.Forms.DataGridView dgv_medicamentRechercher;
        private System.Windows.Forms.Button b_RetraitMedicament;
        private System.Windows.Forms.Label l_medicamentChoisi;
        private System.Windows.Forms.Panel p_retraitMedicament;
        private System.Windows.Forms.NumericUpDown nud_choixTailleRetraitMedicament;
        private System.Windows.Forms.Button b_gestionMedicament;
        private System.Windows.Forms.Label l_localisationMedicament;
        private System.Windows.Forms.Button b_rechercheReapprovisionnementMedic;
        private System.Windows.Forms.Button b_modifierRajouterMedic;
        private System.Windows.Forms.Button b_rechecherMedicamentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrincipeActif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn seuilCritique;
        private System.Windows.Forms.DataGridViewTextBoxColumn localisation;
        private System.Windows.Forms.Panel p_panelDegestionStock;
        private System.Windows.Forms.Panel p_acceuil;
        private System.Windows.Forms.Label l_acceuil;
        private System.Windows.Forms.Button b_Deconnection;
        private System.Windows.Forms.Panel p_modificationComplete;
        private System.Windows.Forms.Button b_modificationComplete;
        private System.Windows.Forms.CheckBox cb_medicamentMasqué;
        /* patient pour plus tard
private System.Windows.Forms.TextBox tb_numeroDossierPatient;
private System.Windows.Forms.TextBox tb_ChambrePatient;
private System.Windows.Forms.TextBox tb_prenomPatient;
private System.Windows.Forms.TextBox tb_nomPatient;
private System.Windows.Forms.Label l_numeroDossierPatient;
private System.Windows.Forms.Label l_chambrePatient;
private System.Windows.Forms.Label l_prenomPatient;
private System.Windows.Forms.Label l_nomPatient;
*/
    }
}

