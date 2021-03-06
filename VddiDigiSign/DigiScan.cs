﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace VddiDigiSign
{
    public partial class DigiScan : Form
    {
        bool initRes = sopadDLL.SOPAD_initialize();
        IntPtr pcert = Marshal.AllocHGlobal(256);
        IntPtr psettings = Marshal.AllocHGlobal(256);
        IntPtr padID = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PidType)));
        IntPtr timestamp = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GMTStamType)));
        Image thisFile;


        public DigiScan()
        {
            InitializeComponent();

            //  Create OnSignFinish Timer
            OnSignFinishedType myDelegate = new OnSignFinishedType(this.OnSignFinishedHandler);

            //  Set OnSignFinish Timer to 3000ms
            sopadDLL.SOPAD_SetDriverLong(5/*autoFinish*/, 3000);

            // Now you can pass that to the function that needs to call you back.
            sopadDLL.SOPAD_SetDriverLong(4/*OnSignFinishedHandler*/, Marshal.GetFunctionPointerForDelegate(myDelegate).ToInt32());


        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            Marshal.FreeHGlobal(pcert);
            Marshal.FreeHGlobal(psettings);
            Marshal.FreeHGlobal(padID);
            Marshal.FreeHGlobal(timestamp);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            //your code here...
        }

        public void OnSignFinishedHandler()
        {
            //do something
            // disable pen drawing
            sopadDLL.SOPAD_SetDriverLong(48, 0);

            // Stops SignMode
            sopadDLL.SOPAD_stopCapture(padID, timestamp);


            // get encrypted biodata as string
            IntPtr biodata = sopadDLL.SOPAD_GetBioDataString();

            // Convert the characters inside the buffer into a managed string.
            string strBio = Marshal.PtrToStringAnsi(biodata);

            // get final image
            int picsize = 0;
            IntPtr picture = sopadDLL.SOPAD_ReadHighResBitmap(0, ref picsize);
            if (picsize > 0)
            {
                byte[] managedArray = new byte[picsize];
                Marshal.Copy(picture, managedArray, 0, picsize);
                MemoryStream ms = new MemoryStream();
                ms.Write(managedArray, 0, Convert.ToInt32(managedArray.Length));
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.Refresh();
            }
        }


        private void btnSearchPad_Click(object sender, EventArgs e)
        {
            //  configure Pad
            bool x = sopadDLL.SOPAD_configurePad(pcert, true, true, true, psettings);
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            sopadDLL.SOPAD_SetDriverLong(59, 0);

            //  Start SignMode
            bool x = sopadDLL.SOPAD_startCapture(pcert, true, true, false, true, psettings);

            //  Enable Timer for Preview Image while signing
            if (x) timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int width = 400;
            int height = 300;

            int picsize = 0;

            //  Read Preview Image and update PictureBox while signing
            IntPtr picture = sopadDLL.SOPAD_ReadPreviewImage(0, width, height, ref picsize);
            if (picsize > 0)
            {
                byte[] managedArray = new byte[picsize];
                Marshal.Copy(picture, managedArray, 0, picsize);

                MemoryStream ms = new MemoryStream();
                ms.Write(managedArray, 0, Convert.ToInt32(managedArray.Length));
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.Refresh();

            }
        }

        private void btnLead_Click(object sender, EventArgs e)
        {

        }

        private void DigiScan_Load(object sender, EventArgs e)
        {
            VSLog vsLogger = new VSLog();
            vsLogger.WriteDebug("Loaded Scanning Page" + System.DateTime.Now.ToString());
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }

        private void txtLead_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            //  Disable SignMode (back to Standby Mode)
            //sopadDLL.SOPAD_stopCapture(padID, timestamp);
            updateDigiField("7712076024085", "WitnessName", "RiyaadaShdhhsd");
            updateDigiField("7712076024085", "ResidentInitial", "Kdfjiefdfkjsdkfjsdkjfk");

        }

        private void btnSaveScan_Click(object sender, EventArgs e)
        {
            thisFile = pictureBox1.Image;

            SaveFileDialog svF = new SaveFileDialog();
            svF.Filter = "JPG(*.JPG)|*.jpg";

            if (svF.ShowDialog() == DialogResult.OK)
            {
                thisFile.Save(svF.FileName);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
              

        protected override void SetClientSizeCore(int x, int y)
        {
            base.SetClientSizeCore(2132, 1263);
        }

        private void txtLead_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLead_Click_1(object sender, EventArgs e)
        {
            string thisCustomer = "Not Found";
            string customerId = "Not Found";

            customerId = txtLead.Text;

            Controllers.DigiSignOperations digiSig = new Controllers.DigiSignOperations();
            thisCustomer = digiSig.getCustomerName(customerId);
            lblCustomer.Text = thisCustomer;
            sendOtp(thisCustomer, customerId);

        }

        private int GenerateBaseInviteNo()
        {
            int _min = 10000;
            int _max = 99999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        public string GenerateSignCode(string custIdNo)
        {
            int inviteNo;
            string inviteCode = "";

            inviteNo = GenerateBaseInviteNo();

            inviteCode = inviteNo.ToString();

            //Wtite to DB

            return inviteCode;
        }

        public string getMobileNumber(string custIdNo)
        {
            string mobileNo  = "";

            var db = new PetaPoco.Database("Olgarsconnection");

            mobileNo = db.ExecuteScalar<string>("select isnull(Max(MobileNumber),'0834634921') as MobileNumber from [ApplicationLeads] where ResidentId = @0", custIdNo);

            mobileNo = "0834634921";

            return mobileNo;
        }

        public string getCustDigiFolder(string custIdNo)
        {
            string folderName = "";

            var db = new PetaPoco.Database("Olgarsconnection");

            folderName = db.ExecuteScalar<string>("select Max(ServerPath) as ServerPath from [DigiSignature] where [ResidentId] = @0", custIdNo);

            return folderName;
        }

        public int checkIfIdExists(string custIdNo)
        {
            int OwnershipStatus = 0;

            var db = new PetaPoco.Database("Olgarsconnection");

            OwnershipStatus = db.ExecuteScalar<int>("select count(*) from [DigiSignature] where [ResidentId] = @0  ", custIdNo);

            return OwnershipStatus;
        }

        public int deleteCustId(string custIdNo)
        {
            int IsUserOwner = 0;
            int tripLegDeleteId = 0;
            IsUserOwner = checkIfIdExists(custIdNo);
            if (IsUserOwner != 0)
            {
                var db = new PetaPoco.Database("Olgarsconnection");
                tripLegDeleteId = db.Execute("Delete [DigiSignature] Where ResidentId = @0", custIdNo);
            }
            else
            { tripLegDeleteId = -1; }

            return tripLegDeleteId;
        }

        public int updateDigiField(string custIdNo, string fieldName, string fieldValue)
        {
            int IsUserOwner = 0;
            int tripLegDeleteId = 0;
            IsUserOwner = checkIfIdExists(custIdNo);

            string sqlExec = "update DigiSignature set " + fieldName + "=@0 where ResidentId = @1";

            if (IsUserOwner != 0)
            {
                var db = new PetaPoco.Database("Olgarsconnection");
                tripLegDeleteId = db.Execute(sqlExec, fieldValue,custIdNo);
            }
            else
            { tripLegDeleteId = -1; }

            return tripLegDeleteId;
        }


        public string getCustOTP(string custIdNo)
        {
            string mobileNo = "";

            var db = new PetaPoco.Database("Olgarsconnection");

            mobileNo = db.ExecuteScalar<string>("select isnull(Max(MobileNumber),'0834634921') as MobileNumber from [ApplicationLeads] where ResidentId = @0", custIdNo);

            mobileNo = "0834634921";

            return mobileNo;
        }

        public string checkCustOTP(string custIdNo)
        {
            string mobileNo = "";

            var db = new PetaPoco.Database("Olgarsconnection");

            mobileNo = db.ExecuteScalar<string>("select isnull(Max([OtpNo]),'NotSetup') as OtpNo from [DigiSignature] where ResidentId = @0", custIdNo);

            return mobileNo;
        }


        private void sendOtp(string fullName,string custIdNo)
        {
            VSLog vsLogger = new VSLog();
            string response = "";
            string otpNo = "";

            otpNo = GenerateSignCode(custIdNo);

            Controllers.SMSMessageOperations smsOps = new Controllers.SMSMessageOperations();
            Models.SMSObj smsObj = new Models.SMSObj();

            vsLogger.WriteDebug("Inside SMS Code ");

            smsObj.messageText = "You about to sign a document please provide this ICARS Signing Security OTP " + otpNo + " to the Sales Team Member";
            smsObj.toNumber = getMobileNumber(custIdNo);   // "0834634921";
            //smsObj.toNumber = "0799425095";
            smsObj.olgarsUser = "Signing OTP Notice";
            smsObj.toUser = fullName;

            smsObj.olgarsEmail = fullName;


            response = smsOps.sendManualSMSMessage(smsObj, "3", 2);

            //Add the to the DB the OTP
            Models.DigiSignature thisDigiSign = new Models.DigiSignature();

            thisDigiSign.DateAdded = DateTime.Now;
            thisDigiSign.AddedBy = fullName;
            thisDigiSign.ResidentId = custIdNo;
            thisDigiSign.ResidentInitial = "NotSetup";
            thisDigiSign.ResidentSignature = "NotSetup";
            thisDigiSign.SalesInitial = "NotSetup";
            thisDigiSign.SalesSignature = "NotSetup";
            thisDigiSign.WitnessInitial = "NotSetup";
            thisDigiSign.WitnessName = "NotSetup";
            thisDigiSign.WitnessSignature = "NotSetup";
            thisDigiSign.OtpNo = otpNo;
            thisDigiSign.ServerPath = GenerateFileName();

            //Remove whatever Signature is there
            //Always a unique combination
            //Need to delete the files as well at some point
            deleteCustId(custIdNo);

            int thiSigId = addSig(thisDigiSign);



        }


        public string GenerateFileName()
        {
            return  DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + Guid.NewGuid().ToString("N");
        }

        public int addSig(Models.DigiSignature currentSig)
        {
            int StatusId = -1;
            
            var db = new PetaPoco.Database("Olgarsconnection");

            try
            {
                db.Insert("DigiSignature", "DigiSignatureId", true, currentSig);
                StatusId = currentSig.DigiSignatureId;
            }
            catch (Exception ex)
            {
                string errMessage = "";
                errMessage = ex.Message.ToString();
            }

            return StatusId;
        }

        private void enableButtons(string custIdNo)
        {
            VSLog vsLogger = new VSLog();
            vsLogger.WriteDebug("Enabling Buttons for ID No" + custIdNo);
            btnSearchPad.Visible = true;
            btnStartScan.Visible = true;
            btnStopScan.Visible = true;
            btnSaveScan.Visible = true;
        }

        private void disableButtons(string custIdNo)
        {
            VSLog vsLogger = new VSLog();
            vsLogger.WriteDebug("Disabling Buttons for ID No" + custIdNo);
            btnSearchPad.Visible = false;
            btnStartScan.Visible = false;
            btnStopScan.Visible = false;
            btnSaveScan.Visible = false;
        }

        private void btnOtp_Click(object sender, EventArgs e)
        {
            string otpText = "";
            string otpCheck = "NotSetup";
            string custIdNo = "";

            otpText = txtOtp.Text;
            custIdNo = txtLead.Text;

            //If OTP equals what is on the DB then enable all the buttons
            otpCheck = checkCustOTP(custIdNo);

            if (otpCheck == otpText)
            {
                //Enable
                enableButtons(custIdNo);
            }
            else
            {
                lblError.Text = "Please verify the OTP";
                disableButtons(custIdNo);
            }



        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Witness Initial" || comboBox1.Text == "Witness Signature")
            {
                txtWitness.Visible = true;
                lblWitness.Visible = true;
            }
            else
            {
                txtWitness.Visible = false;
                lblWitness.Visible = false;
            }
        }
    }
}
