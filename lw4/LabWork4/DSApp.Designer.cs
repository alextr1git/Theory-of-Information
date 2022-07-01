namespace LabWork4
{
    partial class DSApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbKc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.bFileChoose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bSign = new System.Windows.Forms.Button();
            this.tbDS = new System.Windows.Forms.TextBox();
            this.tbHIM = new System.Windows.Forms.TextBox();
            this.tbCHI = new System.Windows.Forms.TextBox();
            this.tbHI = new System.Windows.Forms.TextBox();
            this.tbOK = new System.Windows.Forms.TextBox();
            this.tbcheckfile = new System.Windows.Forms.TextBox();
            this.bCheckSign = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFpath = new System.Windows.Forms.TextBox();
            this.bSaveFile = new System.Windows.Forms.Button();
            this.sfdSignFile = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdCheckFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(168, 71);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(273, 31);
            this.tbP.TabIndex = 0;
            this.tbP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbP_KeyPress);
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(168, 128);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(273, 31);
            this.tbQ.TabIndex = 1;
            this.tbQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQ_KeyPress);
            // 
            // tbKc
            // 
            this.tbKc.Location = new System.Drawing.Point(168, 202);
            this.tbKc.Name = "tbKc";
            this.tbKc.Size = new System.Drawing.Size(273, 31);
            this.tbKc.TabIndex = 2;
            this.tbKc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Closed Key (Kc)";
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // bFileChoose
            // 
            this.bFileChoose.Location = new System.Drawing.Point(649, 69);
            this.bFileChoose.Name = "bFileChoose";
            this.bFileChoose.Size = new System.Drawing.Size(112, 34);
            this.bFileChoose.TabIndex = 6;
            this.bFileChoose.Text = "Choose File";
            this.bFileChoose.UseVisualStyleBackColor = true;
            this.bFileChoose.Click += new System.EventHandler(this.bFileChoose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "File";
            // 
            // tbSFile
            // 
            this.tbSFile.Location = new System.Drawing.Point(788, 128);
            this.tbSFile.Name = "tbSFile";
            this.tbSFile.ReadOnly = true;
            this.tbSFile.Size = new System.Drawing.Size(222, 31);
            this.tbSFile.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Signed File Path";
            // 
            // bSign
            // 
            this.bSign.Location = new System.Drawing.Point(493, 190);
            this.bSign.Name = "bSign";
            this.bSign.Size = new System.Drawing.Size(517, 55);
            this.bSign.TabIndex = 10;
            this.bSign.Tag = "";
            this.bSign.Text = "Sign";
            this.bSign.UseVisualStyleBackColor = true;
            this.bSign.Click += new System.EventHandler(this.bSign_Click);
            // 
            // tbDS
            // 
            this.tbDS.Location = new System.Drawing.Point(725, 355);
            this.tbDS.Name = "tbDS";
            this.tbDS.Size = new System.Drawing.Size(273, 31);
            this.tbDS.TabIndex = 11;
            this.tbDS.TextChanged += new System.EventHandler(this.tbDS_TextChanged);
            this.tbDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDS_KeyPress);
            // 
            // tbHIM
            // 
            this.tbHIM.Location = new System.Drawing.Point(725, 546);
            this.tbHIM.Name = "tbHIM";
            this.tbHIM.Size = new System.Drawing.Size(273, 31);
            this.tbHIM.TabIndex = 12;
            this.tbHIM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHIM_KeyPress);
            // 
            // tbCHI
            // 
            this.tbCHI.Location = new System.Drawing.Point(725, 626);
            this.tbCHI.Name = "tbCHI";
            this.tbCHI.Size = new System.Drawing.Size(273, 31);
            this.tbCHI.TabIndex = 14;
            this.tbCHI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCHI_KeyPress);
            // 
            // tbHI
            // 
            this.tbHI.Location = new System.Drawing.Point(725, 481);
            this.tbHI.Name = "tbHI";
            this.tbHI.Size = new System.Drawing.Size(273, 31);
            this.tbHI.TabIndex = 13;
            this.tbHI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHI_KeyPress);
            // 
            // tbOK
            // 
            this.tbOK.Location = new System.Drawing.Point(725, 413);
            this.tbOK.Name = "tbOK";
            this.tbOK.Size = new System.Drawing.Size(273, 31);
            this.tbOK.TabIndex = 15;
            this.tbOK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOK_KeyPress);
            // 
            // tbcheckfile
            // 
            this.tbcheckfile.Location = new System.Drawing.Point(284, 413);
            this.tbcheckfile.Name = "tbcheckfile";
            this.tbcheckfile.ReadOnly = true;
            this.tbcheckfile.Size = new System.Drawing.Size(192, 31);
            this.tbcheckfile.TabIndex = 16;
            // 
            // bCheckSign
            // 
            this.bCheckSign.Location = new System.Drawing.Point(12, 469);
            this.bCheckSign.Name = "bCheckSign";
            this.bCheckSign.Size = new System.Drawing.Size(464, 55);
            this.bCheckSign.TabIndex = 17;
            this.bCheckSign.Text = "Check Digital Sign";
            this.bCheckSign.UseVisualStyleBackColor = true;
            this.bCheckSign.Click += new System.EventHandler(this.bCheckSign_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "File to check";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hash Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Digital Signature";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Open Key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hash image (M\')";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 626);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Calculated Hash Image";
            // 
            // tbFpath
            // 
            this.tbFpath.Location = new System.Drawing.Point(788, 68);
            this.tbFpath.Name = "tbFpath";
            this.tbFpath.ReadOnly = true;
            this.tbFpath.Size = new System.Drawing.Size(222, 31);
            this.tbFpath.TabIndex = 24;
            // 
            // bSaveFile
            // 
            this.bSaveFile.Location = new System.Drawing.Point(649, 129);
            this.bSaveFile.Name = "bSaveFile";
            this.bSaveFile.Size = new System.Drawing.Size(112, 34);
            this.bSaveFile.TabIndex = 25;
            this.bSaveFile.Text = "Choose File";
            this.bSaveFile.UseVisualStyleBackColor = true;
            this.bSaveFile.Click += new System.EventHandler(this.bSaveFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdCheckFile
            // 
            this.ofdCheckFile.FileName = "openFileDialog1";
            // 
            // DSApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 743);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bSaveFile);
            this.Controls.Add(this.tbFpath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bCheckSign);
            this.Controls.Add(this.tbcheckfile);
            this.Controls.Add(this.tbOK);
            this.Controls.Add(this.tbCHI);
            this.Controls.Add(this.tbHI);
            this.Controls.Add(this.tbHIM);
            this.Controls.Add(this.tbDS);
            this.Controls.Add(this.bSign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bFileChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKc);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.tbP);
            this.MaximizeBox = false;
            this.Name = "DSApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbP;
        private TextBox tbQ;
        private TextBox tbKc;
        private Label label1;
        private Label label2;
        private Label label3;
        private OpenFileDialog ofdOpenFile;
        private Button bFileChoose;
        private Label label4;
        private TextBox tbSFile;
        private Label label5;
        private Button bSign;
        private TextBox tbDS;
        private TextBox tbHIM;
        private TextBox tbCHI;
        private TextBox tbHI;
        private TextBox tbOK;
        private TextBox tbcheckfile;
        private Button bCheckSign;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbFpath;
        private Button bSaveFile;
        private SaveFileDialog sfdSignFile;
        private Button button1;
        private OpenFileDialog ofdCheckFile;
    }
}