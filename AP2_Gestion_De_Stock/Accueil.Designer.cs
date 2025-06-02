namespace AP2_Gestion_De_Stock
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxCategorie = new System.Windows.Forms.ComboBox();
            this.cBoxFabricant = new System.Windows.Forms.ComboBox();
            this.cBoxDepot = new System.Windows.Forms.ComboBox();
            this.cBoxLibelle = new System.Windows.Forms.ComboBox();
            this.btnNouvelArticle = new System.Windows.Forms.Button();
            this.checkBoxDecroissant = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editionArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dépôtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementsDeStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche par catégorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recherche par fabricant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recherche par dépot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recherche par libellé";
            // 
            // cBoxCategorie
            // 
            this.cBoxCategorie.FormattingEnabled = true;
            this.cBoxCategorie.Location = new System.Drawing.Point(217, 43);
            this.cBoxCategorie.Name = "cBoxCategorie";
            this.cBoxCategorie.Size = new System.Drawing.Size(121, 21);
            this.cBoxCategorie.TabIndex = 4;
            this.cBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.cBoxCategorie_SelectedIndexChanged);
            // 
            // cBoxFabricant
            // 
            this.cBoxFabricant.FormattingEnabled = true;
            this.cBoxFabricant.Location = new System.Drawing.Point(217, 81);
            this.cBoxFabricant.Name = "cBoxFabricant";
            this.cBoxFabricant.Size = new System.Drawing.Size(197, 21);
            this.cBoxFabricant.TabIndex = 5;
            this.cBoxFabricant.SelectedIndexChanged += new System.EventHandler(this.cBoxFabricant_SelectedIndexChanged);
            // 
            // cBoxDepot
            // 
            this.cBoxDepot.FormattingEnabled = true;
            this.cBoxDepot.Location = new System.Drawing.Point(217, 118);
            this.cBoxDepot.Name = "cBoxDepot";
            this.cBoxDepot.Size = new System.Drawing.Size(197, 21);
            this.cBoxDepot.TabIndex = 6;
            this.cBoxDepot.SelectedIndexChanged += new System.EventHandler(this.cBoxDepot_SelectedIndexChanged_1);
            // 
            // cBoxLibelle
            // 
            this.cBoxLibelle.FormattingEnabled = true;
            this.cBoxLibelle.Location = new System.Drawing.Point(217, 156);
            this.cBoxLibelle.Name = "cBoxLibelle";
            this.cBoxLibelle.Size = new System.Drawing.Size(272, 21);
            this.cBoxLibelle.TabIndex = 7;
            this.cBoxLibelle.SelectedIndexChanged += new System.EventHandler(this.cBoxLibelle_SelectedIndexChanged);
            // 
            // btnNouvelArticle
            // 
            this.btnNouvelArticle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNouvelArticle.Location = new System.Drawing.Point(595, 156);
            this.btnNouvelArticle.Name = "btnNouvelArticle";
            this.btnNouvelArticle.Size = new System.Drawing.Size(85, 23);
            this.btnNouvelArticle.TabIndex = 8;
            this.btnNouvelArticle.Text = "Nouvel article";
            this.btnNouvelArticle.UseVisualStyleBackColor = false;
            this.btnNouvelArticle.Click += new System.EventHandler(this.btnNouvelArticle_Click);
            // 
            // checkBoxDecroissant
            // 
            this.checkBoxDecroissant.AutoSize = true;
            this.checkBoxDecroissant.Location = new System.Drawing.Point(595, 43);
            this.checkBoxDecroissant.Name = "checkBoxDecroissant";
            this.checkBoxDecroissant.Size = new System.Drawing.Size(137, 17);
            this.checkBoxDecroissant.TabIndex = 9;
            this.checkBoxDecroissant.Text = "Classement décroissant";
            this.checkBoxDecroissant.UseVisualStyleBackColor = true;
            this.checkBoxDecroissant.CheckedChanged += new System.EventHandler(this.checkBoxDecroissant_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 220);
            this.dataGridView1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionArticleToolStripMenuItem,
            this.dépôtsToolStripMenuItem,
            this.fabricantsToolStripMenuItem,
            this.catégoriesToolStripMenuItem,
            this.unitésToolStripMenuItem,
            this.mouvementsDeStocksToolStripMenuItem,
            this.paysToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editionArticleToolStripMenuItem
            // 
            this.editionArticleToolStripMenuItem.Name = "editionArticleToolStripMenuItem";
            this.editionArticleToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.editionArticleToolStripMenuItem.Text = "Edition article";
            this.editionArticleToolStripMenuItem.Click += new System.EventHandler(this.editionArticleToolStripMenuItem_Click);
            // 
            // dépôtsToolStripMenuItem
            // 
            this.dépôtsToolStripMenuItem.Name = "dépôtsToolStripMenuItem";
            this.dépôtsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dépôtsToolStripMenuItem.Text = "Dépôts";
            this.dépôtsToolStripMenuItem.Click += new System.EventHandler(this.dépôtsToolStripMenuItem_Click);
            // 
            // fabricantsToolStripMenuItem
            // 
            this.fabricantsToolStripMenuItem.Name = "fabricantsToolStripMenuItem";
            this.fabricantsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fabricantsToolStripMenuItem.Text = "Fabricants";
            this.fabricantsToolStripMenuItem.Click += new System.EventHandler(this.fabricantsToolStripMenuItem_Click);
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            this.catégoriesToolStripMenuItem.Click += new System.EventHandler(this.catégoriesToolStripMenuItem_Click);
            // 
            // unitésToolStripMenuItem
            // 
            this.unitésToolStripMenuItem.Name = "unitésToolStripMenuItem";
            this.unitésToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.unitésToolStripMenuItem.Text = "Unités";
            this.unitésToolStripMenuItem.Click += new System.EventHandler(this.unitésToolStripMenuItem_Click);
            // 
            // mouvementsDeStocksToolStripMenuItem
            // 
            this.mouvementsDeStocksToolStripMenuItem.Name = "mouvementsDeStocksToolStripMenuItem";
            this.mouvementsDeStocksToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.mouvementsDeStocksToolStripMenuItem.Text = "Mouvements de stocks";
            this.mouvementsDeStocksToolStripMenuItem.Click += new System.EventHandler(this.mouvementsDeStocksToolStripMenuItem_Click);
            // 
            // paysToolStripMenuItem
            // 
            this.paysToolStripMenuItem.Name = "paysToolStripMenuItem";
            this.paysToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.paysToolStripMenuItem.Text = "Pays";
            this.paysToolStripMenuItem.Click += new System.EventHandler(this.paysToolStripMenuItem_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxDecroissant);
            this.Controls.Add(this.btnNouvelArticle);
            this.Controls.Add(this.cBoxLibelle);
            this.Controls.Add(this.cBoxDepot);
            this.Controls.Add(this.cBoxFabricant);
            this.Controls.Add(this.cBoxCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Liste des articles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxCategorie;
        private System.Windows.Forms.ComboBox cBoxFabricant;
        private System.Windows.Forms.ComboBox cBoxDepot;
        private System.Windows.Forms.ComboBox cBoxLibelle;
        private System.Windows.Forms.Button btnNouvelArticle;
        private System.Windows.Forms.CheckBox checkBoxDecroissant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editionArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dépôtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementsDeStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paysToolStripMenuItem;
    }
}

