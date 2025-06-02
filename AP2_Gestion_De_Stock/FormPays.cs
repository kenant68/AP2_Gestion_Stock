using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_Gestion_De_Stock
{
    public partial class FormPays : Form
    {
        public FormPays()
        {
            InitializeComponent();
        }

        private void Pays_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Id", "Nom");
                dataGridView1.Columns.Add("taux", "Taux de taxes");
                ChargerPays();
            }
            else
            {
                MessageBox.Show("Aucun accès à la base de données.");
            }
        }

        private void ChargerPays()
        {
            List<BLL.Pays> pays = Bdd.GetPays();

            if (pays == null)
            {
                MessageBox.Show("Erreur lors de la récupération des pays.");
                return;
            }

            dataGridView1.Rows.Clear();
            pays = pays.OrderBy(p => p.IdPays).ToList();

            foreach (BLL.Pays p in pays)
            {
                dataGridView1.Rows.Add(p.IdPays, p.taux);
            }
        }



        //boutons



        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string id = txtBoxNomPays.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Veuillez entrer le nom du pays à supprimer.");
                return;
            }

            bool success = Bdd.supprimerPays(id);

            if (success)
            {
                MessageBox.Show("Pays supprimé avec succès.");
                txtBoxNomPays.Clear();
            }
            else
            {
                MessageBox.Show("Échec de la suppression. Vérifiez que le pays existe ou réessayez plus tard.");
            }
            ChargerPays();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string idPays = txtBoxNomPays.Text.Trim();
            string tauxText = txtBoxTaux.Text.Trim();

            if (string.IsNullOrWhiteSpace(idPays) || string.IsNullOrWhiteSpace(tauxText))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;            }

            if (!float.TryParse(tauxText, out float taux))
            {
                MessageBox.Show("Le taux doit être un nombre valide.");
                return;
            }

            List<Pays> paysList = Bdd.GetPays();

            if (paysList == null)
            {
                MessageBox.Show("Erreur lors de la récupération des pays.");
                return;
            }

            Pays existing = paysList.FirstOrDefault(p => p.IdPays == idPays);

            if (existing != null)
            {
                existing.taux = taux;
                Bdd.mettreAJourPays(existing);
                ChargerPays();
                MessageBox.Show("Pays mis à jour avec succès.");
            }
            else
            {
                Pays nouveau = new Pays(idPays, taux);
                Bdd.ajouterPays(nouveau);
                MessageBox.Show("Pays enregistré avec succès.");
            }

            txtBoxTaux.Clear();
            txtBoxNomPays.Clear();
            ChargerPays();
        }


    }
}

