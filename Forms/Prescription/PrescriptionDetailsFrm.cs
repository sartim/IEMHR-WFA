using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEMHR_WFA.Forms.Prescription
{
    public partial class PrescriptionDetailsFrm : Form
    {
        public PrescriptionDetailsFrm()
        {
            InitializeComponent();
        }

        private void prescriptionMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prescriptionMasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iEMHR_DB_DataSet);

        }

        private void Prescription_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iEMHR_DB_DataSet.PrescriptionMaster' table. You can move, or remove it, as needed.
            this.prescriptionMasterTableAdapter.Fill(this.iEMHR_DB_DataSet.PrescriptionMaster);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
