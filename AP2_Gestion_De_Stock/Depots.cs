using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace AP2_Gestion_De_Stock
{
    public partial class Depots : Form
    {
        public Depots()
        {
            InitializeComponent();
        }

        private void Depots_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();

            if (ouvert)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("NumeroDepot", "Numéro");
                dataGridView1.Columns.Add("Nom", "Nom");
                dataGridView1.Columns.Add("Ville", "Ville");
                dataGridView1.Columns.Add("Pays", "Pays");
                dataGridView1.Columns.Add("Latitude", "Latitude");
                dataGridView1.Columns.Add("Longitude", "Longitude");

                ChargerDepots();
                RemplirComboBoxPays();
            }
            else
            {
                MessageBox.Show("Aucun accès à la base de données.");
            }
        }

        private void RemplirComboBoxPays()
        {
            List<Depot> depots = Bdd.GetDepots();
            if (depots == null)
            {
                MessageBox.Show("Erreur lors du chargement des pays.");
                return;
            }

            cBoxRechercheDepotPays.Items.Clear();
            cBoxRechercheDepotPays.Items.Add("*");

            foreach (string pays in depots.Select(d => d.Pays).Distinct())
            {
                cBoxRechercheDepotPays.Items.Add(pays);
            }

            cBoxRechercheDepotPays.SelectedIndex = 0; 
        }


        private void ChargerDepots()
        {
            List<Depot> depots = Bdd.GetDepots();

            if (depots == null)
            {
                MessageBox.Show("Erreur lors de la récupération des dépôts.");
                return;
            }

            dataGridView1.Rows.Clear();

            foreach (Depot depot in depots.OrderBy(d => d.Nom))
            {
                dataGridView1.Rows.Add(
                    depot.NumeroDepot, depot.Nom, depot.Ville,
                    depot.Pays, depot.Latitude, depot.Longitude
                );
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nom = txtBoxNomDepot.Text;

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Veuillez entrer le nom du dépôt à supprimer.");
                return;
            }

            bool success = Bdd.supprimerDepot(nom);

            if (success)
            {
                MessageBox.Show("Dépôt supprimé avec succès.");
                EffacerChamps();
            }
            else
            {
                MessageBox.Show("Échec de la suppression. Vérifiez que le dépôt existe.");
            }
            ChargerDepots();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxNumDepot.Text, out int numero))
            {
                MessageBox.Show("Numéro de dépôt invalide.");
                return;
            }

            string nom = txtBoxNomDepot.Text;
            string ville = txtBoxVille.Text;
            string pays = txtBoxPays.Text;
            if (!float.TryParse(txtBoxLatitude.Text, out float lat) ||
                !float.TryParse(txtBoxLongitude.Text, out float lon))
            {
                MessageBox.Show("Coordonnées invalides.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(ville) || string.IsNullOrWhiteSpace(pays))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            List<Depot> depots = Bdd.GetDepots();
            if (depots == null)
            {
                MessageBox.Show("Erreur lors de la récupération des dépôts.");
                return;
            }

            Depot existant = depots.FirstOrDefault(d => d.Nom == nom);
            if (existant != null)
            {
                if (Bdd.mettreAJourDepot(existant, numero, nom, ville, pays, lat, lon))
                {
                    MessageBox.Show("Dépôt mis à jour avec succès.");
                    ChargerDepots();
                    EffacerChamps();
                }
                else
                {
                    MessageBox.Show("Échec de la mise à jour du dépôt.");
                }
            }
            else
            {
                Depot nouveau = new Depot(numero, nom, ville, pays, lat, lon);
                if (Bdd.ajouterDepot(nouveau))
                {
                    MessageBox.Show("Dépôt ajouté avec succès.");
                    ChargerDepots();
                    EffacerChamps();
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout du dépôt.");
                }
            }
            
        }

        private void EffacerChamps()
        {
            txtBoxNumDepot.Clear();
            txtBoxNomDepot.Clear();
            txtBoxVille.Clear();
            txtBoxPays.Clear();
            txtBoxLatitude.Clear();
            txtBoxLongitude.Clear();
        }

        private void cBoxRechercheDepotPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paysSelectionne = cBoxRechercheDepotPays.SelectedItem.ToString();

            if (paysSelectionne == "*")
            {
                ChargerDepots();
            }
            else
            {
                List<Depot> depots = Bdd.GetDepotsSelonPays(paysSelectionne);

                if (depots == null)
                {
                    MessageBox.Show("Erreur lors de la récupération des dépôts pour ce pays.");
                    return;
                }

                dataGridView1.Rows.Clear();

                foreach (Depot depot in depots.OrderBy(d => d.Nom))
                {
                    dataGridView1.Rows.Add(
                        depot.NumeroDepot, depot.Nom, depot.Ville,
                        depot.Pays, depot.Latitude, depot.Longitude
                    );
                }
            }
        }
    }
}
