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
            initialise("stopwatch");
            textBoxRepeat.Text = "1";
            textBoxRepeat.Enabled = false;

            listViewHistory.Columns.Add("Timing", 60, HorizontalAlignment.Center);
            listViewHistory.Columns.Add("Repeats", 80, HorizontalAlignment.Center);
            listViewHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewHistory.Font = new Font("Arial", 8, FontStyle.Bold);

            listViewBmark.Columns.Add("", 60);
            listViewBmark.HeaderStyle = ColumnHeaderStyle.None;

            SWListViewHis.Columns.Add("", 100);
           

            memory.loadFile("history");
            memory.loadFile("bookmark");
            memory.loadFile("stopwatch");

            memory.updateListViewSingle(listViewBmark, memory.listCountDownBookMarks);
            memory.updateListViewMultiple(listViewHistory, memory.listCountDownHistory, memory.listCountDownRepeat);
            memory.updateListViewSingle(SWListViewHis, memory.listSWHistory);




        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TimerCountDown.Stop();

            try
            {
                timeTick.setTimeInt("countdown", textBoxHour.Text, textBoxMin.Text, textBoxSec.Text);
                numRepeat = int.Parse(textBoxRepeat.Text);
                timeTick.countDownTotalTime = 0;
                countDownCurrent = timeTick.countDownHour * 3600 + timeTick.countDownMin * 60 + timeTick.countDownSec;

                if (timeTick.countDownHour * 3600 + timeTick.countDownMin * 60 + timeTick.countDownSec > 0 && timeTick.countDownMin <= 60 && timeTick.countDownSec <= 60)
                {

                    memory.addToListMultipleCol(textBoxHour.Text, textBoxMin.Text, textBoxSec.Text, textBoxRepeat.Text);
                    memory.updateListViewMultiple(listViewHistory, memory.listCountDownHistory, memory.listCountDownRepeat);


                    TimerCountDown.Interval = 1000;
                    TimerCountDown.Start();
                    toggleAvaliabilityTextbox("countdown",false);
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
            updateTextBoxes("countdown");

        }

        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRepeat.Enabled = true;
        }

        private void checkTiming_Tick(object sender, EventArgs e)
        {

            timeTick.updateTime("countdown",countDownCurrent);
            Console.WriteLine(countDownCurrent);
            updateTextBoxes("countdown");

            if (countDownCurrent > 0)
            {
                countDownCurrent--;
            }

            if (countDownCurrent == 0)
            {

                if (numRepeat == 1)
                {
                    TimerCountDown.Stop();
                    toggleAvaliabilityTextbox("countdown",true);
                    MessageBox.Show(memory.listCountDownHistory.Last() + " has elapsed", "Timing has Ended", MessageBoxButtons.OK);
                    timeTick.countDownTotalTime = 0;

                }


                if (numRepeat > 1)
                {
                    numRepeat--;
                    countDownCurrent = timeTick.countDownTotalTime;


                    setTextBoxes(memory.getSplittedTime(memory.listCountDownHistory.Count() - 1 , "history"));
                    timeTick.setTimeList("countdown", memory.getSplittedTime(memory.listCountDownHistory.Count() - 1, "history"));
                    TimerCountDown.Stop();

                    if (MessageBox.Show(memory.listCountDownHistory.Last() + " has elapsed. " + "Repeating " + numRepeat.ToString() + " more times", "Timing has Ended", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        TimerCountDown.Interval = 1000;
                        TimerCountDown.Start();
                    }
                }


            }



        }

        private void updateTextBoxes(string type)
        {
            switch(type)
            {
                case "countdown":
                    textBoxHour.Text = memory.padSingleString(timeTick.countDownHour.ToString());
                    textBoxMin.Text = memory.padSingleString(timeTick.countDownMin.ToString());
                    textBoxSec.Text = memory.padSingleString(timeTick.countDownSec.ToString());
                    break;

                case "stopwatch":
                    SWTextBoxHr.Text = memory.padSingleString(timeTick.SWHour.ToString());
                    SWTextBoxMin.Text = memory.padSingleString(timeTick.SWMin.ToString());
                    SWTextBoxSec.Text = memory.padSingleString(timeTick.SWSec.ToString());
                    SWTextBoxMiSec.Text = memory.padSingleString(timeTick.SWMiSec.ToString());
                    break;
            }

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
                    timeTick.countDownHour = 0;
                    timeTick.countDownMin = 0;
                    timeTick.countDownSec = 0;
                    TimerCountDown.Stop();
                    toggleAvaliabilityTextbox(mode,true);
                    break;

                case"stopwatch":
                    SWTextBoxHr.Text = "00";
                    SWTextBoxMin.Text = "00";
                    SWTextBoxSec.Text = "00";
                    SWTextBoxMiSec.Text = "00";
                    timeTick.SWHour = 0;
                    timeTick.SWMin = 0;
                    timeTick.SWSec = 0;
                    timeTick.SWMiSec = 0;
                    SWtimer.Stop();

                    break;
            }
            
        }

        private void toggleAvaliabilityTextbox(string type, bool enabled)
        {

            switch(type)
            {
                case "countdown":

                    switch (enabled)
                    {
                        case true:
                            textBoxHour.ReadOnly = false;
                            textBoxMin.ReadOnly = false;
                            textBoxSec.ReadOnly = false;
                            btnHistoTimer.Enabled = true;
                            btnBMtoTimer.Enabled = true;
                            btnStart.Enabled = true;
                            break;

                        case false:
                            textBoxHour.ReadOnly = true;
                            textBoxMin.ReadOnly = true;
                            textBoxSec.ReadOnly = true;
                            btnHistoTimer.Enabled = false;
                            btnBMtoTimer.Enabled = false;
                            btnStart.Enabled = false;
                            break;
                    }
                    break;

                case "stopwatch":
                    switch(enabled)
                    {
                        case true:
                            SWbtnStart.Enabled = true;
                            SWbtnReset.Enabled = true;
                            SWbtnStop.Enabled = false;
                            
                            break;

                        case false:
                            SWbtnStart.Enabled = false;
                            SWbtnReset.Enabled = false;
                            SWbtnStop.Enabled = true;

                            break;
                    }
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
                memory.listCountDownHistory.RemoveAt(index);
                memory.updateListViewMultiple(listViewHistory, memory.listCountDownHistory, memory.listCountDownRepeat);
            }
        }

        private void btnDelAllHis_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to clear all history", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                memory.listCountDownHistory.Clear();
                memory.updateListViewMultiple(listViewHistory, memory.listCountDownHistory, memory.listCountDownRepeat);

            }
        }

        private void btnHistoTimer_Click(object sender, EventArgs e)
        {
            initialise("countdown");

            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                setTextBoxes(memory.getSplittedTime(index, "history"));
                timeTick.setTimeList("countdown", memory.getSplittedTime(index, "history"));
            }

        }

        private void btnAddBMFrmTimer_Click(object sender, EventArgs e)
        {
            memory.addToListSingleCol(textBoxHour.Text, textBoxMin.Text, textBoxSec.Text, memory.listCountDownBookMarks);
            memory.updateListViewSingle(listViewBmark, memory.listCountDownBookMarks);
        }

        private void btnAddBMFrmHis_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                memory.listCountDownBookMarks.Insert(0,memory.listCountDownHistory[index]);
                memory.updateListViewSingle(listViewBmark, memory.listCountDownBookMarks);
            }
        }

        private void btnBMtoTimer_Click(object sender, EventArgs e)
        {
            initialise("countdown");

            if (listViewBmark.SelectedIndices.Count > 0)
            {
                int index = listViewBmark.SelectedIndices[0];
                setTextBoxes(memory.getSplittedTime(index, "bookmark"));
                timeTick.setTimeList("countdown", memory.getSplittedTime(index, "bookmark"));
            }
        }

        private void btnDelSelBM_Click(object sender, EventArgs e)
        {
            if (listViewBmark.SelectedIndices.Count > 0)
            {
                int index = listViewBmark.SelectedIndices[0];
                memory.listCountDownBookMarks.RemoveAt(index);
                memory.updateListViewSingle(listViewBmark, memory.listCountDownBookMarks);
            }
        }

        private void DellAllBM_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to clear all bookmarks", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                memory.listCountDownBookMarks.Clear();
                memory.updateListViewSingle(listViewBmark, memory.listCountDownBookMarks);

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
            memory.updateListViewMultiple(listViewHistory, memory.listCountDownHistory, memory.listCountDownRepeat);
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memory.loadFile("bookmark");
            memory.updateListViewSingle(listViewBmark, memory.listCountDownBookMarks);
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
            
            
            SWtimer.Interval = 1;
            SWtimer.Start();
            toggleAvaliabilityTextbox("stopwatch", false);
            
        }

       

        private void SWbtnStop_Click(object sender, EventArgs e)
        {
            toggleAvaliabilityTextbox("stopwatch", true);
            SWtimer.Stop();
            memory.listSWHistory.Add(SWTextBoxHr.Text + ":" + SWTextBoxMin.Text + ":" + SWTextBoxSec.Text + ":" + SWTextBoxMiSec.Text);
            memory.updateListViewSingle(SWListViewHis, memory.listSWHistory);
            //MessageBox.Show(memory.listSWHistory[0]);
            


        }

        private void SWbtnReset_Click(object sender, EventArgs e)
        {
            initialise("stopwatch");
        }

        

        private void SWtimer_Tick(object sender, EventArgs e)
        {
            
            timeTick.updateTime("stopwatch", SWcurrent);
            updateTextBoxes("stopwatch");
            SWcurrent++;
        }

        private void SwBtnLoad_Click(object sender, EventArgs e)
        {
            memory.loadFile("stopwatch");
            memory.updateListViewSingle(SWListViewHis, memory.listSWHistory);
        }

        private void SWBtnSave_Click(object sender, EventArgs e)
        {
            memory.saveFile("stopwatch");
        }

        private void SWBtnDel_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(SWListViewHis.SelectedIndices.Count > 0)
            {
                index = SWListViewHis.SelectedIndices[0];
                memory.listSWHistory.RemoveAt(index);
                memory.updateListViewSingle(SWListViewHis, memory.listSWHistory);
            }
        }
    }
}
