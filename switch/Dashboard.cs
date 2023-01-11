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
    public partial class Dashboard : Form
{
    public Dashboard()
    {
            InitializeComponent();
    }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void create_invoice_Click(object sender, EventArgs e)
        {
            CreateInvoice createInvoice = new CreateInvoice();
            this.Hide();
            createInvoice.ShowDialog();
        }
        private void view_record_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            this.Hide();
            record.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "CLICK " + "YES" + " TO CLOSE APPLICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }



        private void add_product_Click_1(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            this.Hide();
            addProduct.ShowDialog();
        }

        private void change_pass_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            this.Hide();
            password.ShowDialog();
        }
    }
}
