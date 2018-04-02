using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResidentHall
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewResident res = new NewResident();
            res.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login home = new Login();
            home.Show();
        }
    }
}
