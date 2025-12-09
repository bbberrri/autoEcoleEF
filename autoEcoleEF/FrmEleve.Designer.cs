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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGererEleve));
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
            this.bdgNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tsbEnregistrer = new System.Windows.Forms.ToolStripButton();
            this.bdgSourceEleve = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgNav)).BeginInit();
            this.bdgNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).BeginInit();
            this.SuspendLayout();
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
            this.txtNum.ReadOnly = true;
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
            // bdgNav
            // 
            this.bdgNav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdgNav.BindingSource = this.bdgSourceEleve;
            this.bdgNav.CountItem = this.bindingNavigatorCountItem;
            this.bdgNav.DeleteItem = null;
            this.bdgNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tsbEnregistrer});
            this.bdgNav.Location = new System.Drawing.Point(0, 0);
            this.bdgNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgNav.Name = "bdgNav";
            this.bdgNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgNav.Size = new System.Drawing.Size(351, 25);
            this.bdgNav.TabIndex = 16;
            this.bdgNav.Text = "bindingNavigator1";
            this.bdgNav.RefreshItems += new System.EventHandler(this.bdgNav_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tsbEnregistrer
            // 
            this.tsbEnregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("tsbEnregistrer.Image")));
            this.tsbEnregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEnregistrer.Name = "tsbEnregistrer";
            this.tsbEnregistrer.Size = new System.Drawing.Size(23, 22);
            this.tsbEnregistrer.Text = "Enregistrer";
            this.tsbEnregistrer.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.Controls.Add(this.bdgNav);
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
            this.Name = "FrmGererEleve";
            this.Text = "Gestion des élèves";
            this.Load += new System.EventHandler(this.FrmGererEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgNav)).EndInit();
            this.bdgNav.ResumeLayout(false);
            this.bdgNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.BindingNavigator bdgNav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEnregistrer;
    }
}