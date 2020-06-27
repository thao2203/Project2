namespace BaiThucHanh2
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.btnxoadc = new System.Windows.Forms.Button();
            this.btnxoachon = new System.Windows.Forms.Button();
            this.btntang2 = new System.Windows.Forms.Button();
            this.btnbinhphuong = new System.Windows.Forms.Button();
            this.btnchan = new System.Windows.Forms.Button();
            this.btnle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "LISTBOX";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 134);
            this.listBox1.TabIndex = 4;
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(6, 63);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 23);
            this.btnnhap.TabIndex = 5;
            this.btnnhap.Text = "&Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(27, 403);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(448, 23);
            this.btnketthuc.TabIndex = 6;
            this.btnketthuc.Text = "&KẾT THÚC";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(6, 34);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(201, 23);
            this.btntinhtong.TabIndex = 7;
            this.btntinhtong.Text = "Tổng các phần tử trong List";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnxoadc
            // 
            this.btnxoadc.Location = new System.Drawing.Point(6, 63);
            this.btnxoadc.Name = "btnxoadc";
            this.btnxoadc.Size = new System.Drawing.Size(201, 23);
            this.btnxoadc.TabIndex = 8;
            this.btnxoadc.Text = "Xoá phần tử đầu và cuối";
            this.btnxoadc.UseVisualStyleBackColor = true;
            this.btnxoadc.Click += new System.EventHandler(this.btnxoadc_Click);
            // 
            // btnxoachon
            // 
            this.btnxoachon.Location = new System.Drawing.Point(6, 92);
            this.btnxoachon.Name = "btnxoachon";
            this.btnxoachon.Size = new System.Drawing.Size(201, 23);
            this.btnxoachon.TabIndex = 9;
            this.btnxoachon.Text = "Xoá phần tử đang chọn";
            this.btnxoachon.UseVisualStyleBackColor = true;
            this.btnxoachon.Click += new System.EventHandler(this.btnxoachon_Click);
            // 
            // btntang2
            // 
            this.btntang2.Location = new System.Drawing.Point(6, 121);
            this.btntang2.Name = "btntang2";
            this.btntang2.Size = new System.Drawing.Size(201, 23);
            this.btntang2.TabIndex = 10;
            this.btntang2.Text = "Tăng mỗi phần tử lên 2 ";
            this.btntang2.UseVisualStyleBackColor = true;
            this.btntang2.Click += new System.EventHandler(this.btntang2_Click);
            // 
            // btnbinhphuong
            // 
            this.btnbinhphuong.Location = new System.Drawing.Point(6, 150);
            this.btnbinhphuong.Name = "btnbinhphuong";
            this.btnbinhphuong.Size = new System.Drawing.Size(201, 23);
            this.btnbinhphuong.TabIndex = 11;
            this.btnbinhphuong.Text = "Thay bằng bình phương";
            this.btnbinhphuong.UseVisualStyleBackColor = true;
            this.btnbinhphuong.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnchan
            // 
            this.btnchan.Location = new System.Drawing.Point(6, 179);
            this.btnchan.Name = "btnchan";
            this.btnchan.Size = new System.Drawing.Size(201, 23);
            this.btnchan.TabIndex = 12;
            this.btnchan.Text = "Chọn số chẵn";
            this.btnchan.UseVisualStyleBackColor = true;
            this.btnchan.Click += new System.EventHandler(this.btnchan_Click);
            // 
            // btnle
            // 
            this.btnle.Location = new System.Drawing.Point(6, 208);
            this.btnle.Name = "btnle";
            this.btnle.Size = new System.Drawing.Size(201, 23);
            this.btnle.TabIndex = 13;
            this.btnle.Text = "Chọn số lẻ ";
            this.btnle.UseVisualStyleBackColor = true;
            this.btnle.Click += new System.EventHandler(this.btnle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnnhap);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 259);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Box";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntinhtong);
            this.groupBox2.Controls.Add(this.btnxoadc);
            this.groupBox2.Controls.Add(this.btnle);
            this.groupBox2.Controls.Add(this.btnxoachon);
            this.groupBox2.Controls.Add(this.btnchan);
            this.groupBox2.Controls.Add(this.btntang2);
            this.groupBox2.Controls.Add(this.btnbinhphuong);
            this.groupBox2.Location = new System.Drawing.Point(256, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 259);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử Lý List Box";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Button btnxoadc;
        private System.Windows.Forms.Button btnxoachon;
        private System.Windows.Forms.Button btntang2;
        private System.Windows.Forms.Button btnbinhphuong;
        private System.Windows.Forms.Button btnchan;
        private System.Windows.Forms.Button btnle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}