namespace TraineWinForm
{
    partial class GestionAdmin
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
            this.p_acceuil = new System.Windows.Forms.Panel();
            this.l_acceuil = new System.Windows.Forms.Label();
            this.b_Deconnection = new System.Windows.Forms.Button();
            this.p_rechercheRetraitMedicament = new System.Windows.Forms.Panel();
            this.cb_allMedicament = new System.Windows.Forms.CheckBox();
            this.b_rechercheReapprovisionnementMedic = new System.Windows.Forms.Button();
            this.b_modifierRajouterMedic = new System.Windows.Forms.Button();
            this.b_rechecherMedicamentInfo = new System.Windows.Forms.Button();
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
            this.p_retraitMedicament = new System.Windows.Forms.Panel();
            this.p_panelDegestionStock = new System.Windows.Forms.Panel();
            this.p_modificationComplete = new System.Windows.Forms.Panel();
            this.b_modificationComplete = new System.Windows.Forms.Button();
            this.l_medicamentChoisi = new System.Windows.Forms.Label();
            this.b_gestionMedicament = new System.Windows.Forms.Button();
            this.nud_choixTailleRetraitMedicament = new System.Windows.Forms.NumericUpDown();
            this.dgv_medicamentRechercher = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMesure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrincipeActif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seuilCritique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_modifierRajouter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p_nouveauMedecament = new System.Windows.Forms.Panel();
            this.l_Ajout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_acceuil.SuspendLayout();
            this.p_rechercheRetraitMedicament.SuspendLayout();
            this.p_retraitMedicament.SuspendLayout();
            this.p_panelDegestionStock.SuspendLayout();
            this.p_modificationComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_choixTailleRetraitMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicamentRechercher)).BeginInit();
            this.p_modifierRajouter.SuspendLayout();
            this.p_nouveauMedecament.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_acceuil
            // 
            this.p_acceuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_acceuil.Controls.Add(this.l_acceuil);
            this.p_acceuil.Controls.Add(this.b_Deconnection);
            this.p_acceuil.Location = new System.Drawing.Point(12, 12);
            this.p_acceuil.Name = "p_acceuil";
            this.p_acceuil.Size = new System.Drawing.Size(427, 22);
            this.p_acceuil.TabIndex = 11;
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
            this.b_Deconnection.Click += new System.EventHandler(this.b_Deconnection_Click);
            // 
            // p_rechercheRetraitMedicament
            // 
            this.p_rechercheRetraitMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_rechercheRetraitMedicament.Controls.Add(this.cb_allMedicament);
            this.p_rechercheRetraitMedicament.Controls.Add(this.b_rechercheReapprovisionnementMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.b_modifierRajouterMedic);
            this.p_rechercheRetraitMedicament.Controls.Add(this.b_rechecherMedicamentInfo);
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
            this.p_rechercheRetraitMedicament.Location = new System.Drawing.Point(12, 40);
            this.p_rechercheRetraitMedicament.Name = "p_rechercheRetraitMedicament";
            this.p_rechercheRetraitMedicament.Size = new System.Drawing.Size(427, 304);
            this.p_rechercheRetraitMedicament.TabIndex = 12;
            // 
            // cb_allMedicament
            // 
            this.cb_allMedicament.AutoSize = true;
            this.cb_allMedicament.Location = new System.Drawing.Point(235, 46);
            this.cb_allMedicament.Name = "cb_allMedicament";
            this.cb_allMedicament.Size = new System.Drawing.Size(161, 17);
            this.cb_allMedicament.TabIndex = 1;
            this.cb_allMedicament.Text = "Afficher tous les médicament";
            this.cb_allMedicament.UseVisualStyleBackColor = true;
            this.cb_allMedicament.Click += new System.EventHandler(this.cb_medicamentMasqué_CheckedChanged);
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
            this.b_rechercheReapprovisionnementMedic.Click += new System.EventHandler(this.b_reapprovisionnementMedic_Click);
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
            this.b_modifierRajouterMedic.Click += new System.EventHandler(this.b_modifierRajouterMedic_Click);
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
            this.b_rechecherMedicamentInfo.Click += new System.EventHandler(this.b_rechecherMedicamentInfo_Click);
            // 
            // b_RetraitMedicament
            // 
            this.b_RetraitMedicament.BackColor = System.Drawing.Color.White;
            this.b_RetraitMedicament.Location = new System.Drawing.Point(24, 182);
            this.b_RetraitMedicament.Name = "b_RetraitMedicament";
            this.b_RetraitMedicament.Size = new System.Drawing.Size(194, 23);
            this.b_RetraitMedicament.TabIndex = 14;
            this.b_RetraitMedicament.Text = "Recherche pour retrait";
            this.b_RetraitMedicament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_RetraitMedicament.UseVisualStyleBackColor = false;
            this.b_RetraitMedicament.Click += new System.EventHandler(this.b_retraitMedicament_Click);
            // 
            // tb_rechercheTypeMedic
            // 
            this.tb_rechercheTypeMedic.Location = new System.Drawing.Point(235, 121);
            this.tb_rechercheTypeMedic.Name = "tb_rechercheTypeMedic";
            this.tb_rechercheTypeMedic.Size = new System.Drawing.Size(189, 20);
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
            this.tb_recherchePrincipeActifMedic.Location = new System.Drawing.Point(235, 147);
            this.tb_recherchePrincipeActifMedic.Name = "tb_recherchePrincipeActifMedic";
            this.tb_recherchePrincipeActifMedic.Size = new System.Drawing.Size(189, 20);
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
            this.tb_rechercheCodeMedic.Location = new System.Drawing.Point(235, 95);
            this.tb_rechercheCodeMedic.Name = "tb_rechercheCodeMedic";
            this.tb_rechercheCodeMedic.Size = new System.Drawing.Size(189, 20);
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
            this.tb_rechercheNomMedic.Location = new System.Drawing.Point(235, 69);
            this.tb_rechercheNomMedic.Name = "tb_rechercheNomMedic";
            this.tb_rechercheNomMedic.Size = new System.Drawing.Size(189, 20);
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
            // p_retraitMedicament
            // 
            this.p_retraitMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_retraitMedicament.Controls.Add(this.p_panelDegestionStock);
            this.p_retraitMedicament.Controls.Add(this.dgv_medicamentRechercher);
            this.p_retraitMedicament.Location = new System.Drawing.Point(445, 12);
            this.p_retraitMedicament.Name = "p_retraitMedicament";
            this.p_retraitMedicament.Size = new System.Drawing.Size(869, 333);
            this.p_retraitMedicament.TabIndex = 13;
            this.p_retraitMedicament.Visible = false;
            // 
            // p_panelDegestionStock
            // 
            this.p_panelDegestionStock.Controls.Add(this.p_modificationComplete);
            this.p_panelDegestionStock.Controls.Add(this.l_medicamentChoisi);
            this.p_panelDegestionStock.Controls.Add(this.b_gestionMedicament);
            this.p_panelDegestionStock.Controls.Add(this.nud_choixTailleRetraitMedicament);
            this.p_panelDegestionStock.Location = new System.Drawing.Point(11, 271);
            this.p_panelDegestionStock.Name = "p_panelDegestionStock";
            this.p_panelDegestionStock.Size = new System.Drawing.Size(615, 50);
            this.p_panelDegestionStock.TabIndex = 11;
            this.p_panelDegestionStock.Visible = false;
            // 
            // p_modificationComplete
            // 
            this.p_modificationComplete.Controls.Add(this.b_modificationComplete);
            this.p_modificationComplete.Location = new System.Drawing.Point(403, 0);
            this.p_modificationComplete.Name = "p_modificationComplete";
            this.p_modificationComplete.Size = new System.Drawing.Size(209, 56);
            this.p_modificationComplete.TabIndex = 11;
            this.p_modificationComplete.Visible = false;
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
            // l_medicamentChoisi
            // 
            this.l_medicamentChoisi.AutoSize = true;
            this.l_medicamentChoisi.Location = new System.Drawing.Point(3, 0);
            this.l_medicamentChoisi.Name = "l_medicamentChoisi";
            this.l_medicamentChoisi.Size = new System.Drawing.Size(149, 13);
            this.l_medicamentChoisi.TabIndex = 8;
            this.l_medicamentChoisi.Text = "Veuiller choisir un médicament";
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
            this.b_gestionMedicament.Click += new System.EventHandler(this.b_gestionMedicament_Click);
            // 
            // nud_choixTailleRetraitMedicament
            // 
            this.nud_choixTailleRetraitMedicament.Location = new System.Drawing.Point(6, 20);
            this.nud_choixTailleRetraitMedicament.Name = "nud_choixTailleRetraitMedicament";
            this.nud_choixTailleRetraitMedicament.Size = new System.Drawing.Size(62, 20);
            this.nud_choixTailleRetraitMedicament.TabIndex = 9;
            this.nud_choixTailleRetraitMedicament.Visible = false;
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
            this.dgv_medicamentRechercher.Size = new System.Drawing.Size(850, 248);
            this.dgv_medicamentRechercher.TabIndex = 7;
            this.dgv_medicamentRechercher.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_medicamentRechercher_CellMouseClick);
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
            // 
            // localisation
            // 
            this.localisation.HeaderText = "Localisation";
            this.localisation.Name = "localisation";
            this.localisation.ReadOnly = true;
            // 
            // p_modifierRajouter
            // 
            this.p_modifierRajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p_modifierRajouter.Controls.Add(this.panel2);
            this.p_modifierRajouter.Controls.Add(this.p_nouveauMedecament);
            this.p_modifierRajouter.Controls.Add(this.label2);
            this.p_modifierRajouter.Location = new System.Drawing.Point(445, 351);
            this.p_modifierRajouter.Name = "p_modifierRajouter";
            this.p_modifierRajouter.Size = new System.Drawing.Size(869, 303);
            this.p_modifierRajouter.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(518, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // p_nouveauMedecament
            // 
            this.p_nouveauMedecament.BackColor = System.Drawing.Color.White;
            this.p_nouveauMedecament.Controls.Add(this.l_Ajout);
            this.p_nouveauMedecament.Location = new System.Drawing.Point(11, 15);
            this.p_nouveauMedecament.Name = "p_nouveauMedecament";
            this.p_nouveauMedecament.Size = new System.Drawing.Size(335, 272);
            this.p_nouveauMedecament.TabIndex = 2;
            // 
            // l_Ajout
            // 
            this.l_Ajout.AutoSize = true;
            this.l_Ajout.Location = new System.Drawing.Point(74, 12);
            this.l_Ajout.Name = "l_Ajout";
            this.l_Ajout.Size = new System.Drawing.Size(159, 13);
            this.l_Ajout.TabIndex = 0;
            this.l_Ajout.Text = "Insérer un nouveau médicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // GestionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 666);
            this.Controls.Add(this.p_modifierRajouter);
            this.Controls.Add(this.p_retraitMedicament);
            this.Controls.Add(this.p_rechercheRetraitMedicament);
            this.Controls.Add(this.p_acceuil);
            this.Name = "GestionAdmin";
            this.Text = "gestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionAdmin_FormClosing);
            this.p_acceuil.ResumeLayout(false);
            this.p_acceuil.PerformLayout();
            this.p_rechercheRetraitMedicament.ResumeLayout(false);
            this.p_rechercheRetraitMedicament.PerformLayout();
            this.p_retraitMedicament.ResumeLayout(false);
            this.p_panelDegestionStock.ResumeLayout(false);
            this.p_panelDegestionStock.PerformLayout();
            this.p_modificationComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_choixTailleRetraitMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicamentRechercher)).EndInit();
            this.p_modifierRajouter.ResumeLayout(false);
            this.p_modifierRajouter.PerformLayout();
            this.p_nouveauMedecament.ResumeLayout(false);
            this.p_nouveauMedecament.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_acceuil;
        private System.Windows.Forms.Label l_acceuil;
        private System.Windows.Forms.Button b_Deconnection;
        private System.Windows.Forms.Panel p_rechercheRetraitMedicament;
        private System.Windows.Forms.Button b_rechercheReapprovisionnementMedic;
        private System.Windows.Forms.Button b_modifierRajouterMedic;
        private System.Windows.Forms.Button b_rechecherMedicamentInfo;
        private System.Windows.Forms.Button b_RetraitMedicament;
        private System.Windows.Forms.TextBox tb_rechercheTypeMedic;
        private System.Windows.Forms.Label l_typeMedic;
        private System.Windows.Forms.TextBox tb_recherchePrincipeActifMedic;
        private System.Windows.Forms.Label l_principeActifMedic;
        private System.Windows.Forms.Label l_recherchePar;
        private System.Windows.Forms.TextBox tb_rechercheCodeMedic;
        private System.Windows.Forms.Label l_rechercheCodeMedic;
        private System.Windows.Forms.Label l_rechercheNomMedic;
        private System.Windows.Forms.TextBox tb_rechercheNomMedic;
        private System.Windows.Forms.Label l_retraitMedicament;
        private System.Windows.Forms.Panel p_retraitMedicament;
        private System.Windows.Forms.CheckBox cb_allMedicament;
        private System.Windows.Forms.Panel p_panelDegestionStock;
        private System.Windows.Forms.Label l_medicamentChoisi;
        private System.Windows.Forms.Button b_gestionMedicament;
        private System.Windows.Forms.NumericUpDown nud_choixTailleRetraitMedicament;
        private System.Windows.Forms.DataGridView dgv_medicamentRechercher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMesure;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrincipeActif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn seuilCritique;
        private System.Windows.Forms.DataGridViewTextBoxColumn localisation;
        private System.Windows.Forms.Panel p_modifierRajouter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel p_nouveauMedecament;
        private System.Windows.Forms.Label l_Ajout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p_modificationComplete;
        private System.Windows.Forms.Button b_modificationComplete;
    }
}