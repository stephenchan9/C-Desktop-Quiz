using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Chapter8 : Form
    {
        private System.DateTime startTime;
        private System.DateTime endTime;
        string time;
        //store how many questions user got correct
        int correction = 0;
        //arrayC store string of "correct" or "incorrect" for each question
        String[] arrayC = new String[13];
        //returnf store the users answer 
        String[] returnf = new String[13];
        //will let the program know which chapter the user is using when returning from result screen
        int chp = 0;
        //To use to remove extra space at start and end of text in textbox
        string trimtext = "";
        string name;
        int count;

        public Chapter8(string user)
        {
            InitializeComponent();
            // timer
            this.C8timer.Tick += new System.EventHandler(this.C8timer_Tick);
            C8timer.Start();
            startTime = DateTime.Now;
            name = user;
        }

        //When return from Result.cs, this function will have the answer inputted by users,
        //show the correct answer for each question
        //and disable all radio button and textbox to not let user able to change answers.
        public Chapter8(string[] giveback, string t, string user, int check)
        {
            InitializeComponent();
            count = check;
            name = user;
            //time
            time = t;
            lbltimer.Text = time;

            //Question 1
            if (giveback[1] == "true")
            {
                rdbTrue1.Checked = true;
            }
            else if (giveback[1] == "false")
            {
                rdbFalse1.Checked = true;
            }
            else
            {
                rdbTrue1.Checked = false;
                rdbFalse1.Checked = false;
            }

            //Question 2
            if (giveback[2] == "true")
            {
                rdbTrue2.Checked = true;
            }
            else if (giveback[2] == "false")
            {
                rdbFalse2.Checked = true;
            }

            //Question 3
            if (giveback[3] == "true")
            {
                rdbTrue3.Checked = true;
            }
            else if (giveback[3] == "false")
            {
                rdbFalse3.Checked = true;
            }
            
            //Qustion 4-6
            txtTBA1.Text = giveback[4];
            txtTBA2.Text = giveback[5];            
            txtTBA3.Text = giveback[6];

            //Question 7
            if (giveback[7] == "A")
                rdb7A.Checked = true;
            else if (giveback[7] == "B")
                rdb7B.Checked = true;
            else if (giveback[7] == "C")
                rdb7C.Checked = true;
            else if (giveback[7] == "D")
                rdb7D.Checked = true;

            //Question8
            if (giveback[8] == "A")
                rdb8A.Checked = true;
            else if (giveback[8] == "B")
                rdb8B.Checked = true;
            else if (giveback[8] == "C")
                rdb8C.Checked = true;
            else if (giveback[8] == "D")
                rdb8D.Checked = true;

            //Question9
            if (giveback[9] == "A")
                rdb9A.Checked = true;
            else if (giveback[9] == "B")
                rdb9B.Checked = true;
            else if (giveback[9] == "C")
                rdb9C.Checked = true;
            else if (giveback[9] == "D")
                rdb9D.Checked = true;
            //Question 10 -12
            txtQ10.Text = giveback[10];
            txtQ11.Text = giveback[11];
            txtQ12.Text = giveback[12];

            //Show the correct answer for every question
            showAns();
            //disable all radio button and textbox, so user cannot change answer
            disablebtn();           
        }

        //Go back to Chapter select form
        private void btnBack_Click(object sender, EventArgs e)
        {
            correction = 0;
            this.Hide();
            var form1 = new ChapterSelect(name);
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            C8timer.Stop();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //Question 1
            if (rdbTrue1.Checked)
            {
                correction += 1;
                arrayC[1] = "Correct";
                returnf[1] = "true";
            }
            else if (rdbFalse1.Checked)
            {
                arrayC[1] = "Incorrect";
                returnf[1] = "false";
            }


            //Question 2
            if (rdbFalse2.Checked)
            {
                correction += 1;
                arrayC[2] = "Correct";
                returnf[2] = "false";
            }
            else if (rdbTrue2.Checked)
            {
                arrayC[2] = "Incorrect";
                returnf[2] = "true";
            }
            else
            {
                arrayC[2] = "Incorrect";
                returnf[2] = "";
            }

            //Question 3
            if (rdbTrue3.Checked)
            {
                correction += 1;
                arrayC[3] = "Correct";
                returnf[3] = "true";
            }
            else if (rdbFalse3.Checked)
            {
                arrayC[3] = "Incorrect";
                returnf[3] = "false";
            }
            else
            {
                arrayC[3] = "Incorrect";
                returnf[3] = "";
            }

            //Question 4
            //This is able to remove extra space in the textbox, so when user
            //accidentally enter extra space at the start and end will still be correct
            trimtext = txtTBA1.Text.ToLower().Trim();
            if (trimtext == "stakeholders" || trimtext == "stakeholder")
            {
                correction += 1;
                arrayC[4] = "Correct";
                returnf[4] = txtTBA1.Text;
            }
            else
            {
                arrayC[4] = "Incorrect";
                returnf[4] = txtTBA1.Text;
            }

            //Question 5 
            trimtext = txtTBA2.Text.ToLower().Trim();
            if (trimtext == "relationship" || trimtext == "relationships")
            {
                correction += 1;
                arrayC[5] = "Correct";
                returnf[5] = txtTBA2.Text;             
            }
            else
            {
                arrayC[5] = "Incorrect";
                returnf[5] = txtTBA2.Text;               
            }

            //Question 6
            trimtext = txtTBA3.Text.ToLower().Trim();
            if (trimtext == "ambiguity")
            {
                correction += 1;
                arrayC[6] = "Correct";
                returnf[6] = txtTBA3.Text;
            }
            else
            {
                arrayC[6] = "Incorrect";
                returnf[6] = txtTBA3.Text;
            }

            //Question 7
            if (rdb7A.Checked)
            {
                correction += 1;
                arrayC[7] = "Correct";
                returnf[7] = "A";
            }
            else
            {
                arrayC[7] = "Incorrect";
                if (rdb7B.Checked)
                    returnf[7] = "B";
                else if (rdb7C.Checked)
                    returnf[7] = "C";
                else if (rdb7D.Checked)
                    returnf[7] = "D";
                else
                    returnf[7] = "E";
            }

            //Question 8
            if (rdb8C.Checked)
            {
                correction += 1;
                arrayC[8] = "Correct";
                returnf[8] = "C";
            }
            else
            {
                arrayC[8] = "Incorrect";
                if (rdb8A.Checked)
                    returnf[8] = "A";             
                else if (rdb8B.Checked)
                    returnf[8] = "B";
                else if (rdb8D.Checked)
                    returnf[8] = "D";
                else
                    returnf[8] = "E";
            }

            //Question 9
            if (rdb9D.Checked)
            {
                correction += 1;
                arrayC[9] = "Correct";
                returnf[9] = "D";
            }
            else
            {
                arrayC[9] = "Incorrect";
                if (rdb9A.Checked)
                    returnf[9] = "A";
                else if (rdb9B.Checked)
                    returnf[9] = "B";
                else if (rdb9C.Checked)
                    returnf[9] = "C";
                else
                    returnf[10] = "E";
            }

            //Question 10
            trimtext = txtQ10.Text.ToLower().Trim();
            if (trimtext == "c")
            {
                correction += 1;
                arrayC[10] = "Correct";
                returnf[10] = txtQ10.Text;
            }
            else
            {
                arrayC[10] = "Incorrect";
                returnf[10] = txtQ10.Text;
            }

            //Question 11
            trimtext = txtQ11.Text.ToLower().Trim();
            if (trimtext == "b")
            {
                correction += 1;
                arrayC[11] = "Correct";
                returnf[11] = txtQ11.Text;
            }
            else
            {
                arrayC[11] = "Incorrect";
                returnf[11] = txtQ11.Text;
            }

            //Question 12 
            trimtext = txtQ12.Text.ToLower().Trim();
            if (trimtext == "a")
            {
                correction += 1;
                arrayC[12] = "Correct";
                returnf[12] = txtQ12.Text;
            }
            else
            {
                arrayC[12] = "Incorrect";
                returnf[12] = txtQ12.Text;
            }
            //Let the Result.cs know this is chapter 8
            chp = 8;
            //Stop the timer
            C8timer.Stop();
            time = lbltimer.Text;
            //Go to Result.cs form with number of correct answered,
            //array with string of correct or incorrect of the question user answer
            //,which chapter the questions are from and the answer user inputted 
            this.Hide();
            var form1 = new Result(correction, arrayC, chp, returnf, time, name, count);
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            correction = 0;                 
        }

        private void Chapter8_Load(object sender, EventArgs e)
        {
            lblQ1.Focus();
        }

        //This function would disable all the radio button and textbox
        public void disablebtn()
        {
            PanelQ1.Enabled = false;
            PanelQ2.Enabled = false;
            PanelQ3.Enabled = false;
            txtTBA1.Enabled = false;
            txtTBA2.Enabled = false;
            txtTBA3.Enabled = false;
            PanelQ7.Enabled = false;
            PanelQ8.Enabled = false;
            PanelQ9.Enabled = false;
            txtQ10.Enabled = false;
            txtQ11.Enabled = false;
            txtQ12.Enabled = false;
        }
        /*This function would show all the correct answer and
          if user answered the correct answer, then the answer will
          be show. If users answered wrong, then the answer will be 
          red.*/
        public void showAns()
        {
            if (rdbTrue1.Checked == true)
                lblA1.ForeColor = System.Drawing.Color.Green;

            if (rdbFalse2.Checked == true)
                lblA2.ForeColor = System.Drawing.Color.Green;

            if (rdbTrue3.Checked == true)
                lblA3.ForeColor = System.Drawing.Color.Green;

            if (txtTBA1.Text == "stakeholder" || txtTBA1.Text == "stakeholders")
                lblA4.ForeColor = System.Drawing.Color.Green;

            if (txtTBA2.Text == "relationship" || txtTBA2.Text == "relationships")
                lblA5.ForeColor = System.Drawing.Color.Green;

            if (txtTBA3.Text == "ambiguity")
                lblA6.ForeColor = System.Drawing.Color.Green;

            if (rdb7A.Checked == true)
                lblA7.ForeColor = System.Drawing.Color.Green;

            if (rdb8C.Checked == true)
                lblA8.ForeColor = System.Drawing.Color.Green;

            if (rdb9D.Checked == true)
                lblA9.ForeColor = System.Drawing.Color.Green;

            if (txtQ10.Text == "c")
                lblA10.ForeColor = System.Drawing.Color.Green;

            if (txtQ11.Text == "b")
                lblA11.ForeColor = System.Drawing.Color.Green;

            if (txtQ12.Text == "a")
                lblA12.ForeColor = System.Drawing.Color.Green;
            lblA1.Text = "Answer: True";
            lblA2.Text = "Answer: False";
            lblA3.Text = "Answer: True";
            lblA4.Text = "Answer: Stakeholders";
            lblA5.Text = "Answer: Relationship";
            lblA6.Text = "Answer: Ambiguity";
            lblA7.Text = "Answer: Begins during the communication activity and modeling activity";
            lblA8.Text = "Answer: Group members from the software team and other stakeholders also attend the meeting";
            lblA9.Text = "Answer: How the final product is influenced by the stakeholders";
            lblA10.Text = "Answer: C";
            lblA11.Text = "Answer: B";
            lblA12.Text = "Answer: A";
        }
        private void testclick(DateTime endTime)
        {
            TimeSpan endoftime = (endTime - startTime);
            int x = int.Parse(endoftime.Seconds.ToString());
            string elapsedTime = String.Format("{1:00}:{2:00}",
                endoftime.Hours, endoftime.Minutes, endoftime.Seconds,
                endoftime.Milliseconds / 10);            

            lbltimer.Text = elapsedTime;

            //When the timer get to 25:00, this function will perform the
            //click function on Finish button to finish the test
            if (lbltimer.Text == "25:00")
            {
                lbltimer.ForeColor = Color.Black;
                btnFinish.PerformClick();
            }
            //Will beep twice when time is at 24:50 as a reminder
            if (x == 1490)
            {
                Console.Beep();
                Thread.Sleep(500);
            }
            if (x > 1489 && x <= 1500)
            {
                //Make the label flash red at the last ten second
                if (lbltimer.ForeColor == Color.Black)
                    lbltimer.ForeColor = Color.Red;
                else
                    lbltimer.ForeColor = Color.Black;
            }     
        }
        private void C8timer_Tick(object sender, EventArgs e)
        {
            endTime = DateTime.Now;
            testclick(endTime);
        }
    }
}

