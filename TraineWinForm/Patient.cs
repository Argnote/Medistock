using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineWinForm
{
    class Patient
    {
        private string nom;
        private string prenom;
        private string numeroChambre;
        private string numeroDossier;
        private List<Medicament> traitement;

        //Constructeur
        public Patient()
        {

        }
        public Patient(string p_nom, string p_prenom, string p_numeroChambre, string p_numeroDeDossier, List<Medicament> p_traitement)
        {
            nom = p_nom;
            prenom = p_prenom;
            numeroChambre = p_numeroChambre;
            numeroDossier = p_numeroDeDossier;
            traitement = p_traitement;
        }

        //liste des get
        public string get_multiAttribut(string p_attributRechercher)
        {
            switch (p_attributRechercher)
            {
                case "nom":
                    p_attributRechercher = get_nom();
                    break;
                case "prenom":
                    p_attributRechercher = get_prenom();
                    break;
                case "numroChambre":
                    p_attributRechercher = get_numeroChambre();
                    break;
                case "numeroDossier":
                    p_attributRechercher = get_numeroDossier();
                    break;
            }
            return p_attributRechercher;
        }
        public string get_nom()
        {
            return nom;
        }
        public string get_prenom()
        {
            return prenom;
        }
        public string get_numeroChambre()
        {
            return numeroChambre;
        }
        public string get_numeroDossier()
        {
            return numeroDossier;
        }
        public List<Medicament> get_traitement()
        {
            return traitement;
        }
        public Medicament get_traitementPrecis(int p_nList)
        {
            return traitement[p_nList];
        }
    }
}
