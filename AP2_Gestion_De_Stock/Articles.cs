using BLL;
using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_Gestion_De_Stock
{
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Nom", "Dépôt");
                dataGridView1.Columns.Add("Quantite", "Quantité");
                RemplirComboBox();
            }
            else
            {
                MessageBox.Show("Aucun accès à la base de données.");
            }
        }

        private void RemplirComboBox()
        {
            List<ArticleAffichage> articles = Bdd.GetArticlesAvecDetails();
            List<Categorie> categories = Bdd.GetCategories();
            List<Fabricant> fabricants = Bdd.GetFabricants();
            List<Unite> unites = Bdd.GetUnite();

            // Remplir les ComboBox de recherche
            cBoxRechercheReference.Items.Clear();
            cBoxRechercheReference.Items.Add("*");
            foreach (var a in articles)
            {
                cBoxRechercheReference.Items.Add(a.ReferenceArticle);
            }

            cBoxRechercheLibelle.Items.Clear();
            cBoxRechercheLibelle.Items.Add("*");
            foreach (var b in articles)
            {
                cBoxRechercheLibelle.Items.Add(b.Libelle);
            }

            cBoxCategorie.Items.Clear();
            cBoxCategorie.Items.Add("*");
            foreach (var cat in categories)
            {
                cBoxCategorie.Items.Add(cat.Libelle);
            }

            cBoxFabricant.Items.Clear();
            cBoxFabricant.Items.Add("*");
            foreach (var fab in fabricants.Select(fab => fab.NomEntreprise).Distinct())
            {
                cBoxFabricant.Items.Add(fab);
            }

            cBoxUnite.Items.Clear();
            cBoxUnite.Items.Add("*");
            foreach (var u in unites.Select(u => u.Libelle).Distinct())
            {
                cBoxUnite.Items.Add(u);
            }

            // Définir les valeurs sélectionnées par défaut
            cBoxRechercheReference.SelectedIndex = 0;
            cBoxRechercheLibelle.SelectedIndex = 0;
            cBoxCategorie.SelectedIndex = 0;
            cBoxFabricant.SelectedIndex = 0;
            cBoxUnite.SelectedIndex = 0;
        }

        private void cBoxRechercheReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReference = cBoxRechercheReference.SelectedItem.ToString();

            if (selectedReference != "*")
            {
                AfficherDepotStock(selectedReference);  
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void cBoxRechercheLibelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLibelle = cBoxRechercheLibelle.SelectedItem.ToString();

            if (selectedLibelle != "*")
            {
                AfficherDepotStock(libelle: selectedLibelle); 
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void AfficherDepotStock(string reference = null, string libelle = null)
        {
            // Adaptation de la requête en fonction du critère de recherche
            string query = @"
            SELECT 
                a.ReferenceArticle, 
                a.Libelle, 
                s.NumeroDepot, 
                d.Nom AS NomDepot,  
                s.Quantite
            FROM 
                Articles a
            JOIN 
                mouvementsstock s ON a.ReferenceArticle = s.ReferenceArticle
            JOIN
                Depots d ON s.NumeroDepot = d.NumeroDepot
            WHERE ";

            //recherche selon la référence 
            if (reference != null) 
            {
                query += "a.ReferenceArticle = @reference";
            }
            //ou le libellé
            else if (libelle != null) 
            {
                query += "a.Libelle = @libelle";
            }
            else
            {
                return; 
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Bdd.GetConnection());

                // Ajouter le paramètre de recherche
                if (reference != null)
                {
                    cmd.Parameters.AddWithValue("@reference", reference);
                }
                else if (libelle != null)
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        string nomDepot = reader["NomDepot"].ToString();
                        int quantite = Convert.ToInt32(reader["Quantite"]); 

                        dataGridView1.Rows.Add(nomDepot, quantite); 
                    }
                }
                else
                {
                    MessageBox.Show("Aucun stock trouvé pour cet article.");
                }

                reader.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des stocks : " + ex.Message);
            }
        }




        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            string reference = txtBoxReference.Text;

            if (string.IsNullOrEmpty(reference))
            {
                MessageBox.Show("Veuillez entrer la référence de l'article à supprimer.");
                return;
            }

            Bdd.supprimerArticle(reference);
            MessageBox.Show("Article supprimé avec succès.");

            // Vider les champs après la suppression
            txtBoxReference.Clear();
            txtBoxLibelle.Clear();
            cBoxCategorie.SelectedIndex = -1;
            cBoxFabricant.SelectedIndex = -1;
            cBoxUnite.SelectedIndex = -1;

            RemplirComboBox();
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            string reference = txtBoxReference.Text;
            string libelle = txtBoxLibelle.Text;

            string categorie = cBoxCategorie.SelectedItem?.ToString();
            string fabricant = cBoxFabricant.SelectedItem?.ToString();
            string unite = cBoxUnite.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(reference) || string.IsNullOrEmpty(libelle) ||
                categorie == "*" || fabricant == "*" || unite == "*")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (categorie == null || fabricant == null || unite == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie, un fabricant et une unité.");
                return;
            }

            string codeCategorie = Bdd.GetCategories().First(c => c.Libelle == categorie).CodeCategorie;
            string idFabricant = Bdd.GetFabricants().First(f => f.NomEntreprise == fabricant).IdFabricant;
            string codeUnite = Bdd.GetUnite().First(u => u.Libelle == unite).CodeUnite;

            Article existingArticle = Bdd.GetArticles().FirstOrDefault(a => a.ReferenceArticle == reference);

            //si l'article existe déjà il est mis à jour 
            if (existingArticle != null)
            {
                existingArticle.Libelle = libelle;
                Bdd.mettreAJourArticle(existingArticle, codeCategorie, idFabricant, codeUnite);
                MessageBox.Show("Article mis à jour avec succès.");
            }
            else //sinon il est créé
            {
                Article newArticle = new Article(reference, libelle);
                Bdd.ajouterArticle(newArticle, codeCategorie, idFabricant, codeUnite);
                MessageBox.Show("Article enregistré avec succès.");
            }

            // Vider les champs après l'enregistrement
            txtBoxReference.Clear();
            txtBoxLibelle.Clear();
            cBoxCategorie.SelectedIndex = -1;
            cBoxFabricant.SelectedIndex = -1;
            cBoxUnite.SelectedIndex = -1;

            RemplirComboBox();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    



        private void txtBoxReference_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLibelle_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
