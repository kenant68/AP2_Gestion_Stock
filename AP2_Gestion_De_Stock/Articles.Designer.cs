namespace AP2_Gestion_De_Stock
{
    partial class Articles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxRechercheReference = new System.Windows.Forms.ComboBox();
            this.cBoxRechercheLibelle = new System.Windows.Forms.ComboBox();
            this.txtBoxReference = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLibelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxCategorie = new System.Windows.Forms.ComboBox();
            this.cBoxFabricant = new System.Windows.Forms.ComboBox();
            this.cBoxUnite = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche par référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recherche par libellé";
            // 
            // cBoxRechercheReference
            // 
            this.cBoxRechercheReference.FormattingEnabled = true;
            this.cBoxRechercheReference.Location = new System.Drawing.Point(229, 19);
            this.cBoxRechercheReference.Name = "cBoxRechercheReference";
            this.cBoxRechercheReference.Size = new System.Drawing.Size(121, 21);
            this.cBoxRechercheReference.TabIndex = 2;
            this.cBoxRechercheReference.SelectedIndexChanged += new System.EventHandler(this.cBoxRechercheReference_SelectedIndexChanged);
            // 
            // cBoxRechercheLibelle
            // 
            this.cBoxRechercheLibelle.FormattingEnabled = true;
            this.cBoxRechercheLibelle.Location = new System.Drawing.Point(229, 50);
            this.cBoxRechercheLibelle.Name = "cBoxRechercheLibelle";
            this.cBoxRechercheLibelle.Size = new System.Drawing.Size(233, 21);
            this.cBoxRechercheLibelle.TabIndex = 3;
            this.cBoxRechercheLibelle.SelectedIndexChanged += new System.EventHandler(this.cBoxRechercheLibelle_SelectedIndexChanged);
            // 
            // txtBoxReference
            // 
            this.txtBoxReference.Location = new System.Drawing.Point(181, 147);
            this.txtBoxReference.Name = "txtBoxReference";
            this.txtBoxReference.Size = new System.Drawing.Size(100, 20);
            this.txtBoxReference.TabIndex = 4;
            this.txtBoxReference.TextChanged += new System.EventHandler(this.txtBoxReference_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Référence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Libellé";
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(181, 180);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.Size = new System.Drawing.Size(240, 20);
            this.txtBoxLibelle.TabIndex = 7;
            this.txtBoxLibelle.TextChanged += new System.EventHandler(this.txtBoxLibelle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Catégorie";
            // 
            // cBoxCategorie
            // 
            this.cBoxCategorie.FormattingEnabled = true;
            this.cBoxCategorie.Location = new System.Drawing.Point(181, 221);
            this.cBoxCategorie.Name = "cBoxCategorie";
            this.cBoxCategorie.Size = new System.Drawing.Size(121, 21);
            this.cBoxCategorie.TabIndex = 9;
            // 
            // cBoxFabricant
            // 
            this.cBoxFabricant.FormattingEnabled = true;
            this.cBoxFabricant.Location = new System.Drawing.Point(181, 257);
            this.cBoxFabricant.Name = "cBoxFabricant";
            this.cBoxFabricant.Size = new System.Drawing.Size(196, 21);
            this.cBoxFabricant.TabIndex = 10;
            // 
            // cBoxUnite
            // 
            this.cBoxUnite.FormattingEnabled = true;
            this.cBoxUnite.Location = new System.Drawing.Point(181, 292);
            this.cBoxUnite.Name = "cBoxUnite";
            this.cBoxUnite.Size = new System.Drawing.Size(83, 21);
            this.cBoxUnite.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fabricant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unité";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(254, 241);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(82, 365);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Lime;
            this.btnEnregistrer.Location = new System.Drawing.Point(206, 365);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 16;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(346, 365);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.cBoxRechercheLibelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBoxRechercheReference);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxUnite);
            this.Controls.Add(this.cBoxFabricant);
            this.Controls.Add(this.cBoxCategorie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxLibelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxReference);
            this.Name = "Form2";
            this.Text = "Ajout/Suppression d\'articles";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxRechercheReference;
        private System.Windows.Forms.ComboBox cBoxRechercheLibelle;
        private System.Windows.Forms.TextBox txtBoxReference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLibelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxCategorie;
        private System.Windows.Forms.ComboBox cBoxFabricant;
        private System.Windows.Forms.ComboBox cBoxUnite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}