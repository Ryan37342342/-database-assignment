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
    public partial class DisplayPage : Form
    {
        public DisplayPage()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            SQL.selectQuery("SELECT * FROM Customer");

         
            
            
          if(SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                   


                    listBoxCustomerData.Items.Add("User: "+  SQL.read[0].ToString());
                    listBoxCustomerData.Items.Add("Fname: " +SQL.read[1].ToString());
                    listBoxCustomerData.Items.Add("Lname: " +SQL.read[2].ToString());
                    listBoxCustomerData.Items.Add("password: " + SQL.read[3].ToString());
                    listBoxCustomerData.Items.Add("email: " +SQL.read[5].ToString());
                    listBoxCustomerData.Items.Add ("street: " +SQL.read[6].ToString());
                    listBoxCustomerData.Items.Add("city: "+ SQL.read[7].ToString());
                    listBoxCustomerData.Items.Add( "bank: " + SQL.read[8].ToString());
                    listBoxCustomerData.Items.Add( "good: " +SQL.read[9].ToString());
                    listBoxCustomerData.Items.Add( "join: " + SQL.read[10].ToString());
                    listBoxCustomerData.Items.Add ("DOB: " + SQL.read[11].ToString());
                    listBoxCustomerData.Items.Add("Gender: " + SQL.read[12].ToString());
                    listBoxCustomerData.Items.Add("MaxRentNum: " +SQL.read[13].ToString());
                    listBoxCustomerData.Items.Add("");
                   
                }
            }
            else
            {
                listBoxCustomerData.Items.Add("There is no Data in Data Base");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxCustomerData.Items.Clear();
        }
    }
}
