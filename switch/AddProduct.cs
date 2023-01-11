using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace @switch
{
    public partial class AddProduct : Form
{
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        database db = new database();
        public AddProduct()
        {
            InitializeComponent();
            con = new MySqlConnection(db.ConnectionString());
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

  

        private void save_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(categoryInput.Text);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
