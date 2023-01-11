using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @switch
{
    public partial class Record : Form
{
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        database db = new database();
        public Record()
    {
        InitializeComponent();
        con = new MySqlConnection(db.ConnectionString());

        }
        private void Record_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT customer, phone, product, imei, color, amount, payment, date FROM sales";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            table.Rows.Clear();

            DataTable dt = new DataTable();
            da.Fill(dt);
            table.DataSource = dt;

            con.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            //table.Rows.Clear();
            string fromDate = from.Value.ToShortDateString();
            string toDate = to.Value.ToShortDateString();

            string query = "SELECT  customer, phone, product, imei, color, amount, payment, date FROM sales WHERE date BETWEEN @from AND @to ORDER BY id DESC";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@from", fromDate);
            da.SelectCommand.Parameters.AddWithValue("@to", toDate);

            DataTable dt = new DataTable();
            da.Fill(dt);
            table.DataSource = dt;

            con.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
