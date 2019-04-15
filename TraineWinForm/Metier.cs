using System;
using System.Text;
using System.Collections.Generic;

namespace TraineWinForm
{
    public class Metier
    {
        private List<Medicament> nouveauStock;
        private int indiceMedicamentChoisi;
        private List<Medicament> m_medicament;
        private List<Medicament> m_medicamentRecherche;
        //patient pour plus tard private List<Patient> m_patient;
        private Utilisateur m_utilisateur;
        private bool connection;
        private bool controleCreationListRecherche;
        private int boutonChoisi;
        private bool etatModificationStock;
        //constructeur
        public Metier()
        { 
            connection = false;
            m_medicament = new List<Medicament>();
            nouveauStock = new List<Medicament>();
            //patient pour plus tard m_patient = new List<Patient>();
        }

        //liste des get
        //liste de tout les médicaments
        public List<Medicament> get_m_medicament()
        {
            return m_medicament;
        }
        public Medicament get_m_medicament(int p_nList)
        {
            return m_medicament[p_nList];
        }
        //liste de tout les médicament rechercher
        public List<Medicament> get_medicamentRechercher()
        {
            return m_medicamentRecherche;
        }
        //retourne un médicament dans la liste des médicaments rechercher
        public Medicament get_medicamentRechercher(int p_nList)
        {
            return m_medicamentRecherche[p_nList];
        }
        public int get_compteMedicamentRechercher()
        {
            return m_medicamentRecherche.Count;
        }
        public Utilisateur get_m_utilisateur()
        {
            return m_utilisateur;
        }
        public bool get_connection()
        {
            return connection;
        }
        public int get_indiceMedicamentChoisi()
        {
            return indiceMedicamentChoisi;
        }
        public int get_boutonChoisi()
        {
            return boutonChoisi;
        }
        public bool get_etatModificationStock()
        {
            return etatModificationStock;
        }
        //liste des set
        public void set_indiceMedicamentChoisi(int p_indiceMedicamentChoisi)
        {
            indiceMedicamentChoisi = p_indiceMedicamentChoisi;
        }
        public void set_bontonChoisi(int p_bontonChoisi)
        {
            boutonChoisi = p_bontonChoisi;
        }
        public void set_m_medicamentRecherche()
        {
            m_medicamentRecherche = m_medicament;
        }
        public void set_etatModificationStock(bool p_etatModificationStock)
        {
            etatModificationStock = p_etatModificationStock;
        }
        //methode
        public bool identification(string p_identifiant, string p_motDePasse)
        {
            string demande = '1' + p_identifiant + ';' + p_motDePasse;
            Client client = new Client(demande);
            string message = client.getMessage();
            if(message != "faux" && message != null)
            {
                string[] split = message.Split(';');
                m_utilisateur = new Utilisateur(split[0], split[1], split[2], Int32.Parse(split[3]), split[4], split[5]);
                DAO();
                connection = true;
            }
            return connection;
        }
        /*
            //permet d'éffectuer un filtrage en fonction de n'importe quel choix de l'utilisateur(concernant les patients)
            private void rechercheGlobalParPatient(string p_filtreParPatient, string p_attributFiltre)
            {
                //si le filtre est rempli
                if (p_filtreParPatient != "")
                {
                    //si la liste de medicament n'a pas été rempli une premiere foi 
                    if (controleCreationListRecherche == false)
                    {
                        for (int i = 0; i < m_medicament.Count; i++)
                        {
                            if (p_filtreParPatient == m_patient[i].get_multiAttribut(p_attributFiltre))
                            {
                                //on ajoute un médicament dans la liste des médicaments rechercher 
                                m_medicamentRecherche = m_patient[i].get_traitement();
                            }
                        }
                        controleCreationListRecherche = true;
                    }
                    else
                    {
                        for (int i = 0; i < m_medicamentRecherche.Count; i++)
                        {
                            if (p_filtreParPatient != m_patient[i].get_multiAttribut(p_attributFiltre))
                            {
                                //on retire un médicamanet dans la liste des médicaments rechercher
                                m_medicamentRecherche.Remove(m_medicamentRecherche[i]);
                            }
                        }
                    }
                }
            }
        */

        //utilise la méthode RechercheGlobal(parametre) pour chaques champs possible
        public void filtreMedicament(string p_codeMedicament, string p_nomMedicament, string p_typeMedicament, string p_principeActif)
        {
            m_medicamentRecherche = null;
            m_medicamentRecherche = new List<Medicament>();
            controleCreationListRecherche = false;
            RechercheGlobal(p_codeMedicament, "code");
            RechercheGlobal(p_nomMedicament, "nom");
            RechercheGlobal(p_typeMedicament, "type");
            RechercheGlobal(p_principeActif, "principeActif");
        }
        //permet d'éffectuer un filtrage en fonction de n'importe quel choix de l'utilisateur(concernant les médicament)
        private void RechercheGlobal(string p_filtreEntre,string p_attributFiltre)
        {
            //si le filtre est rempli
            if(p_filtreEntre != "")
            {
                //si la liste de medicament n'a pas été rempli une premiere foi 
                if (controleCreationListRecherche == false)
                {
                    for (int i = 0; i < m_medicament.Count; i++)
                    {
                        if (p_filtreEntre == m_medicament[i].get_multiAttribut(p_attributFiltre))
                        {
                            //on ajoute un médicament dans la liste des médicaments rechercher 
                            m_medicamentRecherche.Add(m_medicament[i]);
                        }
                    }
                    controleCreationListRecherche = true;
                }
                //Sinon affine le résultat de la liste des médicamanets rechercher
                else
                {
                    for (int i = 0; i < m_medicamentRecherche.Count; i++)
                    {
                        if (p_filtreEntre != m_medicament[i].get_multiAttribut(p_attributFiltre))
                        {
                            //on retire un médicamanet dans la liste des médicaments rechercher
                            m_medicamentRecherche.Remove(m_medicamentRecherche[i]);
                        }
                    }
                }
            }
        }

        //mise a jour du stock d'un médicament suite à un retrait
        public void retraitStockMedicament(Medicament p_medicament, decimal p_retraitEffectuer)
        {
            int intRetraitEffectuer = Decimal.ToInt32(p_retraitEffectuer);
            for (int i = 0; i < m_medicament.Count; i++)
            {
                if(p_medicament == m_medicament[i])
                {
                    m_medicament[i].set_stock(m_medicament[i].get_stock() - intRetraitEffectuer);
                }
            }

        }

        //mise a jour du stock suite d'un médicament a un ajout 
        public void ajoutStockMedicament(Medicament p_medicament, decimal p_retraitEffectuer)
        {
            int intRetraitEffectuer = Decimal.ToInt32(p_retraitEffectuer);
            for (int i = 0; i < m_medicament.Count; i++)
            {
                if (p_medicament == m_medicament[i])
                {
                    m_medicament[i].set_stock(m_medicament[i].get_stock() + intRetraitEffectuer);
                }
            }
        }
        //pour la mise a jour entiere du stock 
        /*private void initNouveauStock(string p_code,string p_nom,string p_type, string p_principeActif,string p_localisation, string p_stock, string p_seuilCritique, string p_typeMesure)
        {
            int stock = int.Parse(p_stock);
            int intRetraitEffectuer = int.Parse(p_seuilCritique);
            Medicament compareMedic = new Medicament(p_code,p_nom,p_type,p_principeActif,p);
            if
        }*/
        public void modificationEntierStock(string p_code, string p_nom, string p_type, string p_typeMesure, string p_principeActif, int p_stock, int p_seuilCritique, string p_localisation, int p_i)
        {
            if(etatModificationStock)
            {
                m_medicament.Add(new Medicament(p_code, p_nom, p_type, p_typeMesure, p_principeActif, p_localisation, p_stock, p_seuilCritique));
            }   
            else
            {
                if(p_i==0)
                {
                    m_medicament.Clear();
                }               
                m_medicament.Add(new Medicament(p_code, p_nom, p_type, p_typeMesure, p_principeActif, p_localisation, p_stock, p_seuilCritique));
            }
        
        }
        //methode de test de médicament et patient
        public void DAO()
        {
            m_medicament.Add(new Medicament("1", "ibuprophene", "gélulle", "Unité", "prf", "24A", 56, 16));
            m_medicament.Add(new Medicament("2", "eféralgan", "spray", "Flacon", "tty", "24A", 44, 16));
            m_medicament.Add(new Medicament("3", "sirop", "liquide", "Centilitre", "prf", "56T", 34, 4));
            m_medicament.Add(new Medicament("1", "ibuprophene", "spray", "Flacon", "prf", "24A", 56, 16));
        /* patient pour plus tard
            List<Medicament> traitement1 = new List<Medicament>();
            traitement1.Add(m_medicament[0]);
            traitement1.Add(m_medicament[1]);
            List<Medicament> traitement2 = new List<Medicament>();
            traitement2.Add(m_medicament[2]);
            traitement2.Add(m_medicament[3]);
            m_patient.Add(new Patient("AX", "Maxime", "65T", "xpty", traitement1));
            m_patient.Add(new Patient("TY", "Richard", "240b", "dfre", traitement2));
            m_patient.Add(new Patient("TY", "Luna", "240b", "hyji", traitement1));
            m_patient.Add(new Patient("OP", "Amina", "87J", "juyy", traitement2));
        */
        }
        //fin test
    }
}

