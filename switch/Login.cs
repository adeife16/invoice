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
using System.Security.Cryptography;

namespace @switch
{
    public partial class Login : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        database db = new database();
        public Login()
        {
            InitializeComponent();
            con = new MySqlConnection(db.ConnectionString());
        }

        private void login()
        {
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            string user = username.Text;
            string pass_hash = MD5Hash(password.Text);
            con.Open();
            //com = new MySqlCommand("INSERT INTO `user`(`user_id`, `name`, `username`, `password`) VALUES(@id, @name, @user, @pass)", con);
            //com.Parameters.AddWithValue("@id", MD5Hash(datetime));
            //com.Parameters.AddWithValue("@name", "Admin");
            //com.Parameters.AddWithValue("@user", user);
            //com.Parameters.AddWithValue("@pass", pass_hash);
            //com.ExecuteNonQuery();
            com = new MySqlCommand("SELECT * FROM `user` WHERE `username`=@user AND password =@pass", con);
            com.Parameters.AddWithValue("@user", user);
            com.Parameters.AddWithValue("@pass", pass_hash);
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                Dashboard dashboard = new Dashboard();
                // MessageBox.Show("Logged In Successfully!");
                this.Hide();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Login Details!");

            }
            con.Close();
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            login();
        }
        private static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

    class database
    {
        public string ConnectionString()
        {
            string connection = "datasource=localhost; user=root; password=; Database=switch";
            return connection;
        }
    }
}
