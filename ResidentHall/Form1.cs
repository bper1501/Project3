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
    public partial class Login : Form
    {

        public Login()
        {
            
            
            InitializeComponent();
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Authenticate; Integrated Security = True;");

            con.Open();

            SqlCommand sqcmd = new SqlCommand("Select * from LoginDetails where UserName='" + tbUsername.Text
                                                + "' and Password='" + tbPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Selection sel = new Selection();
                sel.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }
            con.Close();
        }


    }
}
