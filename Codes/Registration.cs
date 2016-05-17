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
    public partial class Registration : Form
    {
        //Array to store all the username and password from the textfile
        string[] register;

        public Registration()
        {
            InitializeComponent();
        }

        //If Member login button is click go to the Login form
        //and close the current form
        private void btnmember_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Login();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        //Register for new members and Read the text file to see if 
        //there had already been the same password or username
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtPass.Text;
            string password = txtPass.Text;

            //Read the text file to check how many array index is needed
            string line = "";
            //The count is used to see how many users are in the text file
            int count = 0;
            StreamReader read_newmember = new StreamReader("members.txt");
            while ((line = read_newmember.ReadLine()) != null)
            {
                ++count;
            }
            read_newmember.Close();
            register = new String[count];

            //If there are other members 
            if (count > 0)
            {
                //Copy every line in members.txt into array
                StreamReader read_newmember2 = new StreamReader("members.txt");
                int counter2 = 0;
                while ((line = read_newmember2.ReadLine()) != null)
                {
                    register[counter2] = line;
                    ++counter2;
                }
                read_newmember2.Close();
            }
            
            //These are the restrictions for the username
            //Username textbox is blank
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please enter username.");
            }
            //Username is less than 5 characters
            else if (txtUser.Text.Length < 5)
            {                
                MessageBox.Show("Username need more than 5 characters.");
            }
            //These are the restriction for the password
            //Password textbox is blank
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Please enter password (Maximum 20 characters.");
            }
            //Password is less than 8 characters
            else if (txtPass.Text.Length < 8)
            {
                MessageBox.Show("Password need more than 8 characters.");
            }
            else
            {
                if (count > 0)
                {
                    for (int j = 0; j < register.Length; ++j)
                    {
                        username = Convert.ToString(register[j]);
                        ++j;
                        //This would check to see if there had been the same username
                        if (txtUser.Text == username)
                        {
                            MessageBox.Show("There had already been the same username, please change to another one");
                            break;
                        }
                        //If reaches the end of file and still could not find the same username,
                        //then this would write the new username and password into members.txt 
                        else if (j == register.Length - 1 && txtUser.Text != username)
                        {
                            //Write back all the members back to textfile including 
                            //the new registered members
                            StreamWriter write_member = new StreamWriter("members.txt");
                            for (int i = 0; i < register.Length; ++i)
                            {
                                write_member.WriteLine(register[i]);
                            }
                            write_member.WriteLine(txtUser.Text);
                            write_member.WriteLine(txtPass.Text);
                            write_member.Close();

                            //Clear the textbox
                            AfterAdd();

                            //Go to the Login form after registering a new member
                            this.Hide();
                            var form1 = new Login();
                            form1.Closed += (s, args) => this.Close();
                            form1.Show();
                            break;
                        }
                    }
                }
                else
                {
                    //Write the new member's username and password into the text file
                    StreamWriter write_member = new StreamWriter("members.txt");                    
                    write_member.WriteLine(txtUser.Text);
                    write_member.WriteLine(txtPass.Text);
                    write_member.Close();

                    //Clear the textbox
                    AfterAdd();

                    //Go to the Login form after registering a new member
                    this.Hide();
                    var form1 = new Login();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }
            }
        }

        //After adding the new member, this function will be called 
        //to output a message telling users they become a member and
        //clear the textbox.
        public void AfterAdd()
        {
            MessageBox.Show("You have been added as members.");
            txtName.Clear();
            txtemail.Clear();
            txtUser.Clear();
            txtPass.Clear();
        }

    }
}


