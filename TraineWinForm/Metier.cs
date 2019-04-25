﻿using System;
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
        private List<string> listLocalisation;
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
        public List<string> get_listLocalisation()
        {
            return listLocalisation;
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
                string[] split = message.Split('/');
                listLocalisation = new List<string>();
                for (int i = 1; i < split.Length; i++)
                {
                    string[] splitlocalisation = split[i].Split(',');
                    listLocalisation.Add(splitlocalisation[0] +" "+splitlocalisation[1] + splitlocalisation[2] + " / " + splitlocalisation[3]);  
                }
                string[] splitmessage = split[0].Split('*');
                string[] splitUtilisateur = splitmessage[0].Split(';');
                m_utilisateur = new Utilisateur(Int32.Parse(splitUtilisateur[0]), splitUtilisateur[1], splitUtilisateur[2], splitUtilisateur[3], Int32.Parse(splitUtilisateur[4]), splitUtilisateur[5], splitUtilisateur[6]);
                for(int i = 1; i < splitmessage.Length; i++)
                {
                    string[] splitmedicament = splitmessage[i].Split(',');
                    string localisationMedicament = splitmedicament[7] + splitmedicament[8] + " / " + splitmedicament[9];
                    int stock = Int32.Parse(splitmedicament[5]);
                    for (int j = 10; j < splitmedicament.Length; j ++)
                    {
                        string[] splitAction = splitmedicament[j].Split('ù');
                        if(splitAction[0] == "retrait")
                        {
                            stock = stock - Int32.Parse(splitAction[1]);
                        }
                        else
                        {
                            stock = stock + Int32.Parse(splitAction[1]);
                        }
                    }
                    m_medicament.Add(new Medicament(splitmedicament[0], splitmedicament[1], splitmedicament[2], splitmedicament[3], splitmedicament[4], localisationMedicament, stock, Int32.Parse(splitmedicament[6])));
                }
                //DAO();
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
            string date = System.DateTime.Now.ToShortDateString();
            date = date.Replace("/", "-");
            date = date.Substring(6, 4) + date.Substring(2, 4) + date.Substring(0, 2) + ' ' + System.DateTime.Now.ToLongTimeString();
            int intRetraitEffectuer = Decimal.ToInt32(p_retraitEffectuer);
            for (int i = 0; i < m_medicament.Count; i++)
            {
                if(p_medicament == m_medicament[i])
                {
                    m_medicament[i].set_stock(m_medicament[i].get_stock() - intRetraitEffectuer);
                    //string maj = "2'" + m_utilisateur.get_Id() + "','"+ m_medicament[i].get_code() + "','" + date + "','retrait','" + intRetraitEffectuer + "'";
                    string maj = "2" + m_utilisateur.get_Id() + "," + m_medicament[i].get_code() + "," + date + ",retrait," + intRetraitEffectuer;
                    Client client = new Client(maj);
                }
            }

        }

        //mise a jour du stock suite d'un médicament a un ajout 
        public void ajoutStockMedicament(Medicament p_medicament, decimal p_retraitEffectuer)
        {
            string date = System.DateTime.Now.ToShortDateString();
            date = date.Replace("/", "-");
            date = date.Substring(6, 4) + date.Substring(2, 4) + date.Substring(0, 2) + ' ' + System.DateTime.Now.ToLongTimeString();
            int intRetraitEffectuer = Decimal.ToInt32(p_retraitEffectuer);
            for (int i = 0; i < m_medicament.Count; i++)
            {
                if (p_medicament == m_medicament[i])
                {
                    m_medicament[i].set_stock(m_medicament[i].get_stock() + intRetraitEffectuer);
                    string maj = "2" + m_utilisateur.get_Id() + "," + m_medicament[i].get_code() + "," + date + ",ajout," + intRetraitEffectuer;
                    Client client = new Client(maj);
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
        public void nouveauMedicament(List<string> nouveauMedicament)
        {
            int idLoc = 1;
            m_medicament.Add(new Medicament(nouveauMedicament[0], nouveauMedicament[1], nouveauMedicament[2], nouveauMedicament[3], nouveauMedicament[4], nouveauMedicament[7], Int32.Parse(nouveauMedicament[5]), Int32.Parse(nouveauMedicament[6])));
            foreach(string localisation in listLocalisation)
            {
                if(nouveauMedicament[7] == localisation)
                {
                    idLoc = localisation[0];
                }
            }
            string maj = "3" + nouveauMedicament[0] +"," + nouveauMedicament[1] + "," + nouveauMedicament[2] + "," + nouveauMedicament[3] + "," + nouveauMedicament[4] + "," + nouveauMedicament[5] + "," + nouveauMedicament[6] + "," + idLoc;
            Client client = new Client(maj);
        }
    }
}

