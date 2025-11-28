namespace autoEcoleEF
{
    partial class FrmGererEleve
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.dtInscription = new System.Windows.Forms.DateTimePicker();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblCreditHoraire = new System.Windows.Forms.Label();
            this.lblDateInscription = new System.Windows.Forms.Label();
            this.cmbCredit = new System.Windows.Forms.ComboBox();
            this.bdgSourceEleve = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(351, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 38);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numéro";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNum
            // 
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "id", true));
            this.txtNum.Location = new System.Drawing.Point(105, 35);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "nom", true));
            this.txtNom.Location = new System.Drawing.Point(105, 70);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(105, 109);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "adresse", true));
            this.txtAdresse.Location = new System.Drawing.Point(105, 148);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 8;
            // 
            // dtInscription
            // 
            this.dtInscription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "dateInscription", true));
            this.dtInscription.Location = new System.Drawing.Point(105, 188);
            this.dtInscription.Name = "dtInscription";
            this.dtInscription.Size = new System.Drawing.Size(200, 20);
            this.dtInscription.TabIndex = 9;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 73);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(12, 151);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 11;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 112);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 12;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblCreditHoraire
            // 
            this.lblCreditHoraire.AutoSize = true;
            this.lblCreditHoraire.Location = new System.Drawing.Point(12, 229);
            this.lblCreditHoraire.Name = "lblCreditHoraire";
            this.lblCreditHoraire.Size = new System.Drawing.Size(69, 13);
            this.lblCreditHoraire.TabIndex = 13;
            this.lblCreditHoraire.Text = "Crédit horaire";
            // 
            // lblDateInscription
            // 
            this.lblDateInscription.AutoSize = true;
            this.lblDateInscription.Location = new System.Drawing.Point(12, 194);
            this.lblDateInscription.Name = "lblDateInscription";
            this.lblDateInscription.Size = new System.Drawing.Size(88, 13);
            this.lblDateInscription.TabIndex = 14;
            this.lblDateInscription.Text = "Date d\'inscription";
            // 
            // cmbCredit
            // 
            this.cmbCredit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "creditHoraire", true));
            this.cmbCredit.FormattingEnabled = true;
            this.cmbCredit.Location = new System.Drawing.Point(105, 226);
            this.cmbCredit.Name = "cmbCredit";
            this.cmbCredit.Size = new System.Drawing.Size(121, 21);
            this.cmbCredit.TabIndex = 15;
            // 
            // bdgSourceEleve
            // 
            this.bdgSourceEleve.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // FrmGererEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 270);
            this.Controls.Add(this.cmbCredit);
            this.Controls.Add(this.lblDateInscription);
            this.Controls.Add(this.lblCreditHoraire);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dtInscription);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmGererEleve";
            this.Text = "Gestion des élèves";
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.DateTimePicker dtInscription;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblCreditHoraire;
        private System.Windows.Forms.Label lblDateInscription;
        private System.Windows.Forms.ComboBox cmbCredit;
        private System.Windows.Forms.BindingSource bdgSourceEleve;
    }
}