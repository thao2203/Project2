namespace BTH3_GiaoTrinh
{
    partial class Form9
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nguyễn Thị Thảo, Tin1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nguyễn Thị Nga, Tin1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Đỗ Đình Quang, Tin1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tin1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Trần Đặng Phương Anh, Tin2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Lê Vinh Quang, Tin2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nguyễn Văn Tuấn, Tin2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tin2", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Chu Thảo Ngọc, Tin3");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nguyen Mai Anh, Tin3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Lê Đức Phong, Tin3");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Tin3", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khoa Tin Học", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 64);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "hs";
            treeNode1.Text = "Nguyễn Thị Thảo, Tin1";
            treeNode2.Name = "hs";
            treeNode2.Text = "Nguyễn Thị Nga, Tin1";
            treeNode3.Name = "hs";
            treeNode3.Text = "Đỗ Đình Quang, Tin1";
            treeNode4.Name = "lop";
            treeNode4.Text = "Tin1";
            treeNode5.Name = "hs";
            treeNode5.Text = "Trần Đặng Phương Anh, Tin2";
            treeNode6.Name = "hs";
            treeNode6.Text = "Lê Vinh Quang, Tin2";
            treeNode7.Name = "hs";
            treeNode7.Text = "Nguyễn Văn Tuấn, Tin2";
            treeNode8.Name = "lop";
            treeNode8.Text = "Tin2";
            treeNode9.Name = "hs";
            treeNode9.Text = "Chu Thảo Ngọc, Tin3";
            treeNode10.Name = "hs";
            treeNode10.Text = "Nguyen Mai Anh, Tin3";
            treeNode11.Name = "hs";
            treeNode11.Text = "Lê Đức Phong, Tin3";
            treeNode12.Name = "lop";
            treeNode12.Text = "Tin3";
            treeNode13.Name = "khoa";
            treeNode13.Text = "Khoa Tin Học";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(226, 279);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(534, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(264, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(346, 279);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Sinh Viên";
            this.columnHeader1.Width = 169;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lớp";
            this.columnHeader2.Width = 171;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 368);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}