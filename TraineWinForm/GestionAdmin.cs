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
    public partial class GestionAdmin : Form
    {
        private IHM ihm;
        public GestionAdmin(IHM p_ihm)
        {
            ihm = p_ihm;
            InitializeComponent();
            l_acceuil.Text = ("bonjour " + ihm.get_metier().get_m_utilisateur().get_prenom() + " " + ihm.get_metier().get_m_utilisateur().get_nom());
        }
        //A la selection d'une cellule, sélectionne un médicament et demande le retrait de celui-ci
        private void dgv_medicamentRechercher_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            if (ihm.get_metier().get_boutonChoisi() <= 3)
            {
                if (id >= 0)
                {
                    DataGridViewRow ligne = dgv_medicamentRechercher.Rows[id];
                    l_medicamentChoisi.Text = "Médicament selectionner : " + ligne.Cells[1].Value.ToString() + " en " + ligne.Cells[2].Value.ToString() + ". Combien voulez-vous de " + ligne.Cells[3].Value.ToString() + "?";
                    ihm.get_metier().set_indiceMedicamentChoisi(id);
                    nud_choixTailleRetraitMedicament.Visible = true;
                    b_gestionMedicament.Visible = true;
                    tb_mCode.Text = ligne.Cells[0].Value.ToString();
                    tb_mNom.Text = ligne.Cells[1].Value.ToString();
                    tb_mType.Text = ligne.Cells[2].Value.ToString();
                    tb_mTypeMesure.Text = ligne.Cells[3].Value.ToString();
                    tb_mPrincipeActif.Text = ligne.Cells[4].Value.ToString();
                    tb_mStock.Text = ligne.Cells[5].Value.ToString();
                    nud_mSeuilCritique.Value = Int32.Parse(ligne.Cells[6].Value.ToString());
                    cob_mLocalisation.Text = ligne.Cells[7].Value.ToString();
                    l_choixModification.Visible = false;
                }
                else
                {
                    l_medicamentChoisi.Text = "Veuiller choisir un médicament";
                    nud_choixTailleRetraitMedicament.Visible = false;
                    b_gestionMedicament.Visible = false;
                }
            }
        }
        //au click du bouton de retrait d'un médicament, affiche sa localisation et met a jour le stock
        private void b_gestionMedicament_Click(object sender, EventArgs e)
        {
            //l_localisationMedicament.Text = "Le médicament rechercher se trouve ici : " + ihm.get_metier().get_medicamentRechercher(ihm.get_metier().get_indiceMedicamentChoisi()).get_localisation();
            l_medicamentChoisi.Text = "Veuiller choisir un médicament";
            p_retraitMedicament.Visible = false;
            nud_choixTailleRetraitMedicament.Visible = false;
            b_gestionMedicament.Visible = false;
            tb_rechercheCodeMedic.Text = "";
            tb_rechercheNomMedic.Text = "";
            tb_rechercheTypeMedic.Text = "";
            tb_recherchePrincipeActifMedic.Text = "";
            if (ihm.get_metier().get_boutonChoisi() == 1)
            {
                ihm.get_metier().retraitStockMedicament(ihm.get_metier().get_medicamentRechercher(ihm.get_metier().get_indiceMedicamentChoisi()), nud_choixTailleRetraitMedicament.Value);
                //l_localisationMedicament.Visible = true;
            }
            else if (ihm.get_metier().get_boutonChoisi() == 2)
            {
                ihm.get_metier().ajoutStockMedicament(ihm.get_metier().get_medicamentRechercher(ihm.get_metier().get_indiceMedicamentChoisi()), nud_choixTailleRetraitMedicament.Value);
            }
            nud_choixTailleRetraitMedicament.Value = 0;
        }
        //Affiche les médicament contenue dans la liste de médicament correspondant au filtre
        private void rechercheMedicament()
        {
            dgv_medicamentRechercher.Rows.Clear();
            dgv_medicamentRechercher.Update();
            ihm.get_metier().filtreMedicament(tb_rechercheCodeMedic.Text, tb_rechercheNomMedic.Text, tb_rechercheTypeMedic.Text, tb_recherchePrincipeActifMedic.Text);
            for (int i = 0; i < ihm.get_metier().get_compteMedicamentRechercher(); i++)
            {
                dgv_medicamentRechercher.Rows.Add(
                    ihm.get_metier().get_medicamentRechercher(i).get_code(),
                    ihm.get_metier().get_medicamentRechercher(i).get_nom(),
                    ihm.get_metier().get_medicamentRechercher(i).get_type(),
                    ihm.get_metier().get_medicamentRechercher(i).get_typeMesure(),
                    ihm.get_metier().get_medicamentRechercher(i).get_principeActif(),
                    ihm.get_metier().get_medicamentRechercher(i).get_stock(),
                    ihm.get_metier().get_medicamentRechercher(i).get_seuilCritique(),
                    ihm.get_metier().get_medicamentRechercher(i).get_localisation()
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
            p_modifierRajouter.Visible = false;
            dgv_medicamentRechercher.Update();
            ihm.get_metier().set_bontonChoisi(1);
        }
        private void b_reapprovisionnementMedic_Click(object sender, EventArgs e)
        {
            rechercherAll();
            p_retraitMedicament.Visible = true;
            b_gestionMedicament.Text = "Ajout médicament";
            p_panelDegestionStock.Visible = true;
            p_modifierRajouter.Visible = false;
            dgv_medicamentRechercher.Update();
            ihm.get_metier().set_bontonChoisi(2);
        }
        private void b_rechecherMedicamentInfo_Click(object sender, EventArgs e)
        {
            rechercherAll();
            p_panelDegestionStock.Visible = false;
            p_retraitMedicament.Visible = true;
            p_modifierRajouter.Visible = false;
            dgv_medicamentRechercher.Update();
            ihm.get_metier().set_bontonChoisi(4);
        }

        private void b_modifierRajouterMedic_Click(object sender, EventArgs e)
        {
            rechercherAll();
            p_panelDegestionStock.Visible = false;
            p_retraitMedicament.Visible = true;
            p_modifierRajouter.Visible = true;
            dgv_medicamentRechercher.Update();
            ihm.get_metier().set_bontonChoisi(3);
            int idMedicament = 1 + ihm.get_metier().get_m_medicament().Count;
            tb_nCode.Text = idMedicament.ToString();
            foreach(string localisation in ihm.get_metier().get_listLocalisation())
            {
                cob_nLocalisation.Items.Add(localisation);
                cob_mLocalisation.Items.Add(localisation);
            }
        }

        private void cb_medicamentMasqué_CheckedChanged(object sender, EventArgs e)
        {
            rechercherAll();
        }
        private void rechercherAll()
        {
            if (cb_allMedicament.Checked == true)
            {
                dgv_medicamentRechercher.Rows.Clear();
                dgv_medicamentRechercher.Update();
                ihm.get_metier().set_m_medicamentRecherche();
                for (int i = 0; i < ihm.get_metier().get_compteMedicamentRechercher(); i++)
                {
                    dgv_medicamentRechercher.Rows.Add(
                        ihm.get_metier().get_medicamentRechercher(i).get_code(),
                        ihm.get_metier().get_medicamentRechercher(i).get_nom(),
                        ihm.get_metier().get_medicamentRechercher(i).get_type(),
                        ihm.get_metier().get_medicamentRechercher(i).get_typeMesure(),
                        ihm.get_metier().get_medicamentRechercher(i).get_principeActif(),
                        ihm.get_metier().get_medicamentRechercher(i).get_stock(),
                        ihm.get_metier().get_medicamentRechercher(i).get_seuilCritique(),
                        ihm.get_metier().get_medicamentRechercher(i).get_localisation()
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

