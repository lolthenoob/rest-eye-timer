namespace timerProject
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBoxSec = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.TimerCountDown = new System.Windows.Forms.Timer(this.components);
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewBmark = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.textBoxRepeat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.btnSaveHistory = new System.Windows.Forms.Button();
            this.btnSaveBM = new System.Windows.Forms.Button();
            this.DellAllBM = new System.Windows.Forms.Button();
            this.btnDelSelBM = new System.Windows.Forms.Button();
            this.btnBMtoTimer = new System.Windows.Forms.Button();
            this.btnHistoTimer = new System.Windows.Forms.Button();
            this.btnAddBMFrmTimer = new System.Windows.Forms.Button();
            this.btnAddBMFrmHis = new System.Windows.Forms.Button();
            this.btnDelAllHis = new System.Windows.Forms.Button();
            this.btnDelSelHis = new System.Windows.Forms.Button();
            this.tabPageStopWatch = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.SWTextBoxHr = new System.Windows.Forms.TextBox();
            this.SWbtnStart = new System.Windows.Forms.Button();
            this.SWbtnStop = new System.Windows.Forms.Button();
            this.SWbtnReset = new System.Windows.Forms.Button();
            this.SWTextBoxSec = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SWTextBoxMin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageEye = new System.Windows.Forms.TabPage();
            this.comboBoxTabSelection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restEyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restEyeTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMaim = new System.Windows.Forms.MenuStrip();
            this.SWtimer = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageStopWatch.SuspendLayout();
            this.menuStripMaim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "CountDown Timer";
            // 
            // textBoxHour
            // 
            this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHour.Location = new System.Drawing.Point(174, 128);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(43, 40);
            this.textBoxHour.TabIndex = 4;
            this.textBoxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(174, 190);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(43, 35);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(241, 190);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(43, 35);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(308, 190);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(43, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBoxSec
            // 
            this.textBoxSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSec.Location = new System.Drawing.Point(308, 128);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(43, 40);
            this.textBoxSec.TabIndex = 8;
            this.textBoxSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMin.Location = new System.Drawing.Point(241, 128);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(43, 40);
            this.textBoxMin.TabIndex = 9;
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimerCountDown
            // 
            this.TimerCountDown.Tick += new System.EventHandler(this.checkTiming_Tick);
            // 
            // listViewHistory
            // 
            this.listViewHistory.LabelWrap = false;
            this.listViewHistory.Location = new System.Drawing.Point(97, 273);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(170, 212);
            this.listViewHistory.TabIndex = 10;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seconds";
            // 
            // listViewBmark
            // 
            this.listViewBmark.Location = new System.Drawing.Point(308, 273);
            this.listViewBmark.Name = "listViewBmark";
            this.listViewBmark.Size = new System.Drawing.Size(170, 212);
            this.listViewBmark.TabIndex = 16;
            this.listViewBmark.UseCompatibleStateImageBehavior = false;
            this.listViewBmark.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "History";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "BookMarks";
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(388, 112);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(61, 17);
            this.checkBoxRepeat.TabIndex = 19;
            this.checkBoxRepeat.Text = "Repeat";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            this.checkBoxRepeat.CheckedChanged += new System.EventHandler(this.checkBoxRepeat_CheckedChanged);
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Location = new System.Drawing.Point(516, 129);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(42, 20);
            this.textBoxRepeat.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Number of Times Repeat";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageStopWatch);
            this.tabControl.Controls.Add(this.tabPageEye);
            this.tabControl.Location = new System.Drawing.Point(12, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(629, 533);
            this.tabControl.TabIndex = 22;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.btnSaveHistory);
            this.tabPageMain.Controls.Add(this.btnSaveBM);
            this.tabPageMain.Controls.Add(this.DellAllBM);
            this.tabPageMain.Controls.Add(this.btnDelSelBM);
            this.tabPageMain.Controls.Add(this.btnBMtoTimer);
            this.tabPageMain.Controls.Add(this.btnHistoTimer);
            this.tabPageMain.Controls.Add(this.btnAddBMFrmTimer);
            this.tabPageMain.Controls.Add(this.btnAddBMFrmHis);
            this.tabPageMain.Controls.Add(this.btnDelAllHis);
            this.tabPageMain.Controls.Add(this.btnDelSelHis);
            this.tabPageMain.Controls.Add(this.listViewBmark);
            this.tabPageMain.Controls.Add(this.label9);
            this.tabPageMain.Controls.Add(this.label2);
            this.tabPageMain.Controls.Add(this.textBoxRepeat);
            this.tabPageMain.Controls.Add(this.textBoxHour);
            this.tabPageMain.Controls.Add(this.checkBoxRepeat);
            this.tabPageMain.Controls.Add(this.btnStart);
            this.tabPageMain.Controls.Add(this.label8);
            this.tabPageMain.Controls.Add(this.btnStop);
            this.tabPageMain.Controls.Add(this.label7);
            this.tabPageMain.Controls.Add(this.btnReset);
            this.tabPageMain.Controls.Add(this.textBoxSec);
            this.tabPageMain.Controls.Add(this.label6);
            this.tabPageMain.Controls.Add(this.textBoxMin);
            this.tabPageMain.Controls.Add(this.label5);
            this.tabPageMain.Controls.Add(this.listViewHistory);
            this.tabPageMain.Controls.Add(this.label4);
            this.tabPageMain.Controls.Add(this.label1);
            this.tabPageMain.Controls.Add(this.label3);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(621, 507);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main Timer";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // btnSaveHistory
            // 
            this.btnSaveHistory.Location = new System.Drawing.Point(6, 447);
            this.btnSaveHistory.Name = "btnSaveHistory";
            this.btnSaveHistory.Size = new System.Drawing.Size(72, 38);
            this.btnSaveHistory.TabIndex = 33;
            this.btnSaveHistory.Text = "Save History";
            this.btnSaveHistory.UseVisualStyleBackColor = true;
            this.btnSaveHistory.Click += new System.EventHandler(this.btnSaveHistory_Click);
            // 
            // btnSaveBM
            // 
            this.btnSaveBM.Location = new System.Drawing.Point(510, 447);
            this.btnSaveBM.Name = "btnSaveBM";
            this.btnSaveBM.Size = new System.Drawing.Size(91, 34);
            this.btnSaveBM.TabIndex = 32;
            this.btnSaveBM.Text = "Save BookMarks";
            this.btnSaveBM.UseVisualStyleBackColor = true;
            this.btnSaveBM.Click += new System.EventHandler(this.btnSaveBM_Click);
            // 
            // DellAllBM
            // 
            this.DellAllBM.Location = new System.Drawing.Point(510, 385);
            this.DellAllBM.Name = "DellAllBM";
            this.DellAllBM.Size = new System.Drawing.Size(91, 53);
            this.DellAllBM.TabIndex = 31;
            this.DellAllBM.Text = "Delete all Bookmarks";
            this.DellAllBM.UseVisualStyleBackColor = true;
            this.DellAllBM.Click += new System.EventHandler(this.DellAllBM_Click);
            // 
            // btnDelSelBM
            // 
            this.btnDelSelBM.Location = new System.Drawing.Point(510, 322);
            this.btnDelSelBM.Name = "btnDelSelBM";
            this.btnDelSelBM.Size = new System.Drawing.Size(91, 57);
            this.btnDelSelBM.TabIndex = 30;
            this.btnDelSelBM.Text = "Delete selected bookmark";
            this.btnDelSelBM.UseVisualStyleBackColor = true;
            this.btnDelSelBM.Click += new System.EventHandler(this.btnDelSelBM_Click);
            // 
            // btnBMtoTimer
            // 
            this.btnBMtoTimer.Location = new System.Drawing.Point(510, 200);
            this.btnBMtoTimer.Name = "btnBMtoTimer";
            this.btnBMtoTimer.Size = new System.Drawing.Size(91, 57);
            this.btnBMtoTimer.TabIndex = 29;
            this.btnBMtoTimer.Text = "Place selected bookmark to timer";
            this.btnBMtoTimer.UseVisualStyleBackColor = true;
            this.btnBMtoTimer.Click += new System.EventHandler(this.btnBMtoTimer_Click);
            // 
            // btnHistoTimer
            // 
            this.btnHistoTimer.Location = new System.Drawing.Point(3, 190);
            this.btnHistoTimer.Name = "btnHistoTimer";
            this.btnHistoTimer.Size = new System.Drawing.Size(75, 54);
            this.btnHistoTimer.TabIndex = 28;
            this.btnHistoTimer.Text = "Put selected history to TImer";
            this.btnHistoTimer.UseVisualStyleBackColor = true;
            this.btnHistoTimer.Click += new System.EventHandler(this.btnHistoTimer_Click);
            // 
            // btnAddBMFrmTimer
            // 
            this.btnAddBMFrmTimer.Location = new System.Drawing.Point(510, 263);
            this.btnAddBMFrmTimer.Name = "btnAddBMFrmTimer";
            this.btnAddBMFrmTimer.Size = new System.Drawing.Size(91, 50);
            this.btnAddBMFrmTimer.TabIndex = 27;
            this.btnAddBMFrmTimer.Text = "Add current time to bookMarks";
            this.btnAddBMFrmTimer.UseVisualStyleBackColor = true;
            this.btnAddBMFrmTimer.Click += new System.EventHandler(this.btnAddBMFrmTimer_Click);
            // 
            // btnAddBMFrmHis
            // 
            this.btnAddBMFrmHis.Location = new System.Drawing.Point(6, 247);
            this.btnAddBMFrmHis.Name = "btnAddBMFrmHis";
            this.btnAddBMFrmHis.Size = new System.Drawing.Size(70, 66);
            this.btnAddBMFrmHis.TabIndex = 26;
            this.btnAddBMFrmHis.Text = "Add selected History to Bookmarks";
            this.btnAddBMFrmHis.UseVisualStyleBackColor = true;
            this.btnAddBMFrmHis.Click += new System.EventHandler(this.btnAddBMFrmHis_Click);
            // 
            // btnDelAllHis
            // 
            this.btnDelAllHis.Location = new System.Drawing.Point(6, 378);
            this.btnDelAllHis.Name = "btnDelAllHis";
            this.btnDelAllHis.Size = new System.Drawing.Size(72, 53);
            this.btnDelAllHis.TabIndex = 25;
            this.btnDelAllHis.Text = "Delete All History";
            this.btnDelAllHis.UseVisualStyleBackColor = true;
            this.btnDelAllHis.Click += new System.EventHandler(this.btnDelAllHis_Click);
            // 
            // btnDelSelHis
            // 
            this.btnDelSelHis.Location = new System.Drawing.Point(6, 319);
            this.btnDelSelHis.Name = "btnDelSelHis";
            this.btnDelSelHis.Size = new System.Drawing.Size(72, 53);
            this.btnDelSelHis.TabIndex = 24;
            this.btnDelSelHis.Text = "Delete Selected History";
            this.btnDelSelHis.UseVisualStyleBackColor = true;
            this.btnDelSelHis.Click += new System.EventHandler(this.btnDelSelHis_Click);
            // 
            // tabPageStopWatch
            // 
            this.tabPageStopWatch.Controls.Add(this.label17);
            this.tabPageStopWatch.Controls.Add(this.listView1);
            this.tabPageStopWatch.Controls.Add(this.label16);
            this.tabPageStopWatch.Controls.Add(this.SWTextBoxHr);
            this.tabPageStopWatch.Controls.Add(this.SWbtnStart);
            this.tabPageStopWatch.Controls.Add(this.SWbtnStop);
            this.tabPageStopWatch.Controls.Add(this.SWbtnReset);
            this.tabPageStopWatch.Controls.Add(this.SWTextBoxSec);
            this.tabPageStopWatch.Controls.Add(this.label11);
            this.tabPageStopWatch.Controls.Add(this.SWTextBoxMin);
            this.tabPageStopWatch.Controls.Add(this.label12);
            this.tabPageStopWatch.Controls.Add(this.label13);
            this.tabPageStopWatch.Controls.Add(this.label14);
            this.tabPageStopWatch.Controls.Add(this.label15);
            this.tabPageStopWatch.Location = new System.Drawing.Point(4, 22);
            this.tabPageStopWatch.Name = "tabPageStopWatch";
            this.tabPageStopWatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStopWatch.Size = new System.Drawing.Size(621, 507);
            this.tabPageStopWatch.TabIndex = 2;
            this.tabPageStopWatch.Text = "StopWatch";
            this.tabPageStopWatch.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(224, 29);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 39);
            this.label16.TabIndex = 26;
            this.label16.Text = "StopWatch";
            // 
            // SWTextBoxHr
            // 
            this.SWTextBoxHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWTextBoxHr.Location = new System.Drawing.Point(218, 91);
            this.SWTextBoxHr.Name = "SWTextBoxHr";
            this.SWTextBoxHr.Size = new System.Drawing.Size(43, 40);
            this.SWTextBoxHr.TabIndex = 16;
            this.SWTextBoxHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SWbtnStart
            // 
            this.SWbtnStart.Location = new System.Drawing.Point(218, 153);
            this.SWbtnStart.Name = "SWbtnStart";
            this.SWbtnStart.Size = new System.Drawing.Size(43, 35);
            this.SWbtnStart.TabIndex = 17;
            this.SWbtnStart.Text = "Start";
            this.SWbtnStart.UseVisualStyleBackColor = true;
            this.SWbtnStart.Click += new System.EventHandler(this.SWbtnStart_Click);
            // 
            // SWbtnStop
            // 
            this.SWbtnStop.Location = new System.Drawing.Point(285, 153);
            this.SWbtnStop.Name = "SWbtnStop";
            this.SWbtnStop.Size = new System.Drawing.Size(43, 35);
            this.SWbtnStop.TabIndex = 18;
            this.SWbtnStop.Text = "Stop";
            this.SWbtnStop.UseVisualStyleBackColor = true;
            this.SWbtnStop.Click += new System.EventHandler(this.SWbtnStop_Click);
            // 
            // SWbtnReset
            // 
            this.SWbtnReset.Location = new System.Drawing.Point(352, 153);
            this.SWbtnReset.Name = "SWbtnReset";
            this.SWbtnReset.Size = new System.Drawing.Size(43, 35);
            this.SWbtnReset.TabIndex = 19;
            this.SWbtnReset.Text = "Reset";
            this.SWbtnReset.UseVisualStyleBackColor = true;
            this.SWbtnReset.Click += new System.EventHandler(this.SWbtnReset_Click);
            // 
            // SWTextBoxSec
            // 
            this.SWTextBoxSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWTextBoxSec.Location = new System.Drawing.Point(352, 91);
            this.SWTextBoxSec.Name = "SWTextBoxSec";
            this.SWTextBoxSec.Size = new System.Drawing.Size(43, 40);
            this.SWTextBoxSec.TabIndex = 20;
            this.SWTextBoxSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SWTextBoxSec.TextChanged += new System.EventHandler(this.SWTextBoxSec_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(340, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Seconds";
            // 
            // SWTextBoxMin
            // 
            this.SWTextBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWTextBoxMin.Location = new System.Drawing.Point(285, 91);
            this.SWTextBoxMin.Name = "SWTextBoxMin";
            this.SWTextBoxMin.Size = new System.Drawing.Size(43, 40);
            this.SWTextBoxMin.TabIndex = 21;
            this.SWTextBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Minutes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(214, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Hours";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(261, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 28);
            this.label14.TabIndex = 22;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(334, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 28);
            this.label15.TabIndex = 23;
            this.label15.Text = ":";
            // 
            // tabPageEye
            // 
            this.tabPageEye.Location = new System.Drawing.Point(4, 22);
            this.tabPageEye.Name = "tabPageEye";
            this.tabPageEye.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEye.Size = new System.Drawing.Size(621, 507);
            this.tabPageEye.TabIndex = 1;
            this.tabPageEye.Text = "Rest Eye Timer";
            this.tabPageEye.UseVisualStyleBackColor = true;
            // 
            // comboBoxTabSelection
            // 
            this.comboBoxTabSelection.FormattingEnabled = true;
            this.comboBoxTabSelection.Items.AddRange(new object[] {
            "Timer",
            "StopWatch",
            "Rest Eye Timer"});
            this.comboBoxTabSelection.Location = new System.Drawing.Point(110, 24);
            this.comboBoxTabSelection.Name = "comboBoxTabSelection";
            this.comboBoxTabSelection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTabSelection.TabIndex = 24;
            this.comboBoxTabSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxTabSelection_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Navigation Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitProramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.stopWatchToolStripMenuItem,
            this.restEyeToolStripMenuItem});
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem1,
            this.bookmarksToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.historyToolStripMenuItem.Text = "Timer";
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.historyToolStripMenuItem1.Text = "History";
            this.historyToolStripMenuItem1.Click += new System.EventHandler(this.historyToolStripMenuItem1_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            this.bookmarksToolStripMenuItem.Click += new System.EventHandler(this.bookmarksToolStripMenuItem_Click);
            // 
            // stopWatchToolStripMenuItem
            // 
            this.stopWatchToolStripMenuItem.Name = "stopWatchToolStripMenuItem";
            this.stopWatchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stopWatchToolStripMenuItem.Text = "StopWatch";
            // 
            // restEyeToolStripMenuItem
            // 
            this.restEyeToolStripMenuItem.Name = "restEyeToolStripMenuItem";
            this.restEyeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.restEyeToolStripMenuItem.Text = "Rest Eye Timer\'";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerToolStripMenuItem,
            this.stopWatchToolStripMenuItem1,
            this.restEyeTimerToolStripMenuItem});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem2,
            this.bookmarksToolStripMenuItem1});
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // historyToolStripMenuItem2
            // 
            this.historyToolStripMenuItem2.Name = "historyToolStripMenuItem2";
            this.historyToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.historyToolStripMenuItem2.Text = "History";
            this.historyToolStripMenuItem2.Click += new System.EventHandler(this.historyToolStripMenuItem2_Click);
            // 
            // bookmarksToolStripMenuItem1
            // 
            this.bookmarksToolStripMenuItem1.Name = "bookmarksToolStripMenuItem1";
            this.bookmarksToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.bookmarksToolStripMenuItem1.Text = "Bookmarks";
            this.bookmarksToolStripMenuItem1.Click += new System.EventHandler(this.bookmarksToolStripMenuItem1_Click);
            // 
            // stopWatchToolStripMenuItem1
            // 
            this.stopWatchToolStripMenuItem1.Name = "stopWatchToolStripMenuItem1";
            this.stopWatchToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.stopWatchToolStripMenuItem1.Text = "StopWatch";
            // 
            // restEyeTimerToolStripMenuItem
            // 
            this.restEyeTimerToolStripMenuItem.Name = "restEyeTimerToolStripMenuItem";
            this.restEyeTimerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.restEyeTimerToolStripMenuItem.Text = "Rest Eye Timer";
            // 
            // exitProramToolStripMenuItem
            // 
            this.exitProramToolStripMenuItem.Name = "exitProramToolStripMenuItem";
            this.exitProramToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitProramToolStripMenuItem.Text = "Exit Program";
            this.exitProramToolStripMenuItem.Click += new System.EventHandler(this.exitProramToolStripMenuItem_Click);
            // 
            // menuStripMaim
            // 
            this.menuStripMaim.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMaim.Location = new System.Drawing.Point(0, 0);
            this.menuStripMaim.Name = "menuStripMaim";
            this.menuStripMaim.Size = new System.Drawing.Size(656, 24);
            this.menuStripMaim.TabIndex = 23;
            this.menuStripMaim.Text = "mainMenuStrip";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(218, 266);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(177, 192);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(279, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 587);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxTabSelection);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStripMaim);
            this.MainMenuStrip = this.menuStripMaim;
            this.Name = "Form1";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageStopWatch.ResumeLayout(false);
            this.tabPageStopWatch.PerformLayout();
            this.menuStripMaim.ResumeLayout(false);
            this.menuStripMaim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBoxSec;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Timer TimerCountDown;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewBmark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.TextBox textBoxRepeat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageEye;
        private System.Windows.Forms.Button btnAddBMFrmTimer;
        private System.Windows.Forms.Button btnAddBMFrmHis;
        private System.Windows.Forms.Button btnDelAllHis;
        private System.Windows.Forms.Button btnDelSelHis;
        private System.Windows.Forms.Button btnHistoTimer;
        private System.Windows.Forms.Button DellAllBM;
        private System.Windows.Forms.Button btnDelSelBM;
        private System.Windows.Forms.Button btnBMtoTimer;
        private System.Windows.Forms.Button btnSaveHistory;
        private System.Windows.Forms.Button btnSaveBM;
        private System.Windows.Forms.TabPage tabPageStopWatch;
        private System.Windows.Forms.ComboBox comboBoxTabSelection;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restEyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopWatchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restEyeTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProramToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMaim;
        private System.Windows.Forms.TextBox SWTextBoxHr;
        private System.Windows.Forms.Button SWbtnStart;
        private System.Windows.Forms.Button SWbtnStop;
        private System.Windows.Forms.Button SWbtnReset;
        private System.Windows.Forms.TextBox SWTextBoxSec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SWTextBoxMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer SWtimer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView listView1;
    }
}

