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
    public partial class FrmGererVehicule : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmGererVehicule(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceVehicule.DataSource = mesDonneesEF.eleves.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmGererVehicule_Load(object sender, EventArgs e)
        {

        }
    }
}
