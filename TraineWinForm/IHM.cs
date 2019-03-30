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
    public partial class IHM : Form
    {
        private Metier metier;
        public IHM()
        {
            InitializeComponent();
            metier = new Metier();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Methode de connection
        private void b_connection_Click(object sender, EventArgs e)
        {
            if(metier.identification(tb_identifiant.Text,tb_motDePasse.Text))
            {
                p_connection.Visible = false;
                MessageBox.Show("bonjour " + metier.get_m_utilisateur().get_prenom() + " " + metier.get_m_utilisateur().get_nom());
                p_rechercheRetraitMedicament.Size = new Size(388, 210);
                p_rechercheRetraitMedicament.Visible = true;
                if(metier.get_m_utilisateur().get_permission() == 5)
                {
                    p_rechercheRetraitMedicament.Size = new Size(388, 297);
                    dgv_medicamentRechercher.Size = new Size(742, 162);
                    p_retraitMedicament.Size = new Size(869, 210);          
                    b_rechecherMedicamentInfo.Visible = true;
                    b_rechercheReapprovisionnementMedic.Visible = true;
                    b_modifierRajouterMedic.Visible = true;
                    seuilCritique.Visible = true;
                    localisation.Visible = true;
                }
            }
            else 
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
                tb_identifiant.Text = "";
                tb_motDePasse.Text = "";
            }
        }
        //A la selection d'une cellule, sélectionne un médicament et demande le retrait de celui-ci
        private void dgv_medicamentRechercher_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = e.RowIndex;
            if(metier.get_boutonChoisi() == 1 || metier.get_boutonChoisi() == 2)
            {
                if (id >= 0)
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
        //au click du bouton de retrait d'un médicament, affiche sa localisation et met a jour le stock
        private void b_gestionMedicament_Click(object sender, EventArgs e)
        {
            l_localisationMedicament.Text = "Le médicament rechercher se trouve ici : " + metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()).get_localisation();
            l_medicamentChoisi.Text = "Veuiller choisir un médicament";
            p_retraitMedicament.Visible = false;
            nud_choixTailleRetraitMedicament.Visible = false;
            b_gestionMedicament.Visible = false;
            tb_rechercheCodeMedic.Text = "";
            tb_rechercheNomMedic.Text = "";
            tb_rechercheTypeMedic.Text = "";
            tb_recherchePrincipeActifMedic.Text = "";
            if(metier.get_boutonChoisi() == 1)
            {
                metier.retraitStockMedicament(metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()), nud_choixTailleRetraitMedicament.Value);
                l_localisationMedicament.Visible = true;
            }
            else if (metier.get_boutonChoisi() == 2)
            {
                metier.ajoutStockMedicament(metier.get_medicamentRechercher(metier.get_indiceMedicamentChoisi()), nud_choixTailleRetraitMedicament.Value);
            }
            else
            {
                
            }

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
            rechercheMedicament();
            p_retraitMedicament.Visible = true;
            b_gestionMedicament.Text = "Retrait médicament";
            p_panelDegestionStock.Visible = true;
            metier.set_bontonChoisi(1);
        }
        private void b_reapprovisionnementMedic_Click(object sender, EventArgs e)
        {
            rechercheMedicament();
            p_retraitMedicament.Visible = true;
            b_gestionMedicament.Text = "Ajout médicament";
            p_panelDegestionStock.Visible = true;
            metier.set_bontonChoisi(2);
        }
        private void b_rechecherMedicamentInfo_Click(object sender, EventArgs e)
        {
            rechercheMedicament();
            p_panelDegestionStock.Visible = false;
            p_retraitMedicament.Visible = true;           
        }

        private void b_modifierRajouterMedic_Click(object sender, EventArgs e)
        {
            rechercheMedicament();
            dgv_medicamentRechercher.AllowUserToAddRows = true;
            dgv_medicamentRechercher.AllowUserToDeleteRows = true;
            dgv_medicamentRechercher.ReadOnly = false;
            dgv_medicamentRechercher.Update();
            p_retraitMedicament.Visible = true;
            //metier.set_bontonChoisi(3);
        }
    }
}
