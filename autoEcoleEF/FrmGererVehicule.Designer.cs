namespace autoEcoleEF
{
    partial class FrmGererVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGererVehicule));
            this.bdgNavVehicule = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.chbTrue = new System.Windows.Forms.CheckBox();
            this.radioTrue = new System.Windows.Forms.RadioButton();
            this.bdgSourceVehicule = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgNavVehicule)).BeginInit();
            this.bdgNavVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // bdgNavVehicule
            // 
            this.bdgNavVehicule.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdgNavVehicule.CountItem = this.bindingNavigatorCountItem;
            this.bdgNavVehicule.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdgNavVehicule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bdgNavVehicule.Location = new System.Drawing.Point(0, 0);
            this.bdgNavVehicule.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgNavVehicule.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgNavVehicule.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgNavVehicule.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgNavVehicule.Name = "bdgNavVehicule";
            this.bdgNavVehicule.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgNavVehicule.Size = new System.Drawing.Size(291, 25);
            this.bdgNavVehicule.TabIndex = 0;
            this.bdgNavVehicule.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(46, 68);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numéro";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(46, 106);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(42, 13);
            this.lblModele.TabIndex = 2;
            this.lblModele.Text = "Modèle";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(46, 147);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(43, 13);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "Couleur";
            this.lblCouleur.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtModele
            // 
            this.txtModele.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVehicule, "modele", true));
            this.txtModele.Location = new System.Drawing.Point(112, 103);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(100, 20);
            this.txtModele.TabIndex = 4;
            // 
            // txtCouleur
            // 
            this.txtCouleur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVehicule, "modele", true));
            this.txtCouleur.Location = new System.Drawing.Point(112, 144);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(100, 20);
            this.txtCouleur.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVehicule, "numImma", true));
            this.txtNumero.Location = new System.Drawing.Point(112, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // chbTrue
            // 
            this.chbTrue.AutoSize = true;
            this.chbTrue.Location = new System.Drawing.Point(65, 186);
            this.chbTrue.Name = "chbTrue";
            this.chbTrue.Size = new System.Drawing.Size(48, 17);
            this.chbTrue.TabIndex = 7;
            this.chbTrue.Text = "True";
            this.chbTrue.UseVisualStyleBackColor = true;
            // 
            // radioTrue
            // 
            this.radioTrue.AutoSize = true;
            this.radioTrue.Location = new System.Drawing.Point(190, 186);
            this.radioTrue.Name = "radioTrue";
            this.radioTrue.Size = new System.Drawing.Size(47, 17);
            this.radioTrue.TabIndex = 8;
            this.radioTrue.TabStop = true;
            this.radioTrue.Text = "True";
            this.radioTrue.UseVisualStyleBackColor = true;
            // 
            // bdgSourceVehicule
            // 
            this.bdgSourceVehicule.DataSource = typeof(autoEcoleEF.vehicule);
            // 
            // FrmGererVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 231);
            this.Controls.Add(this.radioTrue);
            this.Controls.Add(this.chbTrue);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.bdgNavVehicule);
            this.Name = "FrmGererVehicule";
            this.Text = "FrmGererVehicule";
            this.Load += new System.EventHandler(this.FrmGererVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgNavVehicule)).EndInit();
            this.bdgNavVehicule.ResumeLayout(false);
            this.bdgNavVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVehicule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bdgNavVehicule;
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
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.CheckBox chbTrue;
        private System.Windows.Forms.RadioButton radioTrue;
        private System.Windows.Forms.BindingSource bdgSourceVehicule;
    }
}