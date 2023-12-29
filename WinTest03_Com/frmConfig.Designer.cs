namespace WinTest03_Com
{
    partial class frmConfig
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
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBoad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnFC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.tbFontName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFCB = new System.Windows.Forms.TextBox();
            this.tbFCG = new System.Windows.Forms.TextBox();
            this.tbFCR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBCB = new System.Windows.Forms.TextBox();
            this.tbBCG = new System.Windows.Forms.TextBox();
            this.tbBCR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(146, 322);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 315);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 315);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbStop);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbData);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbParity);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbBoad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbCom);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Port설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "0 - None",
            "1 - One",
            "2 - Two"});
            this.cbStop.Location = new System.Drawing.Point(87, 155);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(129, 20);
            this.cbStop.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop Bit";
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbData.Location = new System.Drawing.Point(87, 117);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(129, 20);
            this.cbData.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "DataBits";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "None"});
            this.cbParity.Location = new System.Drawing.Point(87, 87);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(129, 20);
            this.cbParity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity";
            // 
            // cbBoad
            // 
            this.cbBoad.FormattingEnabled = true;
            this.cbBoad.Items.AddRange(new object[] {
            "576000",
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.cbBoad.Location = new System.Drawing.Point(87, 52);
            this.cbBoad.Name = "cbBoad";
            this.cbBoad.Size = new System.Drawing.Size(129, 20);
            this.cbBoad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate";
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(87, 22);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(129, 20);
            this.cbCom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBC);
            this.tabPage2.Controls.Add(this.btnFC);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnFont);
            this.tabPage2.Controls.Add(this.tbFontName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbFCB);
            this.tabPage2.Controls.Add(this.tbFCG);
            this.tabPage2.Controls.Add(this.tbFCR);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbBCB);
            this.tabPage2.Controls.Add(this.tbBCG);
            this.tabPage2.Controls.Add(this.tbBCR);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "환경설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBC
            // 
            this.btnBC.Location = new System.Drawing.Point(290, 45);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(27, 23);
            this.btnBC.TabIndex = 15;
            this.btnBC.Text = "...";
            this.btnBC.UseVisualStyleBackColor = true;
            // 
            // btnFC
            // 
            this.btnFC.Location = new System.Drawing.Point(290, 80);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(27, 23);
            this.btnFC.TabIndex = 14;
            this.btnFC.Text = "...";
            this.btnFC.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "Blue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Green";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "Red";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(290, 121);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(27, 23);
            this.btnFont.TabIndex = 10;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // tbFontName
            // 
            this.tbFontName.Location = new System.Drawing.Point(86, 121);
            this.tbFontName.Name = "tbFontName";
            this.tbFontName.Size = new System.Drawing.Size(198, 21);
            this.tbFontName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Font";
            // 
            // tbFCB
            // 
            this.tbFCB.Location = new System.Drawing.Point(222, 82);
            this.tbFCB.Name = "tbFCB";
            this.tbFCB.Size = new System.Drawing.Size(62, 21);
            this.tbFCB.TabIndex = 7;
            // 
            // tbFCG
            // 
            this.tbFCG.Location = new System.Drawing.Point(154, 82);
            this.tbFCG.Name = "tbFCG";
            this.tbFCG.Size = new System.Drawing.Size(62, 21);
            this.tbFCG.TabIndex = 6;
            // 
            // tbFCR
            // 
            this.tbFCR.Location = new System.Drawing.Point(86, 82);
            this.tbFCR.Name = "tbFCR";
            this.tbFCR.Size = new System.Drawing.Size(62, 21);
            this.tbFCR.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Font Color";
            // 
            // tbBCB
            // 
            this.tbBCB.Location = new System.Drawing.Point(222, 45);
            this.tbBCB.Name = "tbBCB";
            this.tbBCB.Size = new System.Drawing.Size(62, 21);
            this.tbBCB.TabIndex = 3;
            // 
            // tbBCG
            // 
            this.tbBCG.Location = new System.Drawing.Point(154, 45);
            this.tbBCG.Name = "tbBCG";
            this.tbBCG.Size = new System.Drawing.Size(62, 21);
            this.tbBCG.TabIndex = 2;
            // 
            // tbBCR
            // 
            this.tbBCR.Location = new System.Drawing.Point(86, 45);
            this.tbBCR.Name = "tbBCR";
            this.tbBCR.Size = new System.Drawing.Size(62, 21);
            this.tbBCR.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Back Color";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.Text = "myPutty Configuration";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBCR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBCB;
        private System.Windows.Forms.TextBox tbBCG;
        private System.Windows.Forms.TextBox tbFCB;
        private System.Windows.Forms.TextBox tbFCG;
        private System.Windows.Forms.TextBox tbFCR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.TextBox tbFontName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnFC;
        public System.Windows.Forms.ComboBox cbStop;
        public System.Windows.Forms.ComboBox cbData;
        public System.Windows.Forms.ComboBox cbParity;
        public System.Windows.Forms.ComboBox cbBoad;
        public System.Windows.Forms.ComboBox cbCom;
    }
}