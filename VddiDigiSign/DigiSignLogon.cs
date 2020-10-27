using System;
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
           

            Models.CurrentUser PresentUser = new Models.CurrentUser();
            Controllers.UserOperations userOps = new Controllers.UserOperations();

            

            if (string.IsNullOrWhiteSpace(txtUser.Text) == true | string.IsNullOrWhiteSpace(txtPwd.Text) == true)
            {
                lblError.Text = "Incorrect User Information";
            }
            else
            {

                int userstatus = userOps.checkUserCreds(txtUser.Text, txtPwd.Text);

                if (userstatus > 0)
                {
                    lblError.Text = "Correct User Information All Good";
                    this.Hide();
                    DigiScan frmScan = new DigiScan();
                    frmScan.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblError.Text = "Incorrect User Credentials";
                }


             }



            }

        private void DigiSignLogon_Load(object sender, EventArgs e)
        {
            VSLog vsLogger = new VSLog();
            vsLogger.WriteDebug("Starting VDI Logon" + System.DateTime.Now.ToString());

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
