using IEMHR_WFA.Forms.Prescription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEMHR_WFA
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void PrescriptionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrescriptionDetailsFrm f = new PrescriptionDetailsFrm();
            f.MdiParent = this; 
            f.Show();
        }
    }
}
