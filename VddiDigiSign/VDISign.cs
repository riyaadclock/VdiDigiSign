using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;



namespace VddiDigiSign
{
    public partial class VDISign : Form
    {

        bool initRes = sopadDLL.SOPAD_initialize();
        IntPtr pcert = Marshal.AllocHGlobal(256);
        IntPtr psettings = Marshal.AllocHGlobal(256);
        IntPtr padID = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(PidType)));
        IntPtr timestamp = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GMTStamType)));
        Image thisFile;


        public VDISign()
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

        }

        private void btnLead_Click(object sender, EventArgs e)
        {

        }

        private void VDISign_Load(object sender, EventArgs e)
        {

        }

        private void txtLead_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
