using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResidentHall
{
    public partial class Search : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ResidentHall;Integrated Security=True;");
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residentHallDataSet5.ResidentDb' table. You can move, or remove it, as needed.
            this.residentDbTableAdapter1.Fill(this.residentHallDataSet5.ResidentDb);

            //this.residentDbTableAdapter.Fill(this.residentHallDataSet5.ResidentDb);

        }

        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [ResidentDb]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGrid_DB.DataSource = dta;
            conn.Close();

        }

        private void gridBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Selection sel = new Selection();
            sel.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string search = tbSearch.Text;
            SqlCommand sqcmd = new SqlCommand("Select * from [ResidentDb] where FirstName Like '%"
                                            + search + "%' OR LastName Like '%" + search + "%' OR RegId Like '%" + search + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
          da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGrid_DB.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("No Record Found");
                conn.Close();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display_data();
        }
    }
}
