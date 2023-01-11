
namespace @switch
{
    partial class Dashboard
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.add_product = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.view_record = new System.Windows.Forms.Button();
            this.create_invoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.change_pass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.splitContainer1.Panel1.Controls.Add(this.change_pass);
            this.splitContainer1.Panel1.Controls.Add(this.add_product);
            this.splitContainer1.Panel1.Controls.Add(this.exit);
            this.splitContainer1.Panel1.Controls.Add(this.view_record);
            this.splitContainer1.Panel1.Controls.Add(this.create_invoice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 0;
            // 
            // add_product
            // 
            this.add_product.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_product.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_product.Location = new System.Drawing.Point(12, 69);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(118, 33);
            this.add_product.TabIndex = 5;
            this.add_product.Text = "Add Product";
            this.add_product.UseVisualStyleBackColor = true;
            this.add_product.Visible = false;
            this.add_product.Click += new System.EventHandler(this.add_product_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(16, 405);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(118, 33);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // view_record
            // 
            this.view_record.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.view_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_record.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.view_record.Location = new System.Drawing.Point(12, 202);
            this.view_record.Name = "view_record";
            this.view_record.Size = new System.Drawing.Size(118, 33);
            this.view_record.TabIndex = 3;
            this.view_record.Text = "Sales Record";
            this.view_record.UseVisualStyleBackColor = true;
            this.view_record.Click += new System.EventHandler(this.view_record_Click);
            // 
            // create_invoice
            // 
            this.create_invoice.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.create_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_invoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.create_invoice.Location = new System.Drawing.Point(12, 130);
            this.create_invoice.Name = "create_invoice";
            this.create_invoice.Size = new System.Drawing.Size(118, 33);
            this.create_invoice.TabIndex = 2;
            this.create_invoice.Text = "Create Invoice";
            this.create_invoice.UseVisualStyleBackColor = true;
            this.create_invoice.Click += new System.EventHandler(this.create_invoice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::@switch.Properties.Resources.WhatsApp_Image_2022_12_13_at_10_32_01;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // change_pass
            // 
            this.change_pass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.change_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.change_pass.Location = new System.Drawing.Point(12, 277);
            this.change_pass.Name = "change_pass";
            this.change_pass.Size = new System.Drawing.Size(118, 33);
            this.change_pass.TabIndex = 6;
            this.change_pass.Text = "Change Password";
            this.change_pass.UseVisualStyleBackColor = true;
            this.change_pass.Click += new System.EventHandler(this.change_pass_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button view_record;
        private System.Windows.Forms.Button create_invoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button change_pass;
    }
}