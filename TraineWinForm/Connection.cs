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
    public partial class Connection : Form
    {
        private Metier metier;
        public Connection()
        {
            InitializeComponent();
            metier = new Metier();
        }
        //Methode de connection
        private void b_connection_Click(object sender, EventArgs e)
        {
            if (metier.identification(tb_identifiant.Text, tb_motDePasse.Text))
            {
                if (metier.get_m_utilisateur().get_permission() == 5)
                {
                    GestionAdmin gestion = new GestionAdmin(metier);
                    gestion.Show();
                }
                else
                {
                    Gestion gestion = new Gestion(metier);
                    gestion.Show();
                }
                this.Hide();

            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
                tb_identifiant.Text = "";
                tb_motDePasse.Text = "";
            }
        }
        private void GestionAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
