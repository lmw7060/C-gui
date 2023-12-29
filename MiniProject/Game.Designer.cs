namespace MiniProject
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.tbGood1 = new System.Windows.Forms.TextBox();
            this.tbId1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb1dab = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.tbGood3 = new System.Windows.Forms.TextBox();
            this.tbId3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb3dab = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.tbGood2 = new System.Windows.Forms.TextBox();
            this.tbId2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb2dab = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.tbGood4 = new System.Windows.Forms.TextBox();
            this.tbId4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb4dab = new System.Windows.Forms.TextBox();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGrey = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.tbdab = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.연결ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stm설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stm실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Control;
            this.Canvas.Location = new System.Drawing.Point(236, 123);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(500, 500);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            this.Canvas.Resize += new System.EventHandler(this.CanVas_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.tbGood1);
            this.groupBox1.Controls.Add(this.tbId1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb1dab);
            this.groupBox1.Location = new System.Drawing.Point(35, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방장";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(8, 127);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(142, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "정답";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tbGood1
            // 
            this.tbGood1.Location = new System.Drawing.Point(50, 40);
            this.tbGood1.Name = "tbGood1";
            this.tbGood1.Size = new System.Drawing.Size(100, 21);
            this.tbGood1.TabIndex = 4;
            // 
            // tbId1
            // 
            this.tbId1.Location = new System.Drawing.Point(50, 14);
            this.tbId1.Name = "tbId1";
            this.tbId1.Size = new System.Drawing.Size(100, 21);
            this.tbId1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "맞춘 수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            // 
            // tb1dab
            // 
            this.tb1dab.Location = new System.Drawing.Point(6, 100);
            this.tb1dab.Name = "tb1dab";
            this.tb1dab.Size = new System.Drawing.Size(144, 21);
            this.tb1dab.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox7.Controls.Add(this.pictureBox5);
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Location = new System.Drawing.Point(29, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(903, 100);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(207, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(502, 81);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "캐 치 마 인 드 ★";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.tbGood3);
            this.groupBox2.Controls.Add(this.tbId3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb3dab);
            this.groupBox2.Location = new System.Drawing.Point(29, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 163);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "중수";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(8, 127);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(142, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "정답";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // tbGood3
            // 
            this.tbGood3.Location = new System.Drawing.Point(50, 40);
            this.tbGood3.Name = "tbGood3";
            this.tbGood3.Size = new System.Drawing.Size(100, 21);
            this.tbGood3.TabIndex = 4;
            // 
            // tbId3
            // 
            this.tbId3.Location = new System.Drawing.Point(50, 14);
            this.tbId3.Name = "tbId3";
            this.tbId3.Size = new System.Drawing.Size(100, 21);
            this.tbId3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "맞춘 수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "아이디";
            // 
            // tb3dab
            // 
            this.tb3dab.Location = new System.Drawing.Point(6, 100);
            this.tb3dab.Name = "tb3dab";
            this.tb3dab.Size = new System.Drawing.Size(144, 21);
            this.tb3dab.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btn2);
            this.groupBox3.Controls.Add(this.tbGood2);
            this.groupBox3.Controls.Add(this.tbId2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb2dab);
            this.groupBox3.Location = new System.Drawing.Point(767, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 163);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "고수";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(8, 127);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(142, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "정답";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // tbGood2
            // 
            this.tbGood2.Location = new System.Drawing.Point(50, 40);
            this.tbGood2.Name = "tbGood2";
            this.tbGood2.Size = new System.Drawing.Size(100, 21);
            this.tbGood2.TabIndex = 4;
            // 
            // tbId2
            // 
            this.tbId2.Location = new System.Drawing.Point(50, 14);
            this.tbId2.Name = "tbId2";
            this.tbId2.Size = new System.Drawing.Size(100, 21);
            this.tbId2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "맞춘 수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "아이디";
            // 
            // tb2dab
            // 
            this.tb2dab.Location = new System.Drawing.Point(6, 100);
            this.tb2dab.Name = "tb2dab";
            this.tb2dab.Size = new System.Drawing.Size(144, 21);
            this.tb2dab.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.btn4);
            this.groupBox4.Controls.Add(this.tbGood4);
            this.groupBox4.Controls.Add(this.tbId4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tb4dab);
            this.groupBox4.Location = new System.Drawing.Point(775, 460);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 163);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "하수";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(8, 127);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(142, 23);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "정답";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // tbGood4
            // 
            this.tbGood4.Location = new System.Drawing.Point(50, 40);
            this.tbGood4.Name = "tbGood4";
            this.tbGood4.Size = new System.Drawing.Size(100, 21);
            this.tbGood4.TabIndex = 4;
            // 
            // tbId4
            // 
            this.tbId4.Location = new System.Drawing.Point(50, 14);
            this.tbId4.Name = "tbId4";
            this.tbId4.Size = new System.Drawing.Size(100, 21);
            this.tbId4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "맞춘 수";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "아이디";
            // 
            // tb4dab
            // 
            this.tb4dab.Location = new System.Drawing.Point(6, 100);
            this.tb4dab.Name = "tb4dab";
            this.tb4dab.Size = new System.Drawing.Size(144, 21);
            this.tb4dab.TabIndex = 0;
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(244, 131);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(75, 23);
            this.btnPen.TabIndex = 8;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(325, 131);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 9;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Location = new System.Drawing.Point(406, 131);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(75, 23);
            this.btnEraser.TabIndex = 10;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(487, 131);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 11;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(568, 131);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(75, 23);
            this.btnRec.TabIndex = 12;
            this.btnRec.Text = "Rectangle";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Location = new System.Drawing.Point(649, 131);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(75, 23);
            this.btnBlack.TabIndex = 13;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(244, 160);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 14;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(325, 160);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 23);
            this.btnYellow.TabIndex = 15;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(406, 160);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 23);
            this.btnGreen.TabIndex = 16;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(487, 161);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 17;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGrey
            // 
            this.btnGrey.Location = new System.Drawing.Point(568, 160);
            this.btnGrey.Name = "btnGrey";
            this.btnGrey.Size = new System.Drawing.Size(75, 23);
            this.btnGrey.TabIndex = 18;
            this.btnGrey.Text = "Gray";
            this.btnGrey.UseVisualStyleBackColor = true;
            this.btnGrey.Click += new System.EventHandler(this.btnGrey_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(649, 160);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(75, 23);
            this.btnWhite.TabIndex = 19;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // tbdab
            // 
            this.tbdab.Location = new System.Drawing.Point(325, 190);
            this.tbdab.Name = "tbdab";
            this.tbdab.Size = new System.Drawing.Size(318, 21);
            this.tbdab.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.연결ToolStripMenuItem,
            this.stm설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 연결ToolStripMenuItem
            // 
            this.연결ToolStripMenuItem.Name = "연결ToolStripMenuItem";
            this.연결ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.연결ToolStripMenuItem.Text = "연결";
            this.연결ToolStripMenuItem.Click += new System.EventHandler(this.연결ToolStripMenuItem_Click);
            // 
            // stm설정ToolStripMenuItem
            // 
            this.stm설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stm실행ToolStripMenuItem});
            this.stm설정ToolStripMenuItem.Name = "stm설정ToolStripMenuItem";
            this.stm설정ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.stm설정ToolStripMenuItem.Text = "stm설정";
            this.stm설정ToolStripMenuItem.Click += new System.EventHandler(this.stm설정ToolStripMenuItem_Click);
            // 
            // stm실행ToolStripMenuItem
            // 
            this.stm실행ToolStripMenuItem.Name = "stm실행ToolStripMenuItem";
            this.stm실행ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.stm실행ToolStripMenuItem.Text = "stm실행";
            this.stm실행ToolStripMenuItem.Click += new System.EventHandler(this.stm실행ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 74);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(788, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 74);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(120, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 59);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(775, 344);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 59);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(74, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 72);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(871, 331);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 72);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 657);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbdab);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnGrey);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb1dab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbGood1;
        private System.Windows.Forms.TextBox tbId1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox tbGood3;
        private System.Windows.Forms.TextBox tbId3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb3dab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox tbGood2;
        private System.Windows.Forms.TextBox tbId2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb2dab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox tbGood4;
        private System.Windows.Forms.TextBox tbId4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb4dab;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGrey;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.TextBox tbdab;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 연결ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem stm설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stm실행ToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}