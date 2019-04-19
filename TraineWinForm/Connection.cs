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
        private IHM ihm;
        public Connection()
        {
            InitializeComponent();
            ihm = new IHM();
        }
        //Methode de connection
        private void b_connection_Click(object sender, EventArgs e)
        {
            if (ihm.get_metier().identification(tb_identifiant.Text, tb_motDePasse.Text))
            {
                if (ihm.get_metier().get_m_utilisateur().get_permission() == 5)
                {
                    GestionAdmin gestion = new GestionAdmin(ihm);
                    gestion.Show();
                }
                else
                {
                    Gestion gestion = new Gestion(ihm);
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
    }
}
