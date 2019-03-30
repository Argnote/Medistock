using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineWinForm
{
    public class Utilisateur
    {
        private string nom;
        private string prenom;
        private string fonction;
        private int permission;
        private string identifiant;
        private string motDePasse;

        //constructeurs
        public Utilisateur()
        {
        }

        public Utilisateur(string p_nom, string p_prenom, string p_fonction, int p_permission, string p_identifiant, string p_motDePasse)
        {
            nom = p_nom;
            prenom = p_prenom;
            fonction = p_fonction;
            permission = p_permission;
            identifiant = p_identifiant;
            motDePasse = p_motDePasse;
        }

        //liste des get
        public string get_nom()
        {
            return nom;
        }
        public string get_prenom()
        {
            return prenom;
        }
        public string get_fonction()
        {
            return fonction;
        }
        public int get_permission()
        {
            return permission;
        }

        //liste des set

        //methodes
       /* public void connectionUtilisateur(string p_nom, string p_prenom, string p_fonction, string p_permission, string p_identifiant, string p_motDePasse)
        {
            nom = p_nom;
            prenom = p_prenom;
            fonction = p_fonction;
            permission = p_permission;
            identifiant = p_identifiant;
            motDePasse = p_motDePasse;
        }
        */

    }
}
