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
            this.tb_motDePasse = new System.Windows.Forms.TextBox();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.b_connection = new System.Windows.Forms.Button();
            this.l_motDePasse = new System.Windows.Forms.Label();
            this.l_identifiant = new System.Windows.Forms.Label();
            this.p_connection = new System.Windows.Forms.Panel();
            this.p_connection.SuspendLayout();
            this.SuspendLayout();
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
            this.p_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.p_connection.Controls.Add(this.l_identifiant);
            this.p_connection.Controls.Add(this.l_motDePasse);
            this.p_connection.Controls.Add(this.b_connection);
            this.p_connection.Controls.Add(this.tb_identifiant);
            this.p_connection.Controls.Add(this.tb_motDePasse);
            this.p_connection.Location = new System.Drawing.Point(455, 181);
            this.p_connection.Name = "p_connection";
            this.p_connection.Size = new System.Drawing.Size(217, 128);
            this.p_connection.TabIndex = 5;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 593);
            this.Controls.Add(this.p_connection);
            this.Name = "Connection";
            this.Text = " Médistock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionAdmin_FormClosing);
            this.p_connection.ResumeLayout(false);
            this.p_connection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_motDePasse;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.Button b_connection;
        private System.Windows.Forms.Label l_motDePasse;
        private System.Windows.Forms.Label l_identifiant;
        private System.Windows.Forms.Panel p_connection;
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

