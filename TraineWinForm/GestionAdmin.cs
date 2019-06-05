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
        private Metier metier;
        public GestionAdmin(Metier p_metier)
        {
            metier = p_metier;
            InitializeComponent();
            l_acceuil.Text = ("bonjour " + metier.get_m_utilisateur().get_prenom() + " " + metier.get_m_utilisateur().get_nom());
        }
        //A la selection d'une cellule, sélectionne un médicament et demande le retrait de celui-ci
        private void dgv_medicamentRechercher_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            if (metier.get_boutonChoisi() <= 3)
            {
                if (id >= 0)
                {
                    DataGridViewRow ligne = dgv_medicamentRechercher.Rows[id];
                    l_medicamentChoisi.Text = "Médicament selectionner : " + ligne.Cells[1].Value.ToString() + " en " + ligne.Cells[2].Value.ToString() + ". Combien voulez-vous de " + ligne.Cells[3].Value.ToString() + "?";
                    metier.set_indiceMedicamentChoisi(id);
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
                    l_mErreur.Visible = false;
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
            //l_localisationMedicament.Text = "Le médicament rechercher se trouve ici : " + metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()).get_localisation();
            l_medicamentChoisi.Text = "Veuiller choisir un médicament";
            p_visualisationMedicament.Visible = false;
            nud_choixTailleRetraitMedicament.Visible = false;
            b_gestionMedicament.Visible = false;
            tb_rechercheCodeMedic.Text = "";
            tb_rechercheNomMedic.Text = "";
            tb_rechercheTypeMedic.Text = "";
            tb_recherchePrincipeActifMedic.Text = "";
            if (metier.get_boutonChoisi() == 1)
            {
                metier.retraitStockMedicament(metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()), nud_choixTailleRetraitMedicament.Value);
                //l_localisationMedicament.Visible = true;
            }
            else if (metier.get_boutonChoisi() == 2)
            {
                metier.ajoutStockMedicament(metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()), nud_choixTailleRetraitMedicament.Value);
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
            p_modifierRajouter.Visible = false;
            rechercherAll();
            p_visualisationMedicament.Visible = true;
            b_gestionMedicament.Text = "Retrait médicament";
            p_panelDegestionStock.Visible = true;
            dgv_medicamentRechercher.ClearSelection();
            dgv_medicamentRechercher.Update();
            metier.set_bontonChoisi(1);            
        }
        private void b_reapprovisionnementMedic_Click(object sender, EventArgs e)
        {
            p_modifierRajouter.Visible = false;
            rechercherAll();
            p_visualisationMedicament.Visible = true;
            b_gestionMedicament.Text = "Ajout médicament";
            p_panelDegestionStock.Visible = true;
            dgv_medicamentRechercher.ClearSelection();
            dgv_medicamentRechercher.Update();
            metier.set_bontonChoisi(2);
        }
        private void b_rechecherMedicamentInfo_Click(object sender, EventArgs e)
        {
            p_modifierRajouter.Visible = false;
            rechercherAll();
            p_panelDegestionStock.Visible = false;
            p_visualisationMedicament.Visible = true;
            dgv_medicamentRechercher.ClearSelection();
            dgv_medicamentRechercher.Update();
            metier.set_bontonChoisi(4);
        }

        private void b_modifierRajouterMedic_Click(object sender, EventArgs e)
        {
            rechercherAll();
            p_panelDegestionStock.Visible = false;
            p_visualisationMedicament.Visible = true;
            p_modifierRajouter.Visible = true;
            dgv_medicamentRechercher.ClearSelection();
            dgv_medicamentRechercher.Update();
            metier.set_bontonChoisi(3);
            int idMedicament = 1 + metier.get_m_medicament().Count;
            tb_nCode.Text = idMedicament.ToString();
            foreach(string localisation in metier.get_listLocalisation())
            {
                cob_nLocalisation.Items.Add(localisation.Substring(2));
                cob_mLocalisation.Items.Add(localisation.Substring(2));
            }
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
        private void b_nMedicament_Click(object sender, EventArgs e)
        {
            List<string> nMedicament = new List<string>();
            nMedicament.Add(tb_nCode.Text);
            nMedicament.Add(tb_nNom.Text);
            nMedicament.Add(tb_nType.Text);
            nMedicament.Add(tb_nTypeMesure.Text);
            nMedicament.Add(tb_nPrincipeActif.Text);
            nMedicament.Add(nud_nStock.Text);
            nMedicament.Add(nud_nSeuilCritique.Text);
            nMedicament.Add(cob_nLocalisation.Text);

            foreach(string attribut in nMedicament)
            {
                if(attribut == "")
                {
                    l_nErreur.Text = "Tous les champs ne sont pas remplis";
                    l_nErreur.Visible = true;
                }
                else
                {
                    l_nErreur.Visible = false;
                }
            }
            if(l_nErreur.Visible == false)
            {
                metier.nouveauMedicament(nMedicament);
                int idMedicament = 1 + metier.get_m_medicament().Count;
                tb_nCode.Text = idMedicament.ToString();
                tb_nNom.Text = "";
                tb_nType.Text = "";
                tb_nTypeMesure.Text = "";
                tb_nPrincipeActif.Text = "";
                nud_nStock.Value = 0;
                nud_nSeuilCritique.Value = 0;
                cob_nLocalisation.Text = null;
                rechercherAll();
            }

        }
        private void b_mMedicament_Click(object sender, EventArgs e)
        {
            List<string> mMedicament = new List<string>();
            mMedicament.Add(tb_mCode.Text);
            mMedicament.Add(tb_mNom.Text);
            mMedicament.Add(tb_mType.Text);
            mMedicament.Add(tb_mTypeMesure.Text);
            mMedicament.Add(tb_mPrincipeActif.Text);
            mMedicament.Add(tb_mStock.Text);
            mMedicament.Add(nud_mSeuilCritique.Text);
            mMedicament.Add(cob_mLocalisation.Text);

            foreach (string attribut in mMedicament)
            {
                if (attribut == "")
                {
                    l_mErreur.Text = "Tous les champs ne sont pas remplis";
                    l_mErreur.Visible = true;
                }
                else
                {
                    l_mErreur.Visible = false;
                }
            }
            if (l_mErreur.Visible == false)
            {
                metier.modifierMedicament(mMedicament);
                tb_mCode.Text = "";
                tb_mNom.Text = "";
                tb_mType.Text = "";
                tb_mTypeMesure.Text = "";
                tb_mPrincipeActif.Text = "";
                tb_mStock.Text = "";
                nud_mSeuilCritique.Value = 0;
                cob_mLocalisation.Text = null;
                l_mErreur.Text = "Veuiller coisir un médicament";
                l_mErreur.Visible = true;
                rechercherAll();
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

