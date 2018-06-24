using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace timerProject
{
    public partial class Form1 : Form
    {
        timeKeeping timeTick = new timeKeeping();
        storage memory = new storage();


        int countDownCurrent = 0;
        int SWcurrent = 0;
        int numRepeat = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            initialise("countdown");
            textBoxRepeat.Text = "1";
            textBoxRepeat.Enabled = false;

            listViewHistory.Columns.Add("Timing", 60, HorizontalAlignment.Center);
            listViewHistory.Columns.Add("Repeats", 80, HorizontalAlignment.Center);
            listViewHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewHistory.Font = new Font("Arial", 8, FontStyle.Bold);

            listViewBmark.Columns.Add("", 60);
            listViewBmark.HeaderStyle = ColumnHeaderStyle.None;

            memory.loadFile("history");
            memory.loadFile("bookmark");

            memory.updateListView(listViewBmark, "bookmark");
            memory.updateListView(listViewHistory, "history");




        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TimerCountDown.Stop();

            try
            {
                timeTick.setTimeInt(textBoxHour.Text, textBoxMin.Text, textBoxSec.Text);
                numRepeat = int.Parse(textBoxRepeat.Text);
                timeTick.totalTime = 0;
                countDownCurrent = timeTick.hour * 3600 + timeTick.min * 60 + timeTick.sec;

                if (timeTick.hour * 3600 + timeTick.min * 60 + timeTick.sec > 0 && timeTick.min <= 60 && timeTick.sec <= 60)
                {

                    memory.addHistoryList(textBoxHour.Text, textBoxMin.Text, textBoxSec.Text, textBoxRepeat.Text);
                    memory.updateListView(listViewHistory, "history");


                    TimerCountDown.Interval = 1000;
                    TimerCountDown.Start();
                    toggleAvaliabilityTextbox(false);
                }

                else
                {
                    MessageBox.Show("Please enter a valid value", "Error", MessageBoxButtons.OK);
                    initialise("countdown");
                }
            }

            catch
            {
                MessageBox.Show("Please enter positive integers to all textBoxes", "Error", MessageBoxButtons.OK);
                initialise("countdown");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            initialise("countdown");

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TimerCountDown.Stop();
            updateTextBoxes();

        }

        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRepeat.Enabled = true;
        }

        private void checkTiming_Tick(object sender, EventArgs e)
        {

            timeTick.updateTime(countDownCurrent);
            Console.WriteLine(countDownCurrent);
            updateTextBoxes();

            if (countDownCurrent > 0)
            {
                countDownCurrent--;
            }

            if (countDownCurrent == 0)
            {

                if (numRepeat == 1)
                {
                    TimerCountDown.Stop();
                    toggleAvaliabilityTextbox(true);
                    MessageBox.Show(memory.listHistory.Last() + " has elapsed", "Timing has Ended", MessageBoxButtons.OK);
                    timeTick.totalTime = 0;

                }


                if (numRepeat > 1)
                {
                    numRepeat--;
                    countDownCurrent = timeTick.totalTime;


                    setTextBoxes(memory.getSplittedTime(memory.listHistory.Count() - 1 , "history"));
                    timeTick.setTimeList(memory.getSplittedTime(memory.listHistory.Count() - 1, "history"));
                    TimerCountDown.Stop();

                    if (MessageBox.Show(memory.listHistory.Last() + " has elapsed. " + "Repeating " + numRepeat.ToString() + " more times", "Timing has Ended", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        TimerCountDown.Interval = 1000;
                        TimerCountDown.Start();
                    }
                }


            }



        }

        private void updateTextBoxes()
        {
            textBoxHour.Text = memory.padSingleString(timeTick.hour.ToString());
            textBoxMin.Text = memory.padSingleString(timeTick.min.ToString());
            textBoxSec.Text = memory.padSingleString(timeTick.sec.ToString());
        }

        private void initialise(string mode)
        {
            switch(mode)
            {
                case "countdown":
                    textBoxHour.Text = "00";
                    textBoxMin.Text = "00";
                    textBoxSec.Text = "00";
                    countDownCurrent = 0;
                    timeTick.hour = 0;
                    timeTick.min = 0;
                    timeTick.sec = 0;
                    TimerCountDown.Stop();
                    toggleAvaliabilityTextbox(true);
                    break;

                case"stopwatch":
                    SWTextBoxHr.Text = "00";
                    SWTextBoxMin.Text = "00";
                    SWTextBoxSec.Text = "00";
                    break;
            }
            
        }

        private void toggleAvaliabilityTextbox(bool enabled)
        {
            switch (enabled)
            {
                case true:
                    textBoxHour.ReadOnly = false;
                    textBoxMin.ReadOnly = false;
                    textBoxSec.ReadOnly = false;
                    btnHistoTimer.Enabled = true;
                    break;

                case false:
                    textBoxHour.ReadOnly = true;
                    textBoxMin.ReadOnly = true;
                    textBoxSec.ReadOnly = true;
                    btnHistoTimer.Enabled = false;
                    break;

            }
        }

        private void setTextBoxes(List<string> data)
        {
            textBoxHour.Text = data[0];
            textBoxMin.Text = data[1];
            textBoxSec.Text = data[2];
        }

        private void btnDelSelHis_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                memory.listHistory.RemoveAt(index);
                memory.updateListView(listViewHistory, "history");
            }
        }

        private void btnDelAllHis_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to clear all history", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                memory.listHistory.Clear();
                memory.updateListView(listViewHistory, "history");

            }
        }

        private void btnHistoTimer_Click(object sender, EventArgs e)
        {
            initialise("countdown");

            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                setTextBoxes(memory.getSplittedTime(index, "history"));
                timeTick.setTimeList(memory.getSplittedTime(index, "history"));
            }

        }

        private void btnAddBMFrmTimer_Click(object sender, EventArgs e)
        {
            memory.addBookMarkListMultiple(textBoxHour.Text, textBoxMin.Text, textBoxSec.Text);
            memory.updateListView(listViewBmark, "bookmark");
        }

        private void btnAddBMFrmHis_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                memory.listBookMarks.Insert(0,memory.listHistory[index]);
                memory.updateListView(listViewBmark, "bookmark");
            }
        }

        private void btnBMtoTimer_Click(object sender, EventArgs e)
        {
            initialise("countdown");

            if (listViewBmark.SelectedIndices.Count > 0)
            {
                int index = listViewBmark.SelectedIndices[0];
                setTextBoxes(memory.getSplittedTime(index, "bookmark"));
                timeTick.setTimeList(memory.getSplittedTime(index, "bookmark"));
            }
        }

        private void btnDelSelBM_Click(object sender, EventArgs e)
        {
            if (listViewBmark.SelectedIndices.Count > 0)
            {
                int index = listViewBmark.SelectedIndices[0];
                memory.listBookMarks.RemoveAt(index);
                memory.updateListView(listViewBmark, "bookmark");
            }
        }

        private void DellAllBM_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to clear all bookmarks", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                memory.listBookMarks.Clear();
                memory.updateListView(listViewBmark, "bookmark");

            }
        }

        private void btnSaveHistory_Click(object sender, EventArgs e)
        {
            memory.saveFile("history");
        }

        private void btnSaveBM_Click(object sender, EventArgs e)
        {
            memory.saveFile("bookmark");
        }

        private void exitProramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memory.saveFile("bookmark");
            memory.saveFile("history");
            this.Close();

        }

        private void comboBoxTabSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = comboBoxTabSelection.Text;

            switch(selection)
            {
                case "Timer":
                    tabControl.SelectedTab = tabPageMain;
                    break;

                case "StopWatch":
                    tabControl.SelectedTab = tabPageStopWatch;
                    break;

                case "Rest Eye Timer":
                    tabControl.SelectedTab = tabPageEye;
                    break;
            }
        }

        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memory.loadFile("history");
            memory.updateListView(listViewHistory, "history");
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memory.loadFile("bookmark");
            memory.updateListView(listViewBmark, "bookmark");
        }

        private void historyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            memory.saveFile("history");
        }

        private void bookmarksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memory.saveFile("bookmark");
        }

        private void SWbtnStart_Click(object sender, EventArgs e)
        {

        }

       

        private void SWbtnStop_Click(object sender, EventArgs e)
        {

        }

        private void SWbtnReset_Click(object sender, EventArgs e)
        {

        }

        private void SWTextBoxSec_TextChanged(object sender, EventArgs e)
        {

        }

      
        

       
    }
}
