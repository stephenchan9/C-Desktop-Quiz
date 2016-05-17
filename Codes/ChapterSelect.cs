using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ChapterSelect : Form
    {
        string name; 
        public ChapterSelect(string user)
        {
            InitializeComponent();
            name = user;
        }

        //Click one of the chapter button to start answering the
        //chapter question with name parameter pass so later on
        //it could add the score to the correct user.
        private void btnC3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Chapter3(name);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Chapter4(name);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Chapter5(name);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Chapter8(name);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Chapter9(name);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Chapter10(name);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        //Log off
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Login();
            form3.Closed += (s, args) => this.Close();
            form3.Show();

        }

        //Go to the Reveiw Screen with the username as a parameter,
        //so the program will know whose score to output in the
        //TotalScore.cs
        private void btnTotal_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new TotalScore(name);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }       
    }
}
