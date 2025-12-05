using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmGererEleve : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmGererEleve(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                this.cmbCredit.Items.Add(i);
            }
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceEleve.DataSource = mesDonneesEF.eleves.ToList();
        }

        private int getNumEleve()
        {
            var reqDernier = (from el in this.mesDonneesEF.eleves
                              orderby el.id descending
                              select el);
            eleve dernierEleve = reqDernier.First();
            int n = dernierEleve.id + 1;
            return n;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNum.Text = this.getNumEleve().ToString();
        }

        private eleve newEleve()
        {
            eleve newEleve = new eleve();
            newEleve.id = Convert.ToInt16(txtNum.Text);
            newEleve.nom = txtNom.Text;
            newEleve.prenom = txtPrenom.Text;
            newEleve.adresse = txtAdresse.Text;
            newEleve.dateInscription = dtInscription.Value;
            return newEleve;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            try
            {
                this.mesDonneesEF.eleves.Add(newEleve());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement validé");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bdgNav_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new autoecoleEntities())
            {
                var idASupprimer = Convert.ToInt16(txtNum.Text);
                var entiteASupprimer = context.eleves.FirstOrDefault(el
                                                                    => el.id
                                                                    == idASupprimer);
                if (entiteASupprimer != null)
                {
                    context.eleves.Remove(entiteASupprimer);
                    context.SaveChanges();
                    bdgSourceEleve.RemoveCurrent();
                    MessageBox.Show("Enregistrement supprimé");
                }
            }
        }
    }
}
