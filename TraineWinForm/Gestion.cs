using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraineWinForm
{
    public partial class Gestion : Form
    {
        private Metier metier;
        public Gestion(Metier p_metier)
        {
            metier = p_metier;
            InitializeComponent();
            l_acceuil.Text = ("bonjour " + metier.get_m_utilisateur().get_prenom() + " " + metier.get_m_utilisateur().get_nom());           
        }

        //A la selection d'une cellule, sélectionne un médicament et demande le retrait de celui-ci
        private void dgv_medicamentRechercher_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            if (metier.get_boutonChoisi() == 1 || metier.get_boutonChoisi() == 2)
            {
                if (id >= 0 && metier.get_boutonChoisi() <= 2)
                {
                    DataGridViewRow ligne = dgv_medicamentRechercher.Rows[id];
                    l_medicamentChoisi.Text = "Médicament selectionner : " + ligne.Cells[1].Value.ToString() + " en " + ligne.Cells[2].Value.ToString() + ". Combien voulez-vous de " + ligne.Cells[3].Value.ToString() + "?";
                    metier.set_indiceMedicamentChoisi(id);
                    nud_choixTailleRetraitMedicament.Visible = true;
                    b_gestionMedicament.Visible = true;
                }
                else
                {
                    l_medicamentChoisi.Text = "Veuiller choisir un médicament";
                    nud_choixTailleRetraitMedicament.Visible = false;
                    b_gestionMedicament.Visible = false;
                }
            }
        }
        private void b_gestionMedicament_Click(object sender, EventArgs e)
        {
            l_medicamentChoisi.Text = "Veuiller choisir un médicament";
            p_retraitMedicament.Visible = false;
            nud_choixTailleRetraitMedicament.Visible = false;
            b_gestionMedicament.Visible = false;
            tb_rechercheCodeMedic.Text = "";
            tb_rechercheNomMedic.Text = "";
            tb_rechercheTypeMedic.Text = "";
            tb_recherchePrincipeActifMedic.Text = "";
            if (metier.get_boutonChoisi() == 1)
            {
                metier.retraitStockMedicament(metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()), nud_choixTailleRetraitMedicament.Value);
                l_localisationMedicament.Text = "Le médicament rechercher se trouve ici : " + metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()).get_localisation();
                l_localisationMedicament.Visible = true;
            }
            nud_choixTailleRetraitMedicament.Value = 0;
        }
        //Affiche les médicament contenue dans la liste de médicament correspondant au filtre
        private void rechercheMedicament()
        {
            dgv_medicamentRechercher.Rows.Clear();
            dgv_medicamentRechercher.Update();
            metier.filtreMedicament(tb_rechercheCodeMedic.Text, tb_rechercheNomMedic.Text, tb_rechercheTypeMedic.Text, tb_recherchePrincipeActifMedic.Text);
            for (int i = 0; i < metier.get_compteMedicamentRechercher(); i++)
            {
                dgv_medicamentRechercher.Rows.Add(
                    metier.get_medicamentRechercher(i).get_code(),
                    metier.get_medicamentRechercher(i).get_nom(),
                    metier.get_medicamentRechercher(i).get_type(),
                    metier.get_medicamentRechercher(i).get_typeMesure(),
                    metier.get_medicamentRechercher(i).get_principeActif(),
                    metier.get_medicamentRechercher(i).get_stock(),
                    metier.get_medicamentRechercher(i).get_seuilCritique(),
                    metier.get_medicamentRechercher(i).get_localisation()
                    );
            }
            dgv_medicamentRechercher.Update();
        }
        private void b_retraitMedicament_Click(object sender, EventArgs e)
        {
            rechercherAll();
            p_retraitMedicament.Visible = true;
            b_gestionMedicament.Text = "Retrait médicament";
            p_panelDegestionStock.Visible = true;
            dgv_medicamentRechercher.AllowUserToAddRows = false;
            dgv_medicamentRechercher.AllowUserToDeleteRows = false;
            dgv_medicamentRechercher.ReadOnly = true;
            dgv_medicamentRechercher.Update();
            metier.set_bontonChoisi(1);
        }
        private void b_rechecherMedicamentInfo_Click(object sender, EventArgs e)
        {
            rechercherAll();
            p_panelDegestionStock.Visible = false;
            p_retraitMedicament.Visible = true;
            dgv_medicamentRechercher.AllowUserToAddRows = false;
            dgv_medicamentRechercher.AllowUserToDeleteRows = false;
            dgv_medicamentRechercher.ReadOnly = true;
            dgv_medicamentRechercher.Update();
            metier.set_bontonChoisi(3);
        }

        private void cb_allMedicament_CheckedChanged(object sender, EventArgs e)
        {
            rechercherAll();
        }
        private void rechercherAll()
        {
            if (cb_allMedicament.Checked == true)
            {
                dgv_medicamentRechercher.Rows.Clear();
                dgv_medicamentRechercher.Update();
                metier.set_m_medicamentRecherche();
                for (int i = 0; i < metier.get_compteMedicamentRechercher(); i++)
                {
                    dgv_medicamentRechercher.Rows.Add(
                        metier.get_medicamentRechercher(i).get_code(),
                        metier.get_medicamentRechercher(i).get_nom(),
                        metier.get_medicamentRechercher(i).get_type(),
                        metier.get_medicamentRechercher(i).get_typeMesure(),
                        metier.get_medicamentRechercher(i).get_principeActif(),
                        metier.get_medicamentRechercher(i).get_stock(),
                        metier.get_medicamentRechercher(i).get_seuilCritique(),
                        metier.get_medicamentRechercher(i).get_localisation()
                        );

                }
                dgv_medicamentRechercher.Update();
            }
            else
            {
                rechercheMedicament();
            }
        }
        private void b_Deconnection_Click(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            connection.Show();
            this.Hide();
        }
        private void GestionAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
