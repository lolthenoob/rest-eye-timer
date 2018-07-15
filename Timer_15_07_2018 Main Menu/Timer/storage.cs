using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace timerProject
{
    public class storage
    {
       public  List<string> listCDHistory = new List<string>();
       public  List<string> listCDBookMarks = new List<string>();
       public  List<string> listCDRepeat = new List<string>();

       public List<string> listSWHistory = new List<string>();

       public List<string> listREHistory = new List<string>();
       public List<string> listREDate = new List<string>();
       public List<int> listREConfirmationTimer = new List<int>();


        public string[] getSplittedTime(int index, List<string> list)
       {
           string[] splitArray = new string[3];
           splitArray = list[index].Split(':');

            return splitArray;
       }

        public  void addToListMultipleCol( string a, string b, string c, string d)
        {
            string input = a.PadLeft(3 - a.Length, '0') + ":" + b.PadLeft(3 - a.Length, '0') + ":" + c.PadLeft(3 - c.Length, '0');

            listCDHistory.Insert(0, input);
            listCDRepeat.Insert(0, d);      
        }

        public void addToListSingleCol(string a, string b, string c,  List<string> listType)
        {
            
            string input = a.PadLeft(3 - a.Length, '0') + ":" + b.PadLeft(3 - a.Length, '0') + ":" + c.PadLeft(3 - c.Length, '0') ;
            listType.Insert(0, input);
        }

        public void updateListViewSingle(ListView listview, List<string> list)
        {
             listview.Items.Clear();

            
                  foreach(string j in list)
                    {
                        listview.Items.Add(j);
                    }
        
        }

        public void updateListViewMultiple(ListView listview, List<string> list1, List<string> list2)
        {
            listview.Items.Clear();
            for (int i = 0; i < list1.Count(); i++)
            {
                listview.Items.Add(list1[i]).SubItems.Add(list2[i]);
            }
        }

        public string padSingleString(string a)
        {
            string input = a;
            if (a.Length < 3)
            {
                input = a.PadLeft(3 - a.Length, '0');
            }
            return input;
        }

        public void loadFile(string type)
        {
            string line = "";
            int lineNum = 0;
            bool success = false;
            
            string filepath = Path.GetDirectoryName(Application.ExecutablePath) + type + ".txt";

            if (File.Exists(filepath) == false)
            {
                File.WriteAllBytes(filepath, new byte[0]);
            }

            using (StreamReader sr = new StreamReader(filepath))
            {
                while (!sr.EndOfStream)
                {

                    {
                        lineNum++;
                        line = sr.ReadLine();

                        switch(type)
                        {
                            case "history":
                                if (checkLoadedFile(line, "multiple") == true)
                                {
                                    string[] file = line.Split(',');
                                    listCDHistory.Add(file[0]);
                                    listCDRepeat.Add(file[1]);
                                    success = true;
                                }


                               
                                break;


                            case "bookmark":
                                if (checkLoadedFile(line, "single") == true)
                                {
                                    listCDBookMarks.Add(line);
                                    success = true;
                                }

                                
                                break;


                            case "stopwatch":
                                if (checkLoadedFile(line, "single") == true)
                                {
                                    listSWHistory.Add(line);
                                    success = true;
                                }

                                
                                break;

                            case "resteye":
                                if(checkLoadedFile(line, "resteye") == true)
                                {
                                    string[] csvArray = line.Split(',');

                                    listREDate.Add(csvArray[0]);
                                    listREHistory.Add(csvArray[1]);
                                    listREConfirmationTimer.Add(int.Parse(csvArray[2]));
                                    success = true;
                                }
                               
                                break;
                        }
                   }
                }
            }

            if(line.Trim().Length == 0)
            {
                success = true;
            }

            if(success == false)
            {
                MessageBox.Show("Error at line " + lineNum.ToString() + "in " + type + " file" + "\nRaw data: " + line, "Error", MessageBoxButtons.OK);
            }
        }

        private bool checkLoadedFile(string input, string type)
        {
            bool isValid = true;
            List<int> splittedTime = new List<int>();


            try
            {

                switch (type)
                {
                    case "multiple":
                        string[] arrayHis = input.Split(',');
                        int checkHistoryRepeat = int.Parse(arrayHis[1]);
                        string[] checkHistoryTIme = arrayHis[0].Split(':');

                        for (int i = 0; i < checkHistoryTIme.Length; i++ )
                        {
                            splittedTime.Add(int.Parse(checkHistoryTIme[i]));
                        }

                            break;

                    case "single":
                        string[] checkBmTime = input.Split(':');

                        for (int i = 0; i < checkBmTime.Length; i++)
                        {
                            splittedTime.Add(int.Parse(checkBmTime[i]));
                        }
                        break;

                    case "resteye":
                        string[] checkREValue = input.Split(',');
                        DateTime temp = DateTime.Parse(checkREValue[0]);
                        int eye = int.Parse(checkREValue[2]);

                        string[] checkRETime = checkREValue[1].Split(':');

                       foreach(string s in checkRETime)
                        {
                            splittedTime.Add(int.Parse(s));
                        }


                        break;
                }

                
            }

            catch
            {
                isValid = false;
            }

            if(isValid == true)
            {
                for (int t = 1; t < 3; t++)
                {
                    if (splittedTime[t] > 60)
                    {
                        isValid = false;
                    }
                }
            }
            

                return isValid;
        }

        public void saveFile(string type)
        {
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + type + ".txt"))
            {
                switch(type)
                {                 

                    case "history":

                        for (int i = 0; i < listCDHistory.Count(); i ++ )
                        {
                            string input = listCDHistory[i] + "," + listCDRepeat[i];
                            sw.WriteLine(input);
                        }
                            break;

                    case "bookmark":

                        for(int j = 0; j < listCDBookMarks.Count(); j++)
                        {
                            sw.WriteLine(listCDBookMarks[j]);
                        }
                        break;

                    case "stopwatch":
                        for (int k = 0; k < listSWHistory.Count(); k++)
                        {
                            sw.WriteLine(listSWHistory[k]);
                        }
                        break;

                    case "resteye":
                        for(int l = 0; l < listREDate.Count(); l++)
                        {
                            sw.WriteLine(listREDate[l] + "," + listREHistory[l] + "," + listREConfirmationTimer[l].ToString());
                        }
                        break;

                        
                }
            }

            MessageBox.Show("Successfully saved " + type + ".txt", "Success", MessageBoxButtons.OK);
        }

        public string SetEmptyTextBox(string input)
        {            
           if(input.Trim().Length == 0)
            {
                input = "00";
            }
           return input;
        }

      
        
    }
}
