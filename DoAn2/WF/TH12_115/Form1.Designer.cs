namespace TH12_115
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
            this.dgLop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.txtSiso = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.btMoi = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLop
            // 
            this.dgLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLop.Location = new System.Drawing.Point(3, 2);
            this.dgLop.Name = "dgLop";
            this.dgLop.Size = new System.Drawing.Size(794, 224);
            this.dgLop.TabIndex = 0;
            this.dgLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLop_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sĩ số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi chú";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(30, 279);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(100, 20);
            this.txtMalop.TabIndex = 5;
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(234, 279);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(143, 20);
            this.txtTenlop.TabIndex = 6;
            // 
            // txtSiso
            // 
            this.txtSiso.Location = new System.Drawing.Point(443, 279);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.Size = new System.Drawing.Size(100, 20);
            this.txtSiso.TabIndex = 7;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(606, 279);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(167, 20);
            this.txtGhichu.TabIndex = 8;
            // 
            // btMoi
            // 
            this.btMoi.Location = new System.Drawing.Point(106, 345);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(75, 23);
            this.btMoi.TabIndex = 9;
            this.btMoi.Text = "Mới";
            this.btMoi.UseVisualStyleBackColor = true;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(221, 345);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(339, 345);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(468, 345);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btDoc
            // 
            this.btDoc.Location = new System.Drawing.Point(587, 345);
            this.btDoc.Name = "btDoc";
            this.btDoc.Size = new System.Drawing.Size(75, 23);
            this.btDoc.TabIndex = 13;
            this.btDoc.Text = "Đọc";
            this.btDoc.UseVisualStyleBackColor = true;
            this.btDoc.Click += new System.EventHandler(this.btDoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDoc);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btMoi);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtSiso);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLop);
            this.Name = "Form1";
            this.Text = "QUAN LY LOP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.TextBox txtSiso;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btDoc;
    }
}

