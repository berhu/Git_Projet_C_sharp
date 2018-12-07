namespace MaPremièreApplication_SuperBouton
{
    partial class FrmButton
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
            this.components = new System.ComponentModel.Container();
            this.btnSuperButton = new System.Windows.Forms.Button();
            this.btnCible = new System.Windows.Forms.Button();
            this.timerCible = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSuperButton
            // 
            this.btnSuperButton.Location = new System.Drawing.Point(12, 12);
            this.btnSuperButton.Name = "btnSuperButton";
            this.btnSuperButton.Size = new System.Drawing.Size(215, 60);
            this.btnSuperButton.TabIndex = 0;
            this.btnSuperButton.Text = "My Super Button";
            this.btnSuperButton.UseVisualStyleBackColor = true;
            this.btnSuperButton.Click += new System.EventHandler(this.btnSuperButton_Click);
            // 
            // btnCible
            // 
            this.btnCible.Enabled = false;
            this.btnCible.Location = new System.Drawing.Point(12, 78);
            this.btnCible.Name = "btnCible";
            this.btnCible.Size = new System.Drawing.Size(67, 31);
            this.btnCible.TabIndex = 1;
            this.btnCible.Text = "Cible";
            this.btnCible.UseVisualStyleBackColor = true;
            this.btnCible.Visible = false;
            this.btnCible.EnabledChanged += new System.EventHandler(this.btnCible_EnabledChanged);
            // 
            // timerCible
            // 
            this.timerCible.Interval = 10;
            this.timerCible.Tick += new System.EventHandler(this.timerCible_Tick);
            // 
            // FrmButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 438);
            this.Controls.Add(this.btnCible);
            this.Controls.Add(this.btnSuperButton);
            this.Name = "FrmButton";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuperButton;
        private System.Windows.Forms.Button btnCible;
        private System.Windows.Forms.Timer timerCible;
    }
}

