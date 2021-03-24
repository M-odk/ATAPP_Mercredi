
namespace test_transposer
{
    partial class frmMain
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
            this.cmbTonaliteDepart = new System.Windows.Forms.ComboBox();
            this.cmbTonaliteTransposee = new System.Windows.Forms.ComboBox();
            this.lblNotesDepart = new System.Windows.Forms.Label();
            this.lblNotesTransposee = new System.Windows.Forms.Label();
            this.tbxNotesPartition = new System.Windows.Forms.TextBox();
            this.tbxResultDepart = new System.Windows.Forms.TextBox();
            this.tbxResultTransposee = new System.Windows.Forms.TextBox();
            this.btnTransposer = new System.Windows.Forms.Button();
            this.lblEntry = new System.Windows.Forms.Label();
            this.ckbMineur = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbTonaliteDepart
            // 
            this.cmbTonaliteDepart.FormattingEnabled = true;
            this.cmbTonaliteDepart.Location = new System.Drawing.Point(87, 215);
            this.cmbTonaliteDepart.Name = "cmbTonaliteDepart";
            this.cmbTonaliteDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbTonaliteDepart.TabIndex = 0;
            this.cmbTonaliteDepart.Text = "Partir de :";
            // 
            // cmbTonaliteTransposee
            // 
            this.cmbTonaliteTransposee.FormattingEnabled = true;
            this.cmbTonaliteTransposee.Location = new System.Drawing.Point(312, 215);
            this.cmbTonaliteTransposee.Name = "cmbTonaliteTransposee";
            this.cmbTonaliteTransposee.Size = new System.Drawing.Size(121, 21);
            this.cmbTonaliteTransposee.TabIndex = 1;
            this.cmbTonaliteTransposee.Text = "Transposer en : ";
            // 
            // lblNotesDepart
            // 
            this.lblNotesDepart.AutoSize = true;
            this.lblNotesDepart.Location = new System.Drawing.Point(84, 334);
            this.lblNotesDepart.Name = "lblNotesDepart";
            this.lblNotesDepart.Size = new System.Drawing.Size(92, 13);
            this.lblNotesDepart.TabIndex = 2;
            this.lblNotesDepart.Text = "Notes de départ : ";
            // 
            // lblNotesTransposee
            // 
            this.lblNotesTransposee.AutoSize = true;
            this.lblNotesTransposee.Location = new System.Drawing.Point(84, 473);
            this.lblNotesTransposee.Name = "lblNotesTransposee";
            this.lblNotesTransposee.Size = new System.Drawing.Size(95, 13);
            this.lblNotesTransposee.TabIndex = 3;
            this.lblNotesTransposee.Text = "Notes transposées";
            // 
            // tbxNotesPartition
            // 
            this.tbxNotesPartition.ForeColor = System.Drawing.Color.Black;
            this.tbxNotesPartition.Location = new System.Drawing.Point(87, 74);
            this.tbxNotesPartition.Multiline = true;
            this.tbxNotesPartition.Name = "tbxNotesPartition";
            this.tbxNotesPartition.Size = new System.Drawing.Size(346, 41);
            this.tbxNotesPartition.TabIndex = 4;
            // 
            // tbxResultDepart
            // 
            this.tbxResultDepart.Location = new System.Drawing.Point(87, 361);
            this.tbxResultDepart.Multiline = true;
            this.tbxResultDepart.Name = "tbxResultDepart";
            this.tbxResultDepart.ReadOnly = true;
            this.tbxResultDepart.Size = new System.Drawing.Size(346, 67);
            this.tbxResultDepart.TabIndex = 5;
            // 
            // tbxResultTransposee
            // 
            this.tbxResultTransposee.Location = new System.Drawing.Point(87, 498);
            this.tbxResultTransposee.Multiline = true;
            this.tbxResultTransposee.Name = "tbxResultTransposee";
            this.tbxResultTransposee.ReadOnly = true;
            this.tbxResultTransposee.Size = new System.Drawing.Size(346, 67);
            this.tbxResultTransposee.TabIndex = 6;
            // 
            // btnTransposer
            // 
            this.btnTransposer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTransposer.Location = new System.Drawing.Point(201, 627);
            this.btnTransposer.Name = "btnTransposer";
            this.btnTransposer.Size = new System.Drawing.Size(127, 62);
            this.btnTransposer.TabIndex = 7;
            this.btnTransposer.Text = "Changer de tonalité";
            this.btnTransposer.UseVisualStyleBackColor = false;
            this.btnTransposer.Click += new System.EventHandler(this.btnTransposer_Click);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(55, 51);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(416, 16);
            this.lblEntry.TabIndex = 8;
            this.lblEntry.Text = "Entrez les notes que vous voulez transposer. Ex : Do Re Mi";
            // 
            // ckbMineur
            // 
            this.ckbMineur.AutoSize = true;
            this.ckbMineur.Location = new System.Drawing.Point(223, 151);
            this.ckbMineur.Name = "ckbMineur";
            this.ckbMineur.Size = new System.Drawing.Size(105, 17);
            this.ckbMineur.TabIndex = 10;
            this.ckbMineur.Text = "Tonalité Mineure";
            this.ckbMineur.UseVisualStyleBackColor = true;
            this.ckbMineur.CheckedChanged += new System.EventHandler(this.ckbMineur_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(532, 721);
            this.Controls.Add(this.ckbMineur);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.btnTransposer);
            this.Controls.Add(this.tbxResultTransposee);
            this.Controls.Add(this.tbxResultDepart);
            this.Controls.Add(this.tbxNotesPartition);
            this.Controls.Add(this.lblNotesTransposee);
            this.Controls.Add(this.lblNotesDepart);
            this.Controls.Add(this.cmbTonaliteTransposee);
            this.Controls.Add(this.cmbTonaliteDepart);
            this.Name = "frmMain";
            this.Text = "transposer clé et tonalité";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTonaliteDepart;
        private System.Windows.Forms.ComboBox cmbTonaliteTransposee;
        private System.Windows.Forms.Label lblNotesDepart;
        private System.Windows.Forms.Label lblNotesTransposee;
        private System.Windows.Forms.TextBox tbxNotesPartition;
        private System.Windows.Forms.TextBox tbxResultDepart;
        private System.Windows.Forms.TextBox tbxResultTransposee;
        private System.Windows.Forms.Button btnTransposer;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.CheckBox ckbMineur;
    }
}

