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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Open the "members.txt" to see if the username and password
        //are correct, and let the user login into chapter select menu
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string line = "";
            string user;
            string pass;

            List<String> members = new List<String>();
            //Read in the username and password from members.txt into
            //members vector till end of file
            StreamReader read_member = new StreamReader("members.txt");
            while ((line = read_member.ReadLine()) != null)
            {
                members.Add(line);
            }
            for (int i = 0; i < members.Count(); ++i)
            {
                user = Convert.ToString(members[i]);
                ++i;
                //There is a username in members vector match the inputted
                //username in the text box, then it will match the password
                if (txtUser.Text == user)
                {
                    pass = Convert.ToString(members[i]);
                    //If password is correct,then user can log in with the
                    //username as a parameter which is use to find the 
                    //total score of the user later on 
                    if (txtPass.Text == pass)
                    {
                        i = 0;
                        this.Hide();
                        var form2 = new ChapterSelect(user);
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                        break;
                    }
                    //If password is incorrect,then the text box will
                    //be cleared and the message will show.
                    else
                    {
                        i = 0;
                        MessageBox.Show("Wrong password");
                        txtUser.Clear();
                        txtPass.Clear();
                        break;
                    }
                }
                //The username could not be found in the members vector
                //Then will show the message and clear the username and password 
                //textbox
                else if (i == members.Count - 1 && txtUser.Text != user)
                {
                    i = 0;
                    MessageBox.Show("Wrong username");
                    txtUser.Clear();
                    txtPass.Clear();
                    break;
                }
            }
            read_member.Close();
        }
        
        //Exit the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }  
    }
}
