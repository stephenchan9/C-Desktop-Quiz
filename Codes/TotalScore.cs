using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class TotalScore : Form
    {       
        string tester;
        int people_list;
        //The delimiter
        string[] separators = { "|", "."};

        List<String> list = new List<String>();       
        public TotalScore(string user)
        {
            InitializeComponent();
            tester = user;
            string line = "";

            //Read all the users and their name into list 
            StreamReader sr = new StreamReader("score.txt");
            while ((line = sr.ReadLine()) != null)
            {
                list.Add(line);             
            }           
            //count number of index in list
            people_list=list.Count();
            string ch;   //chapter
            string chp_score;  //chapter score
            string date_taken; //The date of when test was taken
            for (int i = 0; i < people_list; ++i)
            {
                //In the word array, it will contain a username and his or her score
                string[] words = list[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                //The first value in word[] is the username, so when the username is match to the 
                //username inputted from the login screen, then the datagrid will output the user's
                //past test score
                if (words[0] == user)
                {
                    //This count how many chapter scores are in the words array
                    int m = words.Count();
                    //Input the chapter and the chapter score into the DataGrid
                    for (int j = 1; j < m; ++j)
                    {
                        ch = words[j];
                        ++j;
                        chp_score = words[j];
                        ++j;
                        date_taken = words[j];
                        TotalGrid.Rows.Add(ch, chp_score, date_taken);
                    }
                }                
            }
            sr.Close();

            //Don't let the Result datagrid's chapter and score to sort, but
            //able to let the date to sort, so users can choose to look from
            //newest to oldest or oldest to newest.
            for (int i = 0; i < 2; ++i)
            {
                TotalGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Make the extra space after the last row in TotalGrid to different color
            TotalGrid.BackgroundColor = System.Drawing.SystemColors.Control;           
        }

        //Return back to the chapter menu screen
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new ChapterSelect(tester);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
