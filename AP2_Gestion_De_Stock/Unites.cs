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
    public partial class Unites : Form
    {
        public Unites()
        {
            InitializeComponent();
        }

        private void Unites_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("CodeUnite", "Code");
                dataGridView1.Columns.Add("Libelle", "Libellé");
                ChargerUnites();
            }
            else
            {
                MessageBox.Show("Aucun accès à la base de données.");
            }
        }

        private void ChargerUnites()
        {
            List<Unite> unites = Bdd.GetUnite();

            if (unites == null)
            {
                MessageBox.Show("Erreur lors de la récupération des unités.");
                return;
            }

            dataGridView1.Rows.Clear();
            unites = unites.OrderBy(u => u.Libelle).ToList();

            foreach (Unite u in unites)
            {
                dataGridView1.Rows.Add(u.CodeUnite, u.Libelle);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string libelle = txtBoxLibelle.Text;

            if (string.IsNullOrWhiteSpace(libelle))
            {
                MessageBox.Show("Veuillez entrer le libellé de l’unité à supprimer.");
                return;
            }

            bool success = Bdd.supprimerUnite(libelle);

            if (success)
            {
                MessageBox.Show("Unité supprimée avec succès.");
                txtBoxCodeUnite.Clear();
                txtBoxLibelle.Clear();
            }
            else
            {
                MessageBox.Show("Échec de la suppression. Vérifiez que l’unité existe ou réessayez plus tard.");
            }
            ChargerUnites();
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            string code = txtBoxCodeUnite.Text;
            string libelle = txtBoxLibelle.Text;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(libelle))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            List<Unite> unites = Bdd.GetUnite();

            if (unites == null)
            {
                MessageBox.Show("Erreur lors de la récupération des unités.");
                return;
            }

            Unite existing = unites.FirstOrDefault(u => u.Libelle == libelle);

            if (existing != null)
            {
                existing.Libelle = libelle;
                Bdd.mettreAJourUnite(existing, code, libelle);
                MessageBox.Show("Unité mise à jour avec succès.");
            }
            else
            {
                Unite nouvelle = new Unite(code, libelle);
                Bdd.ajouterUnite(nouvelle);
                MessageBox.Show("Unité enregistrée avec succès.");
            }

            txtBoxCodeUnite.Clear();
            txtBoxLibelle.Clear();
            ChargerUnites();
        }

        
    }
}
