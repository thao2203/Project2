namespace BTH3_GiaoTrinh
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.maskdate = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtadrress = new System.Windows.Forms.TextBox();
            this.listcity = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskphone = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.listqua = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adrress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qualification:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "EMail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date of Joinning:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(76, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link to Thaor:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(155, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(231, 20);
            this.txtname.TabIndex = 10;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // maskdate
            // 
            this.maskdate.Location = new System.Drawing.Point(155, 48);
            this.maskdate.Mask = "00/00/0000";
            this.maskdate.Name = "maskdate";
            this.maskdate.Size = new System.Drawing.Size(231, 20);
            this.maskdate.TabIndex = 16;
            this.maskdate.Leave += new System.EventHandler(this.maskdate_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtadrress
            // 
            this.txtadrress.Location = new System.Drawing.Point(155, 87);
            this.txtadrress.Name = "txtadrress";
            this.txtadrress.Size = new System.Drawing.Size(231, 20);
            this.txtadrress.TabIndex = 17;
            this.txtadrress.TextChanged += new System.EventHandler(this.txtadrress_TextChanged);
            this.txtadrress.Leave += new System.EventHandler(this.txtadrress_Leave);
            // 
            // listcity
            // 
            this.listcity.FormattingEnabled = true;
            this.listcity.Location = new System.Drawing.Point(155, 123);
            this.listcity.Name = "listcity";
            this.listcity.Size = new System.Drawing.Size(231, 56);
            this.listcity.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Việt Nam",
            "Thái Lan"});
            this.comboBox1.Location = new System.Drawing.Point(155, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maskphone
            // 
            this.maskphone.Location = new System.Drawing.Point(155, 316);
            this.maskphone.Mask = "000-0000000";
            this.maskphone.Name = "maskphone";
            this.maskphone.Size = new System.Drawing.Size(231, 20);
            this.maskphone.TabIndex = 21;
            this.maskphone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskphone_MaskInputRejected);
            this.maskphone.Leave += new System.EventHandler(this.maskphone_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(155, 350);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(231, 20);
            this.txtemail.TabIndex = 22;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 384);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(182, 423);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 24;
            this.btn_submit.Text = "&Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(288, 423);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // listqua
            // 
            this.listqua.FormattingEnabled = true;
            this.listqua.Items.AddRange(new object[] {
            "University",
            "Master",
            "Ph D"});
            this.listqua.Location = new System.Drawing.Point(155, 241);
            this.listqua.Name = "listqua";
            this.listqua.Size = new System.Drawing.Size(231, 56);
            this.listqua.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 454);
            this.Controls.Add(this.listqua);
            this.Controls.Add(this.listcity);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.maskphone);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtadrress);
            this.Controls.Add(this.maskdate);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.MaskedTextBox maskdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox maskphone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listcity;
        private System.Windows.Forms.TextBox txtadrress;
        private System.Windows.Forms.ListBox listqua;
    }
}

