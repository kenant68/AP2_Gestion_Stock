namespace AP2_Gestion_De_Stock
{
    partial class Fabricants
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
            this.lblNomEntreprise = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxEntreprise = new System.Windows.Forms.TextBox();
            this.txtBoxMarque = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxIdFabricant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomEntreprise
            // 
            this.lblNomEntreprise.AutoSize = true;
            this.lblNomEntreprise.Location = new System.Drawing.Point(9, 41);
            this.lblNomEntreprise.Name = "lblNomEntreprise";
            this.lblNomEntreprise.Size = new System.Drawing.Size(97, 13);
            this.lblNomEntreprise.TabIndex = 0;
            this.lblNomEntreprise.Text = "Nom de l\'entreprise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marque";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 178);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtBoxEntreprise
            // 
            this.txtBoxEntreprise.Location = new System.Drawing.Point(112, 38);
            this.txtBoxEntreprise.Name = "txtBoxEntreprise";
            this.txtBoxEntreprise.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEntreprise.TabIndex = 3;
            // 
            // txtBoxMarque
            // 
            this.txtBoxMarque.Location = new System.Drawing.Point(112, 71);
            this.txtBoxMarque.Name = "txtBoxMarque";
            this.txtBoxMarque.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMarque.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnnuler.Location = new System.Drawing.Point(53, 146);
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
            this.btnEnregistrer.Location = new System.Drawing.Point(152, 146);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.btnSupprimer.Location = new System.Drawing.Point(255, 146);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id du Fabricant";
            // 
            // txtBoxIdFabricant
            // 
            this.txtBoxIdFabricant.Location = new System.Drawing.Point(112, 105);
            this.txtBoxIdFabricant.Name = "txtBoxIdFabricant";
            this.txtBoxIdFabricant.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdFabricant.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxIdFabricant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtBoxMarque);
            this.Controls.Add(this.txtBoxEntreprise);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomEntreprise);
            this.Name = "Form4";
            this.Text = "Fabricants";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomEntreprise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxEntreprise;
        private System.Windows.Forms.TextBox txtBoxMarque;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxIdFabricant;
    }
}