using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VddiDigiSign
{
    public partial class DigiSignLogon : Form
    {
        public DigiSignLogon()
        {
            InitializeComponent();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            this.Hide();
            //VDISign frmScan = new VDISign();
            DigiScan frmScan = new DigiScan();
            frmScan.ShowDialog();
            this.Close();
        }
    }
}
