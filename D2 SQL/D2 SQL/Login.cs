using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2_SQL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
          

            try
            {

                // if both textboxes have text in them
                if (textBoxUser.Text != "" && textBoxPassword.Text != "")
                {
                    // get the username and password 
                    username = textBoxUser.Text.Trim();
                    password = textBoxPassword.Text.Trim();

                    // GET THE DATA FROM THE MANAGERS TABLE IN THE DATABASE
                    SQL.selectQuery("SELECT*FROM MANAGER");

                    // If there is data in the data base
                    if (SQL.read.HasRows)
                    {
                        
                        while (SQL.read.Read())
                        {
                            // if the username and password are in the data base
                            if (username.Equals(SQL.read[0].ToString()) && password.Equals(SQL.read[1]))
                            {
                                // log them in 
                                MessageBox.Show("Welcome" + " " + username);
                                // switch to data screen
                                Hide();
                                DisplayPage displayPage = new DisplayPage();
                                displayPage.ShowDialog();
                                Close();
                               
                            }
                            
                        }
                        // show if username or password are incorrect/not in the database
                        MessageBox.Show("Please Check Username and Password are correct");
                    }
                    // else database must be empty
                    else
                    {
                        MessageBox.Show("The Data base has no Data");
                    }
                    

                }
                // else there must be an empty field
                else
                {
                    MessageBox.Show("Please enter a Username and Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }


        }
    }
}
