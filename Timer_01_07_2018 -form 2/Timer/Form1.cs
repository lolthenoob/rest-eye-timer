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
        //declare new instances of classess
        timeKeeping timeTick = new timeKeeping();
        storage memory = new storage();
        Form2 confimationForm = new Form2();
 

        //Set the current time for all stopwatche ot 0
        int CDCurrent = 0;
        int SWcurrent = 0;
        int RECurrent = 0;

        //Set the number of repeats for the counydown timer to 0
        int CDnumRepeat = 0;


        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// EventHandler for Form1_load
        /// It initialise the program by stting all textboxes to its appropriate text
        /// It basicly create all objects on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the text for the time textboxes(hour/min/sec) for the rest eye timer to 00:20:00
            REtextBoxSetHr.Text = "00";
            REtextBoxSetMin.Text = "20";
            REtextBoxSetSec.Text = "00";

            //Initialises the timers; countdown, stopwatch, rest eye
            //The initialise(0 function reverts all controls and variables for the timer to its original value
            initialise("countdown");
            initialise("stopwatch");
            initialise("resteye");

            //Disable certain controls for each of the timer
            //For example, the stop button is disabled for all timers to prevent user from pressing it
            toggleAvaliabilityControl("countdown", true);
            toggleAvaliabilityControl("stopwatch", true);
            toggleAvaliabilityControl("resteye", true);

            //Set the text of the repeat textbox for the countdown timer to one
            //This means the timer will not repeat.
            //Then disable it
            textBoxRepeat.Text = "1";
            textBoxRepeat.Enabled = false;

            //Disable the textboxes for displaying time in the rest eye timer
            REtextBoxSetHr.Enabled = false;
            REtextBoxSetMin.Enabled = false;
            REtextBoxSetSec.Enabled = false;

            //Create columns for the listview that displays countdown timer's history
            listViewHistory.Columns.Add("Timing", 60, HorizontalAlignment.Center);
            listViewHistory.Columns.Add("Repeats", 80, HorizontalAlignment.Center);
            listViewHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewHistory.Font = new Font("Arial", 8, FontStyle.Bold);

            //Create columns for the listview the displays the rest eye timer's history
            REListViewHistory.Columns.Add("Date", 150);
            REListViewHistory.Columns.Add("Period", 60);
            REListViewHistory.Columns.Add("EyeSight Exercise", 180);
            REListViewHistory.Font = new Font("Arial", 9, FontStyle.Bold);

            //Create columns for the listview that contains the countdown timer's bookmarks
            listViewBmark.Columns.Add("", 60);
            listViewBmark.HeaderStyle = ColumnHeaderStyle.None;

            //Create columns for stopwatch history listview
            SWListViewHis.Columns.Add("", 100);

            //Load the savefile(.txt) for each of the timers
            //This loads the text file and adds it to the correct list
            memory.loadFile("history");
            memory.loadFile("bookmark");
            memory.loadFile("stopwatch");
            memory.loadFile("resteye");

            //Update the listviews(countdown's history & bookmarks, stopwatch's history)
            memory.updateListViewSingle(listViewBmark, memory.listCDBookMarks);
            memory.updateListViewMultiple(listViewHistory, memory.listCDHistory, memory.listCDRepeat);
            memory.updateListViewSingle(SWListViewHis, memory.listSWHistory);

            //Create new listview item and insert correct valkues
            //The listview item is put into resteye's history
            ListViewItem item = new ListViewItem();
            item.Text = memory.listREDate[0];
            item.SubItems.Add(memory.listREHistory[0]);
            item.SubItems.Add(memory.listREConfirmationTimer[0].ToString());
            REListViewHistory.Items.Insert(0, item);

            //Add new eventhandler for VisibleChanged for confimation form which is displayed when rest eye timer reaches 00:00:00
            confimationForm.VisibleChanged += confirmationForm_VisibleChanged;
        }

        /// <summary>
        /// Evenhandler for clicking "start" button in the countdown timer
        /// It begins the countdown timer and updates time display textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            CDTimer.Stop(); //Stops the countdown timer

            try
            {
                //Set the time display textbox to correct vakue(which is stored in timetick class)
                timeTick.setTimeInt("countdown", textBoxHour.Text, textBoxMin.Text, textBoxSec.Text);

                //Get number of repeats user wants
                CDnumRepeat = int.Parse(textBoxRepeat.Text);

                //Set the total time(of the countdown timer) to 0; this variable is stored in timetick class
                timeTick.CDTotalTime = 0;

                //Get the current time in seconds form varaibles stored timetick class
                CDCurrent = timeTick.CDHour * 3600 + timeTick.CDMin * 60 + timeTick.CDSec;

                //Check if the time inputed by user is greater than 0, and if minute and second values are less than 60
                if (timeTick.CDHour * 3600 + timeTick.CDMin * 60 + timeTick.CDSec > 0 && timeTick.CDMin <= 60 && timeTick.CDSec <= 60)
                {
                    //Update listCDHistory(stores countdown timer history) then 
                    //update the listViewCDHistory(displays countdown timer history) with listcd history
                    memory.addToListMultipleCol(textBoxHour.Text, textBoxMin.Text, textBoxSec.Text, textBoxRepeat.Text);
                    memory.updateListViewMultiple(listViewHistory, memory.listCDHistory, memory.listCDRepeat);

                    //Set interval for countdown timer and start it
                    CDTimer.Interval = 1000;
                    CDTimer.Start();

                    //Disable "start" button and set time display textboxes to readonly
                    //It also disables putting time values from history and bookmarks into timer
                    toggleAvaliabilityControl("countdown", false);
                }

                else
                {
                    //If inputed time values(minutes/seconds > 60 or total time <= 0) were incorrect display a error message
                    MessageBox.Show("Please enter a valid value", "Error", MessageBoxButtons.OK);

                    //Set all values and controls for countdown timer to the original
                    initialise("countdown");
                }
            }

            catch
            {
                //If values where not integers, display a error message
                MessageBox.Show("Please enter positive integers to all textBoxes", "Error", MessageBoxButtons.OK);

                //Set all values and controls for countdown timer to the original
                initialise("countdown");
            }
        }


        /// <summary>
        /// Eventhandler for countdown timer's "reset" button
        /// It Set all values and controls for countdown timer to the original
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Set all values and controls for countdown timer to the original
            initialise("countdown");
        }

        /// <summary>
        /// Eventhandler for countdown timer's "stop" button
        /// It stops the CDTimer(which is the timer component for countdown timer)
        /// Effectively pausing the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            //Stop the timer
            CDTimer.Stop();

            //Disable "stop button", but enables the time display textboxes, the "start" button and the buttons which facititate putting time values form listviews to display textboxes
            toggleAvaliabilityControl("countdown", true);

            //Update the countdown timer's time display textboxes with correct varaibles form timetick classes
            updateTextBoxes("countdown");

        }

        /// <summary>
        /// EventHandler for ticking/ unticking checkBox repeat in countdown timer
        /// It enables/disable the user setting desired repeat number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            //Enables textBoxRepeat
            textBoxRepeat.Enabled = true;
        }

        /// <summary>
        /// Eventhandler when CDTimer ticks.
        /// It updates the correct varaibles, list and textboxes
        /// If teh CDCurrent is 0, it stops counting down
        /// However, if numRepeat is > 1, it will restart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTiming_Tick(object sender, EventArgs e)
        {
            //Update varaibles for storing current time in timeTick class
            timeTick.MultUpdateTime("countdown", CDCurrent, timeTick.CDHour, timeTick.CDMin, timeTick.CDSec, timeTick.CDTotalTime);

            //Update the countdown textboxes with corrct value form time keeping variables in timetick class
            updateTextBoxes("countdown");

            if (CDCurrent > 0)
            {
                CDCurrent--;
            }

            if (CDCurrent == 0)
            {

                if (CDnumRepeat == 1)
                {
                    CDTimer.Stop();
                    toggleAvaliabilityControl("countdown", true);
                    MessageBox.Show(memory.listCDHistory[0] + " has elapsed", "Timing has Ended", MessageBoxButtons.OK);
                    timeTick.CDTotalTime = 0;

                }


                if (CDnumRepeat > 1)
                {
                    CDnumRepeat--;
                    CDCurrent = timeTick.CDTotalTime;


                    setTextBoxes("countdown", memory.getSplittedTime(memory.listCDHistory.Count() - 1, memory.listCDHistory));
                    timeTick.setTimeList("countdown", memory.getSplittedTime(memory.listCDHistory.Count() - 1, memory.listCDHistory));
                    CDTimer.Stop();

                    if (MessageBox.Show(memory.listCDHistory.Last() + " has elapsed. " + "Repeating " + CDnumRepeat.ToString() + " more times", "Timing has Ended", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        CDTimer.Interval = 1000;
                        CDTimer.Start();
                    }
                }


            }



        }

        private void updateTextBoxes(string type)
        {
            switch (type)
            {
                case "countdown":
                    textBoxHour.Text = memory.padSingleString(timeTick.CDHour.ToString());
                    textBoxMin.Text = memory.padSingleString(timeTick.CDMin.ToString());
                    textBoxSec.Text = memory.padSingleString(timeTick.CDSec.ToString());
                    break;

                case "stopwatch":
                    SWTextBoxHr.Text = memory.padSingleString(timeTick.SWHour.ToString());
                    SWTextBoxMin.Text = memory.padSingleString(timeTick.SWMin.ToString());
                    SWTextBoxSec.Text = memory.padSingleString(timeTick.SWSec.ToString());
                    SWTextBoxMiSec.Text = memory.padSingleString(timeTick.SWMiSec.ToString());
                    break;

                case "resteye":
                    REtextBoxHr.Text = memory.padSingleString(timeTick.REHour.ToString());
                    REtextBoxMin.Text = memory.padSingleString(timeTick.REMin.ToString());
                    REtextBoxSec.Text = memory.padSingleString(timeTick.RESec.ToString());
                    break;
            }

        }

        private void initialise(string mode)
        {
            switch (mode)
            {
                case "countdown":
                    textBoxHour.Text = "00";
                    textBoxMin.Text = "00";
                    textBoxSec.Text = "00";
                    CDCurrent = 0;
                    timeTick.CDHour = 0;
                    timeTick.CDMin = 0;
                    timeTick.CDSec = 0;
                    CDTimer.Stop();
                    toggleAvaliabilityControl(mode, true);
                    break;

                case "stopwatch":
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

                case "resteye":
                    REtextBoxSetHr.Text = memory.SetEmptyTextBox(REtextBoxSetHr.Text);
                    REtextBoxSetMin.Text = memory.SetEmptyTextBox(REtextBoxSetMin.Text);
                    REtextBoxSetSec.Text = memory.SetEmptyTextBox(REtextBoxSetSec.Text);

                    REtextBoxHr.Text = REtextBoxSetHr.Text;
                    REtextBoxMin.Text = REtextBoxSetMin.Text;
                    REtextBoxSec.Text = REtextBoxSetSec.Text;

                    timeTick.REHour = 0;
                    timeTick.RESec = 0;
                    timeTick.REMin = 0;
                    timeTick.RESec = 0;

                    RECurrent = 0;
                    REtimer.Stop();
                    toggleAvaliabilityControl(mode, true);
                    break;
            }

        }

        private void toggleAvaliabilityControl(string type, bool enabled)
        {

            switch (type)
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
                            btnStop.Enabled = false;
                            break;

                        case false:
                            textBoxHour.ReadOnly = true;
                            textBoxMin.ReadOnly = true;
                            textBoxSec.ReadOnly = true;

                            btnHistoTimer.Enabled = false;
                            btnBMtoTimer.Enabled = false;


                            btnStart.Enabled = false;
                            btnStop.Enabled = true;
                            break;
                    }
                    break;

                case "stopwatch":
                    switch (enabled)
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

                case "resteye":

                    switch (enabled)
                    {
                        case true:
                            REbtnStart.Enabled = true;
                            REbtnStop.Enabled = false;

                            break;

                        case false:
                            REbtnStart.Enabled = false;
                            REbtnStop.Enabled = true;
                            break;
                    }
                    break;
            }


        }

        private void setTextBoxes(string type, string[] data)
        {
            switch (type)
            {
                case "countdown":
                    textBoxHour.Text = data[0];
                    textBoxMin.Text = data[1];
                    textBoxSec.Text = data[2];
                    break;

                case "resteye":
                    REtextBoxHr.Text = data[0];
                    REtextBoxMin.Text = data[1];
                    REtextBoxSec.Text = data[2];
                    break;
            }

        }

        private void btnDelSelHis_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                memory.listCDHistory.RemoveAt(index);
                memory.listCDRepeat.RemoveAt(index);

                memory.updateListViewMultiple(listViewHistory, memory.listCDHistory, memory.listCDRepeat);
            }
        }

        private void btnDelAllHis_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to clear all history", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                memory.listCDHistory.Clear();
                memory.updateListViewMultiple(listViewHistory, memory.listCDHistory, memory.listCDRepeat);

            }
        }

        private void btnHistoTimer_Click(object sender, EventArgs e)
        {
            initialise("countdown");

            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                setTextBoxes("countdown", memory.getSplittedTime(index, memory.listCDHistory));
                timeTick.setTimeList("countdown", memory.getSplittedTime(index, memory.listCDHistory));
            }

        }

        private void btnAddBMFrmTimer_Click(object sender, EventArgs e)
        {
            memory.addToListSingleCol(textBoxHour.Text, textBoxMin.Text, textBoxSec.Text, memory.listCDBookMarks);
            memory.updateListViewSingle(listViewBmark, memory.listCDBookMarks);
        }

        private void btnAddBMFrmHis_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count > 0)
            {
                int index = listViewHistory.SelectedIndices[0];
                memory.listCDBookMarks.Insert(0, memory.listCDHistory[index]);
                memory.updateListViewSingle(listViewBmark, memory.listCDBookMarks);
            }
        }

        private void btnBMtoTimer_Click(object sender, EventArgs e)
        {
            initialise("countdown");

            if (listViewBmark.SelectedIndices.Count > 0)
            {
                int index = listViewBmark.SelectedIndices[0];
                setTextBoxes("countdown", memory.getSplittedTime(index, memory.listCDBookMarks));
                timeTick.setTimeList("countdown", memory.getSplittedTime(index, memory.listCDBookMarks));
            }
        }

        private void btnDelSelBM_Click(object sender, EventArgs e)
        {
            if (listViewBmark.SelectedIndices.Count > 0)
            {
                int index = listViewBmark.SelectedIndices[0];
                memory.listCDBookMarks.RemoveAt(index);
                memory.updateListViewSingle(listViewBmark, memory.listCDBookMarks);
            }
        }

        private void DellAllBM_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to clear all bookmarks", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                memory.listCDBookMarks.Clear();
                memory.updateListViewSingle(listViewBmark, memory.listCDBookMarks);

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

            switch (selection)
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
            memory.updateListViewMultiple(listViewHistory, memory.listCDHistory, memory.listCDRepeat);
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memory.loadFile("bookmark");
            memory.updateListViewSingle(listViewBmark, memory.listCDBookMarks);
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
            toggleAvaliabilityControl("stopwatch", false);

        }



        private void SWbtnStop_Click(object sender, EventArgs e)
        {
            toggleAvaliabilityControl("stopwatch", true);
            SWtimer.Stop();
            memory.listSWHistory.Insert(0, SWTextBoxHr.Text + ":" + SWTextBoxMin.Text + ":" + SWTextBoxSec.Text + ":" + SWTextBoxMiSec.Text);
            memory.updateListViewSingle(SWListViewHis, memory.listSWHistory);
            //MessageBox.Show(memory.listSWHistory[0]);



        }

        private void SWbtnReset_Click(object sender, EventArgs e)
        {
            initialise("stopwatch");
        }



        private void SWtimer_Tick(object sender, EventArgs e)
        {

            timeTick.SWUpdateTime(SWcurrent);
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
            if (SWListViewHis.SelectedIndices.Count > 0)
            {
                index = SWListViewHis.SelectedIndices[0];
                memory.listSWHistory.RemoveAt(index);
                memory.updateListViewSingle(SWListViewHis, memory.listSWHistory);
            }
        }

        private void REbtnStart_Click(object sender, EventArgs e)
        {
            REtimer.Stop();
            toggleAvaliabilityControl("resteye", false);

            if (RECurrent == 0)
            {

                try
                {

                    timeTick.setTimeInt("resteye", REtextBoxSetHr.Text, REtextBoxSetMin.Text, REtextBoxSetSec.Text);
                    timeTick.RETotalTime = 0;
                    RECurrent = timeTick.REHour * 3600 + timeTick.REMin * 60 + timeTick.RESec;

                    if (RECurrent > 0 && timeTick.CDMin <= 60 && timeTick.CDSec <= 60)
                    {
                        updateTextBoxes("resteye");
                        memory.addToListSingleCol(REtextBoxSetHr.Text, REtextBoxSetMin.Text, REtextBoxSetSec.Text, memory.listREHistory);


                        REtimer.Interval = 1000;
                        REtimer.Start();
                    }

                    else
                    {
                        initialise("resteye");
                        MessageBox.Show("Please enter a valid value", "Error", MessageBoxButtons.OK);
                    }
                }

                catch
                {
                    initialise("resteye");
                    MessageBox.Show("Please enter positive integers to all textBoxes", "Error", MessageBoxButtons.OK);
                }
            }


            else
            {
                REtimer.Start();
            }

        }

        private void RECheckboxSet_CheckedChanged(object sender, EventArgs e)
        {
            REtextBoxSetHr.Enabled = true;
            REtextBoxSetMin.Enabled = true;
            REtextBoxSetSec.Enabled = true;
        }

        private void REtimer_Tick(object sender, EventArgs e)
        {
            timeTick.MultUpdateTime("resteye", RECurrent, timeTick.REHour, timeTick.REMin, timeTick.RESec, timeTick.RETotalTime);
            updateTextBoxes("resteye");

            if (RECurrent == 0)
            {
                RECurrent = timeTick.RETotalTime;


                setTextBoxes("resteye", memory.listREHistory[0].Split(':'));
                timeTick.setTimeList("resteye", memory.listREHistory[0].Split(':'));

                memory.listREDate.Insert(0, DateTime.Now.ToString());

                REtimer.Stop();
                confimationForm.Show();

                

            }

            else if (RECurrent > 0)
            {
                RECurrent--;
            }


        }

        private void REbtnStop_Click(object sender, EventArgs e)
        {
            toggleAvaliabilityControl("resteye", true);
            REtimer.Stop();
        }

        private void REBtnReset_Click(object sender, EventArgs e)
        {
            initialise("resteye");
            toggleAvaliabilityControl("resteye", true);

        }

        private void confirmationForm_VisibleChanged(object sender, EventArgs e)
        {
            if(confimationForm.Visible == true)
            {
                confimationForm.currentTime = 0;
                confimationForm.SECtimer.Start();               
            }

            if(confimationForm.Visible == false)
            {
                memory.listREConfirmationTimer.Insert(0, confimationForm.currentTime);
                memory.addToListSingleCol(REtextBoxSetHr.Text, REtextBoxSetMin.Text, REtextBoxSetSec.Text, memory.listREHistory);

                ListViewItem item = new ListViewItem();

                item.Text = memory.listREDate[0];
                item.SubItems.Add(memory.listREHistory[0]);
                item.SubItems.Add(memory.listREConfirmationTimer[0].ToString());

                REListViewHistory.Items.Insert(0,item);
                confimationForm.SECtimer.Stop();
                REtimer.Start();
                
               
            }
        }

        private void REBtnSave_Click(object sender, EventArgs e)
        {
            memory.saveFile("resteye");
        }
    }
}
