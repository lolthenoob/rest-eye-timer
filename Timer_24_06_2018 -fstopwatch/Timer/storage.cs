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
       public  List<string> listCountDownHistory = new List<string>();
       public  List<string> listCountDownBookMarks = new List<string>();
       public  List<string> listCountDownRepeat = new List<string>();

       public List<string> listSWHistory = new List<string>();


        public List<string> getSplittedTime(int index, string type)
       {
           string[] splitArray = new string[3];

            switch(type)
            {
                case "history":
                   splitArray = listCountDownHistory[index].Split(':');
                    break;

                case "bookmark":
                    splitArray = listCountDownBookMarks[index].Split(':');
                    break;
            }
            
            List<string> values = splitArray.ToList();

            return values;
       }

        public  void addToListMultipleCol( string a, string b, string c, string d)
        {
            string input = a.PadLeft(3 - a.Length, '0') + ":" + b.PadLeft(3 - a.Length, '0') + ":" + c.PadLeft(3 - c.Length, '0');

            listCountDownHistory.Insert(0, input);
            listCountDownRepeat.Insert(0, d);      
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
            
            string filepath = Path.GetDirectoryName(Application.ExecutablePath) + type + ".txt";
            MessageBox.Show(filepath);

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
                                    listCountDownHistory.Add(file[0]);
                                    listCountDownRepeat.Add(file[1]);
                                }


                                else
                                {
                                    MessageBox.Show("Error at line " + lineNum.ToString() + "in " + type + " file" + "\nRaw data: " + line, "Error", MessageBoxButtons.OK);
                                }
                                break;


                            case "bookmark":
                                if (checkLoadedFile(line, "single") == true)
                                {
                                    listCountDownBookMarks.Add(line);
                                }

                                else
                                {
                                    MessageBox.Show("Error at line " + lineNum.ToString() + "in " + type + " file"  + "\nRaw data: " + line, "Error", MessageBoxButtons.OK);
                                }
                                break;


                            case "stopwatch":
                                if (checkLoadedFile(line, "single") == true)
                                {
                                    listSWHistory.Add(line);
                                }

                                else
                                {
                                    MessageBox.Show("Error at line " + lineNum.ToString() + "in " + type + " file" + "\nRaw data: " + line, "Error", MessageBoxButtons.OK);
                                }
                                break;

                                

                                

                            

                        }
                        







                    }
                }
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
                }

                
            }

            catch
            {
                isValid = false;
            }


            for (int t = 1; t < 3; t++ )
            {
                if(splittedTime[t] > 60)
                {
                    isValid = false;
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

                        for (int i = 0; i < listCountDownHistory.Count(); i ++ )
                        {
                            string input = listCountDownHistory[i] + "," + listCountDownRepeat[i];
                            sw.WriteLine(input);
                        }
                            break;

                    case "bookmark":

                        for(int j = 0; j < listCountDownBookMarks.Count(); j++)
                        {
                            sw.WriteLine(listCountDownBookMarks[j]);
                        }
                        break;

                    case "stopwatch":
                        for (int k = 0; k < listSWHistory.Count(); k++)
                        {
                            sw.WriteLine(listSWHistory[k]);
                        }
                        break;

                        
                }
            }

            MessageBox.Show("Successfully saved " + type + ".txt", "Success", MessageBoxButtons.OK);
        }

      
        
    }
}
