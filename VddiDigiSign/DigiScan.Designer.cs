﻿namespace VddiDigiSign
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
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtp
            // 
            this.btnOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtp.Location = new System.Drawing.Point(570, 290);
            this.btnOtp.Name = "btnOtp";
            this.btnOtp.Size = new System.Drawing.Size(273, 85);
            this.btnOtp.TabIndex = 24;
            this.btnOtp.Text = "Generate OTP";
            this.btnOtp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter OTP No Below:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOtp
            // 
            this.txtOtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtp.Location = new System.Drawing.Point(154, 281);
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.Size = new System.Drawing.Size(267, 45);
            this.txtOtp.TabIndex = 22;
            this.txtOtp.TextChanged += new System.EventHandler(this.txtOtp_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1377, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 85);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(1377, 323);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(273, 85);
            this.btnStopScan.TabIndex = 20;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Lead No Below:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLead
            // 
            this.txtLead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLead.Location = new System.Drawing.Point(154, 124);
            this.txtLead.Name = "txtLead";
            this.txtLead.Size = new System.Drawing.Size(267, 45);
            this.txtLead.TabIndex = 18;
            this.txtLead.TextChanged += new System.EventHandler(this.txtLead_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 517);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLead
            // 
            this.btnLead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLead.Location = new System.Drawing.Point(570, 113);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(273, 85);
            this.btnLead.TabIndex = 16;
            this.btnLead.Text = "Search for Lead";
            this.btnLead.UseVisualStyleBackColor = true;
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(1377, 201);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(273, 85);
            this.btnStartScan.TabIndex = 15;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnSearchPad
            // 
            this.btnSearchPad.Location = new System.Drawing.Point(1377, 84);
            this.btnSearchPad.Name = "btnSearchPad";
            this.btnSearchPad.Size = new System.Drawing.Size(273, 85);
            this.btnSearchPad.TabIndex = 14;
            this.btnSearchPad.Text = "Search for Pad";
            this.btnSearchPad.UseVisualStyleBackColor = true;
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
            "SalesPerson Signature"});
            this.comboBox1.Location = new System.Drawing.Point(452, 447);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(396, 39);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select Scan Mode:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DigiScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2100, 1175);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Button button1;
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
    }
}