using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace AP2_Gestion_De_Stock
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            //par défaut les combobox sont tous à "*" signifiant tout
            cBoxCategorie.Text = "*";
            cBoxFabricant.Text = "*";
            cBoxDepot.Text = "*";
            cBoxLibelle.Text = "*";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();

            if (ouvert)
            {
                MessageBox.Show(Bdd.afficherConnexion());

                List<ArticleAffichage> articles = Bdd.GetArticlesAvecDetails();
                List<Categorie> categories = Bdd.GetCategories();
                List<Fabricant> fabricants = Bdd.GetFabricants();
                List<Depot> depots = Bdd.GetDepots();
                cBoxFabricant.Items.Clear();
                cBoxFabricant.Items.Add("*");
                cBoxFabricant.SelectedIndex = 0;
                foreach (var fab in fabricants)
                {
                    cBoxFabricant.Items.Add(fab.NomEntreprise);
                }
                cBoxCategorie.Items.Clear();
                cBoxCategorie.Items.Add("*");
                foreach (var cat in categories)
                {
                    cBoxCategorie.Items.Add(cat.Libelle);
                }

                cBoxCategorie.SelectedIndex = 0;

                cBoxLibelle.Items.Clear();
                cBoxLibelle.Items.Add("*");
                foreach (var lib in articles)
                {
                    cBoxLibelle.Items.Add(lib.Libelle);
                }

                cBoxLibelle.SelectedIndex = 0;

                cBoxDepot.Items.Clear();
                cBoxDepot.Items.Add("*"); 
                foreach (var dep in depots)
                {
                    cBoxDepot.Items.Add(dep.Nom); 
                }
                cBoxDepot.SelectedIndex = 0;


                //si il y a des articles, on les affiche
                if (articles != null && articles.Count > 0)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Référence");
                    table.Columns.Add("Libellé");
                    table.Columns.Add("Catégorie");
                    table.Columns.Add("Fabricant");
                    table.Columns.Add("Unité");
                    

                    foreach (var a in articles)
                    {
                        try
                        {
                            table.Rows.Add(
                                a.ReferenceArticle ?? "",
                                a.Libelle ?? "",
                                a.Categorie ?? "",
                                a.Fabricant ?? "",
                                a.Unite ?? ""
                                
                            );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erreur sur l'article {a.ReferenceArticle} : {ex.Message}");
                        }
                    }



                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Aucun article trouvé.");
                }
            }
            else
            {
                MessageBox.Show("Aucun accès à la base de données.");
            }
        }

        //bouton pour accèder au form2
        private void btnNouvelArticle_Click(object sender, EventArgs e)
        {
            Articles form2 = new Articles();
            form2.Show();
        }

        //fonction de filtrage des recherches utilisée dans les combobox
        private void FiltrerArticles()
        {
            string selectedCategorie = cBoxCategorie.SelectedItem?.ToString() ?? "*";
            string selectedFabricant = cBoxFabricant.SelectedItem?.ToString() ?? "*";
            string selectedLibelle = cBoxLibelle.SelectedItem?.ToString() ?? "*";
            string selectedDepot = cBoxDepot.SelectedItem?.ToString() ?? "*";

            // 1. Charger depuis la BDD selon le dépôt, ou tous les articles si aucun dépôt sélectionné
            List<ArticleAffichage> articles = selectedDepot != "*"
                ? Bdd.GetArticlesSelonDepot(selectedDepot)
                : Bdd.GetArticlesAvecDetails();

            // 2. Appliquer les autres filtres
            if (selectedCategorie != "*")
            {
                articles = articles.Where(a => a.Categorie == selectedCategorie).ToList();
            }

            if (selectedFabricant != "*")
            {
                
                var tousLesFabricants = Bdd.GetFabricants();

                // Cherche les marques liées à l'entreprise sélectionnée
                var marquesAssociees = tousLesFabricants
                    .Where(f => f.NomEntreprise.Trim().Equals(selectedFabricant.Trim(), StringComparison.OrdinalIgnoreCase))
                    .Select(f => f.Marque.Trim())
                    .ToList();

                // Garde les articles dont la marque correspond à l’une des marques de l’entreprise
                articles = articles
                    .Where(a => a.Fabricant != null &&
                                marquesAssociees.Any(m => a.Fabricant.Trim().Equals(m, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }


            if (selectedLibelle != "*")
            {
                articles = articles.Where(a => a.Libelle == selectedLibelle).ToList();
            }

            // 3. Tri
            if (checkBoxDecroissant.Checked)
            {
                articles = articles.OrderByDescending(a => a.ReferenceArticle).ToList();
            }
            else
            {
                articles = articles.OrderBy(a => a.ReferenceArticle).ToList();
            }

            // 4. Affichage dans le DataGridView
            DataTable table = new DataTable();
            table.Columns.Add("Référence");
            table.Columns.Add("Libellé");
            table.Columns.Add("Catégorie");
            table.Columns.Add("Fabricant");
            table.Columns.Add("Unité");

            foreach (var a in articles)
            {
                try
                {
                    table.Rows.Add(
                        a.ReferenceArticle ?? "",
                        a.Libelle ?? "",
                        a.Categorie ?? "",
                        a.Fabricant ?? "",
                        a.Unite ?? ""
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur sur l'article {a.ReferenceArticle} : {ex.Message}");
                }
            }

            dataGridView1.DataSource = table;
        }




        //comboboxes pour filtrer les articles
        private void cBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerArticles();
        }

        private void cBoxFabricant_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerArticles();
        }



        private void cBoxLibelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerArticles();
        }


        private void checkBoxDecroissant_CheckedChanged(object sender, EventArgs e)
        {
            FiltrerArticles();
        }

        private void cBoxDepot_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FiltrerArticles();
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories form3 = new Categories();
            form3.Show();
        }

        private void fabricantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fabricants form4 = new Fabricants();
            form4.Show();
        }

        private void editionArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articles form2 = new Articles();
            form2.Show();
        }

        private void unitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unites form5 = new Unites();
            form5.Show();
        }

        private void dépôtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depots form6 = new Depots();
            form6.Show();
        }

        private void mouvementsDeStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouvementsStock form7 = new MouvementsStock();
            form7.Show();
        }

        private void paysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPays form8 = new FormPays();
            form8.Show();
        }
    }
}
