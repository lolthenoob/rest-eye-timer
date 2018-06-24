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
       public  List<string> listHistory = new List<string>();
       public  List<string> listBookMarks = new List<string>();
       public  List<string> listRepeat = new List<string>();


        public List<string> getSplittedTime(int index, string type)
       {
           string[] splitArray = new string[3];

            switch(type)
            {
                case "history":
                   splitArray = listHistory[index].Split(':');
                    break;

                case "bookmark":
                    splitArray = listBookMarks[index].Split(':');
                    break;
            }
            
            List<string> values = splitArray.ToList();

            return values;
       }

        public  void addHistoryList( string a, string b, string c, string d)
        {
            string input = a.PadLeft(3 - a.Length, '0') + ":" + b.PadLeft(3 - a.Length, '0') + ":" + c.PadLeft(3 - c.Length, '0');

            listHistory.Insert(0, input);
            listRepeat.Insert(0, d);      
        }

        public void addBookMarkListMultiple(string a, string b, string c)
        {
            string input = a.PadLeft(3 - a.Length, '0') + ":" + b.PadLeft(3 - a.Length, '0') + ":" + c.PadLeft(3 - c.Length, '0');
            listBookMarks.Insert(0, input);
        }

        public void updateListView(ListView listview, string type)
        {
             listview.Items.Clear();
        switch(type)
        { 
            case "history":

                 for(int i = 0; i < listHistory.Count(); i++)
                    {
                        listview.Items.Add(listHistory[i]).SubItems.Add(listRepeat[i]);
                    }
           break;

            case "bookmark":
                  foreach(string j in listBookMarks)
                    {
                        listview.Items.Add(j);
                    }
            break;
        }
        }

        public string padSingleString(string a)
        {
            string input = a.PadLeft(3 - a.Length, '0');
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
                File.CreateText(filepath);
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
                                if (checkLoadedFile(line, type) == true)
                                {
                                    string[] file = line.Split(',');
                                    listHistory.Add(file[0]);
                                    listRepeat.Add(file[1]);
                                }


                                else
                                {
                                    MessageBox.Show("Error at line " + lineNum.ToString() + "in " + type + " file" + "\nRaw data: " + line, "Error", MessageBoxButtons.OK);
                                }
                                break;


                            case "bookmark":
                                if (checkLoadedFile(line, type) == true)
                                {
                                    listBookMarks.Add(line);
                                }

                                else
                                {
                                    MessageBox.Show("Error at line " + lineNum.ToString() + "in " + type + " file"  + "\nRaw data: " + line, "Error", MessageBoxButtons.OK);
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
                    case "history":
                        string[] arrayHis = input.Split(',');
                        int checkHistoryRepeat = int.Parse(arrayHis[1]);
                        string[] checkHistoryTIme = arrayHis[0].Split(':');

                        for (int i = 0; i < checkHistoryTIme.Length; i++ )
                        {
                            splittedTime.Add(int.Parse(checkHistoryTIme[i]));
                        }

                            break;

                    case "bookmark":
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

                        for (int i = 0; i < listHistory.Count(); i ++ )
                        {
                            string input = listHistory[i] + "," + listRepeat[i];
                            sw.WriteLine(input);
                        }
                            break;

                    case "bookmark":

                        for(int j = 0; j < listBookMarks.Count(); j++)
                        {
                            sw.WriteLine(listBookMarks[j]);
                        }

                        break;
                }
            }
        }

      
        
    }
}
