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

        private void DigiSignLogon_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;

        }


        protected override void SetClientSizeCore(int x, int y)
        {
            base.SetClientSizeCore(3237, 3249);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
