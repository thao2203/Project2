namespace BaiThucHanh2
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
            this.txtso = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btntonguoc = new System.Windows.Forms.Button();
            this.btnuocchan = new System.Windows.Forms.Button();
            this.btnuocnguyento = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(6, 35);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 2;
            this.txtso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtso_KeyUp);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(119, 32);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "&Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btntonguoc
            // 
            this.btntonguoc.Location = new System.Drawing.Point(6, 150);
            this.btntonguoc.Name = "btntonguoc";
            this.btntonguoc.Size = new System.Drawing.Size(188, 23);
            this.btntonguoc.TabIndex = 6;
            this.btntonguoc.Text = "&Tổng các ước số";
            this.btntonguoc.UseVisualStyleBackColor = true;
            this.btntonguoc.Click += new System.EventHandler(this.btntonguoc_Click);
            // 
            // btnuocchan
            // 
            this.btnuocchan.Location = new System.Drawing.Point(6, 179);
            this.btnuocchan.Name = "btnuocchan";
            this.btnuocchan.Size = new System.Drawing.Size(188, 23);
            this.btnuocchan.TabIndex = 7;
            this.btnuocchan.Text = "&Số lượng các ước số chẵn";
            this.btnuocchan.UseVisualStyleBackColor = true;
            this.btnuocchan.Click += new System.EventHandler(this.btnuocchan_Click);
            // 
            // btnuocnguyento
            // 
            this.btnuocnguyento.Location = new System.Drawing.Point(6, 208);
            this.btnuocnguyento.Name = "btnuocnguyento";
            this.btnuocnguyento.Size = new System.Drawing.Size(188, 23);
            this.btnuocnguyento.TabIndex = 8;
            this.btnuocnguyento.Text = "&Số lượng các ước số nguyên tố";
            this.btnuocnguyento.UseVisualStyleBackColor = true;
            this.btnuocnguyento.Click += new System.EventHandler(this.btnuocnguyento_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Th&oát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 121);
            this.listBox1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtso);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btntonguoc);
            this.groupBox2.Controls.Add(this.btnuocchan);
            this.groupBox2.Controls.Add(this.btnuocnguyento);
            this.groupBox2.Location = new System.Drawing.Point(235, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 237);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btntonguoc;
        private System.Windows.Forms.Button btnuocchan;
        private System.Windows.Forms.Button btnuocnguyento;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

