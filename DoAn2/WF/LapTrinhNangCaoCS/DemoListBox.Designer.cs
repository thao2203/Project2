namespace LapTrinhNangCaoCS
{
    partial class DemoListBox
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(37, 23);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(305, 20);
            this.txtbox.TabIndex = 0;
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Items.AddRange(new object[] {
            "Thứ  2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ Nhật"});
            this.lbx.Location = new System.Drawing.Point(37, 77);
            this.lbx.Name = "lbx";
            this.lbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx.Size = new System.Drawing.Size(406, 95);
            this.lbx.TabIndex = 1;
            this.lbx.SelectedIndexChanged += new System.EventHandler(this.lbx_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(368, 203);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // DemoListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 252);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.txtbox);
            this.Name = "DemoListBox";
            this.Text = "DemoListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnThoat;
    }
}