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
    public partial class MouvementsStock : Form
    {
        public MouvementsStock()
        {
            InitializeComponent();
        }

        private void MouvementsStock_Load(object sender, EventArgs e)
        {
            if (!Bdd.ouvrirConnexion())
            {
                MessageBox.Show("Aucun accès à la base de données.");
                return;
            }

            // Création des colonnes du DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NomDepot", "Dépôt");
            dataGridView1.Columns.Add("NomArticle", "Article");
            dataGridView1.Columns.Add("Quantite", "Quantité");
            dataGridView1.Columns.Add("Type", "Type");

            ChargerMouvements();
            RemplirComboBoxDepots();
            RemplirComboBoxFabricants();
            RemplirComboBoxCategories();
            RemplirComboBoxTypeStock();
            RemplirComboBoxReferenceArticle();


        }

        private void RemplirComboBoxTypeStock()
        {
            cBoxTypeStock.Items.Clear();
            cBoxTypeStock.Items.Add("*");
            cBoxTypeStock.Items.Add("Entrée");
            cBoxTypeStock.Items.Add("Sortie");
            cBoxTypeStock.SelectedIndex = 0;
        }


        private void ChargerMouvements()
        {
            List<Stock> mouvements = Bdd.GetTousLesMouvements();
            List<Depot> depots = Bdd.GetDepots();
            List<ArticleAffichage> articles = Bdd.GetArticlesAvecDetails();

            if (mouvements == null || depots == null || articles == null)
            {
                MessageBox.Show("Erreur lors du chargement des données.");
                return;
            }

            dataGridView1.Rows.Clear();

            foreach (Stock m in mouvements.OrderBy(m => m.DateHeureMouvement))
            {
                string nomDepot = depots.FirstOrDefault(d => d.NumeroDepot == m.NumeroDepot)?.Nom ?? "Inconnu";
                ArticleAffichage article = articles.FirstOrDefault(a => a.ReferenceArticle == m.ReferenceArticle);
                string nomArticle = article?.Libelle ?? m.ReferenceArticle;
                string typeMouvement = m.Type ?? "Inconnu";

                dataGridView1.Rows.Add(
                    nomDepot,
                    nomArticle,
                    m.Quantite,
                    typeMouvement
                );
            }
        }





        private void RemplirComboBoxDepots()
        {
            List<Depot> depots = Bdd.GetDepots(); 
            if (depots == null)
            {
                MessageBox.Show("Erreur lors du chargement des dépôts.");
                return;
            }

            cBoxRechercheDepot.Items.Clear();
            cBoxRechercheDepot.Items.Add("*");

            foreach (string nom in depots.Select(d => d.Nom).Distinct())
            {
                cBoxRechercheDepot.Items.Add(nom);
            }

            cBoxRechercheDepot.SelectedIndex = 0;
        }

        private void RemplirComboBoxFabricants()
        {
            List<Fabricant> fabricants = Bdd.GetFabricants(); // ou GetTousLesFabricants()
            if (fabricants == null)
            {
                MessageBox.Show("Erreur lors du chargement des fabricants.");
                return;
            }

            cBoxRechercheFabricant.Items.Clear();
            cBoxRechercheFabricant.Items.Add("*");

            foreach (string nom in fabricants.Select(f => f.NomEntreprise).Distinct())
            {
                cBoxRechercheFabricant.Items.Add(nom);
            }

            cBoxRechercheFabricant.SelectedIndex = 0;
        }

        private void RemplirComboBoxCategories()
        {
            List<Categorie> categories = Bdd.GetCategories(); // ou GetToutesLesCategories()
            if (categories == null)
            {
                MessageBox.Show("Erreur lors du chargement des catégories.");
                return;
            }

            cBoxRechercheCategorie.Items.Clear();
            cBoxRechercheCategorie.Items.Add("*");

            foreach (string nom in categories.Select(c => c.Libelle).Distinct())
            {
                cBoxRechercheCategorie.Items.Add(nom);
            }

            cBoxRechercheCategorie.SelectedIndex = 0;
        }

        private void RemplirComboBoxReferenceArticle()
        {
            var articles = Bdd.GetArticlesAvecDetails();
            cBoxReferenceArticle.Items.Clear();
            cBoxReferenceArticle.Items.Add("*");

            foreach (var article in articles)
            {
                cBoxReferenceArticle.Items.Add(article.ReferenceArticle);
            }

            cBoxReferenceArticle.SelectedIndex = 0;
        }


        private void FiltrerMouvements()
        {
            int.TryParse(txtStockInferieur.Text, out int qteMax);
            int.TryParse(txtStockSuperieur.Text, out int qteMin);
            bool filtrerQuantite = qteMin != 0 || qteMax != 0; // Modification ici : vérifier que les quantités sont bien prises en compte, même négatives

            string selectedDepot = cBoxRechercheDepot.SelectedItem?.ToString() ?? "*";
            string selectedFabricant = cBoxRechercheFabricant.SelectedItem?.ToString() ?? "*";
            string selectedCategorie = cBoxRechercheCategorie.SelectedItem?.ToString() ?? "*";
            string selectedReference = cBoxReferenceArticle.SelectedItem?.ToString() ?? "*";
            string dateFiltreText = txtDateHeure.Text.Trim();
            DateTime.TryParse(dateFiltreText, out DateTime dateFiltre);

            List<Stock> mouvements = Bdd.GetTousLesMouvements();
            List<Depot> depots = Bdd.GetDepots();
            List<ArticleAffichage> articles = Bdd.GetArticlesAvecDetails();

            if (mouvements == null || depots == null || articles == null)
            {
                MessageBox.Show("Erreur lors du chargement des données pour le filtrage.");
                return;
            }

            var mouvementsFiltres = mouvements.Where(m =>
            {
                var article = articles.FirstOrDefault(a => a.ReferenceArticle == m.ReferenceArticle);
                if (article == null) return false;

                bool depotOk = selectedDepot == "*" ||
                               m.NumeroDepot == depots.FirstOrDefault(d => d.Nom == selectedDepot)?.NumeroDepot;

                bool fabricantOk = selectedFabricant == "*" ||
                                   (article.Fabricant?.Trim().Equals(selectedFabricant.Trim(), StringComparison.OrdinalIgnoreCase) ?? false);

                bool categorieOk = selectedCategorie == "*" ||
                                   article.Categorie == selectedCategorie;

                bool quantiteOk = !filtrerQuantite ||
                    (m.Quantite >= qteMin && (qteMax == 0 || m.Quantite <= qteMax));

                bool referenceOk = selectedReference == "*" || m.ReferenceArticle == selectedReference;
                bool dateOk = string.IsNullOrEmpty(dateFiltreText) || m.DateHeureMouvement.Date == dateFiltre.Date;

                return depotOk && fabricantOk && categorieOk && quantiteOk && referenceOk && dateOk;
            }).OrderBy(m => m.DateHeureMouvement).ToList();

            dataGridView1.Rows.Clear();
            foreach (var m in mouvementsFiltres)
            {
                string nomDepot = depots.FirstOrDefault(d => d.NumeroDepot == m.NumeroDepot)?.Nom ?? "Inconnu";
                var article = articles.FirstOrDefault(a => a.ReferenceArticle == m.ReferenceArticle);
                string nomArticle = article?.Libelle ?? m.ReferenceArticle;
                string typeMouvement = m.Type ?? "Inconnu";


                dataGridView1.Rows.Add(
                    nomDepot,
                    nomArticle,
                    m.Quantite,
                    typeMouvement
                );
            }
        }








        private void cBoxRechercheDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerMouvements();
        }

        private void cBoxRechercheFabricant_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerMouvements();
        }

        private void cBoxRechercheCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerMouvements();
        }

        private void txtStockInferieur_TextChanged(object sender, EventArgs e)
        {
            FiltrerMouvements();
        }

        private void txtStockSuperieur_TextChanged(object sender, EventArgs e)
        {
            FiltrerMouvements();
        }

        private void txtDateHeure_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedDepot = cBoxRechercheDepot.SelectedItem?.ToString();
                string selectedFabricant = cBoxRechercheFabricant.SelectedItem?.ToString();
                string selectedCategorie = cBoxRechercheCategorie.SelectedItem?.ToString();
                string selectedReference = cBoxReferenceArticle.SelectedItem?.ToString();
                string selectedType = cBoxTypeStock.SelectedItem?.ToString();
                string quantiteText = txtQuantite.Text.Trim();
                string dateText = txtDateHeure.Text.Trim();

                if (string.IsNullOrEmpty(selectedDepot) || string.IsNullOrEmpty(selectedReference)
                    || string.IsNullOrEmpty(selectedType) || selectedType == "*" || string.IsNullOrEmpty(quantiteText)
                    || string.IsNullOrEmpty(dateText))
                {
                    MessageBox.Show("Veuillez remplir tous les champs requis.");
                    return;
                }

                if (!int.TryParse(quantiteText, out int quantite))
                {
                    MessageBox.Show("Quantité invalide.");
                    return;
                }

                if (!DateTime.TryParse(dateText, out DateTime dateHeure))
                {
                    MessageBox.Show("Date invalide.");
                    return;
                }

                Depot depot = Bdd.GetDepots().FirstOrDefault(d => d.Nom == selectedDepot);
                if (depot == null)
                {
                    MessageBox.Show("Dépôt introuvable.");
                    return;
                }

                Stock nouveauMouvement = new Stock(selectedReference, depot.NumeroDepot, dateHeure, selectedType, quantite);

                // Supprimer l'existant si présent (même dépôt, référence, type, date)
                var existant = Bdd.GetTousLesMouvements().FirstOrDefault(m =>
                    m.ReferenceArticle == selectedReference &&
                    m.NumeroDepot == depot.NumeroDepot &&
                    m.Type == selectedType &&
                    m.DateHeureMouvement.Date == dateHeure.Date);

                if (existant != null)
                {
                    Bdd.SupprimerMouvementStock(existant);
                }

                Bdd.AjouterMouvementStock(nouveauMouvement);
                MessageBox.Show("Mouvement enregistré avec succès.");

                ChargerMouvements();
                EffacerChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }





        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedDepot = cBoxRechercheDepot.SelectedItem?.ToString();
                string selectedReference = cBoxReferenceArticle.SelectedItem?.ToString();
                string selectedType = cBoxTypeStock.SelectedItem?.ToString();
                string dateText = txtDateHeure.Text.Trim();

                if (string.IsNullOrEmpty(selectedDepot))
                {
                    MessageBox.Show("Veuillez sélectionner un dépôt.");
                    return;
                }

                if (!DateTime.TryParse(dateText, out DateTime dateHeure))
                {
                    MessageBox.Show("Veuillez entrer une date valide.");
                    return;
                }

                Depot depot = Bdd.GetDepots().FirstOrDefault(d => d.Nom == selectedDepot);
                if (depot == null)
                {
                    MessageBox.Show("Dépôt non trouvé.");
                    return;
                }

                List<Stock> mouvements = Bdd.GetTousLesMouvements();
                var mouvementsFiltres = mouvements.Where(m =>
                    m.NumeroDepot == depot.NumeroDepot &&
                    (string.IsNullOrEmpty(selectedReference) || m.ReferenceArticle == selectedReference) &&
                    (string.IsNullOrEmpty(selectedType) || selectedType == "*" || m.Type == selectedType) &&
                    m.DateHeureMouvement.Date == dateHeure.Date
                ).ToList();

                if (mouvementsFiltres.Count == 0)
                {
                    MessageBox.Show("Aucun mouvement trouvé à supprimer.");
                    return;
                }

                foreach (var mouvement in mouvementsFiltres)
                {
                    bool suppressionReussie = Bdd.SupprimerMouvementStock(mouvement);
                    if (suppressionReussie)
                    {
                        MessageBox.Show($"Mouvement supprimé : {mouvement.ReferenceArticle}");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression d'un mouvement.");
                    }
                }

                ChargerMouvements();
                EffacerChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }



        private void EffacerChamps()
        {
            txtDateHeure.Clear();
            txtStockInferieur.Clear();
            txtStockSuperieur.Clear();
        }

        private void cBoxTypeStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxReferenceArticle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
