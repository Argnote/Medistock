using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineWinForm
{
    public class Medicament
    {
        private string code;
        private string nom;
        private string type;
        private string principeActif;
        private string localisation;
        private int stock;
        private int seuilCritique;
        private string typeMesure;

        //constructeurs
        public Medicament()
        {
        }

        public Medicament(string p_code, string p_nom, string p_type, string p_typeMesure, string p_principeActif, string p_localisation, int p_stock, int p_seuilCritique)
        {
            code = p_code;
            nom = p_nom;
            type = p_type;
            typeMesure = p_typeMesure;
            principeActif = p_principeActif;
            localisation = p_localisation;
            stock = p_stock;
            seuilCritique = p_seuilCritique;
        }

        //liste des get
        public string get_multiAttribut(string p_attributRechercher)
        {
            switch (p_attributRechercher)
            {
                case "code":
                    p_attributRechercher = get_code();
                    break;
                case "nom":
                    p_attributRechercher = get_nom();
                    break;
                case "type":
                    p_attributRechercher = get_type();
                    break;
                case "principeActif":
                    p_attributRechercher = get_principeActif();
                    break;
            }
            return p_attributRechercher;
        }
        //Liste des get
        public string get_typeMesure()
        {
            return typeMesure;
        }
        public string get_code()
        {
            return code;
        }

        public string get_nom()
        {
            return nom;
        }

        public string get_type()
        {
            return type;
        }

        public string get_principeActif()
        {
            return principeActif;
        }

        public string get_localisation()
        {
            return localisation;
        }

        public int get_stock()
        {
            return stock;
        }

        public int get_seuilCritique()
        {
            return seuilCritique;
        }
        //Liste de set
        public void set_stock(int p_stock)
        {
            stock = p_stock;
        }
    }
}
