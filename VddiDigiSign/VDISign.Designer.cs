namespace VddiDigiSign
{
    partial class VDISign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSearchPad = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnLead = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtp = new System.Windows.Forms.TextBox();
            this.btnOtp = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPad
            // 
            this.btnSearchPad.Location = new System.Drawing.Point(1071, 72);
            this.btnSearchPad.Name = "btnSearchPad";
            this.btnSearchPad.Size = new System.Drawing.Size(273, 85);
            this.btnSearchPad.TabIndex = 0;
            this.btnSearchPad.Text = "Search for Pad";
            this.btnSearchPad.UseVisualStyleBackColor = true;
            this.btnSearchPad.Click += new System.EventHandler(this.btnSearchPad_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(1071, 189);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(273, 85);
            this.btnStartScan.TabIndex = 1;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnLead
            // 
            this.btnLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLead.Location = new System.Drawing.Point(478, 72);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(273, 85);
            this.btnLead.TabIndex = 2;
            this.btnLead.Text = "Search for Lead";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 470);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtLead
            // 
            this.txtLead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLead.Location = new System.Drawing.Point(151, 112);
            this.txtLead.Name = "txtLead";
            this.txtLead.Size = new System.Drawing.Size(267, 45);
            this.txtLead.TabIndex = 4;
            this.txtLead.TextChanged += new System.EventHandler(this.txtLead_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Lead No Below:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(1071, 311);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(273, 85);
            this.btnStopScan.TabIndex = 6;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1071, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 85);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter OTP No Below:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOtp
            // 
            this.txtOtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtp.Location = new System.Drawing.Point(151, 269);
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.Size = new System.Drawing.Size(267, 45);
            this.txtOtp.TabIndex = 8;
            // 
            // btnOtp
            // 
            this.btnOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtp.Location = new System.Drawing.Point(478, 249);
            this.btnOtp.Name = "btnOtp";
            this.btnOtp.Size = new System.Drawing.Size(273, 85);
            this.btnOtp.TabIndex = 10;
            this.btnOtp.Text = "Generate OTP";
            this.btnOtp.UseVisualStyleBackColor = true;
            // 
            // VDISign
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1798, 1032);
            this.Controls.Add(this.btnOtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOtp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStopScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.btnSearchPad);
            this.Name = "VDISign";
            this.Text = "VDI Scan ";
            this.Load += new System.EventHandler(this.VDISign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPad;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.Button btnOtp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}