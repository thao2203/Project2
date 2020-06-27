namespace LapTrinhNangCaoCS
{
    partial class Combobox
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
            this.cbo = new System.Windows.Forms.ComboBox();
            this.lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbo
            // 
            this.cbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo.FormattingEnabled = true;
            this.cbo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbo.Location = new System.Drawing.Point(74, 29);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(121, 21);
            this.cbo.TabIndex = 0;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lbx.Location = new System.Drawing.Point(87, 123);
            this.lbx.Name = "lbx";
            this.lbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx.Size = new System.Drawing.Size(120, 69);
            this.lbx.TabIndex = 1;
            this.lbx.SelectedIndexChanged += new System.EventHandler(this.lbx_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 290);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.cbo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.ListBox lbx;
    }
}

