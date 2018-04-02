using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace ResidentHall
{
    public partial class NewResident : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ResidentHall;Integrated Security=True;");
        public NewResident()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Selection sel = new Selection();
            sel.Show();
        }
        string residentType;
        private void change_floorList()
        {
            floorsList.Items.Clear();
            switch (residentType)
            {
                case "Athlete":
                    floorsList.Items.Add("4");
                    floorsList.Text = "4";
                    floorsList.Items.Add("5");
                    floorsList.Text = "5";
                    floorsList.Items.Add("6");
                    floorsList.Text = "6";
                    break;
                case "Scholarship":
                    floorsList.Items.Add("7");
                    floorsList.Text = "7";
                    floorsList.Items.Add("8");
                    floorsList.Text = "8";
                    break;
                case "Student Worker":
                    floorsList.Items.Add("1");
                    floorsList.Text = "1";
                    floorsList.Items.Add("2");
                    floorsList.Text = "2";
                    floorsList.Items.Add("3");
                    floorsList.Text = "3";
                    break;

            }
        }
        private void ResType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (residentType != ResType.SelectedItem.ToString())
            {
                residentType = ResType.SelectedItem.ToString();
                
                change_floorList();
            }

        }
        string residentFee;
        private void residentMonthlyFee()
        {
            if (residentType == "Scholarship")
            {
                residentFee = "100";
            }
            else if (residentType == "Athlete")
            {
                residentFee = "1200";
            }
            else
            {

                int fee = int.Parse(tbFee.Text);
                residentFee = (1245 - (fee * 14 / 2)).ToString();
               
            }


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqcmd = new SqlCommand("Select * from [ResidentDb] where RegID ='"
                                                                + tbID.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                conn.Close();
                MessageBox.Show("Reg ID already exists");
            }
            else
            {
                
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [ResidentDb]" +
                    "(RegId, FirstName, LastName, DormNum, FloorRange,StudentType, MonthlyFee) values " +
                    "                       ('" + tbID.Text + "','"
                                            + tbFirstName.Text + "','"
                                            + tbLastName.Text + "' ,'"
                                            + tbDorm.Text + "','"
                                            + floorsList.Text + "','"
                                            + ResType.Text + "','"
                                            + residentFee + "')";
                residentMonthlyFee();
                

                cmd.ExecuteNonQuery();
                conn.Close();
                //display_data();
                tbID.Text = "";
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbDorm.Text = "";


                MessageBox.Show("Data Inserted Successfully");
            }






        }


    }
}

