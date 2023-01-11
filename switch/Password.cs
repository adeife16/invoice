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
using System.Security.Cryptography;


namespace @switch
{
    public partial class Password : Form
{
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        database db = new database();
        public Password()
    {
        InitializeComponent();
        con = new MySqlConnection(db.ConnectionString());

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
           string old_pass = MD5Hash(oldPass.Text);
            string new_pass = newPass.Text;
            string confirm_pass = confirm_newPass.Text;



            con.Open();
            com = new MySqlCommand("SELECT * FROM user WHERE password=@pass", con);
            com.Parameters.AddWithValue("@pass", old_pass);
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                con.Close();
                if(new_pass == confirm_pass)
                {
                    con.Open();
                    com = new MySqlCommand("UPDATE user SET password=@pass",con);
                    com.Parameters.AddWithValue("@pass", MD5Hash(new_pass));
                    com.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Password Updated Successfully!");
                }
                else
                {
                    //dr.Close();
                    MessageBox.Show("Passwords do no match!");
                }
            }
            else
            {
                dr.Close();
                con.Close();
                MessageBox.Show("Old Password is Incorrect!");
            }
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
