namespace AP2_Gestion_De_Stock
{
    partial class MouvementsStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxRechercheDepot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxRechercheFabricant = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxRechercheCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockInferieur = new System.Windows.Forms.TextBox();
            this.txtStockSuperieur = new System.Windows.Forms.TextBox();
            this.txtDateHeure = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxTypeStock = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxReferenceArticle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dépôt";
            // 
            // cBoxRechercheDepot
            // 
            this.cBoxRechercheDepot.FormattingEnabled = true;
            this.cBoxRechercheDepot.Location = new System.Drawing.Point(79, 27);
            this.cBoxRechercheDepot.Name = "cBoxRechercheDepot";
            this.cBoxRechercheDepot.Size = new System.Drawing.Size(121, 21);
            this.cBoxRechercheDepot.TabIndex = 2;
            this.cBoxRechercheDepot.SelectedIndexChanged += new System.EventHandler(this.cBoxRechercheDepot_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fabricant";
            // 
            // cBoxRechercheFabricant
            // 
            this.cBoxRechercheFabricant.FormattingEnabled = true;
            this.cBoxRechercheFabricant.Location = new System.Drawing.Point(80, 60);
            this.cBoxRechercheFabricant.Name = "cBoxRechercheFabricant";
            this.cBoxRechercheFabricant.Size = new System.Drawing.Size(121, 21);
            this.cBoxRechercheFabricant.TabIndex = 4;
            this.cBoxRechercheFabricant.SelectedIndexChanged += new System.EventHandler(this.cBoxRechercheFabricant_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Catégorie";
            // 
            // cBoxRechercheCategorie
            // 
            this.cBoxRechercheCategorie.FormattingEnabled = true;
            this.cBoxRechercheCategorie.Location = new System.Drawing.Point(79, 95);
            this.cBoxRechercheCategorie.Name = "cBoxRechercheCategorie";
            this.cBoxRechercheCategorie.Size = new System.Drawing.Size(121, 21);
            this.cBoxRechercheCategorie.TabIndex = 6;
            this.cBoxRechercheCategorie.SelectedIndexChanged += new System.EventHandler(this.cBoxRechercheCategorie_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock <= à :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock >= à :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date et heure";
            // 
            // txtStockInferieur
            // 
            this.txtStockInferieur.Location = new System.Drawing.Point(356, 30);
            this.txtStockInferieur.Name = "txtStockInferieur";
            this.txtStockInferieur.Size = new System.Drawing.Size(100, 20);
            this.txtStockInferieur.TabIndex = 10;
            this.txtStockInferieur.TextChanged += new System.EventHandler(this.txtStockInferieur_TextChanged);
            // 
            // txtStockSuperieur
            // 
            this.txtStockSuperieur.Location = new System.Drawing.Point(356, 56);
            this.txtStockSuperieur.Name = "txtStockSuperieur";
            this.txtStockSuperieur.Size = new System.Drawing.Size(100, 20);
            this.txtStockSuperieur.TabIndex = 11;
            this.txtStockSuperieur.TextChanged += new System.EventHandler(this.txtStockSuperieur_TextChanged);
            // 
            // txtDateHeure
            // 
            this.txtDateHeure.Location = new System.Drawing.Point(356, 91);
            this.txtDateHeure.Name = "txtDateHeure";
            this.txtDateHeure.Size = new System.Drawing.Size(100, 20);
            this.txtDateHeure.TabIndex = 12;
            this.txtDateHeure.TextChanged += new System.EventHandler(this.txtDateHeure_TextChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAnnuler.Location = new System.Drawing.Point(43, 149);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.LightGreen;
            this.btnEnregistrer.Location = new System.Drawing.Point(143, 149);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(239, 149);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantité";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(626, 36);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 20);
            this.txtQuantite.TabIndex = 17;
            this.txtQuantite.TextChanged += new System.EventHandler(this.txtQuantite_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Type";
            // 
            // cBoxTypeStock
            // 
            this.cBoxTypeStock.FormattingEnabled = true;
            this.cBoxTypeStock.Location = new System.Drawing.Point(626, 68);
            this.cBoxTypeStock.Name = "cBoxTypeStock";
            this.cBoxTypeStock.Size = new System.Drawing.Size(121, 21);
            this.cBoxTypeStock.TabIndex = 19;
            this.cBoxTypeStock.SelectedIndexChanged += new System.EventHandler(this.cBoxTypeStock_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Référence article";
            // 
            // cBoxReferenceArticle
            // 
            this.cBoxReferenceArticle.FormattingEnabled = true;
            this.cBoxReferenceArticle.Location = new System.Drawing.Point(626, 98);
            this.cBoxReferenceArticle.Name = "cBoxReferenceArticle";
            this.cBoxReferenceArticle.Size = new System.Drawing.Size(121, 21);
            this.cBoxReferenceArticle.TabIndex = 21;
            this.cBoxReferenceArticle.SelectedIndexChanged += new System.EventHandler(this.cBoxReferenceArticle_SelectedIndexChanged);
            // 
            // MouvementsStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxReferenceArticle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBoxTypeStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtDateHeure);
            this.Controls.Add(this.txtStockSuperieur);
            this.Controls.Add(this.txtStockInferieur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxRechercheCategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxRechercheFabricant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxRechercheDepot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MouvementsStock";
            this.Text = "Mouvements de Stock";
            this.Load += new System.EventHandler(this.MouvementsStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxRechercheDepot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxRechercheFabricant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxRechercheCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockInferieur;
        private System.Windows.Forms.TextBox txtStockSuperieur;
        private System.Windows.Forms.TextBox txtDateHeure;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxTypeStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxReferenceArticle;
    }
}