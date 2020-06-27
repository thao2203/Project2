namespace BTH3_GiaoTrinh
{
    partial class Form10
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("11111-Nguyễn Thị Thảo");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TK16.1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TK16.2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("TK16.3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("TK16.4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("TK16.5");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("TK16.6");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TK16.7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("TK16.8");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Danh sách lóp", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView1.HideSelection = false;
            this.treeView1.LineColor = System.Drawing.Color.DimGray;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "sv";
            treeNode1.Text = "11111-Nguyễn Thị Thảo";
            treeNode2.Name = "lop";
            treeNode2.Text = "TK16.1";
            treeNode3.Name = "lop";
            treeNode3.Text = "TK16.2";
            treeNode4.Name = "lop";
            treeNode4.Text = "TK16.3";
            treeNode5.Name = "lop";
            treeNode5.Text = "TK16.4";
            treeNode6.Name = "lop";
            treeNode6.Text = "TK16.5";
            treeNode7.Name = "lop";
            treeNode7.Text = "TK16.6";
            treeNode8.Name = "lop";
            treeNode8.Text = "TK16.7";
            treeNode9.Name = "lop";
            treeNode9.Text = "TK16.8";
            treeNode10.Name = "ds";
            treeNode10.Text = "Danh sách lóp";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(557, 304);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(84, 36);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(185, 20);
            this.txtma.TabIndex = 5;
            this.txtma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtma_KeyUp);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(84, 74);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(185, 20);
            this.txtten.TabIndex = 6;
            this.txtten.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtten_KeyUp);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(84, 114);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(185, 20);
            this.txtdiachi.TabIndex = 7;
            this.txtdiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiachi_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 266);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(9, 153);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(260, 35);
            this.btncapnhat.TabIndex = 8;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(9, 204);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(260, 35);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // Form10
            // 
            this.AcceptButton = this.btncapnhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.MinimumSize = new System.Drawing.Size(573, 343);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
    }
}