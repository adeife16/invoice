
namespace @switch
{
    partial class CreateInvoice
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateInvoice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productId = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pdf = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.Button();
            this.printInput = new System.Windows.Forms.Button();
            this.customerInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wordsInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorInput = new System.Windows.Forms.TextBox();
            this.imeiInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.printInvoicePreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printInvoice = new System.Drawing.Printing.PrintDocument();
            this.invoice_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productId);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.product);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pdf);
            this.groupBox1.Controls.Add(this.gbInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.preview);
            this.groupBox1.Controls.Add(this.printInput);
            this.groupBox1.Controls.Add(this.customerInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.wordsInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.amountInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.colorInput);
            this.groupBox1.Controls.Add(this.imeiInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Location = new System.Drawing.Point(145, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(492, 33);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(201, 20);
            this.productId.TabIndex = 33;
            this.productId.Visible = false;
            // 
            // payment
            // 
            this.payment.FormattingEnabled = true;
            this.payment.Items.AddRange(new object[] {
            "Cash",
            "Transfer"});
            this.payment.Location = new System.Drawing.Point(492, 299);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(201, 21);
            this.payment.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(378, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Payment Mode";
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(492, 78);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(201, 20);
            this.product.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(378, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Product";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(156, 205);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(201, 20);
            this.phone.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(16, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Customer Phone";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(156, 117);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(201, 60);
            this.address.TabIndex = 34;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(16, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Customer Address";
            // 
            // pdf
            // 
            this.pdf.BackColor = System.Drawing.Color.Gray;
            this.pdf.FlatAppearance.BorderSize = 0;
            this.pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pdf.Location = new System.Drawing.Point(589, 393);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(80, 30);
            this.pdf.TabIndex = 32;
            this.pdf.Text = "Save PDF";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Visible = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // gbInput
            // 
            this.gbInput.Location = new System.Drawing.Point(492, 209);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(201, 20);
            this.gbInput.TabIndex = 31;
            this.gbInput.TextChanged += new System.EventHandler(this.gbInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(378, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Memory (gb)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.preview.FlatAppearance.BorderSize = 0;
            this.preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.preview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.preview.Location = new System.Drawing.Point(479, 392);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(90, 30);
            this.preview.TabIndex = 29;
            this.preview.Text = "Preview";
            this.preview.UseVisualStyleBackColor = false;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // printInput
            // 
            this.printInput.BackColor = System.Drawing.Color.Purple;
            this.printInput.FlatAppearance.BorderSize = 0;
            this.printInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.printInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printInput.Location = new System.Drawing.Point(383, 392);
            this.printInput.Name = "printInput";
            this.printInput.Size = new System.Drawing.Size(90, 30);
            this.printInput.TabIndex = 28;
            this.printInput.Text = "Print";
            this.printInput.UseVisualStyleBackColor = false;
            this.printInput.Click += new System.EventHandler(this.printInput_Click);
            // 
            // customerInput
            // 
            this.customerInput.Location = new System.Drawing.Point(156, 78);
            this.customerInput.Name = "customerInput";
            this.customerInput.Size = new System.Drawing.Size(201, 20);
            this.customerInput.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(16, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Customer Name";
            // 
            // wordsInput
            // 
            this.wordsInput.Location = new System.Drawing.Point(157, 260);
            this.wordsInput.Multiline = true;
            this.wordsInput.Name = "wordsInput";
            this.wordsInput.Size = new System.Drawing.Size(201, 60);
            this.wordsInput.TabIndex = 25;
            this.wordsInput.TextChanged += new System.EventHandler(this.wordsInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Amount in Words";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(492, 260);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(201, 20);
            this.amountInput.TabIndex = 23;
            this.amountInput.TextChanged += new System.EventHandler(this.amountInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(378, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Amount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(378, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Colour";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // colorInput
            // 
            this.colorInput.Location = new System.Drawing.Point(492, 158);
            this.colorInput.Name = "colorInput";
            this.colorInput.Size = new System.Drawing.Size(201, 20);
            this.colorInput.TabIndex = 20;
            this.colorInput.TextChanged += new System.EventHandler(this.colorInput_TextChanged);
            // 
            // imeiInput
            // 
            this.imeiInput.Location = new System.Drawing.Point(492, 119);
            this.imeiInput.Name = "imeiInput";
            this.imeiInput.Size = new System.Drawing.Size(201, 20);
            this.imeiInput.TabIndex = 19;
            this.imeiInput.TextChanged += new System.EventHandler(this.imeiInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(378, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "IMEI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(119, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Generate Invoice";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.clear_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear_btn.Location = new System.Drawing.Point(175, 392);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(90, 30);
            this.clear_btn.TabIndex = 14;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.save_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save_btn.Location = new System.Drawing.Point(279, 392);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(90, 30);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_btn.Location = new System.Drawing.Point(12, 411);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(127, 31);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back To Dashboard";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // printInvoicePreview
            // 
            this.printInvoicePreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printInvoicePreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printInvoicePreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printInvoicePreview.Enabled = true;
            this.printInvoicePreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printInvoicePreview.Icon")));
            this.printInvoicePreview.Name = "printInvoicePreview";
            this.printInvoicePreview.Visible = false;
            // 
            // printInvoice
            // 
            this.printInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoice_PrintPage);
            // 
            // invoice_id
            // 
            this.invoice_id.Location = new System.Drawing.Point(33, 34);
            this.invoice_id.Name = "invoice_id";
            this.invoice_id.Size = new System.Drawing.Size(201, 20);
            this.invoice_id.TabIndex = 32;
            this.invoice_id.Visible = false;
            // 
            // CreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(914, 446);
            this.Controls.Add(this.invoice_id);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Invoice";
            this.Load += new System.EventHandler(this.CreateInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox imeiInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox customerInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wordsInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colorInput;
        private System.Windows.Forms.Button printInput;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.PrintPreviewDialog printInvoicePreview;
        private System.Drawing.Printing.PrintDocument printInvoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gbInput;
        private System.Windows.Forms.TextBox invoice_id;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox payment;
        private System.Windows.Forms.TextBox productId;
    }
}