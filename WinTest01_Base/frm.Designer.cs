namespace WinTest01_Base
{
    partial class frm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuF = new System.Windows.Forms.ToolStripMenuItem();
            this.menuN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuO = new System.Windows.Forms.ToolStripMenuItem();
            this.menuS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuE = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Popup1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLower = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Popup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinTest01_Base.Properties.Settings.Default, "Test", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnTest.Location = new System.Drawing.Point(817, 61);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(298, 330);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = global::WinTest01_Base.Properties.Settings.Default.Test;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test1";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("굴림", 10F);
            this.tb1.Location = new System.Drawing.Point(61, 61);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(94, 23);
            this.tb1.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("굴림", 10F);
            this.tb2.Location = new System.Drawing.Point(61, 106);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(94, 23);
            this.tb2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Test2";
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("굴림", 10F);
            this.tb3.Location = new System.Drawing.Point(61, 148);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(94, 23);
            this.tb3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Test3";
            // 
            // tb4
            // 
            this.tb4.Font = new System.Drawing.Font("굴림", 10F);
            this.tb4.Location = new System.Drawing.Point(61, 187);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(289, 329);
            this.tb4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Test4";
            // 
            // cmb1
            // 
            this.cmb1.Enabled = false;
            this.cmb1.Font = new System.Drawing.Font("굴림", 10F);
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하쇼",
            "반갑소"});
            this.cmb1.Location = new System.Drawing.Point(229, 61);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 10;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("굴림", 10F);
            this.cb1.Location = new System.Drawing.Point(161, 64);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(62, 18);
            this.cb1.TabIndex = 11;
            this.cb1.Text = "Test1";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("굴림", 10F);
            this.cb2.Location = new System.Drawing.Point(161, 108);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(62, 18);
            this.cb2.TabIndex = 12;
            this.cb2.Text = "Test2";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("굴림", 10F);
            this.cb3.Location = new System.Drawing.Point(161, 150);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(62, 18);
            this.cb3.TabIndex = 13;
            this.cb3.Text = "Test3";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("굴림", 10F);
            this.cb4.Location = new System.Drawing.Point(363, 186);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(62, 18);
            this.cb4.TabIndex = 14;
            this.cb4.Text = "Test4";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // cmb2
            // 
            this.cmb2.Enabled = false;
            this.cmb2.Font = new System.Drawing.Font("굴림", 10F);
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하쇼",
            "반갑소"});
            this.cmb2.Location = new System.Drawing.Point(229, 106);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 21);
            this.cmb2.TabIndex = 15;
            // 
            // cmb3
            // 
            this.cmb3.Enabled = false;
            this.cmb3.Font = new System.Drawing.Font("굴림", 10F);
            this.cmb3.FormattingEnabled = true;
            this.cmb3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하쇼",
            "반갑소"});
            this.cmb3.Location = new System.Drawing.Point(229, 142);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(121, 21);
            this.cmb3.TabIndex = 16;
            // 
            // cmb4
            // 
            this.cmb4.Enabled = false;
            this.cmb4.Font = new System.Drawing.Font("굴림", 10F);
            this.cmb4.FormattingEnabled = true;
            this.cmb4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하쇼",
            "반갑소"});
            this.cmb4.Location = new System.Drawing.Point(431, 183);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(121, 21);
            this.cmb4.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuF,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuF
            // 
            this.menuF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuN,
            this.menuO,
            this.menuS,
            this.toolStripSeparator1,
            this.menuE});
            this.menuF.Name = "menuF";
            this.menuF.Size = new System.Drawing.Size(37, 20);
            this.menuF.Text = "File";
            // 
            // menuN
            // 
            this.menuN.Name = "menuN";
            this.menuN.Size = new System.Drawing.Size(180, 22);
            this.menuN.Text = "New";
            // 
            // menuO
            // 
            this.menuO.Name = "menuO";
            this.menuO.Size = new System.Drawing.Size(180, 22);
            this.menuO.Text = "Open";
            this.menuO.Click += new System.EventHandler(this.menuO_Click);
            // 
            // menuS
            // 
            this.menuS.Name = "menuS";
            this.menuS.Size = new System.Drawing.Size(180, 22);
            this.menuS.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuE
            // 
            this.menuE.Name = "menuE";
            this.menuE.Size = new System.Drawing.Size(180, 22);
            this.menuE.Text = "Exit";
            this.menuE.Click += new System.EventHandler(this.menuE_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // Popup1
            // 
            this.Popup1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpper,
            this.mnuLower});
            this.Popup1.Name = "Popup1";
            this.Popup1.Size = new System.Drawing.Size(107, 48);
            // 
            // mnuUpper
            // 
            this.mnuUpper.Name = "mnuUpper";
            this.mnuUpper.Size = new System.Drawing.Size(106, 22);
            this.mnuUpper.Text = "Upper";
            this.mnuUpper.Click += new System.EventHandler(this.mnuUpper_Click);
            // 
            // mnuLower
            // 
            this.mnuLower.Name = "mnuLower";
            this.mnuLower.Size = new System.Drawing.Size(106, 22);
            this.mnuLower.Text = "Lower";
            this.mnuLower.Click += new System.EventHandler(this.mnuLower_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 71);
            this.button1.TabIndex = 20;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(80, 532);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(289, 21);
            this.tbFileName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "SelectFile";
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 661);
            this.ContextMenuStrip = this.Popup1;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb4);
            this.Controls.Add(this.cmb3);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm";
            this.Text = "WinFormTest ver 2.3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Popup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuF;
        private System.Windows.Forms.ToolStripMenuItem menuN;
        private System.Windows.Forms.ToolStripMenuItem menuO;
        private System.Windows.Forms.ToolStripMenuItem menuS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuE;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Popup1;
        private System.Windows.Forms.ToolStripMenuItem mnuUpper;
        private System.Windows.Forms.ToolStripMenuItem mnuLower;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label5;
    }
}

