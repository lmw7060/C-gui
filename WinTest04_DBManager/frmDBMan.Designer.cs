namespace WinTest04_DBManager
{
    partial class frmDBMan
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
            this.DataView = new System.Windows.Forms.TabControl();
            this.ViewTable = new System.Windows.Forms.TabPage();
            this.config = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu편집 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu보기 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu도움말 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dataView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mnuReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.testSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.PopUp1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRunSql = new System.Windows.Forms.ToolStripMenuItem();
            this.DataView.SuspendLayout();
            this.ViewTable.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PopUp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.Controls.Add(this.ViewTable);
            this.DataView.Controls.Add(this.config);
            this.DataView.Location = new System.Drawing.Point(0, 24);
            this.DataView.Name = "DataView";
            this.DataView.SelectedIndex = 0;
            this.DataView.Size = new System.Drawing.Size(800, 426);
            this.DataView.TabIndex = 0;
            this.DataView.UseWaitCursor = true;
            // 
            // ViewTable
            // 
            this.ViewTable.Controls.Add(this.splitContainer1);
            this.ViewTable.Location = new System.Drawing.Point(4, 22);
            this.ViewTable.Name = "ViewTable";
            this.ViewTable.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTable.Size = new System.Drawing.Size(792, 400);
            this.ViewTable.TabIndex = 0;
            this.ViewTable.Text = "[Table Name]";
            this.ViewTable.UseVisualStyleBackColor = true;
            this.ViewTable.UseWaitCursor = true;
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(4, 22);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(792, 400);
            this.config.TabIndex = 1;
            this.config.Text = "설정";
            this.config.UseVisualStyleBackColor = true;
            this.config.UseWaitCursor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnu편집,
            this.mnu보기,
            this.mnu도움말,
            this.testSqlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2,
            this.sbLabel3});
            this.statusBar.Location = new System.Drawing.Point(0, 555);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(840, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(43, 20);
            this.mnuFile.Text = "파일";
            // 
            // mnu편집
            // 
            this.mnu편집.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuReplace});
            this.mnu편집.Name = "mnu편집";
            this.mnu편집.Size = new System.Drawing.Size(43, 20);
            this.mnu편집.Text = "편집";
            // 
            // mnu보기
            // 
            this.mnu보기.Name = "mnu보기";
            this.mnu보기.Size = new System.Drawing.Size(43, 20);
            this.mnu보기.Text = "보기";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(180, 22);
            this.mnuNew.Text = "New";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "Save as";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(180, 22);
            this.mnuFind.Text = "찾기";
            // 
            // mnu도움말
            // 
            this.mnu도움말.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnu도움말.Name = "mnu도움말";
            this.mnu도움말.Size = new System.Drawing.Size(55, 20);
            this.mnu도움말.Text = "도움말";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(187, 22);
            this.mnuAbout.Text = "About DB Manager...";
            // 
            // dataView1
            // 
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.Location = new System.Drawing.Point(0, 0);
            this.dataView1.Name = "dataView1";
            this.dataView1.RowTemplate.Height = 23;
            this.dataView1.Size = new System.Drawing.Size(786, 266);
            this.dataView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.PopUp1;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(786, 124);
            this.textBox1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataView1);
            this.splitContainer1.Size = new System.Drawing.Size(786, 394);
            this.splitContainer1.SplitterDistance = 124;
            this.splitContainer1.TabIndex = 2;
            // 
            // mnuReplace
            // 
            this.mnuReplace.Name = "mnuReplace";
            this.mnuReplace.Size = new System.Drawing.Size(180, 22);
            this.mnuReplace.Text = "바꾸기";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(10, 17);
            this.sbLabel1.Text = ".";
            // 
            // sbLabel2
            // 
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(10, 17);
            this.sbLabel2.Text = ".";
            // 
            // sbLabel3
            // 
            this.sbLabel3.Name = "sbLabel3";
            this.sbLabel3.Size = new System.Drawing.Size(10, 17);
            this.sbLabel3.Text = ".";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ValidateNames = false;
            // 
            // testSqlToolStripMenuItem
            // 
            this.testSqlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.testSqlToolStripMenuItem.Name = "testSqlToolStripMenuItem";
            this.testSqlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.testSqlToolStripMenuItem.Text = "Test sql";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // PopUp1
            // 
            this.PopUp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRunSql});
            this.PopUp1.Name = "PopUp1";
            this.PopUp1.Size = new System.Drawing.Size(125, 26);
            // 
            // mnuRunSql
            // 
            this.mnuRunSql.Name = "mnuRunSql";
            this.mnuRunSql.Size = new System.Drawing.Size(180, 22);
            this.mnuRunSql.Text = "SQL 실행";
            this.mnuRunSql.Click += new System.EventHandler(this.mnuRunSql_Click);
            // 
            // frmDBMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 577);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusBar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDBMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Manager ver 1.3";
            this.DataView.ResumeLayout(false);
            this.ViewTable.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PopUp1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl DataView;
        private System.Windows.Forms.TabPage ViewTable;
        private System.Windows.Forms.TabPage config;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnu편집;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem mnu보기;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnu도움말;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.DataGridView dataView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem mnuReplace;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem testSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip PopUp1;
        private System.Windows.Forms.ToolStripMenuItem mnuRunSql;
    }
}

