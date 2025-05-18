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
    public partial class Fabricants : Form
    {
        public Fabricants()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("IdFabricant", "ID");
                dataGridView1.Columns.Add("NomEntreprise", "Entreprise");
                dataGridView1.Columns.Add("Marque", "Marque");
                ChargerFabricants();
            }
            else
            {
                MessageBox.Show("Aucun accès à la base de données.");
            }
        }

        private void ChargerFabricants()
        {
            List<Fabricant> fabricants = Bdd.GetFabricants();

            if (fabricants == null)
            {
                MessageBox.Show("Erreur lors de la récupération des fabricants.");
                return;
            }

            dataGridView1.Rows.Clear();
            fabricants = fabricants.OrderBy(f => f.NomEntreprise).ToList();

            foreach (Fabricant fab in fabricants)
            {
                dataGridView1.Rows.Add(fab.IdFabricant, fab.NomEntreprise, fab.Marque);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string marque = txtBoxMarque.Text;

            if (string.IsNullOrWhiteSpace(marque))
            {
                MessageBox.Show("Veuillez entrer la marque du fabricant à supprimer.");
                return;
            }

            bool success = Bdd.supprimerFabricant(marque);

            if (success)
            {
                MessageBox.Show("Fabricant supprimé avec succès.");
                txtBoxMarque.Clear();
                txtBoxEntreprise.Clear();
                txtBoxIdFabricant.Clear();
            }
            else
            {
                MessageBox.Show("Échec de la suppression. Vérifiez que le fabricant existe ou réessayez plus tard.");
            }
            ChargerFabricants();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string id = txtBoxIdFabricant.Text;
            string entreprise = txtBoxEntreprise.Text;
            string marque = txtBoxMarque.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(entreprise) || string.IsNullOrWhiteSpace(marque))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            List<Fabricant> fabricants = Bdd.GetFabricants();

            if (fabricants == null)
            {
                MessageBox.Show("Erreur lors de la récupération des fabricants.");
                return;
            }

            Fabricant existing = fabricants.FirstOrDefault(f => f.Marque == marque);

            if (existing != null)
            {
                existing.NomEntreprise = entreprise;
                Bdd.mettreAJourFabricant(existing, id, entreprise, marque);
                MessageBox.Show("Fabricant mis à jour avec succès.");
            }
            else
            {
                Fabricant nouveau = new Fabricant(id, entreprise, marque);
                Bdd.ajouterFabricant(nouveau);
                MessageBox.Show("Fabricant enregistré avec succès.");
            }

            txtBoxMarque.Clear();
            txtBoxEntreprise.Clear();
            txtBoxIdFabricant.Clear();
            ChargerFabricants();
        }

    }
}
