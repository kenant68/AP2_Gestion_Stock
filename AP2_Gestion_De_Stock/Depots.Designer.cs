namespace AP2_Gestion_De_Stock
{
    partial class Depots
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNumDepot = new System.Windows.Forms.TextBox();
            this.txtBoxNomDepot = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxPays = new System.Windows.Forms.TextBox();
            this.txtBoxLongitude = new System.Windows.Forms.TextBox();
            this.txtBoxLatitude = new System.Windows.Forms.TextBox();
            this.cBoxRechercheDepotPays = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAnnuler.Location = new System.Drawing.Point(73, 129);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.LightGreen;
            this.btnEnregistrer.Location = new System.Drawing.Point(177, 129);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(274, 129);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numéro du dépôt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom du dépôt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Longitude";
            // 
            // txtBoxNumDepot
            // 
            this.txtBoxNumDepot.Location = new System.Drawing.Point(160, 27);
            this.txtBoxNumDepot.Name = "txtBoxNumDepot";
            this.txtBoxNumDepot.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumDepot.TabIndex = 15;
            // 
            // txtBoxNomDepot
            // 
            this.txtBoxNomDepot.Location = new System.Drawing.Point(160, 61);
            this.txtBoxNomDepot.Name = "txtBoxNomDepot";
            this.txtBoxNomDepot.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomDepot.TabIndex = 16;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(346, 27);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVille.TabIndex = 17;
            // 
            // txtBoxPays
            // 
            this.txtBoxPays.Location = new System.Drawing.Point(350, 64);
            this.txtBoxPays.Name = "txtBoxPays";
            this.txtBoxPays.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPays.TabIndex = 18;
            // 
            // txtBoxLongitude
            // 
            this.txtBoxLongitude.Location = new System.Drawing.Point(550, 64);
            this.txtBoxLongitude.Name = "txtBoxLongitude";
            this.txtBoxLongitude.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLongitude.TabIndex = 19;
            // 
            // txtBoxLatitude
            // 
            this.txtBoxLatitude.Location = new System.Drawing.Point(550, 27);
            this.txtBoxLatitude.Name = "txtBoxLatitude";
            this.txtBoxLatitude.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLatitude.TabIndex = 20;
            // 
            // cBoxRechercheDepotPays
            // 
            this.cBoxRechercheDepotPays.FormattingEnabled = true;
            this.cBoxRechercheDepotPays.Location = new System.Drawing.Point(550, 100);
            this.cBoxRechercheDepotPays.Name = "cBoxRechercheDepotPays";
            this.cBoxRechercheDepotPays.Size = new System.Drawing.Size(121, 21);
            this.cBoxRechercheDepotPays.TabIndex = 21;
            this.cBoxRechercheDepotPays.SelectedIndexChanged += new System.EventHandler(this.cBoxRechercheDepotPays_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Recherche selon pays";
            // 
            // Depots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBoxRechercheDepotPays);
            this.Controls.Add(this.txtBoxLatitude);
            this.Controls.Add(this.txtBoxLongitude);
            this.Controls.Add(this.txtBoxPays);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxNomDepot);
            this.Controls.Add(this.txtBoxNumDepot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Depots";
            this.Text = "Depots";
            this.Load += new System.EventHandler(this.Depots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxNumDepot;
        private System.Windows.Forms.TextBox txtBoxNomDepot;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxPays;
        private System.Windows.Forms.TextBox txtBoxLongitude;
        private System.Windows.Forms.TextBox txtBoxLatitude;
        private System.Windows.Forms.ComboBox cBoxRechercheDepotPays;
        private System.Windows.Forms.Label label7;
    }
}