namespace AP2_Gestion_De_Stock
{
    partial class Categories
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
            this.nomCategorie = new System.Windows.Forms.Label();
            this.codeCatégorie = new System.Windows.Forms.Label();
            this.txtBoxCodeCatégorie = new System.Windows.Forms.TextBox();
            this.txtBoxNomCatégorie = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomCategorie
            // 
            this.nomCategorie.AutoSize = true;
            this.nomCategorie.Location = new System.Drawing.Point(59, 32);
            this.nomCategorie.Name = "nomCategorie";
            this.nomCategorie.Size = new System.Drawing.Size(100, 13);
            this.nomCategorie.TabIndex = 1;
            this.nomCategorie.Text = "Libellé de Catégorie";
            // 
            // codeCatégorie
            // 
            this.codeCatégorie.AutoSize = true;
            this.codeCatégorie.Location = new System.Drawing.Point(59, 64);
            this.codeCatégorie.Name = "codeCatégorie";
            this.codeCatégorie.Size = new System.Drawing.Size(95, 13);
            this.codeCatégorie.TabIndex = 2;
            this.codeCatégorie.Text = "Code de Catégorie";
            // 
            // txtBoxCodeCatégorie
            // 
            this.txtBoxCodeCatégorie.Location = new System.Drawing.Point(160, 61);
            this.txtBoxCodeCatégorie.Name = "txtBoxCodeCatégorie";
            this.txtBoxCodeCatégorie.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodeCatégorie.TabIndex = 3;
            // 
            // txtBoxNomCatégorie
            // 
            this.txtBoxNomCatégorie.Location = new System.Drawing.Point(157, 29);
            this.txtBoxNomCatégorie.Name = "txtBoxNomCatégorie";
            this.txtBoxNomCatégorie.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomCatégorie.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAnnuler.Location = new System.Drawing.Point(58, 128);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.LightGreen;
            this.btnEnregistrer.Location = new System.Drawing.Point(157, 128);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(250, 128);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtBoxNomCatégorie);
            this.Controls.Add(this.txtBoxCodeCatégorie);
            this.Controls.Add(this.codeCatégorie);
            this.Controls.Add(this.nomCategorie);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Catégories";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nomCategorie;
        private System.Windows.Forms.Label codeCatégorie;
        private System.Windows.Forms.TextBox txtBoxCodeCatégorie;
        private System.Windows.Forms.TextBox txtBoxNomCatégorie;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
    }
}