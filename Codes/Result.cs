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
    public partial class Result : Form
    {
        //Find the date and write into the username
        string InputDate;
        int correction;
        string total;
        int chapter;
        double calculation;        
        string Percentage;
       
        //store user answers in the array
        String[] give_back = new String[13];
        //Store the pagenumber of the question from text file
        string[] pagenumber;
        string time;
        string name;
        string[] separators = { "|", "." };
        string[] score;
        int people_list;
        string new_tester ="";

        //The check variable is use to act as a counter so when user went back to Chapter Question screen from
        //Result screen and come back to Result screen, this will not let them add the same test score.
        int check = 0;
        public Result(int _correct, string []arrayC, int c, string[] returnf, string t, string user, int count)
        {
            InitializeComponent();
            check = count;
            name = user;
            correction = _correct;
            //Calculate the percentage and round up to two decimal
            calculation = Convert.ToDouble(correction / Convert.ToDouble(12));
            calculation = calculation * 100;
            calculation = Math.Round(calculation, 2);

            chapter = c;

            total = _correct.ToString();
            Percentage = calculation.ToString();

            lbltotal.Text = total + "/12";           
            lblPercent.Text = Percentage + "%";

            time = t;
            lbltime.Text = time;

            //String of the current date
            InputDate = DateTime.Now.ToString("MM/dd/yyyy");

            //A switch case to know which questions are from so it can read the page number from the 
            //text file of the chapter
            switch (chapter)
            {
                case 3:
                    pagenumber = System.IO.File.ReadAllLines("chapter3.txt");
                    break;
                case 4:
                    pagenumber = System.IO.File.ReadAllLines("chapter4.txt");
                    break;
                case 5:
                    pagenumber = System.IO.File.ReadAllLines("chapter5.txt");
                    break;
                case 8:
                    pagenumber = System.IO.File.ReadAllLines("chapter8.txt");
                    break;
                case 9:
                    pagenumber = System.IO.File.ReadAllLines("chapter9.txt");
                    break;
                case 10:
                    pagenumber = System.IO.File.ReadAllLines("chapter10.txt");
                    break;
            }

            //Output the Question number and if the user answered correct or incorrect
            //on the data grid. 
            
            for(int i = 1; i <= 12; ++i)
            {
                ResultGrid.Rows.Add("Question " +i, arrayC[i], pagenumber[i]);
                give_back[i] = returnf[i];
            }
            //This for loop change the text color of "Incorrect" to red and "Correct" to 
            //green in the datagridview
            for (int i = 0; i < 12; ++i)
            {
                if (ResultGrid.Rows[i].Cells[1].Value.ToString() == "Incorrect")
                    ResultGrid.Rows[i].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Red};
                else
                    ResultGrid.Rows[i].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Green};
            }

            //Don't let the Result datagrid to sort
            for (int i = 0; i < 3; ++i)
            {
                ResultGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Make the extra space after the last row in ResultGrid to different color
            ResultGrid.BackgroundColor = System.Drawing.SystemColors.Control; 


            //The check was use as a counter when user return back to Result Screen
            //after viewing the correct answer, the program will not add the score 
            //again.
            if (check == 0)
            {
                //Will write the new score into the score.txt score = System.IO.File.ReadAllLines("score.txt");
                //Find how many in the textfile
                string line = "";
                StreamReader sr = new StreamReader("score.txt");
                int counter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    ++counter;
                }
                score = new String[counter];
                sr.Close();

                //Copy every line into array
                StreamReader sr2 = new StreamReader("score.txt");
                int counter2 = 0;
                while ((line = sr2.ReadLine()) != null)
                {
                    score[counter2] = line;
                    ++counter2;
                }
                sr2.Close();

                people_list = score.Count();
                //change the chapter from int to string
                string chp = c.ToString();
                //change the number of correct to string 
                string chapter_score = _correct.ToString();

                //This check if there are any users in the text file
                if (people_list > 0)
                {
                    //This function add new name, chapter or score to the text file contain 
                    //the record of the user's testing score
                    for (int i = 0; i < people_list; ++i)
                    {
                        string[] split = score[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        //The first value in word[] is the username, so when the username is match to the 
                        //username inputted from the login screen, then the datagrid will output the user's
                        //past test score
                        if (split[0] == user)
                        {
                            string new_score = chp + "." + chapter_score + "." + InputDate + "|";
                            score[i] = score[i].Replace(user + "|", user + "|" + new_score);
                            break;
                        }
                        //If the user doesn't have score in text file containing the score (score.txt) then add the name, chapter and score
                        else if (i == people_list - 1 && split[0] != user)
                        {
                            new_tester = user + "|" + chp + "." + chapter_score + "." + InputDate + "|";
                            break;
                        }
                    }
                }
                //If there are no users in the textfile just add it in
                else
                {
                    new_tester = user + "|" + chp + "." + chapter_score + "." + InputDate + "|";
                }
                sr.Close();
                //This would write back all the name, chapter and score back to the text file
                StreamWriter sw = new StreamWriter("score.txt");
                for (int i = 0; i < score.Length; ++i)
                {
                    sw.WriteLine(score[i]);
                }
                //If the user have not yet take the test, then this function will write the user
                //name, chapter and score in the text file
                if (new_tester != "")
                {
                    sw.WriteLine(new_tester);
                }
                sw.Close();
            }
        }

        /* When the Back to Question button was clicked, user will go back to
           the questions they just answered to check the correct answer.            
           The variable check will add one everytime user click Back to Question
           button to be set as counter, so when user return back to Result Screen
           after viewing the correct answer, the program will not add the score 
           again.
         */
        private void btnBack_Click(object sender, EventArgs e)
        {
            check += 1;
            if (chapter == 3)
            {
                this.Hide();
                var form1 = new Chapter3(give_back, time, name, check);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else if (chapter == 4)
            {
                this.Hide();
                var form1 = new Chapter4(give_back, time, name, check);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else if (chapter == 5)
            {
                this.Hide();
                var form1 = new Chapter5(give_back, time, name, check);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else if (chapter == 8)
            {
                this.Hide();
                var form1 = new Chapter8(give_back, time, name, check);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else if (chapter == 9)
            {
                this.Hide();
                var form1 = new Chapter9(give_back, time, name,check);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else if (chapter == 10)
            {
                this.Hide();
                var form1 = new Chapter10(give_back, time, name,check);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }          
        }

        //Go to the Login Screen once the Log off button is clicked
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            correction = 0;
            this.Hide();
            var form1 = new Login();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
