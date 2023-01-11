using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;
using System.Drawing.Printing;
using System.IO;

namespace @switch
{
    public partial class CreateInvoice : Form
{
    MySqlConnection con;
    MySqlCommand com;
    MySqlDataReader dr;
    database db = new database();

    string serial = "";

        public PrinterSettings PrinterSettings { get; private set; }

        public CreateInvoice()
    {
        InitializeComponent();
        con = new MySqlConnection(db.ConnectionString());
    }

    private void CreateInvoice_Load(object sender, EventArgs e)
    {
            get_id();
    }
        private void SaveInvoice()
        {
            DateTime dt = DateTime.Now;

            try
            {
                string sDate = dt.ToShortDateString();
                con.Open();
                com = new MySqlCommand("INSERT INTO sales(`invoice_id`,`product`,`customer`,`address`,`phone`,`imei`,`color`,`amount`,`words`,`payment`,`date`) VALUES(@id,@product,@customer,@address,@phone,@imei,@color,@amount,@word,@payment,@date)", con);

                com.Parameters.AddWithValue("@id", invoice_id.Text);
                com.Parameters.AddWithValue("@product", product.Text);
                com.Parameters.AddWithValue("@customer", customerInput.Text);
                com.Parameters.AddWithValue("@address", address.Text);
                com.Parameters.AddWithValue("@phone", phone.Text);
                com.Parameters.AddWithValue("@imei", imeiInput.Text);
                com.Parameters.AddWithValue("@color", colorInput.Text);
                com.Parameters.AddWithValue("@amount", amountInput.Text);
                com.Parameters.AddWithValue("@word", wordsInput.Text);
                com.Parameters.AddWithValue("@date", sDate);
                com.Parameters.AddWithValue("@payment", payment.Text);

                com.ExecuteNonQuery();
                //dr.Close();
                con.Close();
                MessageBox.Show("Record Saved");
                //Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                MessageBox.Show("Clear form before creating new invoicce");
            }
            con.Close();
        }
        private void Clear()
        {
            productId.Text = "";
            invoice_id.Text = "";
            customerInput.Text = "";
            address.Text = "";
            phone.Text = "";
            product.Text = "";
            imeiInput.Text = "";
            colorInput.Text = "";
            gbInput.Text = "";
            amountInput.Text = "";
            wordsInput.Text = "";
            payment.Text = "";
            get_id();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveInvoice();
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void printInput_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("SELECT * FROM sales WHERE product_id=@product", con);
            com.Parameters.AddWithValue("@product", productId.Text);
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                printInvoice.Print();
            }
            else
            {
                MessageBox.Show("Save Invoice before Printing");
            }
            dr.Close();
            con.Close();
        }

        private void preview_Click(object sender, EventArgs e)
        {
            printInvoicePreview.Document = printInvoice;
            printInvoicePreview.ShowDialog();
        }

        private void printInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DateTime dt = DateTime.Now;
            int amount = Int32.Parse(amountInput.Text);
            string sDate = dt.ToShortDateString();
            Bitmap bitmap = Properties.Resources.WhatsApp_Image_2022_12_13_at_10_32_01;
            Image image = bitmap;
            Bitmap home = Properties.Resources.home;
            Image homeIcon = home;
            Bitmap insta = Properties.Resources.instagram;
            Image instaIcon = insta;
            Bitmap phonei = Properties.Resources.phone;
            Image phoneIcon = phonei;
            Bitmap water = Properties.Resources.watermark;
            Image watermark = water;


            e.Graphics.DrawImage(image, 230, 100, 400, 150);
            e.Graphics.DrawImage(watermark, 60, 400, 800, 500);
            e.Graphics.DrawString("2, OSHITELU STREET, COMPUTER VILLAGE, IKEJA LAGOS.", new Font("Microsoft Sans Serif", 14, FontStyle.Bold), Brushes.Black, new Point(150, 250));
            e.Graphics.DrawImage(phoneIcon, 150, 280, 20, 20);
            e.Graphics.DrawString("+2347053112479, +23408063127611", new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(170, 280));
            e.Graphics.DrawImage(instaIcon, 490, 280, 20, 20);
            e.Graphics.DrawString("Switch_Phones_Gadgets", new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(510, 280));
            e.Graphics.DrawString("Date: " + sDate, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 350));
            e.Graphics.DrawString("Invoice No: " + invoice_id.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(500, 350));
            e.Graphics.DrawString("Customer Name: " + customerInput.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 450));
            e.Graphics.DrawString("Customer Address: " + address.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 500));
            e.Graphics.DrawString("Customer Phone: " + phone.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 550));
            e.Graphics.DrawString("Product: " + product.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 600));
            e.Graphics.DrawString("IMEI Number: " + imeiInput.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 650));
            e.Graphics.DrawString("Colour: " + colorInput.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 700));
            e.Graphics.DrawString("Memory: " + gbInput.Text + "Gb", new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 750));
            e.Graphics.DrawString("Amount: " + string.Format(new CultureInfo("yo-NG"), "{0:C}", amount), new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100,800));
            e.Graphics.DrawString("Amount In Words: " + wordsInput.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 850));
            e.Graphics.DrawString("Payment Mode: " + payment.Text, new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 900));
            e.Graphics.DrawString("----------------------------", new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 1000));
            e.Graphics.DrawString("Customer Signature", new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(100, 1020));
            e.Graphics.DrawString("----------------------------", new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(500, 1000));
            e.Graphics.DrawString("CEO Sign and Stamp", new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, new Point(500, 1020));

        }

        private void get_id()
        {
            con.Open();
            com = new MySqlCommand("SELECT COUNT(*) FROM `sales`", con);
            int ID = Int32.Parse(com.ExecuteScalar().ToString());
            string current = "SW-0000" + ID.ToString();
            if(current != invoice_id.Text)
            {
                ID++;
                current = "SW-0000" + ID.ToString();
                invoice_id.Text = current;
            }
            con.Close();
        }
        private void create_pdf()
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void amountInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pdf_Click(object sender, EventArgs e)
        {
            // generate a file name as the current date/time in unix timestamp format
            string file = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();

            // the directory to store the output.
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // initialize PrintDocument object
            PrintDocument doc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    // set the printer to 'Microsoft Print to PDF'
                    PrinterName = "Microsoft Print to PDF",

                    // tell the object this document will print to file
                    PrintToFile = true,

                    // set the filename to whatever you like (full path)
                    PrintFileName = Path.Combine(directory, file + ".pdf"),
                }
            };

            doc.Print();
            //printInvoice.Print();
        }

        private void wordsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void imeiInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void colorInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
