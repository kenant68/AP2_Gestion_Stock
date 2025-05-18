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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("CodeCategorie", "Code");
                dataGridView1.Columns.Add("Libelle", "Libelle");
                ChargerCategories();

            }
            else
            {
                MessageBox.Show("Aucun accès à la base de données.");
            }
        }


        private void ChargerCategories()
        {
            List<Categorie> categories = Bdd.GetCategories();

            if (categories == null)
            {
                MessageBox.Show("Erreur lors de la récupération des catégories.");
                return;
            }

            // Vider la grille avant de la remplir
            dataGridView1.Rows.Clear();

            // Trier par libellé 
            categories = categories.OrderBy(c => c.Libelle).ToList();

            // Ajouter chaque ligne
            foreach (Categorie cat in categories)
            {
                dataGridView1.Rows.Add(cat.CodeCategorie, cat.Libelle);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nom = txtBoxNomCatégorie.Text;

            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Veuillez entrer le nom de la catégorie à supprimer.");
                return;
            }

            bool success = Bdd.supprimerCategorie(nom);

            if (success)
            {
                MessageBox.Show("Catégorie supprimée avec succès.");
                txtBoxNomCatégorie.Clear();
                txtBoxCodeCatégorie.Clear();
            }
            else
            {
                MessageBox.Show("Échec de la suppression. Vérifiez que la catégorie existe ou réessayez plus tard.");
            }
            ChargerCategories();
        }


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = txtBoxNomCatégorie.Text;
            string code = txtBoxCodeCatégorie.Text;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            List<Categorie> categories = Bdd.GetCategories();

            if (categories == null)
            {
                MessageBox.Show("Erreur lors de la récupération des catégories.");
                return;
            }

            // Vérifie si la catégorie existe déjà
            Categorie existingCategorie = categories.FirstOrDefault(c => c.Libelle == nom);

            if (existingCategorie != null)
            {
                existingCategorie.Libelle = nom;
                Bdd.mettreAJourCategorie(existingCategorie, code, nom);
                MessageBox.Show("Catégorie mise à jour avec succès.");
            }
            else
            {
                Categorie newCategorie = new Categorie(code, nom);
                Bdd.ajouterCategorie(newCategorie);
                MessageBox.Show("Catégorie enregistrée avec succès.");
            }

            // Vider les champs après l'enregistrement
            txtBoxNomCatégorie.Clear();
            txtBoxCodeCatégorie.Clear();
            ChargerCategories();
        }

    }
}
