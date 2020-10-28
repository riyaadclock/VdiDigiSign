namespace VddiDigiSign
{
    partial class DigiScan
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
            this.btnOtp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtp = new System.Windows.Forms.TextBox();
            this.btnSaveScan = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLead = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLead = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnSearchPad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblWitness = new System.Windows.Forms.Label();
            this.txtWitness = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtp
            // 
            this.btnOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtp.Location = new System.Drawing.Point(296, 137);
            this.btnOtp.Margin = new System.Windows.Forms.Padding(1);
            this.btnOtp.Name = "btnOtp";
            this.btnOtp.Size = new System.Drawing.Size(102, 36);
            this.btnOtp.TabIndex = 24;
            this.btnOtp.Text = "Confirm OTP";
            this.btnOtp.UseVisualStyleBackColor = true;
            this.btnOtp.Click += new System.EventHandler(this.btnOtp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter OTP No Below:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOtp
            // 
            this.txtOtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtp.Location = new System.Drawing.Point(58, 152);
            this.txtOtp.Margin = new System.Windows.Forms.Padding(1);
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.Size = new System.Drawing.Size(221, 22);
            this.txtOtp.TabIndex = 22;
            this.txtOtp.TextChanged += new System.EventHandler(this.txtOtp_TextChanged);
            // 
            // btnSaveScan
            // 
            this.btnSaveScan.Location = new System.Drawing.Point(516, 187);
            this.btnSaveScan.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveScan.Name = "btnSaveScan";
            this.btnSaveScan.Size = new System.Drawing.Size(102, 36);
            this.btnSaveScan.TabIndex = 21;
            this.btnSaveScan.Tag = "";
            this.btnSaveScan.Text = "Save Scan";
            this.btnSaveScan.UseVisualStyleBackColor = true;
            this.btnSaveScan.Visible = false;
            this.btnSaveScan.Click += new System.EventHandler(this.btnSaveScan_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(516, 135);
            this.btnStopScan.Margin = new System.Windows.Forms.Padding(1);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(102, 36);
            this.btnStopScan.TabIndex = 20;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Visible = false;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Customer ID No Below:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLead
            // 
            this.txtLead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLead.Location = new System.Drawing.Point(58, 52);
            this.txtLead.Margin = new System.Windows.Forms.Padding(1);
            this.txtLead.Name = "txtLead";
            this.txtLead.Size = new System.Drawing.Size(221, 22);
            this.txtLead.TabIndex = 18;
            this.txtLead.TextChanged += new System.EventHandler(this.txtLead_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 281);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 176);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLead
            // 
            this.btnLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLead.Location = new System.Drawing.Point(296, 40);
            this.btnLead.Margin = new System.Windows.Forms.Padding(1);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(102, 36);
            this.btnLead.TabIndex = 16;
            this.btnLead.Text = "Search";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click_1);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(516, 84);
            this.btnStartScan.Margin = new System.Windows.Forms.Padding(1);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(102, 36);
            this.btnStartScan.TabIndex = 15;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Visible = false;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnSearchPad
            // 
            this.btnSearchPad.Location = new System.Drawing.Point(516, 35);
            this.btnSearchPad.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearchPad.Name = "btnSearchPad";
            this.btnSearchPad.Size = new System.Drawing.Size(102, 36);
            this.btnSearchPad.TabIndex = 14;
            this.btnSearchPad.Text = "Search for Pad";
            this.btnSearchPad.UseVisualStyleBackColor = true;
            this.btnSearchPad.Visible = false;
            this.btnSearchPad.Click += new System.EventHandler(this.btnSearchPad_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer Initial",
            "Customer Signature",
            "SalesPerson Initial",
            "SalesPerson Signature",
            "Witness Initial",
            "Witness Signature"});
            this.comboBox1.Location = new System.Drawing.Point(202, 182);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select Scan Mode:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustomer.Location = new System.Drawing.Point(59, 84);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(14, 16);
            this.lblCustomer.TabIndex = 27;
            this.lblCustomer.Text = "..";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(59, 104);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(14, 16);
            this.lblError.TabIndex = 28;
            this.lblError.Text = "..";
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // lblWitness
            // 
            this.lblWitness.AutoSize = true;
            this.lblWitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWitness.Location = new System.Drawing.Point(56, 218);
            this.lblWitness.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWitness.Name = "lblWitness";
            this.lblWitness.Size = new System.Drawing.Size(164, 13);
            this.lblWitness.TabIndex = 29;
            this.lblWitness.Text = "Enter Witness Name Below:";
            this.lblWitness.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtWitness
            // 
            this.txtWitness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWitness.Location = new System.Drawing.Point(58, 232);
            this.txtWitness.Margin = new System.Windows.Forms.Padding(1);
            this.txtWitness.Name = "txtWitness";
            this.txtWitness.Size = new System.Drawing.Size(340, 22);
            this.txtWitness.TabIndex = 30;
            // 
            // DigiScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 314);
            this.Controls.Add(this.txtWitness);
            this.Controls.Add(this.lblWitness);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnOtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOtp);
            this.Controls.Add(this.btnSaveScan);
            this.Controls.Add(this.btnStopScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.btnSearchPad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DigiScan";
            this.Text = "DigiScan";
            this.Load += new System.EventHandler(this.DigiScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.Button btnSaveScan;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnSearchPad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblWitness;
        private System.Windows.Forms.TextBox txtWitness;
    }
}