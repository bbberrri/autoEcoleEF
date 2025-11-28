using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
